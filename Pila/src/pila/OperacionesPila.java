/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pila;

/**
 *
 * @author miguel.anchico
 */
public class OperacionesPila {

    public static < T extends Base> Pila<T> duplicarP(Pila<T> PilaOriginal) {
        Pila<T> PilaAux = new Pila<>();
        Pila<T> PilaDuplicada = new Pila<>();
        T aux1;
        T aux2;

        while (!PilaOriginal.estaVacia()) {
            PilaAux.apilar(PilaOriginal.desapilar());
        }

        while (!PilaAux.estaVacia()) {
            aux1 = PilaAux.desapilar();
            aux2 = (T) aux1.copy();

            PilaOriginal.apilar(aux1);
            PilaDuplicada.apilar(aux2);

        }

        return PilaDuplicada;
    }

    public static < T extends Base> Pila<T> invertirP(Pila<T> PilaOriginal) {
        Pila<T> PilaInvertida = new Pila<>();
        Pila<T> PilaDuplicada = duplicarP(PilaOriginal);

        while (!PilaDuplicada.estaVacia()) {
            PilaInvertida.apilar(PilaDuplicada.desapilar());
        }

        return PilaInvertida;

    }
}
