package com.odysseyserver.main;

import com.odysseyserver.facade.OdysseyServerFacade;
import com.odysseyserver.musicmanagement.GestorMusica;
import com.odysseyserver.server.Server;
import com.odysseyserver.usermanagement.GestorUsuario;

public class OdysseyLauncher {
	
	public static void main(String [] args) {
		
		GestorMusica.getInstance();
		OdysseyServerFacade.getInstance();
		GestorUsuario.getInstance();
		
		Server odysseyServer = new Server();
		new Thread(odysseyServer).start();
		
//		ServidorPrueba s = new ServidorPrueba();
//		new Thread(s).start();;
	}

}
