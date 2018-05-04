package com.odysseyserver.musicmanagement;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

import org.jdom2.Document;

import com.sun.org.apache.xerces.internal.impl.dv.util.Base64;

public class GeneradorMusica {
	
	/**
	 * Se guardan las canciones provenientes de un XML
	 * @param xmlCancion / Document xml que contienen información
	 */
	public static void guardarCancion(Document xmlCancion) {
		String destino = xmlCancion.getRootElement().getChildText("name");
		try {
			FileOutputStream nuevo = new FileOutputStream("OdysseyServer\\data\\music\\" + destino);
			byte[] newSong = Base64.decode(xmlCancion.getRootElement().getChild("song").getText());
			nuevo.write(newSong);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
	}

}
