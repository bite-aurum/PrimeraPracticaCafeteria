using System;

namespace PracticaCafeteria
{
	class Bebida
	{
		//atributos privados
		private string nombre;
		private string tamaño;
		private double precio;

		public Bebida(string nombre, string tamaño, double precio)
		{
			this.nombre = nombre;
			this.tamaño = tamaño;
			this.precio = precio;
		}


		// metodo para preparar la bebida
		public void Preparar()
		{
			Console.WriteLine("Preparando un " + nombre + " tamaño " + tamaño + "...");
		}
		//metodo aplicar descuento	
		public void AplicarDescuento(double porcentaje)
		{
			double descuento = precio * (porcentaje / 100);
			precio = precio - descuento;
		}
		//metodo para mostrar la descripcion de la bebida
		public void MostrarDescripcion()
		{
			Console.WriteLine("Esto es un " + nombre + " de tamaño " + tamaño +" con un costo de $" + precio);
		}
	}

}