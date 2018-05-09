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

import com.odysseyserver.utilidades.CreadorXML;

public class GestorUsuario {
	private static JSONArray listaUsuarios;
	private static GestorUsuario instance;

	
	private GestorUsuario () {
		try {
			JSONParser parser = new JSONParser();
			File json = new File("data\\jsondata\\jsonUsuarios.json");
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
	
	public static GestorUsuario getInstance() {
		if (instance == null) {
			instance = new GestorUsuario();
		}
		return instance;
	}
	
	@SuppressWarnings("unchecked")
	public void registrar(Document xmlDoc) {
		boolean existe = false;
		String usuario = xmlDoc.getRootElement().getChildText("NombreUsuario");
		for (int i = 0; i < listaUsuarios.size(); i++) {
			JSONObject jsonTemp = (JSONObject) listaUsuarios.get(i);
			if (usuario.equals(jsonTemp.get("username"))) {
				existe = true;
				break;
			}
		}
		if (!existe) {
			listaUsuarios.add(JSONUsuario.generarUsuarioJSON(xmlDoc));
			JSONUsuario.reescribirXML(listaUsuarios);
			System.out.println("Se ha registrado");
			CreadorXML.responderTrueFalse(true);
		} else {
			CreadorXML.responderTrueFalse(true);
		}
		
	}
	
	public void verificarSesion(Document xmlDoc) {
		String user = xmlDoc.getRootElement().getChild("Usuario").getChildText("NombreUsuario");
		String contraseña = xmlDoc.getRootElement().getChild("Usuario").getChildText("Contrasena");
		boolean existe= false;
		for (int i = 0; i < listaUsuarios.size(); i++) {
			JSONObject obj = (JSONObject) listaUsuarios.get(i);
			System.out.println(obj.toJSONString());
			System.out.println(obj.get("username"));
			System.out.println(user);
			if (user.equals(obj.get("username"))) {
				if (contraseña.equals(obj.get("contraseña"))) {
					System.out.println("SE Puede ingresar");
					existe = true;
					break;
				}
			}
		}
		
		if (existe) {
			CreadorXML.responderTrueFalse(false);
		} else {
			CreadorXML.responderTrueFalse(true);
		}
	}
}
