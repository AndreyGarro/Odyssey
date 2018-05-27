package com.odysseyserver.arboles;

public class NodeB {
	 
	int numChildren; // number of children
	Entry[] children; // the array of children
	
	// create a node with k children
	public NodeB(int k, int M) {
		numChildren = k;
		children = new Entry[M];
	}

// internal nodes: only use key and next
// external nodes: only use key and value
public class Entry<T> {
	T key;
	NodeB next; // helper field to iterate over array entries

	public Entry(T key, NodeB next) {
		this.key = key;
		this.next = next;
	}
}
}