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

		if (albumes.getLength() != 0) {
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
		} else {
			CreadorXML.responderTrueFalse(false);
		}
	}

	/**
	 * Ordena las canciones en orden del nombre de la canción
	 */
	public static void ordenarCancion(JSONArray jsonMusicList) {
		SimpleList<String> canciones = new SimpleList<>();

		for (int i = 0; i < jsonMusicList.size(); i++) {
			if (!canciones.contains((String) ((JSONObject) (jsonMusicList.get(i))).get("nombre"))) {
				canciones.add(new SimpleNode<String>((String) ((JSONObject) (jsonMusicList.get(i))).get("nombre")));
			} 
			
		}
		if (canciones.getFirst() != null) {
			ordenarCancionAux(canciones, 0, canciones.getLength() - 1);
			int fin = 0;
			SimpleList<Integer> ordenado = new SimpleList<>();
			while (fin < canciones.getLength()) {
				for (int i = 0; i < jsonMusicList.size(); i++) {
					if (canciones.find(fin).equals((String) ((JSONObject) (jsonMusicList.get(i))).get("nombre"))) {
						ordenado.add(new SimpleNode<Integer>(i));
					}
				}
				fin++;
				
			}
			CreadorXML.responderOrdenado(ordenado, jsonMusicList);
		} else {
			CreadorXML.responderTrueFalse(false);
		}

	}

	private static void ordenarCancionAux(SimpleList<String> canciones, int primero, int ultimo) {
		int i = primero;
		int j = ultimo;
		String pivote = canciones.find(primero);
		String auxiliar;
		do {
			while (canciones.find(i).compareToIgnoreCase(pivote) < 0) {
				i++;
			}

			while (canciones.find(j).compareToIgnoreCase(pivote) > 0) {
				j--;
			}

			if (i <= j) {
				auxiliar = canciones.find(i);
				canciones.replace(i, canciones.find(j));
				canciones.replace(j, auxiliar);
				i++;
				j--;
			}
		} while (i <= j);

		if (primero < j) {
			ordenarCancionAux(canciones, primero, j);
		}

		if (i < ultimo) {
			ordenarCancionAux(canciones, i, ultimo);
		}
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
			if (!canciones.contains(artista)) {
				canciones.add(new SimpleNode<String>(artista.toLowerCase()));
				aux.add(new SimpleNode<String>(""));
			}
		}

		if (canciones.getLength() != 0) {
			// Ordena
			ordenarArtistaAux(canciones, aux, 0, canciones.getLength() - 1, 0);

			// Envía la orden para responder XML guardado
			int i = 0;
			while (i < canciones.getLength()) {
				System.out.println(canciones.find(i));
				for (int j = 0; j < jsonMusicList.size(); j++) {
					String artista = (String) ((JSONObject) (jsonMusicList.get(j))).get("artista");
					if (canciones.find(i).equalsIgnoreCase(artista)) {
						ordenArtistas.add(new SimpleNode<Integer>(j));
					}
				}
				i ++;
			}
			CreadorXML.responderOrdenado(ordenArtistas, jsonMusicList);
		} else {
			CreadorXML.responderTrueFalse(false);
		}

	}

	private static void ordenarArtistaAux(SimpleList<String> canciones, SimpleList<String> aux, int min, int max,
			int d) {
		int R = 256;
		if (max <= min)
			return;
		int[] count = new int[R + 2];
		for (int i = min; i <= max; i++) {
			count[charAt(canciones.find(i), d) + 2]++;
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
			ordenarArtistaAux(canciones, aux, min + count[r], min + count[r + 1] - 1, d + 1);
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
