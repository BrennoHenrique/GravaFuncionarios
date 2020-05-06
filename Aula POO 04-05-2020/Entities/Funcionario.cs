using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_POO_04_05_2020.Entities
{
    class Funcionario
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double SalarioBruto { get; private set; }
        public double Desconto { get; private set; }
        public double Adicional { get; private set; }
        public double SalarioLiquido { get; private set; }

        public Funcionario(int id, string nome, string cpf, double salarioBruto, 
                           double desconto, double adicional)
        {
            this.ID = id;
            this.Nome = nome;
            this.CPF = cpf;
            this.SalarioBruto = salarioBruto;
            this.Desconto = desconto;
            this.Adicional = adicional;
            this.SalarioLiquido = CalculaSalarioLiquido();
        }
           

        ~Funcionario()
        { Console.WriteLine($"Funcionáio {this.Nome} foi apagado!"); }

        private double CalculaSalarioLiquido()
        { return this.SalarioBruto - this.Desconto + this.Adicional; }
    }
}
