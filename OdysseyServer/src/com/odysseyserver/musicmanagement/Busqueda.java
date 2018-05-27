package com.odysseyserver.musicmanagement;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.arboles.AVLTree;
import com.odysseyserver.arboles.BTree;
import com.odysseyserver.arboles.SplayTree;
import com.odysseyserver.listas.SimpleList;

/**
 * Clase que se encarga de todo lo relacionado a las búsquedas
 * 
 * @author jorte
 *
 */
public class Busqueda {

	private AVLTree artistas;
	private SplayTree<String> albums;
	private AVLTree canciones;
	private static Busqueda instance;

	private Busqueda(JSONArray jsonCanciones) {
		generarArbolAlbumes(jsonCanciones);
		generarArbolArtistas(jsonCanciones);
		generarArbolCanciones(jsonCanciones);
	}

	/**
	 * Constructor de la clase Busqueda
	 * 
	 * @param jsonCanciones
	 *            JSONArray que contiene las canciones de la biblioteca musical
	 */
	public static Busqueda getInstance(JSONArray jsonCanciones) {
		if (instance == null) {
			instance = new Busqueda(jsonCanciones);
		}
		return instance;
	}

	private void generarArbolArtistas(JSONArray jsonArray) {
		artistas = new AVLTree();
		if (jsonArray.size() > 0) {
			for (int i = 0; i < jsonArray.size(); i++) {
				JSONObject temp = (JSONObject) jsonArray.get(i);
				String artista = (String) temp.get("artista");
				artistas.insert(artista, i);
			}
		}
		System.out.println("Preorden");
		artistas.preOrder();
		System.out.println("Entré a artistas__________________________________");
	}

	private void generarArbolCanciones(JSONArray jsonArray) {
		canciones = new AVLTree();
		if (jsonArray.size() > 0) {
			for (int i = 0; i < jsonArray.size(); i++) {
				JSONObject temp = (JSONObject) jsonArray.get(i);
				String nombre = (String) temp.get("nombre");
				canciones.insert(nombre, i);
			}
		}
		System.out.println("Preorden");
		canciones.preOrder();
		System.out.println("Entré a canciones__________________________________");
	}

	private void generarArbolAlbumes(JSONArray jsonArray) {
		albums = new SplayTree<>();
		if (jsonArray.size() > 0) {
			for (int i = 0; i < jsonArray.size(); i++) {
				JSONObject temp = (JSONObject) jsonArray.get(i);
				String album = (String) temp.get("album");
				albums.insert(album, i);
			}
		}
		System.out.println("Entré a albumes____________________________________");
	}

	/**
	 * Los árboles de búsqueda se crean de nuevo en caso de que exista un cambio en
	 * las canciones
	 * 
	 * @param jsonCanciones
	 *            JSONArray que contiene las canciones
	 */
	public void reconstruirArboles(JSONArray jsonCanciones) {
		generarArbolAlbumes(jsonCanciones);
		generarArbolArtistas(jsonCanciones);
		generarArbolCanciones(jsonCanciones);
	}

	/**
	 * Se buscan las canciones correspondientes a un artista solicitado por el
	 * cliente
	 * 
	 * @param artista
	 *            Nombre del artista al cual corresponden las canciones
	 * @return SimpleList que contiene los índices donde se encuentra el artista
	 */
	public SimpleList<Integer> buscarArtista(String artista) {
		System.out.println("En el Buscador" + artistas.search(artista));
		if (artistas.searchTwo(artista.trim()) != null) {
			return artistas.searchTwo(artista.trim()).getArrayIndx();
		}
		return null;
	}

	/**
	 * Se buscan las canciones correspondientes a un artista solicitado por el
	 * cliente
	 * 
	 * @param cancion
	 *            Nombre de la canción a la cual corresponden las canciones
	 * @return SimpleList que contiene los índices donde se encuentra el artista
	 */
	public SimpleList<Integer> buscarCancion(String cancion) {
		if (canciones.searchTwo(cancion) != null) {
			System.out.println(canciones.searchTwo(cancion).getArrayIndx());
			System.out.println(canciones.search(cancion.trim()));
			return canciones.searchTwo(cancion).arrayIndx;
		}
		return null;
	}

	/**
	 * Se buscan las canciones correspondientes a un artista solicitado por el
	 * cliente
	 * 
	 * @param album
	 *            Nombre del album al cual corresponden las canciones
	 * @return SimpleList que contiene los índices donde se encuentra el artista
	 */
	public SimpleList<Integer> buscarAlbum(String album) {
		System.out.println(albums.find(album));
		if (albums.find(album) != null) {
			return albums.find(album).getArrayIndx();
		}
		return null;

	}

	/**
	 * Agrega una nueva cancion a los arboles de búsquedas
	 * 
	 * @param cancion
	 *            JSONObject que contiene la información de la cancion
	 * @param indx
	 *            indice donde se encuentra la canción
	 */
	public void agregarCancion(JSONObject cancion, int indx) {
		artistas.insert((String) cancion.get("artista"), indx);
		albums.insert((String) cancion.get("artista"), indx);
		canciones.insert((String) cancion.get("nombre"), indx);
	}
}
