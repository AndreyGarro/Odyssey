
package com.odysseyserver.arboles;

import com.odysseyserver.listas.SimpleList;
import com.odysseyserver.listas.SimpleNode;

/**
 * Nodo del arbol Splay, con funcionalidad para guardar
 *  posiciones de archivos como listas o json. 
 *
 */
public class SplayNode {
	
	public String clave;
	public SimpleList<Integer> arrayIndx = new SimpleList<>();
	public  SplayNode left, right;
	/**
	 * Constructor del nodo por defecto se necesitan minimo la clave
	 * y la posicion del archivo.
	 * @param clave
	 * 				Nombre que nodo
	 * @param indx
	 * 			Posicion del archivo 
	 */
	public SplayNode(String clave, Integer indx) {
		this.clave = clave;
		this.left = null;
		this.right = null;
		addArrayIndx(indx);
	}
	/**
	 * Elimina posiciones de los archivos
	 * @param indx
	 * 			Posicion del archivo 
	 */
	public void remArrayIndx(Integer indx) {
		this.arrayIndx.remove(indx);
	}
	
	/**
	 *  Permite insertar posicones de otros archivos que tienen el mismo nombre
	 * @param indx
	 */
	public void addArrayIndx(Integer indx) {
		this.arrayIndx.add(new SimpleNode<Integer>(indx));
	}
}