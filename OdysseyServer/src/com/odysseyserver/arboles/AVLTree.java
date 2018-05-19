package com.odysseyserver.arboles;

import com.odysseyserver.listas.SimpleNode;

import jdk.nashorn.internal.runtime.arrays.ArrayIndex;

/**
 * Arbol de busqueda AVL
 *
 */
public class AVLTree {
	private AVLNode root;

	public AVLTree() {
		root = null;
	}

	/**
	 * @return Verifica si el arbol esta vaciodo return root==null?
	 */
	public boolean isEmpty() {
		return root == null;
	}

	/**
	 * 
	 * Elimina el arbol
	 */
	public void makeEmpty() {
		root = null;
	}

	/**
	 * Inserta nuevos elementos al arbol
	 * 
	 * @param data
	 */
	public void insert(String clave, Integer indx) {
		this.root = insert(clave, indx, root);
	}

	/**
	 * Obtine la altura de un nodo
	 * 
	 * @param current
	 *            Nodo del que se quiere la altura
	 * @return EL valor de la altura
	 */
	private int height(AVLNode current) {
		if (current == null) {
			return -1;
		} else {
			return current.height;
		}
		// return t == null ? -1 : t.height;
	}

	/* Function to max of left/right node */
	private int max(int lhs, int rhs) {
		return lhs > rhs ? lhs : rhs;
	}

	/**
	 * Funcion que inserta nuevos datos al arbol
	 * 
	 * @param clave
	 *            Indentificardor del nodo
	 * @param indx
	 *            Ubicacion donde se encuentra la clave
	 * @param current
	 *            Nodo desde donde evaluara agregar un nuevo dato
	 * @return La estructura del arbol con el nuevo nodo agregado
	 */
	private AVLNode insert(String clave, Integer indx, AVLNode current) {
		if (current == null) {
			current = new AVLNode(clave, indx);
		} else if (clave.compareToIgnoreCase(current.clave) < 0) {
			current.left = insert(clave, indx, current.left);
			if ( height(current.left) - height(current.right) == 2) {
				if (clave.compareToIgnoreCase(current.left.clave) < 0) {
					current = left(current);
				} else {
					current = leftRight(current);
				}
			}
		} else if (clave.compareToIgnoreCase(current.clave) > 0) {
			current.right = insert(clave, indx, current.right);
			if (height(current.right) - height(current.left) == 2) {			 
				if (clave.compareToIgnoreCase(current.right.clave) > 0) {
					current = right(current);
				} else {
					current = rightLeft(current);
				}
			}
		} else if (clave.compareToIgnoreCase(current.clave) == 0) {
			current.arrayIndx.add(new SimpleNode<Integer>(indx));
		} else
			;
		current.height = max(height(current.left), height(current.right)) + 1;
		return current;
	}

	/**
	 * Rotacion simple a la izquierda
	 * 
	 * @param n2
	 *            Nodo sobre el que se quiere aplicar la rotacion
	 * @return La nueva estructura del subArbol rotado
	 */
	private AVLNode left(AVLNode n2) {
		AVLNode n1 = n2.left;
		n2.left = n1.right;
		n1.right = n2;
		n2.height = max(height(n2.left), height(n2.right)) + 1;
		n1.height = max(height(n1.left), n2.height) + 1;
		return n1;
	}

	/**
	 * Rotacion simple a la derecha
	 * 
	 * @param n1
	 *            Nodo sobre el que aplicara la rotacion
	 * @return La nueva estructura del subArbol rotado
	 */
	private AVLNode right(AVLNode n1) {
		AVLNode n2 = n1.right;
		n1.right = n2.left;
		n2.left = n1;
		n1.height = max(height(n1.left), height(n1.right)) + 1;
		n2.height = max(height(n2.right), n1.height) + 1;
		return n2;
	}

	/**
	 * Rotacion compuesta izquerda derecha.
	 * 
	 * @param n3
	 *            Nodo sobre el que se rotara
	 * @return La nueva estructura del subArbol rotado
	 */
	private AVLNode leftRight(AVLNode n3) {
		n3.left = right(n3.left);
		return left(n3);
	}

	/**
	 * Rotavcion compuesta derecha izquierda
	 * 
	 * @param n1
	 *            Nodo sobre el que se aplicara la rotacion
	 * @return La nueva estructura del subArbol rotado.
	 */
	private AVLNode rightLeft(AVLNode n1) {
		n1.right = left(n1.right);
		return right(n1);
	}

	/**
	 * Obtiene el numero de nodos del arbol
	 * 
	 * @return El numero de nodos del arbol
	 */
	public int countNodes() {
		return countNodes(root);
	}

	/**
	 * Realiza la cuenta de los nodos aplicando recurcion
	 * 
	 * @param current
	 *            Nodo desde el cual buscar
	 * @return Numero de nodos
	 */
	private int countNodes(AVLNode current) {
		if (current == null) {
			return 0;
		} else {
			int num = 1;
			num += countNodes(current.left);
			num += countNodes(current.right);
			return num;
		}
	}

	/**
	 * Verifica si elemento esta en el arbol
	 * 
	 * @param clave
	 *            Elemento a buscar
	 * @return true en caso de que lo encuentre/ false en caso de que no lo
	 *         encuentre
	 */
	public boolean search(String clave) {
		return search(root, clave);
	}

