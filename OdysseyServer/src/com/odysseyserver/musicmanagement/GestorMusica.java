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

import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;

public class GestorMusica {
	
	private static JSONArray jsonMusicList;

	public GestorMusica() throws IOException, ParseException {
		try {
			JSONParser parser = new JSONParser();
			File json = new File("data\\jsondata\\jsonMusicList.json");
			if (json.exists()) {
				Object obj =  parser.parse(new FileReader("OdysseyServer\\data\\jsondata\\jsonMusicList.json"));
				jsonMusicList = (JSONArray) obj;
			} else {
				jsonMusicList = new JSONArray();
				try {
					JSONObject obj = new JSONObject();			
					FileWriter jsonWriter = new FileWriter("OdysseyServer\\data\\jsondata\\jsonMusicList.json");
					jsonWriter.write(jsonMusicList.toJSONString());
					jsonWriter.flush();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
			
		} catch (FileNotFoundException fne) {
			
		}
	}
	
	/**
	 * Guarda datos de la canción en un objeto JSON
	 * @param xml
	 */
	@SuppressWarnings("unchecked")
	private static  void guardarDataCancion(Document xml) {
		jsonMusicList.add(JSONMusica.nuevaCanción(xml));
		System.out.println(jsonMusicList.toJSONString());
		JSONMusica.guardarInfo(jsonMusicList);
	}
	
	
	/**
	 * Se guardan las canciones provenientes de un XML
	 * 
	 * @param xmlCancion
	 *            / Document xml que contienen información
	 */
	public static void guardarCancion(Document xmlCancion) {
		String destino = xmlCancion.getRootElement().getChildText("name");
		try {
			FileOutputStream nuevo = new FileOutputStream("data\\music\\" + destino + ".mp3");
			byte[] newSong = Base64.decode(xmlCancion.getRootElement().getChild("song").getText());
			nuevo.write(newSong);
			guardarDataCancion(xmlCancion);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
