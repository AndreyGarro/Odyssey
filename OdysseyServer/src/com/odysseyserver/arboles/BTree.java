package com.odysseyserver.arboles;

import com.odysseyserver.listas.SimpleList;
import com.odysseyserver.listas.SimpleNode;

import sun.java2d.pipe.SpanShapeRenderer.Simple;

/**
 * Arbol B, Metodos get, insertar, ToString
 * @author Christian
 *
 * @param <T>
 */
public class BTree<T extends Comparable<T>> {
	private static final int M = 4;

	private NodeB root;
	private int height;
	// private int n; //

	private static final class NodeB {
		private int numChildren;
		private Entry[] children = new Entry[M];

		private NodeB(int k) {
			numChildren = k;
		}
	}

	// internal nodes: only use key and next
	// external nodes: only use key and value
	private static class Entry<T> {
		private T clave;
		private NodeB next; // helper field to iterate over array entries
		private SimpleList<Integer> arrayIndx;

		public Entry(T key, Integer indx, NodeB next) {
			this.clave = key;
			this.next = next;
			arrayIndx = new SimpleList<>();
			this.addArrayIndx(indx);
		}

		public Entry(T key, SimpleList<Integer> arrayIndx, NodeB next) {
			this.clave = key;
			this.next = next;
			this.arrayIndx = arrayIndx;
		}

		/**
		 * Elimina ubicaciones de la lista de indes
		 * 
		 * @param indx
		 *            Ubicacion a eliminar
		 */
		public void remArrayIndx(Integer indx) {
			arrayIndx.remove(indx);
		}

		/**
		 * Anade ubicaciones a lista de indices
		 * 
		 * @param indx
		 *            Ubicacion a anadir
		 */
		public void addArrayIndx(Integer indx) {
			this.arrayIndx.add(new SimpleNode<Integer>(indx));
		}

		public SimpleList<Integer> getArrayIndx() {
			return this.arrayIndx;
		}
	}

	/**
	 * Inicializa el arbol B
	 */
	public BTree() {
		root = new NodeB(0);
	}

	/**
	 * Verifica que arbol esta vacio root == 0
	 * 
	 * @return True o false
	 */
	public boolean isEmpty() {
		return root == null;
	}

	// /**
	// * @return Numero de claves que hay en el arbol
	// */
	// public int size() {
	// return n;
	// }

	/**
	 * Retorna la altura del arbol
	 *
	 * @return Altura del arbol B
	 */
	public int height() {
		return height;
	}

	/**
	 * Retorna los indices de una clave, si esta se encuentra en el arbol
	 * 
	 * @param clave
	 *            the key
	 * @return Array de indices
	 */
	public SimpleList<Integer> get(T clave) {
		if (clave == null)
			throw new IllegalArgumentException("argument to get() is null");
		return search(root, clave, height);
	}

	private SimpleList<Integer> search(NodeB current, T key, int ht) {
		Entry[] children = current.children;
		// external node
		if (ht == 0) {
			for (int j = 0; j < current.numChildren; j++) {
				if (eq(key, (T) children[j].clave))
					return children[j].arrayIndx;
			}
		}
		// internal node
		else {
			for (int j = 0; j < current.numChildren; j++) {
				if (j + 1 == current.numChildren || less(key, (T) children[j + 1].clave))
					return search(children[j].next, key, ht - 1);
			}
		}
		return null;
	}

	/**
	 * Inserta un nuevo dato, crea el nodo nuevo si ya no hay espacio en el nodo en
	 * el cual le corresponde ir
	 *
	 * @param clave
	 *            Clave del nodo
	 */

	public void insert(T clave, Integer indx) {
		if (clave == null) {
			throw new IllegalArgumentException("Clave nula");
		}
		NodeB nuevo = insert(root, clave, indx, height);
		if (nuevo == null) {
			return;
		}
		NodeB t = new NodeB(2);
		t.children[0] = new Entry((T) root.children[0].clave, root.children[0].arrayIndx, root);
		t.children[1] = new Entry((T) nuevo.children[0].clave, root.children[0].arrayIndx, nuevo);
		root = t;
		height++;
	}

