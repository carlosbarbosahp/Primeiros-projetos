using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Projeto3

{
    class Funcionario
    {

        public string Nome;
        public double SalarioBruto;
        public double imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString() // Entender a ligação desse metodo com o programa
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
