package com.odysseyserver.musicmanagement;

import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.arboles.AVLTree;
import com.odysseyserver.arboles.BTree;
import com.odysseyserver.arboles.SplayTree;
import com.odysseyserver.listas.SimpleList;

/**
 * Clase que se encarga de todo lo relacionado a las b�squedas
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

	}

	private void generarArbolCanciones(JSONArray jsonArray) {

	}

	private void generarArbolAlbumes(JSONArray jsonArray) {

	}

	/**
	 * Los �rboles de b�squeda se crean de nuevo en caso de que exista un cambio en
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
	 * @return SimpleList que contiene los �ndices donde se encuentra el artista
	 */
	public SimpleList<Integer> buscarArtista(String artista) {
		return null;
	}

	/**
	 * Se buscan las canciones correspondientes a un artista solicitado por el
	 * cliente
	 * 
	 * @param cancion
	 *            Nombre de la canci�n a la cual corresponden las canciones
	 * @return SimpleList que contiene los �ndices donde se encuentra el artista
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
	 * @return SimpleList que contiene los �ndices donde se encuentra el artista
	 */
	public SimpleList<Integer> buscarAlbum(String album) {
		return null;

	}

	/**
	 * Agrega una nueva cancion a los arboles de b�squedas
	 * 
	 * @param cancion
	 *            JSONObject que contiene la informaci�n de la cancion
	 */
	public void agregarCancion(JSONObject cancion) {

	}

}