package com.odysseyserver.usermanagement;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import org.jdom2.Document;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

public class GestorUsuario {
	private static JSONArray listaUsuarios;
	
	public GestorUsuario () {
		try {
			JSONParser parser = new JSONParser();
			File json = new File("data/jsondata/jsonUsuarios.json");
			if (json.exists()) {
				Object obj =  parser.parse(new FileReader("data\\jsondata\\jsonUsuarios.json"));
				listaUsuarios = (JSONArray) obj;
			} else {
				listaUsuarios = new JSONArray();
				try {
					JSONObject obj = new JSONObject();			
					FileWriter jsonWriter = new FileWriter("data\\jsondata\\jsonUsuarios.json");
					jsonWriter.write(listaUsuarios.toJSONString());
					jsonWriter.flush();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
			
		} catch (FileNotFoundException fne) {
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void registrar(Document xmlDoc) {
	}

}
