package com.odysseyserver.listas;

/**
 * Crea un Nodo que almacena datos según el usuario decida
 * Se caracteriza por tener referencias a siguiente y a previo
 * @author jorte
 *
 * @param <T> Tipo de dato del nodo
 */
public class DoubleNode<T> {
	private DoubleNode<T> next;
	private DoubleNode<T> previous;
	private T dato;

	public DoubleNode(T dato) {
		this.dato = dato;
	}

	/**
	 * Retorna siguiente Nodo
	 * @return DoubleNode
	 */
	public DoubleNode<T> getNext() {
		return next;
	}

	public DoubleNode<T> getPrevious() {
		return previous;
	}

	/**
	 * Retorna dato del nodo
	 * @return Dato
	 */
	public T getDato() {
		return dato;
	}

	/**
	 * Configura referencia a siguiente nodo
	 * @param next DoubleNode
	 */
	public void setNext(DoubleNode<T> next) {
		this.next = next;
	}

	/**
	 * Configura referencia a nodo anterior
	 * @param previous DoubleNode Nodo anterior
	 */
	public void setPrevious(DoubleNode<T> previous) {
		this.previous = previous;
	}

	/**
	 * Reconfigura dato del nodo
	 * @param dato T - Dato
	 */
	public void setDato(T dato) {
		this.dato = dato;
	}
}