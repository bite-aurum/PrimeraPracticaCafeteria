using PracticaCafeteria;

namespace PrimeraPracticaCafeteria
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Creación de la lista 
			List<Bebida> pedido = new List<Bebida>();

			//lista
			pedido.Add(new BebidaCaliente("Cafe de olla", "Grande", 90.5f, 45.00));
			pedido.Add(new BebidaFria("Refresco", "Mediano", 5, 60.00));
			pedido.Add(new BebidaCaliente("Chocolate", "Chico", 85.0f, 35.00));
			pedido.Add(new BebidaFria("Agua", "Grande", 3, 30.00));
			pedido.Add(new BebidaCaliente("Te", "Mediano", 92.0f, 55.00));

			//llamar a metodo para aplicar descuento
			foreach (Bebida bebida in pedido)
			{
				bebida.AplicarDescuento(10);
			}

			//  foreach
			Console.WriteLine("TICKET DE BARRA\n");

			foreach (Bebida bebida in pedido)
			{
				// Invocamos el metodo Preparar() 
				Console.WriteLine(bebida.Preparar());

				// Regla de negocio
				if (bebida is BebidaCaliente caliente && caliente.temperatura > 88)
				{
					Console.WriteLine("ADVERTENCIA: bebida caliente ");
				}

				Console.WriteLine();
			}

			//
			//calcular el costo total del pedido
			double total = 0;
			foreach (Bebida bebida in pedido)
			{
				total =total + bebida.Precio;
			}

			Console.WriteLine("Total del pedido: " + total);
		}
	}
}
