using System;

namespace dev_homework06
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Hello POO");

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
           

            /* Figura triangulo = new Figura(3,3);
            Figura cuadrado = new Figura(4, 5);
            Figura circulo = new Figura(0, 10);


           triangulo.ImprimirPerimetro();
           cuadrado.ImprimirPerimetro();
           circulo.ImprimirPerimetro();
 */

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


            Console.WriteLine("\n");
            Console.WriteLine("******");
            Console.WriteLine("Tarea 01");
            Console.WriteLine("Clases y metodos");
            Console.WriteLine("\n");

            Console.WriteLine("Bienvenido a Ferrari 🏎️");
            Console.WriteLine("01.-Seleccione que tipo de Modelo quiere customizar: -carro, -van, -race");
            var modelo = Console.ReadLine();
            Console.WriteLine($"Usted a seleccionado {modelo} ");
            Console.WriteLine("02.-Seleccione el tipo de llanta: -carreras, -todo terreno, -plana");
            var llanta = Console.ReadLine();
            Console.WriteLine($"Usted a seleccionado {llanta} ");
            Console.WriteLine("03.-Seleccione el color de la carroceria: -cromo, -plateado, -negro mate");
            var color = Console.ReadLine();
            Console.WriteLine($"Usted a seleccionado {color} ");

            string [] car = new string [8];
            if(modelo == "carro"){
                car[1] = "100";
            }  
            else if( modelo == "van"){
                car[1] = "200";
            }
            else if( modelo == "race"){
                car[1] = "500";
            }

            if(llanta == "carreras"){
                car[2] = "100";
            }  
            else if( llanta == "todo terreno"){
                car[2] = "300";
            }
            else if( llanta == "plana"){
                car[2] = "150";
            }

            if(color == "cromo"){
                car[3] = "100";
            }  
            else if( color == "plateado"){
                car[3] = "110";
            }
            else if( color == "negro mate"){
                car[3] = "200";
            }
            
            
            Console.WriteLine("\n");
            Console.WriteLine("Ticket");
            Console.WriteLine($"Modelo de vehiculo: {modelo} precio: ${car[1]} ");
            Console.WriteLine($"Modelo de llantas del vehiculo: {llanta} precio: ${car[2]} ");
            Console.WriteLine($"Color de vehiculo: {color} precio: ${car[3]} ");
            /* var total = (car[1] + car[2] + car[3]);
            Console.WriteLine($"Total: ${total}"); */
            Console.WriteLine("\n");
            
            

        }
    }

    
}
