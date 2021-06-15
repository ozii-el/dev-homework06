using System;

namespace dev_homework06{

    public class Figura{
        public int NumeroDeLados {get;set;}
        public int MetrosPorLado { get; set; }

        public Figura(int lados, int medida)
        {
            NumeroDeLados = lados;
            MetrosPorLado = medida;
        }

        public int ObtenerPerimetro(){
            return NumeroDeLados * MetrosPorLado;
        }

        public void ImprimirPerimetro(){

            int perimetro = ObtenerPerimetro();    
            Console.WriteLine( $"La figura tiene {NumeroDeLados} lados, cada lado mide { MetrosPorLado } metros y su perimetro es de: { perimetro }");

        }

    }


}