	private NodeB insert(NodeB current, T key, Integer indx, int ht) {
		int j;
		Entry t = new Entry(key, indx, null);
		if (ht == 0) {
			for (j = 0; j < current.numChildren; j++) {
				if (less(key, (T) current.children[j].clave))
					break;
				else if (eq(key, (T) current.children[j].clave)) {
					current.children[j].addArrayIndx(indx);
					return null;
				}
			}
		} else {
			for (j = 0; j < current.numChildren; j++) {
				if ((j + 1 == current.numChildren) || less(key, (T) current.children[j + 1].clave)) {
					NodeB u = insert(current.children[j++].next, key, indx, ht - 1);// POSIBLE PROBLEMA
					if (u == null)
						return null;
					t.clave = u.children[0].clave;
					t.arrayIndx = u.children[0].arrayIndx;
					t.next = u;
					break;
				} else if ((j + 1 == current.numChildren) || eq(key, (T) current.children[j].clave)) {
					current.children[j].addArrayIndx(indx);
					return null;
				}
			}
		}
		for (int i = current.numChildren; i > j; i--)
			current.children[i] = current.children[i - 1];
		current.children[j] = t;
		current.numChildren++;
		if (current.numChildren < M)
			return null;
		else
			return split(current);
	}

	// split node in half
	private NodeB split(NodeB h) {
		NodeB t = new NodeB(M / 2);
		h.numChildren = M / 2;
		for (int j = 0; j < M / 2; j++)
			t.children[j] = h.children[M / 2 + j];
		return t;
	}

	/**
	 * Returns a string representation of this B-tree (for debugging).
	 *
	 * @return a string representation of this B-tree.
	 */
	public String toString() {
		return toString(root, height, "") + "\n";
	}

	private String toString(NodeB h, int ht, String indent) {
		StringBuilder s = new StringBuilder();
		Entry[] children = h.children;

		if (ht == 0) {
			for (int j = 0; j < h.numChildren; j++) {
				s.append(indent + children[j].clave + printIndx(children[j].getArrayIndx()) + "\n");
			}
		} else {
			for (int j = 0; j < h.numChildren; j++) {
				if (j > 0)
					s.append(indent + "(" + children[j].clave + printIndx(children[j].getArrayIndx()) + ")\n");
				s.append(toString(children[j].next, ht - 1, indent + "     "));
			}
		}
		return s.toString();
	}

	// Aux para imprimir lista de indices
	private String printIndx(SimpleList<Integer> indx) {
		String strIndx = "";
		System.out.println(indx.getLength());
		for (int i = 0; i < indx.getLength(); i++) {
			strIndx += " " + indx.find(i);
		}
		return strIndx;
	}

	// comparison functions - make Comparable instead of Key to avoid casts
	private boolean less(T k1, T k2) {
		return k1.compareTo(k2) < 0;
	}

	private boolean eq(T k1, T k2) {
		return k1.compareTo(k2) == 0;
	}

	/**
	 * Unit tests the {@code BTree} data type.
	 *
	 * @param args
	 *            the command-line arguments
	 */
	public static void main(String[] args) {

		BTree<String> st = new BTree<String>();
		st.insert("g", 85);
		st.insert("p", 41);
		st.insert("a", 96);
		st.insert("k", 52);
		st.insert("c", 63);
		st.insert("h", 94);
		st.insert("q", 21);
		st.insert("t", 78);
		st.insert("l", 32);
		st.insert("g", 85);
		st.insert("p", 41);
		st.insert("a", 96);
		st.insert("k", 52);
		st.insert("c", 63);
		st.insert("h", 94);
		st.insert("q", 21);
		st.insert("t", 78);
		st.insert("l", 32);
		System.out.println(st.get("q"));
		System.out.println(st.get("y"));
		System.out.println(st.get("k"));
		System.out.println(st.get("g"));
		System.out.println(st.get("h"));
		System.out.println(st.get("g"));
		System.out.println(st.get("t"));
		System.out.println(st.toString());

	}

}
