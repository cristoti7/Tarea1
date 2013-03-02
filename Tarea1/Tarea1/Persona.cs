using System;
using System.Collections;
namespace Tarea1
{
	public class Persona
	{
		private string nombre;
		private string telefono;
		private string direccionDeFacebook; 
		private string domicilio;
		public Persona ()
		{
			Console.WriteLine (" Dame tu nombre ");
			this.nombre = Console.ReadLine ();
			Console.WriteLine (" Dame tu telefono ");
			this.telefono = Console.ReadLine ();
			Console.WriteLine (" Dame tu direccion de facebook ");
			this.direccionDeFacebook = Console.ReadLine ();
			Console.WriteLine (" Dame tu domicilio ");
			this.domicilio = Console.ReadLine ();

			Console.WriteLine ("");

			Console.WriteLine (" ficha persona:");

			Console.WriteLine (this.nombre);
			Console.WriteLine (this.telefono);
			Console.WriteLine (this.direccionDeFacebook);
			Console.WriteLine (this.domicilio);
		
		}







	}
}

