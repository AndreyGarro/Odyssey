package com.odysseyserver.arboles;

public class Prueba {

	public static void main(String[] args) {
		
//		AVLTree arbol1 = new AVLTree();
//		arbol1.insert("H", 58);
//		arbol1.insert("P", 98);
//		arbol1.insert("G", 56);
//		arbol1.insert("B", 7);
//		arbol1.insert("T", 3);
//		arbol1.insert("U", 3);
//		arbol1.insert("F", 3);
//		arbol1.insert("Z", 45);
//		arbol1.insert("J", 3);
//		arbol1.insert("K", 3);
//		arbol1.insert("L", 3);
//		arbol1.insert("W", 4);
//		arbol1.insert("X", 1);
//		arbol1.insert("Y", 21);
//		
//		arbol1.insert("H", 87);
//		arbol1.insert("P", 254);
//		arbol1.insert("G", 7998);
//		arbol1.insert("B", 74);
//		arbol1.insert("T", 412);
//		arbol1.insert("U", 7);
//		arbol1.insert("F", 654);
//		arbol1.insert("Z", 258);
//		arbol1.insert("J", 956);
//		arbol1.insert("K", 41);
//		arbol1.insert("L", 36);
//		arbol1.insert("W", 96);
//		arbol1.insert("X", 14);
//		arbol1.insert("Y", 25641);
//		
//		arbol1.delete("L", 36);
//		arbol1.delete("W", 96);
//		arbol1.delete("X", 1);
//		arbol1.delete("Y", 25641);
//		arbol1.preOrder();
//		System.out.println(" ");
//		arbol1.delete("T", 8);
//		arbol1.preOrder();
//		System.out.println(" ");
//		arbol1.delete("P", 98);
//		arbol1.preOrder();
//		arbol1.delete("L",3 );
//		System.out.println(" ");
//		arbol1.preOrder();
//		System.out.println();

		
		
		SplayTree arbol2 = new SplayTree<>();
		arbol2.insert("h",78);
		arbol2.insert("f",56);
		arbol2.insert("t",12);
		arbol2.insert("g",85);
		arbol2.insert("y",45);
		arbol2.insert("u", 96);
		arbol2.insert("r", 25);
		arbol2.insert("a", 36);
		arbol2.insert("d", 325);
		arbol2.insert("a", 9636);
		arbol2.preorder(arbol2.getRoot());
		System.out.println("");
		arbol2.remove("t", 12);
		arbol2.remove("u", 54);
		arbol2.remove("a", 36 );
		arbol2.preorder(arbol2.getRoot());
		
		
	}
}
