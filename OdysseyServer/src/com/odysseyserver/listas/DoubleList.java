package com.odysseyserver.listas;
/**
 * Lista doblemente enlazada
 * @author jorte
 *
 * @param <T> Tipo de dato de la lista
 */
public class DoubleList<T> {
	private DoubleNode<T> first;
	private int length;

	public DoubleList() {

	}

	/**
	 * Retorna un nodo según un índica
	 * @param index Indice a verificar 
	 * @return DoubleNode
	 */
	public DoubleNode<T> getNode(int index) {
		int i = 0;
		DoubleNode<T> temp = first;
		while (index < length) {
			if (i == index) {
				return temp;
			} else if (i < index){
				temp = temp.getNext();
				i++;
			}
			break;
			
		}
		return null;
	}

	/**
	 * Añade un nuevo nodo al final de la lista
	 * @param nodo DoubleNode
	 */
	public void add(DoubleNode<T> nodo) {
		if (isEmpty()) {
			addFirst(nodo);
		} else {
			DoubleNode<T> temp = first;
			for (int i = 0; i < length; i++) {
				if (temp.getNext() == null) {
					nodo.setPrevious(temp);
					temp.setNext(nodo);
					this.length += 1;
					break;
				}
				temp = temp.getNext();
			}
		}
	}

	/**
	 * Añade un nuevo nodo en el indice indicado
	 * @param index Indice (int)
	 * @param nodo DoubleNode
	 */
	public void add(int index, DoubleNode<T> nodo) {
		if (index == 0) {
			if (isEmpty()) {
				addFirst(nodo);
			} else {
				nodo.setNext(first);
				first.setPrevious(nodo);
				first = nodo;
				length += 1;
			}
		} else {
			if (index >= length) {
				throw new IndexOutOfBoundsException("Index out of range");
			} else {
				DoubleNode<T> prev = first;
				DoubleNode<T> temp = first;
				int i = 0;
				while (i <= index) {
					if (i == index) {
						nodo.setNext(temp);
						nodo.setPrevious(prev);
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
	 * Añade nodo al principio de la lista
	 * @param nodo Double Node
	 */
	private void addFirst(DoubleNode<T> nodo) {
		first = nodo;
		length += 1;
	}

	/**
	 * Verifica si la lista está vacía
	 * @return True / False
	 */
	public boolean isEmpty() {
		return first == null;
	}

	/**
	 * Remueve un Nodo de la lista
	 * @param nodo DoubleNode
	 */
	public void remove(DoubleNode<T> nodo) {
		if (nodo == first) {
			first = first.getNext();
			first.setPrevious(null);
			length -= 1;
		} else {
			DoubleNode<T> prev = first;
			DoubleNode<T> temp = first;
			for (int i = 0; i < length; i++) {
				if (nodo == temp) {
					prev.setNext(temp.getNext());
					temp.getNext().setNext(prev);
					length -= 1;
					break;
				}
				prev = temp;
				temp = temp.getNext();
			}
		}
	}

	/**
	 * Remueve un nodo según un índice
	 * @param index Int
	 */
	public void remove(int index) {
		if (index == 0) {
			first = first.getNext();
			first.setPrevious(null);
			length -= 1;
		} else {
			DoubleNode<T> prev = first;
			DoubleNode<T> temp = first;
			int i = 0;
			while (index < length) {
				if (i == index) {
					prev.setNext(temp.getNext());
					temp.getNext().setPrevious(prev);
					length -= 1;
					break;
				} else {
					prev = temp;
					temp = temp.getNext();
					i += 1;
				}
			}
		}
	}
	
	/**
	 * Remplaza un nodo en una posición de la lista
	 * @param nodo Double Node
	 * @param index Integer
	 */
	public void replace(DoubleNode<T> nodo, int index) {
		if (index == 0) {
			if (isEmpty()) {
				addFirst(nodo);
			} else {
				nodo.setNext(first.getNext());
				first.getNext().setPrevious(nodo);
				first = nodo;
			}
		} else {
			if (index >= length) {
				throw new IndexOutOfBoundsException("Index out of range");
			} else {
				DoubleNode<T> prev = first;
				DoubleNode<T> temp = first;
				int i = 0;
				while (i <= index) {
					if (i == index && i < length - 1) {
						prev.setNext(nodo);
						nodo.setPrevious(prev);
						nodo.setNext(temp.getNext());
						temp.getNext().setPrevious(nodo);
						break;
					} else if (i == index){
						nodo.setNext(temp.getNext());
						nodo.setPrevious(prev);
						prev.setNext(nodo);
						break;
					} else if (i < index) {
						prev = temp;
						temp = temp.getNext();
						i += 1;
					} else {
						break;
					}
				}
			}
		}
	}

	/**
	 * Vacea la lista
	 */
	public void erase() {
		this.first = null;
		this.length = 0;
	}

	/**
	 * Retorna largo de la lista
	 * @return Integer
 	 */
	public int getLength() {
		return this.length;
	}

	/**
	 * Retorna datos según el índice ingresado
	 * @param index Integer
	 * @return Dato
	 */
	public T find(int index) {
		DoubleNode<T> temp = first;
		if (index < length) {
			for (int i = 0; i <= index; i++) {
				if (i == index) {
					return temp.getDato();
				}
				temp = temp.getNext();
			}
		}
		return null;
	}

	/**
	 * Retorna primer nodo de la lista
	 * @return DoubleNode
	 */
	public DoubleNode<T> getFirst() {
		return first;
	}

	/**
	 * Remueve nodo de la lista según dato ingresado
	 * @param dato Dato
	 */
	public void remove(T dato) {
		if (dato == first.getDato()) {
			first = first.getNext();
			first.setPrevious(null);
			length -= 1;
		} else {
			DoubleNode<T> prev = first;
			DoubleNode<T> temp = first;
			for (int i = 0; i < length; i++) {
				if (dato == temp.getDato() && i < length - 1) {
					temp.getNext().setPrevious(prev);
					prev.setNext(temp.getNext());
					length -= 1;
					break;
				} else if (dato == temp.getDato()) {
					prev.setNext(temp.getNext());
					length -= 1;
					break;
				}
				prev = temp;
				temp = temp.getNext();
			}
		}
	}
}
