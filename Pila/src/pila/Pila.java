/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pila;

import java.util.LinkedList;

/**
 *
 * @author miguel.anchico
 */
public class Pila <T extends Base>{

    private LinkedList<T> elems;
    
    public Pila(){
        elems = new LinkedList<>();
    }

    public void apilar(T elem){
        elems.addFirst(elem);
        
    }
    
    public T desapilar(){
        T aux = elems.removeFirst();
        
        return aux; 
    }

    
    public boolean estaVacia(){
        return elems.isEmpty();
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder("[");
        for(T e : elems){
            sb.append(" ").append(e.toString()).append("\n");
        }
        
        sb.append("]");
        
        return sb.toString();
    }
    
}
