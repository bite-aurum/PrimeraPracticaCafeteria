using System;

namespace PracticaCafeteria
{
	class Bebida
	{
		private string nombre;
		private string tamaño;
		private double precio;

		public Bebida(string nombre, string tamaño, double precio)
		{
			this.nombre = nombre;
			this.tamaño = tamaño;
			this.precio = precio;
		}

		
		public void Preparar()
		{
			Console.WriteLine("Preparando un " + nombre + " tamaño " + tamaño + "...");
		}

		public void AplicarDescuento(double porcentaje)
		{
			double descuento = precio * (porcentaje / 100);
			precio = precio - descuento;
		}

		public void MostrarDescripcion()
		{
			Console.WriteLine("Esto es un " + nombre + " de tamaño " + tamaño +" con un costo de $" + precio);
		}
	}

}