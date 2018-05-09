package com.odysseyserver.main;

import com.odysseyserver.facade.OdysseyServerFacade;
import com.odysseyserver.musicmanagement.GestorMusica;
import com.odysseyserver.server.Server;
import com.odysseyserver.usermanagement.GestorUsuario;

/**
 * Main del proyecto, se inician todos los recursos del programa
 * 
 * @author jorte
 *
 */
public class OdysseyLauncher {
	
	
	public static void main(String[] args) {

		// Se inicializan todos los recursos necesarios para el programa
		GestorMusica.getInstance();
		OdysseyServerFacade.getInstance();
		GestorUsuario.getInstance();

		// Se corre el server
		Server odysseyServer = Server.getInstance();
		new Thread(odysseyServer).start();

	}

}
