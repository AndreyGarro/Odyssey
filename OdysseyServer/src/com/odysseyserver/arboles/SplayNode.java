package com.odysseyserver.arboles;

public class SplayNode {
	
	private SplayNode left;
	private SplayNode right;
	public String contents;

	/**
	 * Creates a node. Sets all parent/child pointers to null.
	 */
	public SplayNode(String contents) {
		this.contents = contents;
	}
	/**
	 * Sets the left child.
	 *
	 * @param child
	 *            The new left child. Can be null.
	 */
	public void setLeft(SplayNode child) {
		left = child;
	}
	/**
	 * Sets the right child.
	 *
	 * @param child
	 *            The new right child. Can be null.
	 */
	public void setRight(SplayNode child) {
		right = child;
	}
	public static void setValor(String musica) {

	}
	/**
	 * Returns the left child.
	 */
	public SplayNode getleft() {
		return left;
	}
	/**
	 * Returns the right child.
	 */
	public SplayNode getright() {
		return right;
	}
}
