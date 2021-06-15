using System;

namespace dev_homework06
{

public class Animal {
        public string Nombre { get; set; }
        public int Edad {get; set;}
        public int MetrosRecorridos {set; get;}

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }


        public Animal(string nombre, int edad, int metrosRecorridos){
            this.Nombre = nombre;
            this.Edad = edad;
            this.MetrosRecorridos = metrosRecorridos;
        }


        public void Correr(int metros){
            MetrosRecorridos = MetrosRecorridos + metros;
            Console.WriteLine (Nombre +  " Corrió " + metros + " metros");
        }

        public void Caminar(int metros){
            MetrosRecorridos += metros;
            Console.WriteLine ($"{Nombre} Caminó {metros} metros.");
        }

        public string ObtenerMetrosRecorridos (){
            return $"{Nombre} recorrió {MetrosRecorridos} metros";
        }


    }
}