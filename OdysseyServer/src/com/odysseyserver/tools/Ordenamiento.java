package com.odysseyserver.tools;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.listas.SimpleList;
import com.odysseyserver.listas.SimpleNode;

/**
 * Realiza los ordenamientos
 * 
 * @author jorte
 *
 */
public class Ordenamiento {

	/**
	 * Ordena la lista de canciones por orden de album, se aplica BubbleSort
	 */
	public static void ordenarAlbum(JSONArray jsonMusicList) {
		SimpleList<Integer> listaOrden = new SimpleList<Integer>();
		for (int i = 0; i < jsonMusicList.size(); i++) {
			listaOrden.add(new SimpleNode<Integer>(i));
		}
		SimpleList<String> albumes = new SimpleList<String>();
		for (int i = 0; i < jsonMusicList.size(); i++) {
			albumes.add(new SimpleNode<String>((String) ((JSONObject) jsonMusicList.get(i)).get("album")));
		}

		for (int i = 0; i < jsonMusicList.size(); i++) {
			for (int j = 1; j < (jsonMusicList.size() - i); j++) {
				if (albumes.find(j - 1).compareToIgnoreCase(albumes.find(j)) > 0) {
					int temp = listaOrden.find(j);
					String tempStr = albumes.find(j);
					listaOrden.replace(j, listaOrden.find(j - 1));
					listaOrden.replace(j - 1, temp);
					albumes.replace(j, albumes.find(j - 1));
					albumes.replace(j - 1, tempStr);
				}
			}
		}
		CreadorXML.responderOrdenado(listaOrden, jsonMusicList);
	}

	/**
	 * Ordena las canciones en orden del nombre de la canción
	 */
	public static void ordenarCancion(JSONArray jsonMusicList) {
		String[] canciones = new String[jsonMusicList.size()];

		for (int i = 0; i < canciones.length; i++) {
			canciones[i] = (String) ((JSONObject) (jsonMusicList.get(i))).get("nombre");
		}
		canciones = ordenarCancionAux(canciones, 0, canciones.length - 1);
		int fin = 0;
		SimpleList<Integer> ordenado = new SimpleList<>();
		while (fin < canciones.length) {
			for (int i = 0; i < jsonMusicList.size(); i++) {
				if (canciones[fin].equals((String) ((JSONObject) (jsonMusicList.get(i))).get("nombre"))) {
					ordenado.add(new SimpleNode<Integer>(i));
					fin++;
					break;
				}
			}
		}
		CreadorXML.responderOrdenado(ordenado, jsonMusicList);
	}

	/**
	 * Ejecuta el quicksort para el ordenamiento
	 * 
	 * @param musica
	 *            String[]
	 * @param izq
	 *            int inicio del array
	 * @param der
	 *            int final del array
	 * @return String [] ordenado
	 */
	private static String[] ordenarCancionAux(String[] musica, int izq, int der) {
		if (izq >= der) {
			return musica;
		}
		int i = izq;
		int d = der;
		if (izq != der) {
			int pivote;
			String aux;
			pivote = izq;
			while (izq != der) {
				while (musica[der].compareToIgnoreCase(musica[pivote]) >= 0 && izq < der) {
					der--;
					while (musica[izq].compareToIgnoreCase(musica[pivote]) < 0 && izq < der) {
						izq++;
					}
				}

				if (der != izq) {
					aux = musica[der];
					musica[der] = musica[izq];
					musica[izq] = aux;
				}
				if (izq == der) {
					ordenarCancionAux(musica, i, izq - 1);
					ordenarCancionAux(musica, izq + 1, d);
				}
			}
		} else {
			return musica;
		}
		return musica;
	}

	/**
	 * Se encarga de ordenar las canciones con respecto al nombre de artista que
	 * tiene cada uno, estas son de menor a mayor posicion
	 * 
	 * @param jsonMusicList
	 *            JSONArray que contiene la información de las canciones
	 */
	public static void ordenarArtista(JSONArray jsonMusicList) {
		SimpleList<String> aux = new SimpleList<>();
		SimpleList<String> canciones = new SimpleList<>();
		SimpleList<Integer> ordenArtistas = new SimpleList<>();

		// Añade los nombres de los artistas
		for (int i = 0; i < jsonMusicList.size(); i++) {
			String artista = (String) ((JSONObject) (jsonMusicList.get(i))).get("artista");
			canciones.add(new SimpleNode<String>(artista.toLowerCase()));
			aux.add(new SimpleNode<String>(""));
		}

		// Ordena
		ordenarArtistaAux(canciones, aux, 0, canciones.getLength() - 1, 0);

		// Envía la orden para responder XML guardado
		for (int i = 0; i < canciones.getLength(); i++) {
			for (int j = 0; j < jsonMusicList.size(); j++) {
				String artista = (String) ((JSONObject) (jsonMusicList.get(j))).get("artista");
				if (canciones.find(i).equalsIgnoreCase(artista)) {
					ordenArtistas.add(new SimpleNode<Integer>(j));
					break;
				}
			}
		}
		CreadorXML.responderOrdenado(ordenArtistas, jsonMusicList);

	}

	private static void ordenarArtistaAux(SimpleList<String> canciones, SimpleList<String> aux, int min, int max,
			int d) {
		int R = 256; // extended ASCII Alphabets
		if (max <= min)
			return;
		int[] count = new int[R + 2]; // R+1 values, including the special small value for padding
		for (int i = min; i <= max; i++) {
			count[charAt(canciones.find(i), d) + 2]++; // alphabet j is counted at count[j + 2]
		}
		for (int r = 0; r < R + 1; r++) {
			count[r + 1] += count[r];
		}
		for (int i = min; i <= max; i++) {
			aux.replace(count[charAt(canciones.find(i), d) + 1]++, canciones.find(i));
		}
		for (int i = min; i <= max; i++) {
			canciones.replace(i, aux.find(i - min));
		}
		for (int r = 0; r < R; r++) {
			ordenarArtistaAux(canciones, aux, min + count[r], min + count[r + 1] - 1, d + 1); // after moving data from
																								// a[] to aux[],
																								// count[r]
		}
	}

	private static int charAt(String s, int d) {
		if (d < s.length()) {
			return s.charAt(d);
		} else {
			return -1;
		}
	}

}
