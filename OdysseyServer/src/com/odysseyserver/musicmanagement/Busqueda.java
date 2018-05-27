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
	private BTree<String> canciones;
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
		System.out.println("Entré a artistas");
	}

	private void generarArbolCanciones(JSONArray jsonArray) {

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
		System.out.println("Entré a albumes");
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
		return artistas.searchTwo(artista).getArrayIndx();
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
		return albums.find(album).getArrayIndx();

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
		artistas.insert((String)cancion.get("artista"), indx);
		albums.insert((String)cancion.get("artista"), indx);
	}

}
