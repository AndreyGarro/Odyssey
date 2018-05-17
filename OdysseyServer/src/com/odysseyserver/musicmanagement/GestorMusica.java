package com.odysseyserver.musicmanagement;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import org.jdom2.Document;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

import com.odysseyserver.utilidades.CreadorXML;
import com.odysseyserver.utilidades.Ordenamiento;
import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;

/**
 * Gestiona todas las tareas relacionadas con la música
 * 
 * @author jorte
 *
 */
public class GestorMusica {

	private JSONArray jsonMusicList;
	private static GestorMusica instance;

	private GestorMusica() throws IOException, ParseException {
		try {

			JSONParser parser = new JSONParser();
			File json = new File("data\\jsondata\\jsonMusicList.json");
			if (json.exists()) {
				Object obj = parser.parse(new FileReader("data\\jsondata\\jsonMusicList.json"));
				jsonMusicList = (JSONArray) obj;
			} else {
				jsonMusicList = new JSONArray();
				try {
					JSONObject obj = new JSONObject();
					FileWriter jsonWriter = new FileWriter("data\\jsondata\\jsonMusicList.json");
					jsonWriter.write(jsonMusicList.toJSONString());
					jsonWriter.flush();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}

		} catch (FileNotFoundException fne) {

		}
	}

	public static GestorMusica getInstance() {
		if (instance == null) {
			try {
				instance = new GestorMusica();
			} catch (IOException | ParseException e) {
				e.printStackTrace();
			}
		}
		return instance;
	}

	/**
	 * Se guardan las canciones provenientes de un XML
	 * 
	 * @param xmlCancion
	 *            / Document xml que contienen información
	 */
	@SuppressWarnings("unchecked")
	public void agregarCancion(Document xmlCancion) {
		String nombre = xmlCancion.getRootElement().getChildText("name");
		String artista = xmlCancion.getRootElement().getChildText("artista");
		// Verifica que la canción no exista

		boolean existe = false;
		for (int i = 0; i < jsonMusicList.size(); i++) {
			JSONObject jsonTemp = (JSONObject) jsonMusicList.get(i);
			if (nombre.equals(jsonTemp.get(nombre)) && artista.equals(jsonTemp.get(artista))) {
				existe = true;
				break;
			}
		}
		if (!existe) {
			try {
				System.out.println(nombre + " " + artista);
				FileOutputStream nuevo = new FileOutputStream("data\\music\\" + nombre + ".mp3");
				byte[] newSong = Base64.decode(xmlCancion.getRootElement().getChild("song").getText());
				nuevo.write(newSong);

				// Agrega la canción
				jsonMusicList.add(JSONMusica.nuevaCanción(xmlCancion));
				System.out.println(jsonMusicList.toJSONString());
				JSONMusica.guardarInfo(jsonMusicList);

				// Envía XML al cliente
				CreadorXML.responderTrueFalse(true);
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
		} else {
			// Responde que no se puede agregar la canción
			CreadorXML.responderTrueFalse(false);
		}
	}

	/**
	 * Ordena la lista de canciones por orden de album, se aplica BubbleSort
	 */
	public void ordenarAlbum() {
		Ordenamiento.ordenarAlbum(jsonMusicList);
	}

	/**
	 * Ordena las canciones en orden del nombre de la canción
	 */
	public void ordenarCancion() {
		Ordenamiento.ordenarCancion(jsonMusicList);
	}
	
	/**
	 * Ordena las canciones en orden del nombre de artista
	 */
	public void ordenarArtista() {
		Ordenamiento.ordenarArtista(jsonMusicList);
	}
}
