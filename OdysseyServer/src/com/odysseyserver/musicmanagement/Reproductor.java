package com.odysseyserver.musicmanagement;

import java.io.IOException;
import java.nio.file.Files;
import java.util.Base64;

import org.jdom2.Document;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import com.odysseyserver.tools.CreadorXML;

/**
 * Gestiona las tareas relacionas a la reproduccion de canciones
 * 
 * @author jorte
 *
 */
public class Reproductor {

	/**
	 * Se encarga de retornarle al cliente que la cancion solicitada para todo
	 * 
	 * @param doc
	 *            Document XML que contiene la informacion de la cancion solicitada
	 * @param canciones
	 *            JSONArray que contiene las canciones de la biblioteca musical
	 */
	public static void reproducir(Document doc, JSONArray canciones) {

		String cancion = (String) doc.getRootElement().getChildText("cancion");
		String artista = (String) doc.getRootElement().getChildText("artista");

		String path = null;

		for (int i = 0; i < canciones.size(); i++) {
			JSONObject temp = (JSONObject) canciones.get(i);
			if (cancion.equals((String) (temp.get("nombre"))) && artista.equals((String) (temp.get("artista")))) {
				path = (String) temp.get("path");
				break;
			}
		}

		if (path == null) {
			CreadorXML.responderTrueFalse(false);
		} else {
			try {
				byte[] cancionArray = Files.readAllBytes(new java.io.File(path).toPath());
				String cancionString = Base64.getEncoder().encodeToString(cancionArray);
				CreadorXML.responderCancion(cancionString);
			} catch (IOException e) {
				e.printStackTrace();
			}
		}

	}

}
