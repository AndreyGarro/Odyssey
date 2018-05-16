package com.odysseyserver.musicmanagement;

import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.listas.SimpleList;
import com.odysseyserver.listas.SimpleNode;
import com.odysseyserver.utilidades.CreadorXML;

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
	static void ordenarAlbum(JSONArray jsonMusicList) {
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
		for (int i = 0; i < listaOrden.getLength(); i++) {
			System.out.print(listaOrden.find(i) + ", ");
		}
		CreadorXML.responderOrdenado(listaOrden, jsonMusicList);
	}

	/**
	 * Ordena las canciones en orden del nombre de la canción
	 */
	static void ordenarCancion(JSONArray jsonMusicList) {
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
}