	private boolean search(AVLNode current, String clave) {
		boolean found = false;
		while ((current != null) && !found) {
			String rval = current.clave;
			if (clave.compareToIgnoreCase(rval) < 0) {
				current = current.left;
			} else if (clave.compareToIgnoreCase(rval) > 0) {
				current = current.right;
			} else {
				found = true;
				break;
			}
			found = search(current, clave);
		}
		return found;
	}

	/**
	 * Obtiene un nodo indicando su clave
	 * 
	 * @param clave
	 * @return
	 */
	public AVLNode searchTwo(String clave) {
		return searchTwo(root, clave);
	}

	private AVLNode searchTwo(AVLNode current, String clave) {
		AVLNode found = new AVLNode();
		while ((current != null) && found == null) {
			String rval = current.clave;
			if (clave.compareToIgnoreCase(rval) < 0) {
				current = current.left;
			} else if (clave.compareToIgnoreCase(rval) > 0) {
				current = current.right;
			} else if (clave.compareToIgnoreCase(rval) == 0) {
				found = current;
				break;
			}
			found = searchTwo(current, clave);
		}
		return found;
	}

	/**
	 * Recorrido del arbol en inOrden
	 */
	public void inOrder() {
		inOrder(root);
	}

	private void inOrder(AVLNode r) {
		if (r != null) {
			inOrder(r.left);
			System.out.print(r.clave + " ");
			inOrder(r.right);
		}
	}

	/**
	 * Recorrido del arbol en preOrden
	 */
	public void preOrder() {
		preorder(root);
	}

	private void preorder(AVLNode r) {
		if (r != null) {
			System.out.print(r.clave);
			for (int i = 0; i < r.arrayIndx.getLength(); i++) {
				System.out.print(" " + r.arrayIndx.find(i));
			}
			System.out.println();
			preorder(r.left);
			preorder(r.right);
		}
	}

	/**
	 * Recorrido del arbol en postOrden
	 */
	public void postorder() {
		postorder(root);
	}

	private void postorder(AVLNode r) {
		if (r != null) {
			postorder(r.left);
			postorder(r.right);
			System.out.print(r.clave + " ");
		}
	}

	/**
	 * Busca el Nodo con el minimo valor
	 *
	 * @return Devuelve el Nodo con el minimo valor
	 */
	public AVLNode findMin() {
		return findMin(this.root);
	}

	/**
	 * Hace la busqueda concreta del elemento
	 *
	 * @param current
	 *            Punto desde el que se quiere buscar
	 * @return El Nodo de menor valor
	 */
	private AVLNode findMin(AVLNode current) {
		if (current == null) {
			return null;
		} else if (current.left == null) {
			return current;
		} else {
			return this.findMin(current.left);
		}
	}

	/**
	 * 
	 * @param key
	 */
	public void delete(String key) {
		root = delete(this.root, key);
		return;
	}

	private AVLNode delete(AVLNode node, String key) {
		if (node == null) {
			return null;
		}
		if (key.compareToIgnoreCase(node.clave) < 0) {
			node.left = delete(node.left, key);
		} else if (key.compareToIgnoreCase(node.clave) > 0) {
			node.right = delete(node.right, key);
		} else {
			if (node.left == null) {
				node = node.right;
			} else if (node.right == null) {
				node = node.left;
			} else {
				AVLNode temp = findMin(node.right);
				node.clave = temp.clave;
				node.arrayIndx = temp.arrayIndx;
				node.right = delete(node.right, temp.clave);
			}
		}
//
//		if (node == null) {
//			return null;
//		}
//		node.height = max(height(node.left), height(node.right)) + 1;
//
//		int balance = getBalance(node);
//
//		if (height(current.left) - height(current.right) == 2) {
//			if (getBalance(node.left) >= 0) {
//				node = left(node);
//			}else {
//				//node = leftRight(node);
//				 node.left = rotateLeft(node.left);
//				 node = rotateRight(node);
//			}
//		}
//		else if (height(current.left) - height(current.right) == 2) {
//			if (getBalance(node.right) <= 0) {
//				node = rotateRight(node);
//			} else {
//				 node.right = rotateRight(node.right);
//				 node = rotateLeft(node);
//			}
//		}
		return node;
	}

	private int getBalance(AVLNode node) {
		if (node == null) {
			return 0;
		}
		int balance;
		balance = height(node.left) - height(node.right);
		return balance;
	}

	private AVLNode rotateRight(AVLNode node) {
		if (node == null)
			return node;
		System.out.println(node.clave);
		AVLNode beta = node.left;
		System.out.println(beta.right);
		AVLNode t2 = beta.right;

		beta.right = node;
		node.left = t2;

		//updateHeight(node);
		node.height = max(height(node.left), height(node.right)) + 1;

		//updateHeight(beta);
		beta.height = max(height(beta.left), height(beta.right)) + 1;

		return beta;
	}

	private AVLNode rotateLeft(AVLNode node) {
		if (node == null)
			return node;

		AVLNode beta = node.right;
		AVLNode t2 = beta.left;

		beta.left = node;
		node.right = t2;

		//updateHeight(node);
		node.height = max(height(node.left), height(node.right)) + 1;
		
		//updateHeight(beta);
		beta.height = max(height(beta.left), height(beta.right)) + 1;
		
		return beta;
	}
}