using System;
using System.Collections;
namespace Tarea1
{
	public class Persona
	{
		public string nombre;
		private string numeroDeTelefono;
		private string direccionDeFacebook; 
		private string domicilio;
		public Persona ()
		{
		
		
		}
		public void obtenerDatosDePersona(){

			Console.WriteLine (" Welcome Please enter the following information:\n");
			Console.WriteLine ("\n please give me your name:\n");
			nombre = Console.ReadLine ();
			Console.WriteLine ("\n Please give me your phone number:\n");
			numeroDeTelefono = Console.ReadLine ();
			Console.WriteLine ("\n Please give me your address facebook :\n");
			direccionDeFacebook = Console.ReadLine ();
			Console.WriteLine ("\n Please give me your address:\n");
			domicilio = Console.ReadLine ();


		}
		public void mostrarDatosDePersona(){
			Console.WriteLine (" ficha persona:");
			Console.WriteLine (" \n\n");
			Console.WriteLine (" your name is: \n ");
			Console.WriteLine (nombre);
			Console.WriteLine ("\n your phone number is: \n ");
			Console.WriteLine (numeroDeTelefono);
			Console.WriteLine ("\n your address facebook is: \n");
			Console.WriteLine (direccionDeFacebook);
			Console.WriteLine ("\n your address is: \n");
			Console.WriteLine (domicilio);
			Console.WriteLine (" \n\n");
		}






	}
}



	}
}

