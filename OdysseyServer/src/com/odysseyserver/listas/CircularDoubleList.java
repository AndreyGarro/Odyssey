package com.odysseyserver.listas;

/**
 * Lista Circular Doblemente Enlazada
 * 
 * @author jorte
 *
 * @param <T>
 *            Tipo de dato que contiene la lista
 */
public class CircularDoubleList<T> {

	private DoubleNode<T> first;
	private int length;

	public CircularDoubleList() {
	}

	/**
	 * add First ubica el nodo entrante en la posición 0 de la lista
	 * 
	 * @param nodo
	 *            Nodo con el dato a agregar
	 */
	private void addFirst(DoubleNode<T> nodo) {
		this.first = nodo;
		first.setNext(first);
		first.setPrevious(first);
		this.length += 1;
	}

	/**
	 * Verifica si la lista está vacía
	 * 
	 * @return true o false
	 */
	public boolean isEmpty() {
		return this.first == null;
	}

	/**
	 * Añade un nodo nuevo en la posición final de la lista
	 * 
	 * @param nodo
	 *            Nodo con el dato
	 */
	public void add(DoubleNode<T> nodo) {
		if (isEmpty()) {
			addFirst(nodo);
		} else {
			nodo.setNext(first);
			nodo.setPrevious(first.getPrevious());
			first.getPrevious().setNext(nodo);
			first.setPrevious(nodo);
			this.length += 1;
		}
	}

	/**
	 * Añade un nuevo nodo en la posición indicada
	 * 
	 * @param index
	 *            índice de la lista donde irá el nuevo nodo
	 * @param nodo
	 *            Nodo con el dato a agregar
	 */
	public void add(int index, DoubleNode<T> nodo) {
		if (index == 0) {
			nodo.setNext(first);
			nodo.setPrevious(first.getPrevious());
			first.getPrevious().setPrevious(nodo);
			first.setPrevious(nodo);
			first = nodo;
			this.length += 1;
		} else {
			DoubleNode<T> temp = first;
			for (int i = 0; i < this.length; i++) {
				if (i == index) {
					nodo.setNext(temp);
					nodo.setPrevious(temp.getPrevious());
					temp.getPrevious().setNext(nodo);
					temp.setPrevious(nodo);
					this.length += 1;
					break;
				}
				temp = temp.getNext();
			}
		}
	}

	/**
	 * Remueve un nodo según el dato
	 * 
	 * @param dato
	 *            dato a verificar para eliminar el nodo de la lista
	 */
	public void remove(T dato) {
		if (first.getDato().equals(dato)) {
			remove(0);
		} else {
			DoubleNode<T> temp = first;
			for (int i = 0; i < this.length; i++) {
				if (temp.getDato().equals(dato)) {
					remove(i);
					break;
				}
				temp = temp.getNext();
			}
		}
	}

	/**
	 * Remueve un nodo según la igualdad del nodo ingresado
	 * 
	 * @param nodo
	 *            Nodo a verificar para eliminar en la lista
	 */
	public void remove(DoubleNode<T> nodo) {
		if (nodo == first) {
			remove(0);
		} else {
			DoubleNode<T> temp = first;
			for (int i = 0; i < this.length; i++) {
				if (nodo == temp) {
					remove(i);
					break;
				}
				temp = temp.getNext();
			}
		}
	}

	/**
	 * Remueve nodo de la lista según el indice indicado
	 * 
	 * @param index
	 *            índice de la lista para eliminar el nodo
	 */
	public void remove(int index) {
		if (index == 0) {
			first.getPrevious().setNext(first.getNext());
			first.getNext().setPrevious(first.getPrevious());
			first = first.getNext();
			this.length -= 1;
		} else {
			DoubleNode<T> temp = first;
			for (int i = 0; i < this.length; i++) {
				if (i == index) {
					temp.getNext().setPrevious(temp.getPrevious());
					temp.getPrevious().setNext(temp.getNext());
					this.length -= 1;
					break;
				}
				temp = temp.getNext();
			}
		}
	}

	/**
	 * Remplaza un nodo en la posición indicada segpun un nuevo nodo agregado
	 * 
	 * @param index
	 *            Indice donde se sustituirá el nodo
	 * @param nodo
	 *            Nodo a agregar
	 */
	public void replace(int index, DoubleNode<T> nodo) {
		DoubleNode<T> temp = first;
		for (int i = 0; i < length; i++) {
			if (i == index) {
				nodo.setNext(temp.getNext());
				nodo.setPrevious(temp.getPrevious());
				temp.getPrevious().setNext(nodo);
				temp.getNext().setPrevious(nodo);
				if (i == 0) {
					first = nodo;
				}
				break;
			}
			temp = temp.getNext();
		}
	}

	/**
	 * Retorna un dato según un indice de la lista
	 * 
	 * @param index
	 *            Indice donde se encuentra el dato
	 * @return Dato del nodo
	 */
	public T find(int index) {
		DoubleNode<T> temp = first;
		for (int i = 0; i < length; i++) {
			if (i == index) {
				return temp.getDato();
			}
			temp = temp.getNext();
		}
		return null;
	}

	/**
	 *
	 * @return Largo de la lista
	 */
	public int getLength() {
		return length;
	}

	/**
	 * 
	 * @return Primer nodo de la lista
	 */
	public DoubleNode<T> getFirst() {
		return this.first;

	}

	public void erase() {
		first = null;
	}

}
