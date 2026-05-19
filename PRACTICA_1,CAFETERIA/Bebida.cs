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

            public string Preparar()
            {
                return("Preparando un: " + nombre + " |Tamaño: " + tamano);
            }

            public void Descuento(float porcentaje)
            {
                float descuento = precio * (porcentaje / 100f);
                precio = precio - descuento;
            }

            public string MostrarDescripcion()
            {
                return("Esto es un" + nombre + "de tamaño " + tamano + " con un precio de " + precio);
            }

        
    }
}
