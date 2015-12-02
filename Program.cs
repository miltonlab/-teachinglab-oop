using System;

namespace OOP
{
	using Modelo;
	class MainClass
	{
		public static void Main (string[] args)
		{
			Docente angel = new Docente ();
			angel.cedula = "11111111";
			angel.nombres = "Angel Bermeo";
			Console.WriteLine ("testing...");
			Console.WriteLine ("Objetos:  ", angel);
		}
	}
}

namespace Modelo {
	class Docente {
		public string cedula {
			get { return cedula; }
			set { cedula = value; }
		} 

		public string nombres {
			get { return nombres; }
			set { nombres = value; }
		} 

		public override string ToString(){
			return this.nombres;
		}
	}

}