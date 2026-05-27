using System;

namespace PracticaCafeteria
{
	class Bebida
	{
		//atributos privados
		protected string nombre;
		protected string tamaño;
		protected double precio;

		//propiedad encapsulada para acceder al precio
		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public Bebida(string nombre, string tamaño, double precio)
		{
			this.nombre = nombre;
			this.tamaño = tamaño;
			this.precio = precio;
		}


		// metodo para preparar la bebida
		public virtual string Preparar()
		{
			return "Preparando un " + nombre + " de tamaño " + tamaño + "...";
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