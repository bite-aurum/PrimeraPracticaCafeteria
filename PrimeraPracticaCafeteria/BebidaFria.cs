using System;
using System.Collections.Generic;
using System.Text;
using PracticaCafeteria;

namespace PrimeraPracticaCafeteria
{
	internal class BebidaFria : Bebida
	{
		private int CantidadHielo;
		public int cantidadHielo
		{
			get { return CantidadHielo; }
			set { CantidadHielo = value; }
		}
		//constructor heredamos
		public BebidaFria(string _nombre, string _tamaño, int _cantidadHielo, double _precio) : base(_nombre, _tamaño, _precio)
		{
			CantidadHielo = _cantidadHielo;
		}
		//metodo sobreescrito
		public override string Preparar()
		{
			return "Estamos preparando un : " + nombre + " Frio Con " + CantidadHielo + " cubos de hielo tamaño : " + tamaño;
		}
	}
}
