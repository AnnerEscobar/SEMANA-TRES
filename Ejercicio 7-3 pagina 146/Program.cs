using System;

namespace Ejercicio_7_3_pagina_146
{
    class Program
    {
        static void Main(string[] args)
        }
           public class Agenda
        {
            //DEclaramos las variables
            private Contacto[] lista_contactos;
            private int num_contactos;

            //Metodo constructor
            public Agenda()
            {
                lista_contactos = new Contacto[100];
                num_contactos = 0;
            }
            //Metodo para a;adir un nuevo contacto a la agenda
            //Entrada: nombre y telefono del contacto
            //salida: void
            //Nota: se permiten contactos repetidos

            public void AnadirContacto(string nombre, int telefono)
            {
                Contacto C = new Contacto(nombre, telefono);
                lista_contactos[num_contactos] = C;
                num_contactos++;
            }
        }
        }
}
