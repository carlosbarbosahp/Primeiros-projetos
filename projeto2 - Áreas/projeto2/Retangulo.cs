using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace projeto2
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {

            return Largura * Altura;

        }

        public double Perimetro()
        {

            return (Largura + Altura) * 2.00;

        }

        public  double Diagonal()
        {

            return Math.Sqrt(Largura * Largura + Altura + Altura);

        }


    }
}


