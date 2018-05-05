package com.odysseyserver.musicmanagement;

import java.io.FileWriter;
import java.io.IOException;

import org.jdom2.Document;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

public class JSONMusica {
	
	public static JSONObject nuevaCanción(Document xml) {
		JSONObject cancion = new JSONObject();
		cancion.put("nombre", xml.getRootElement().getChildText("name"));
		cancion.put("path", "data" + "\\" + "music" + "\\" + xml.getRootElement().getChildText("name") + ".mp3");
		return cancion;
	}
	
	public static void guardarInfo(JSONArray jsonList) {
		try {
			FileWriter jsonWriter = new FileWriter("data\\jsondata\\jsonMusicList.json");
			jsonWriter.write(jsonList.toJSONString());
			jsonWriter.flush();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

}
