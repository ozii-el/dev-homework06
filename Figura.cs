using System;

namespace dev_homework06{

    public class Figura{
        public int NumeroDeLados {get;set;}
        public int MetrosPorLado { get; set; }

        public bool TieneLados {get;set;}

        public Figura(int lados, int medida)
        {
            NumeroDeLados = lados;
            if(NumeroDeLados>0){
                TieneLados = true;
            }
            else{
                TieneLados = false;
            }
            MetrosPorLado = medida;
        }

        public int ObtenerPerimetro(){
            return NumeroDeLados * MetrosPorLado;
        }

        public void ImprimirPerimetro(){

            if(TieneLados == true){
                //obten el perimetro
                 int perimetro = ObtenerPerimetro();    
            Console.WriteLine( $"La figura tiene {NumeroDeLados} lados, cada lado mide { MetrosPorLado } metros y su perimetro es de: { perimetro }");

            }
            else{
                // NO SE PUEDE OBTENER EL PERIMETRO   
                Console.WriteLine("NO SE PUEDE OBTENER EL PERIMETRO"); 

            }

           
        }

    }


}