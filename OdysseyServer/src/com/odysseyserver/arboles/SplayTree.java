package com.odysseyserver.arboles;

/**
 * An implementation of splay trees.
 * <p>
 * Uses the element type's "natural ordering" to compare elements.
 * <p>
 * The code is optimised for clarity rather than efficiency.
 */

public class SplayTree<String extends Comparable<String>, Value> {

	private SplayNode root; // root of the BST

	// BST helper node data type
	private class SplayNode {
		private String key; // key
		private SplayNode left, right; // left and right subtrees

		public SplayNode(String key) {
			this.key = key;
		}
	}

	public boolean contains(String key) {
		return get(key) != null;
	}
	
	public void preorder(SplayNode r) {
		if (r != null) {
			System.out.println(r.key);
			preorder(r.left);
			preorder(r.right);
		}
	}
	
	public SplayNode getRoot() {
		return this.root;
	}

	// return value associated with the given key
	// if no such value, return null
	public String get(String key) {
		root = splay(root, key);
		int cmp = key.compareTo(root.key);
		if (cmp == 0) {
			return key;
		}
		else {
			return null;
		}
	}

	/***************************************************************************
	 * Splay tree insertion.
	 ***************************************************************************/
	public void put(String key) {
		// splay key to root
		if (root == null) {
			root = new SplayNode(key);
			return;
		}

		root = splay(root, key);

		int cmp = key.compareTo(root.key);

		// Insert new node at root
		if (cmp < 0) {
			SplayNode n = new SplayNode(key);
			n.left = root.left;
			n.right = root;
			root.left = null;
			root = n;
		}

		// Insert new node at root
		else if (cmp > 0) {
			SplayNode n = new SplayNode(key);
			n.right = root.right;
			n.left = root;
			root.right = null;
			root = n;
		}

		// It was a duplicate key. Simply replace the value
		else {
			root.key = key;
		}

	}

	/***************************************************************************
	 * Splay tree deletion.
	 ***************************************************************************/
	/*
	 * This splays the key, then does a slightly modified Hibbard deletion on the
	 * root (if it is the node to be deleted; if it is not, the key was not in the
	 * tree). The modification is that rather than swapping the root (call it node
	 * A) with its successor, it's successor (call it Node B) is moved to the root
	 * position by splaying for the deletion key in A's right subtree. Finally, A's
	 * right child is made the new root's right child.
	 */
	public void remove(String key) {
		if (root == null)
			return; // empty tree

		root = splay(root, key);

		int cmp = key.compareTo(root.key);

		if (cmp == 0) {
			if (root.left == null) {
				root = root.right;
			} else {
				SplayNode x = root.right;
				root = root.left;
				splay(root, key);
				root.right = x;
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

		int cmp1 = key.compareTo(h.key);

		if (cmp1 < 0) {
			// key not in tree, so we're done
			if (h.left == null) {
				return h;
			}
			int cmp2 = key.compareTo(h.left.key);
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

			int cmp2 = key.compareTo(h.right.key);
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

	// right rotate
	private SplayNode rotateRight(SplayNode h) {
		SplayNode x = h.left;
		h.left = x.right;
		x.right = h;
		return x;
	}

	// left rotate
	private SplayNode rotateLeft(SplayNode h) {
		SplayNode x = h.right;
		h.right = x.left;
		x.left = h;
		return x;
	}

}
