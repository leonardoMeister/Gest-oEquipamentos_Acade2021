using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoEquipamentos_Acade2021
{
    class Program
    {
        Equipamento[] list = new Equipamento[10];
        public Program()
        {
            Equipamento x = new Equipamento(10,"asd", 2, "10/10/2021", "leonardo");
            list[0] = x;
            Console.Read();

        }

        public void AdicionarEquipamento(Equipamento equipamento)
        {

        }

        public void CriarEquipamento()
        {
            Equipamento equipamento = new Equipamento();
            Console.WriteLine("Insira o Nome: ");
            equipamento.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Preço do Equipamento: ");
            equipamento.Preco = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Insira o Nº série: : ");
            equipamento.Serie =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Insira a Data de fabricação: ");
            equipamento.Data = Console.ReadLine();

            Console.WriteLine("Insira o Fabricante: ");
            equipamento.Fabricante = Console.ReadLine();

            AdicionarEquipamento(equipamento);
        }










        static void Main(string[] args)
        {
            new Program();
        }
    }
}
