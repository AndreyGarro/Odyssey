package com.odysseyserver.arboles;

public class Prueba {

	public static void main(String[] args) {
		
//		ArbolAVL arbol = new ArbolAVL();
//		arbol.insert("L", 456);
//		arbol.insert("j", 200);
//		arbol.insert("q", 5);
//		arbol.insert("t", 9);
//		arbol.insert("u", 5);
//		arbol.insert("a", 59);
//		arbol.insert("b", 67);
//		arbol.insert("h", 8500);
//		arbol.insert("y", 54);
//		arbol.insert("p", 65);
//		arbol.insert("r", 8500);
//		arbol.insert("f", 8);
//		arbol.preOrden(arbol.root);
//		System.out.println();
//		arbol.delete("Hola",456);
//		arbol.delete("Pepe", 8500);
//		arbol.delete("Tata", 7);
//		arbol.delete("Bum Bum", 67);
//		arbol.delete("iikgf", 7);
//		arbol.rightRight(arbol.root.getRight(),arbol.root.getRight().getRight());
//		arbol.rightRight(arbol.root.getRight());
//		arbol.preOrden(arbol.root);
		
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
//		arbol1.preOrder();
//		System.out.println(" ");
//		arbol1.delete("T");
//		arbol1.preOrder();
//		System.out.println(" ");
//		arbol1.delete("K");
//		arbol1.preOrder();
//		System.out.println(" ");
//		arbol1.delete("T");
//		arbol1.preOrder();
		
//		SplayTree<String, String> arbol = new SplayTree<>();
//		
//		arbol.put("Hola", "como está");
//		arbol.put("para siempre", "como nunca");
//		
//		System.out.println();
		
		SplayTree arbol2 = new SplayTree<>();
		arbol2.put("h");
		arbol2.put("f");
		arbol2.put("t");
		arbol2.put("g");
		arbol2.put("y");
		arbol2.put("u");
		arbol2.put("r");
		arbol2.put("a");
		arbol2.put("d");
		arbol2.preorder(arbol2.getRoot());
		System.out.println("");
		arbol2.remove("t");
		arbol2.preorder(arbol2.getRoot());
		
		
	}
}
