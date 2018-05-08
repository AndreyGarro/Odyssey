package com.odysseyserver.listas;

/**
 * Nodo Simple que almacena un dato y tiene una única referencia
 * @author jorte
 *
 * @param <T> Tipo de dato que contiene el nodo
 */
public class SimpleNode<T> {
	private SimpleNode<T> next;
	private T dato;

	
	public SimpleNode(T dato) {
		this.dato = dato;
	}

	/**
	 * Retorna siguiente referencia del nodo
	 * @return SimpleNode
	 */
	public SimpleNode<T> getNext() {
		return this.next;
	}

	/**
	 * Retorna dato del nodo
	 * @return Dato
	 */
	public T getDato() {
		return this.dato;
	}

	/**
	 * COnfigura el dato del nodo
	 * @param dato Dato
	 */
	public void setDato(T dato) {
		this.dato = dato;
	}

	/**
	 * Configura referencia siguiente del nodo
	 * @param nodo SimpleNode
	 */
	public void setNext(SimpleNode<T> nodo) {
		this.next = nodo;
	}
}
