package com.odysseyserver.main;

import java.io.IOException;

import org.json.simple.parser.ParseException;

import com.odysseyserver.musicmanagement.GestorMusica;
import com.odysseyserver.server.Server;

public class OdysseyLauncher {
	
	public static void main(String [] args) {
		
		try {
			GestorMusica generador = new GestorMusica();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ParseException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		Server odysseyServer = new Server();
		new Thread(odysseyServer).start();
	}

}
