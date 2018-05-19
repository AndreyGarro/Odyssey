package com.odysseyserver.arboles;

import com.odysseyserver.listas.SimpleList;
import com.odysseyserver.listas.SimpleNode;

/**
 * 
 * Clase nodo para el arbol AVL
 *
 */
public class AVLNode {
	AVLNode left, right;
	String clave;
	SimpleList<Integer> arrayIndx;
	int height;
	/**
	 * Contructor sin parametro
	 */
	public AVLNode() {
		this.left = null;
		this.right = null;
		this.clave = "";
		this.arrayIndx = new SimpleList<Integer>();
		this.height = 0;
	}
	/**
	 * Constructor con un parametro, debe recibir la clave 
	 * del nodo y el indice de la cancion.
	 * @param clave
	 * 				Identificardor del nodo
	 * @param indx
	 * 				Ubicacion donde es localizada la clave.
	 */
	public AVLNode(String clave, Integer indx ) {
		this.left = null;
		this.right = null;
		this.clave = clave;
		this.arrayIndx = new SimpleList<Integer>();
		this.arrayIndx.add(new SimpleNode<Integer>(indx));
		this.height = 0;
	}
}