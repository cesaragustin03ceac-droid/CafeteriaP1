using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTICA_1_CAFETERIA
{
    internal class Bebida
    {
        
        
            private string nombre;
            private string tamano;
            private float precio;

            public Bebida(string nombre, string tamano, float precio)
            {
                this.nombre = nombre;
                this.tamano = tamano;
                this.precio = precio;
            }

            public void Preparar()
            {
                Console.WriteLine("Preparando un: " + nombre + " |Tamaño: " + tamano);
            }

            public void Descuento(float porcentaje)
            {
                float descuento = precio * (porcentaje / 100f);
                precio = precio - descuento;
            }

            public void MostrarDescripcion()
            {
                Console.WriteLine("Esto es un" + nombre + "de tamaño " + tamano + " con un precio de " + precio);
            }

        
    }
}
