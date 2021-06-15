using System;

namespace dev_homework06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello POO");
/*
            Animal perro = new Animal("Firulais",4,5);
            
            Animal gato = new Animal("Michu", 3);
         

            perro.Correr(3);
            gato.Correr(2);

            perro.Caminar(5);
            gato.Caminar(6);

            perro.Edad = 7;
            gato.Edad = gato.Edad + 1;

            Console.WriteLine($"{gato.Nombre} tiene {gato.Edad} años");

            Console.WriteLine($"{perro.Nombre} tiene {perro.Edad} años");

            Console.WriteLine(perro.ObtenerMetrosRecorridos());
            Console.WriteLine(gato.ObtenerMetrosRecorridos());

*/
           

            Figura triangulo = new Figura(3,3);
            Figura cuadrado = new Figura(4, 5);
            Figura circulo = new Figura(0, 10);


           triangulo.ImprimirPerimetro();
           cuadrado.ImprimirPerimetro();
           circulo.ImprimirPerimetro();


           //Abstraccion
           //ENCAPSULAMIENTO
           //Herencia
           //Polimorfismo


            /*TAREA --  06 -- FIGURA*/

           //Clase Medios de Transporte
           //- Numero de llantas
           //- Tipo (Aereo,Terrestre,Maritimo)
           //- Color
           //- Marca
           //- Capacidad de carga
           //-Enceder()
           //-Avanzar(10)  -- NO PUEDE AVANZAR SI NO ESTA ENCENDIDO
           //-Apagar() -- NO SE PUEDE APAGAR SI ESTA APAGADO  



        }
    }

    
}
