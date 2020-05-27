using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double peso, altura;
        private int idade;

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("o nome deve ser devidamente preenchido.");
                }
            }
            get { return this.nome; }
        }
        public double Peso
        {
            set
            {
                if (value >= 0.00)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("o peso deve ser positivo.");
                }
            }
            get { return this.peso; }
        }
        public double Altura
        {
            set
            {
                if (value >= 0.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("a altura deve ser positiva.");
                }
            }
            get { return this.altura; }
        }
        public int Idade
        {
            set
            {
                if (value >= 0)
                {
                    this.idade = value;
                }
                else
                {
                    throw new Exception("A idade deve ser inteira e positiva.");
                }
            }
            get { return this.idade; }
        }
        public string ImprimeDados()
        {
            return "Seus Dados: \n\nNome: " + this.nome + 
                   "\nIdade:" + this.idade;
        }
        public double CalcIMC()
        {
            return this.peso / (this.altura * this.altura);
        }
    }
}
