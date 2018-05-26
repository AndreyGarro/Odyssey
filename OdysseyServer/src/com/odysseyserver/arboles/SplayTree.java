package com.odysseyserver.arboles;

/**
 * Arbol binario de busqueda Splay
 * Funciones insertar, remove, find, contains
 * @param <String>
 */
public class SplayTree<T extends Comparable<T>> {

	private SplayNode root;

	/**
	 * Nodo del arbol
	 */

	/**
	 * Comprueba la existencia que un nodo en el arbol
	 * 
	 * @param clave
	 *            Clave que sera buscada
	 * @return true si la clave esta contenida en el arbol/ false de lo contrario
	 */
	public boolean contains(String clave) {
		return get(clave) != null;
	}

	public void preorder(SplayNode nodo) {
		if (nodo != null) {
			System.out.print(nodo.clave);
			for (int i = 0; i < nodo.arrayIndx.getLength(); i++) {
				System.out.print(" " + nodo.arrayIndx.find(i));
			}
			System.out.println();
			preorder(nodo.left);
			preorder(nodo.right);
		}
	}

	/**
	 * Permite obtener la raiz
	 * 
	 * @return
	 */
	public SplayNode getRoot() {
		return this.root;
	}
	/**
	 * Realiza la busqueda concreta de un nodo indicando su nombre
	 * 
	 * @param clave
	 *            Nombre del nodo a buscar
	 * @return El nombre del nodo en caso de encontrarlo De lo contrario null
	 */
	public String get(String clave) {
		root = splay(root, clave);
		int cmp = clave.compareTo(root.clave);
		if (cmp == 0) {
			return clave;
		} else {
			return null;
		}
	}
	/**
	 * Permite buscar un nodo, indicando su clave
	 * @param clave
	 * 				Nombre del nodo a buscar
	 * @return
	 * 			Nodo que posee el nombre indicando
	 * 			Null si no lo encuentra
	 */
	public SplayNode find(String clave) {
		root = splay(root, clave);
		int cmp = clave.compareTo(root.clave);
		if (cmp == 0) {
			return root;
		} else {
			return null;
		}
	}

	/**
	 * Inserta un nodo en el arbol
	 * @param clave
	 *            Nombre del nodo
	 * 
	 * @param indx
	 *            Indice donde se puede encontar el archivo con el nombre del nodo
	 * 
	 */
	public void insert(String clave, Integer indx) {
		if (root == null) {
			root = new SplayNode(clave, indx);
			return;
		}
		root = splay(root, clave);
		int cmp = clave.compareTo(root.clave);

		if (cmp < 0) {
			SplayNode n = new SplayNode(clave, indx);
			n.left = root.left;
			n.right = root;
			root.left = null;
			root = n;
		} else if (cmp > 0) {
			SplayNode n = new SplayNode(clave, indx);
			n.right = root.right;
			n.left = root;
			root.right = null;
			root = n;
		} else {
			root.clave = clave;
			root.addArrayIndx(indx);
		}

	}

	/**
	 * Elimina un nodo al indicar su nombre (Tambien de debe indicar la ubicacion en
	 * este caso)
	 * 
	 * @param clave
	 *            Nombre del nodo a eliminar
	 * 
	 *            ( @param indx ubicacion a eliminar)
	 */
	public void remove(String clave, Integer indx) {
		if (root == null)
			return;
		root = splay(root, clave);

		int cmp = clave.compareTo(root.clave);

		if (cmp == 0) {
			if (root.left == null) {

				if ((root.arrayIndx.getLength() == 1 && root.arrayIndx.getFirst().getDato().equals(indx))
						|| indx == -1) {
					root = root.right;
				} else {
					root.remArrayIndx(indx);
				}

			} else if (root.right == null) {

				if ((root.arrayIndx.getLength() == 1 && root.arrayIndx.getFirst().getDato().equals(indx))
						|| indx == -1) {
					root = root.left;
				} else {
					root.remArrayIndx(indx);
				}

			} else {
				if ((root.arrayIndx.getLength() == 1 && root.arrayIndx.getFirst().getDato().equals(indx))
						|| indx == -1) {
					SplayNode x = root.right;
					root = root.left;
					root = splay(root, clave);
					root.right = x;
				} else {
					root.remArrayIndx(indx);
				}
			}
		}
	}

	/**
	 * Metodo se encarga de hacer el biselado cuando se pide acceder al nodo
	 * @param nodo
	 * 			Nodo apartir del cual se empezara a biselar
	 * @param clave
	 * 				Nombre del nodo a buscar
	 * @return
	 * 			El nodo buscando que se encontrara en la raiz
	 */
	private SplayNode splay(SplayNode nodo, String clave) {
		if (nodo == null)
			return null;

		int cmp1 = clave.compareTo(nodo.clave);

		if (cmp1 < 0) {
			if (nodo.left == null) {
				return nodo;
			}
			int cmp2 = clave.compareTo(nodo.left.clave);
			
			if (cmp2 < 0) {
				nodo.left.left = splay(nodo.left.left, clave);
				nodo = rotateRight(nodo);
			} else if (cmp2 > 0) {
				nodo.left.right = splay(nodo.left.right, clave);
				if (nodo.left.right != null)
					nodo.left = rotateLeft(nodo.left);
			}
			if (nodo.left == null)
				return nodo;
			else
				return rotateRight(nodo);
		} else if (cmp1 > 0) {
			if (nodo.right == null) {
				return nodo;
			}
			int cmp2 = clave.compareTo(nodo.right.clave);
			
			if (cmp2 < 0) {
				nodo.right.left = splay(nodo.right.left, clave);
				if (nodo.right.left != null)
					nodo.right = rotateRight(nodo.right);
			} else if (cmp2 > 0) {
				nodo.right.right = splay(nodo.right.right, clave);
				nodo = rotateLeft(nodo);
			}
			if (nodo.right == null)
				return nodo;
			else
				return rotateLeft(nodo);
		}

		else
			return nodo;
	}

	// height of tree (1-node tree has height 0)
	// public int height() {
	// return height(root);
	// }
	//
	// private int height(SplayNode x) {
	// if (x == null)
	// return -1;
	// return 1 + Math.max(height(x.left), height(x.right));
	// }
	//
	// public int size() {
	// return size(root);
	// }
	//
	// private int size(SplayNode x) {
	// if (x == null)
	// return 0;
	// else
	// return 1 + size(x.left) + size(x.right);
	// }

	/**
	 * Realiza la rotacion a la derecha
	 * 
	 * @param h
	 *            Nodo a rotar
	 * @return Nodo aplicada la rotacion
	 */
	private SplayNode rotateRight(SplayNode h) {
		SplayNode x = h.left;
		h.left = x.right;
		x.right = h;
		return x;
	}

	/**
	 * Realiza la rotacion a la izquierda
	 * 
	 * @param h
	 *            Nodo a rotar
	 * @return Nodo aplicada la rotacion
	 */
	private SplayNode rotateLeft(SplayNode h) {
		SplayNode x = h.right;
		h.right = x.left;
		x.left = h;
		return x;
	}

}
