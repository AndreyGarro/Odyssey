package com.odysseyserver.musicmanagement;

import java.io.FileWriter;
import java.io.IOException;

import org.jdom2.Document;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

/**
 * Gestiona lo relacionado a los JSON de la música
 * 
 * @author jorte
 *
 */
public class JSONMusica {

	/**
	 * Crea un nuevo JSONObject con la información de la canción
	 * 
	 * @param xml
	 *            Documento XML donde se extrae la información
	 * @return JSONObject
	 */
	@SuppressWarnings("unchecked")
	public static JSONObject nuevaCanción(Document xml) {
		JSONObject cancion = new JSONObject();
		cancion.put("nombre", xml.getRootElement().getChildText("name"));
		cancion.put("artista", xml.getRootElement().getChildText("artista"));
		cancion.put("album", "");
		cancion.put("año", 0);
		cancion.put("genero", "");
		cancion.put("calificacion", 0);
		cancion.put("letra", "");
		cancion.put("path", "data" + "\\" + "music" + "\\" + xml.getRootElement().getChildText("name") +"-" + xml.getRootElement().getChildText("artista") + ".mp3");
		return cancion;
	}

	/**
	 * Se sobreescribe el JSONArray de la información musical
	 * 
	 * @param jsonList
	 *            JSONArray a sobreescribir
	 */
	public static void guardarInfo(JSONArray jsonList) {
		try {
			@SuppressWarnings("resource")
			FileWriter jsonWriter = new FileWriter("data\\jsondata\\jsonMusicList.json");
			jsonWriter.write(jsonList.toJSONString());
			jsonWriter.flush();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	
	
}
