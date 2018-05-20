package com.odysseyserver.arboles;

import com.odysseyserver.listas.SimpleList;
import com.odysseyserver.listas.SimpleNode;

/**
 * 
 * @param <String>
 */
public class SplayTree<String extends Comparable<String>> {

	private SplayNode root; 

	/**
	 * 
	 *
	 */
	private class SplayNode {
		private String clave; 
		private SimpleList<Integer> arrayIndx = new SimpleList<>();
 		private SplayNode left, right;

		public SplayNode(String clave, Integer indx) {
			this.clave = clave; this.left = null; this.right = null;
			addArrayIndx(indx);
		}
		public void remArrayIndx(Integer indx) {
			this.arrayIndx.remove(indx);
		}
		public void addArrayIndx(Integer indx){
			this.arrayIndx.add(new SimpleNode<Integer>(indx));
		}
	}
	/**
	 * Comprueba la existencia que un nodo en el arbol
	 * 
	 * @param clave
	 * 				Clave que sera buscada
	 * @return
	 * 			true si la clave esta contenida en el arbol/ false de lo contrario
	 */
	public boolean contains(String clave) {
		return get(clave) != null;
	}

	public void preorder(SplayNode r) {
		if (r != null) {
			System.out.println(r.clave);
			preorder(r.left);
			preorder(r.right);
		}
	}
	/**
	 * Permite obtener la raiz 
	 * @return
	 */
	public SplayNode getRoot() {
		return this.root;
	}

	/**
	 * Realiza la busqueda comcreta de un nodo indicando su nombre 
	 *  @param clave
	 *  			Nombre del nodo a buscar 
	 * @return
	 * 			El nombre del nodo en caso de encontrarlo
	 * 			De lo contrario null
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
	 * Inserta un nodo en el arbol
	 * @param clave
	 * 				Nombre del nodo 
	 * 
	 * @param indx
	 * 			Indice donde se puede encontar el archivo con el nombre del 
	 * 			nodo
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
		}
		else if (cmp > 0) {
			SplayNode n = new SplayNode(clave, indx);
			n.right = root.right;
			n.left = root;
			root.right = null;
			root = n;
		}
		else {
			root.clave = clave;
			root.addArrayIndx(indx);
		}

	}

	/**
	 * Elimina un nodo al indicar su nombre
	 * 		(Tambien de debe indicar la ubicacion en este caso)
	 * @param clave
	 * 		Nombre del nodo a eliminar 
	 * 
	 *( @param indx
	 * 			ubicacion a eliminar)
	 */
	public void remove(String clave, Integer indx) {
		if (root == null)
			return; 
		root = splay(root, clave);
		int cmp = clave.compareTo(root.clave);
		
		if (cmp == 0) {
			if (root.left == null) {
				
				if ((root.arrayIndx.getLength() == 1 &&  root.arrayIndx.getFirst().getDato().equals(indx))|| indx == -1) {
					root = root.right;
				}else {
					root.remArrayIndx(indx);
				}
				
			} else if (root.right == null) {
				
				if ((root.arrayIndx.getLength() == 1 &&  root.arrayIndx.getFirst().getDato().equals(indx))|| indx == -1) {
					root = root.left;
				}else {
					root.remArrayIndx(indx);
				}
				
			} else {
				if ((root.arrayIndx.getLength() == 1 &&  root.arrayIndx.getFirst().getDato().equals(indx))|| indx == -1) {
					SplayNode x = root.right;
					root = root.left;
					root = splay(root, clave);
					root.right = x;
				}else {
					root.remArrayIndx(indx);
				}
			}
		}
		// else: it wasn't in the tree to remove
	}
	/***************************************************************************
	 * Splay tree function.
	 **********************************************************************/
	// splay key in the tree rooted at Node h. If a node with that key exists,
	// it is splayed to the root of the tree. If it does not, the last node
	// along the search path for the key is splayed to the root.
	private SplayNode splay(SplayNode h, String key) {
		if (h == null)
			return null;

		int cmp1 = key.compareTo(h.clave);

		if (cmp1 < 0) {
			// key not in tree, so we're done
			if (h.left == null) {
				return h;
			}
			int cmp2 = key.compareTo(h.left.clave);
			if (cmp2 < 0) {
				h.left.left = splay(h.left.left, key);
				h = rotateRight(h);
			} else if (cmp2 > 0) {
				h.left.right = splay(h.left.right, key);
				if (h.left.right != null)
					h.left = rotateLeft(h.left);
			}

			if (h.left == null)
				return h;
			else
				return rotateRight(h);
		}

		else if (cmp1 > 0) {
			// key not in tree, so we're done
			if (h.right == null) {
				return h;
			}

			int cmp2 = key.compareTo(h.right.clave);
			if (cmp2 < 0) {
				h.right.left = splay(h.right.left, key);
				if (h.right.left != null)
					h.right = rotateRight(h.right);
			} else if (cmp2 > 0) {
				h.right.right = splay(h.right.right, key);
				h = rotateLeft(h);
			}

			if (h.right == null)
				return h;
			else
				return rotateLeft(h);
		}

		else
			return h;
	}

	/***************************************************************************
	 * Helper functions.
	 ***************************************************************************/

	// height of tree (1-node tree has height 0)
	public int height() {
		return height(root);
	}

	private int height(SplayNode x) {
		if (x == null)
			return -1;
		return 1 + Math.max(height(x.left), height(x.right));
	}

	public int size() {
		return size(root);
	}

	private int size(SplayNode x) {
		if (x == null)
			return 0;
		else
			return 1 + size(x.left) + size(x.right);
	}

	/**
	 * Realiza la rotacion a la derecha
	 * @param h
	 * 			Nodo a rotar
	 * @return
	 * 		Nodo aplicada la rotacion 
	 */
	private SplayNode rotateRight(SplayNode h) {
		SplayNode x = h.left;
		h.left = x.right;
		x.right = h;
		return x;
	}

	/**
	 * Realiza la rotacion a la izquierda
	 * @param h 
	 * 			Nodo a rotar
	 * @return
	 * 			Nodo aplicada la rotacion
	 */
	private SplayNode rotateLeft(SplayNode h) {
		SplayNode x = h.right;
		h.right = x.left;
		x.left = h;
		return x;
	}

}
