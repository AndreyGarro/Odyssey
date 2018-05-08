package com.odysseyserver.listas;

/**
 * Lista enlazada simple
 * @author jorte
 *
 * @param <T> Tipo de dato de la lista
 */
public class SimpleList<T> {
	private SimpleNode<T> first;
	private int length;

	public SimpleList() {

	}

	/**
	 * Añade un nuevo nodo al final de la lista
	 * @param nodo SimpleNode
	 */
	public void add(SimpleNode<T> nodo) {
		if (isEmpty()) {
			add(0, nodo);
		} else {
			SimpleNode<T> temp = first;
			for (int i = 0; i < length; i++) {
				if (temp.getNext() == null) {
					temp.setNext(nodo);
					this.length += 1;
					break;
				} else {
					temp = temp.getNext();
				}
			}
		}
	}

	/**
	 * Añade un nuevo nodo en la posición indicada de la lista
	 * @param index Int
	 * @param nodo SimpleNode
	 */
	public void add(int index, SimpleNode<T> nodo) {
		if (index == 0) {
			nodo.setNext(first);
			first = nodo;
			length += 1;
		} else {
			if (index >= getLength()) {
				throw new IndexOutOfBoundsException("Index out of range");
			} else {
				SimpleNode<T> prev = first;
				SimpleNode<T> temp = first;
				int i = 0;
				while (i <= index) {
					if (i == index) {
						nodo.setNext(temp);
						prev.setNext(nodo);
						length += 1;
						break;
					} else {
						prev = temp;
						temp = temp.getNext();
						i += 1;
					}
				}
			}
		}
	}

	/**
	 * Remueve un nodo según la posición de la lista
	 * @param index Integer
	 */
	public void remove(int index) {
		if (index == 0) {
			first = first.getNext();
			length -= 1;
		} else {
			SimpleNode<T> prev = first;
			SimpleNode<T> temp = first;

			int i = 0;
			while (index < getLength()) {
				if (i == index) {
					prev.setNext(temp.getNext());
					this.length -= 1;
				} else if (i < index) {
					prev = temp;
					temp = temp.getNext();
					i += 1;
					continue;
				}
				break;
			}
		}
	}

	/**
	 * Remueve un nodo según la igualdad con el nodo ingresado
	 * @param nodo SimpleNode
	 * @return True / False
	 */
	public boolean remove(SimpleNode<T> nodo) {
		SimpleNode<T> prev = first;
		SimpleNode<T> temp = first;
		for (int i = 0; i < length; i++) {
			if (temp == nodo) {
				prev.setNext(temp.getNext());
				this.length -= 1;
			} else {
				prev = temp;
				temp = temp.getNext();
				i += 1;
			}
		}
		return false;
	}

	/**
	 * Reueve un nodo según la igualdad de su dato
	 * @param dato Dato
	 */
	public void remove(T dato) {
		if (first.getDato() == dato) {
			first = first.getNext();
			this.length -= 1;

		} else {
			SimpleNode<T> temp = first;
			SimpleNode<T> prev = first;
			for (int i = 0; i < length; i++) {
				if (temp.getDato() == dato) {
					prev.setNext(temp.getNext());
					this.length -= 1;
					break;
				} else {
					prev = temp;
					temp = temp.getNext();
				}
			}
		}
	}

	/**
	 * Verifica si la lista está vacía
	 * @return True / False
	 */
	public boolean isEmpty() {
		return this.first == null;

	}

	/**
	 * Retorna largo de la lista
	 * @return Integer
	 */
	public int getLength() {
		return length;
	}

	/**
	 * Borra nodos de la lista
	 */
	public void erase() {
		this.first = null;
		this.length = 0;
	}

	/**
	 * Retorna dato según el índice ingresado
	 * @param index Integer
	 * @return Dato
	 */
	public T find(int index) {
		SimpleNode<T> temp = first;
		for (int i = 0; i <= index; i++) {
			if (i == index) {
				return temp.getDato();
			}
			temp = temp.getNext();
		}
		return null;
	}

	/**
	 * Retorna primer nodo de la lista
	 * @return SimpleNode
	 */
	public SimpleNode<T> getFirst() {
		return first;
	}
}
