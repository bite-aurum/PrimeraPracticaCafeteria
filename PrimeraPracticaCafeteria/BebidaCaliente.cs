using System;
using System.Collections.Generic;
using System.Text;
using PracticaCafeteria;

namespace PrimeraPracticaCafeteria
{
	internal class BebidaCaliente:Bebida
	{
		private float Temperatura;
		public float temperatura
		{
			get { return Temperatura; }
			set { Temperatura = value; }
		}
		//constructor herdamos
		public BebidaCaliente(string nombre, string tamaño, float _temperatura, double precio) : base(nombre, tamaño, precio)
		{
			Temperatura=_temperatura;
		}
		//metodo sobreescrito
		public override string Preparar()
		{
			return "Preparando un " + nombre + " caliente de tamaño " + tamaño + " a una temperatura de " + Temperatura + " grados";
		}
	}
}
