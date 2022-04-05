using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace projeto8
{
    class Funcionario
    {

        public int Id { get; set; }

        public double Salario { get; set; }

        public string Nome { get; set; }

        public Funcionario(int id, double salario, string nome)
        {
            Id = id;
            Salario = salario;
            Nome = nome;
        }

        public void AumentoDeSalario(Double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }


        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
