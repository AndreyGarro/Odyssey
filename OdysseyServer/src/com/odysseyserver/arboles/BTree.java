package com.odysseyserver.arboles;



public class BTree<T extends Comparable<T>>  {
    // max children per B-tree node = M-1
    // (must be even and greater than 2)
    private static final int M = 4;

    private Node root;       // root of the B-tree
    private int height;      // height of the B-tree
    private int n;           // number of key-value pairs in the B-tree

    
    private static final class Node {
        private int m;                             // number of children
        private Entry[] children = new Entry[M];   // the array of children
        // create a node with k children
        private Node(int k) {
            m = k;
        }
    }

    // internal nodes: only use key and next
    // external nodes: only use key and value
    private static class Entry {
        private Comparable key;
        private final Object val;
        private Node next;     // helper field to iterate over array entries
        public Entry(Comparable key, Object val, Node next) {
            this.key  = key;
            this.val  = val;
            this.next = next;
        }
    }

    /**
     * Initializes an empty B-tree.
     */
    public BTree() {
        root = new Node(0);
    }
 
    /**
     * Returns true if this symbol table is empty.
     * @return {@code true} if this symbol table is empty; {@code false} otherwise
     */
    public boolean isEmpty() {
        return size() == 0;
    }

    /**
     * Returns the number of key-value pairs in this symbol table.
     * @return the number of key-value pairs in this symbol table
     */
    public int size() {
        return n;
    }

    /**
     * Returns the height of this B-tree (for debugging).
     *
     * @return the height of this B-tree
     */
    public int height() {
        return height;
    }


    /**
     * Returns the value associated with the given key.
     *
     * @param  key the key
     * @return the value associated with the given key if the key is in the symbol table
     *         and {@code null} if the key is not in the symbol table
     * @throws IllegalArgumentException if {@code key} is {@code null}
     */
    public T get(T key) {
        if (key == null) throw new IllegalArgumentException("argument to get() is null");
        return search(root, key, height);
    }

    private T search(Node x, T key, int ht) {
        Entry[] children = x.children;

        // external node
        if (ht == 0) {
            for (int j = 0; j < x.m; j++) {
                if (eq(key, children[j].key)) return (T) children[j].val;
            }
        }

        // internal node
        else {
            for (int j = 0; j < x.m; j++) {
                if (j+1 == x.m || less(key, children[j+1].key))
                    return search(children[j].next, key, ht-1);
            }
        }
        return null;
    }


    /**
     * Inserts the key-value pair into the symbol table, overwriting the old value
     * with the new value if the key is already in the symbol table.
     * If the value is {@code null}, this effectively deletes the key from the symbol table.
     *
     * @param  key the key
     * @param  val the value
     * @throws IllegalArgumentException if {@code key} is {@code null}
     */
    public void put(T key) {
        if (key == null) throw new IllegalArgumentException("argument key to put() is null");
        Node u = insert(root, key, height); 
        n++;
        if (u == null) return;

        // need to split root
        Node t = new Node(2);
        t.children[0] = new Entry(root.children[0].key, null, root);
        t.children[1] = new Entry(u.children[0].key, null, u);
        root = t;
        height++;
    }

    private Node insert(Node nuevo,T key, int ht) {
        int j;
        Entry t = new Entry(key, key, null);

        // external node
        if (ht == 0) {
            for (j = 0; j < nuevo.m; j++) {
                if (less(key, nuevo.children[j].key)) break;
            }
        }
        // internal node
        else {
            for (j = 0; j < nuevo.m; j++) {
                if ((j+1 == nuevo.m) || less(key, nuevo.children[j+1].key)) {
                    Node u = insert(nuevo.children[j++].next, key, ht-1);
                    if (u == null) return null;
                    t.key = u.children[0].key;
                    t.next = u;
                    break;
                }
            }
        }
        for (int i = nuevo.m; i > j; i--)
            nuevo.children[i] = nuevo.children[i-1];
        nuevo.children[j] = t;
        nuevo.m++;
        if (nuevo.m < M) return null;
        else         return split(nuevo);
    }

    // split node in half
    private Node split(Node h) {
        Node t = new Node(M/2);
        h.m = M/2;
        for (int j = 0; j < M/2; j++)
            t.children[j] = h.children[M/2+j]; 
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

    private String toString(Node h, int ht, String indent) {
        StringBuilder s = new StringBuilder();
        Entry[] children = h.children;

        if (ht == 0) {
            for (int j = 0; j < h.m; j++) {
                s.append(indent + children[j].key + " " + children[j].val + "\n");
            }
        }
        else {
            for (int j = 0; j < h.m; j++) {
                if (j > 0) s.append(indent + "(" + children[j].key + ")\n");
                s.append(toString(children[j].next, ht-1, indent + "     "));
            }
        }
        return s.toString();
    }


    // comparison functions - make Comparable instead of Key to avoid casts
    private boolean less(Comparable k1, Comparable k2) {
        return k1.compareTo(k2) < 0;
    }

    private boolean eq(Comparable k1, Comparable k2) {
        return k1.compareTo(k2) == 0;
    }


    /**
     * Unit tests the {@code BTree} data type.
     *
     * @param args the command-line arguments
     */
    public static void main(String[] args) {
    	
        BTree<String> st = new BTree<String>();

        st.put("www.cs.princeton.edu");
        st.put("www.cs.princeton.edu");
        st.put("www.princeton.edu");
        st.put("www.yale.edu");
        st.put("www.simpsons.com");
        st.put("www.apple.com");
        st.put("www.amazon.com");
        st.put("www.ebay.com");
        st.put("www.cnn.com");
        st.put("www.google.com");
        st.put("www.nytimes.com");
        st.put("www.microsoft.com");
        st.put("www.dell.com");
        st.put("www.slashdot.org");
        st.put("www.espn.com");
        st.put("www.weather.com");
        st.put("www.yahoo.com");
        System.out.println(st.toString());

    }

}

