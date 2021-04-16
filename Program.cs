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
            

            Console.Read();

        }

        public void MostrarEquipamentos()
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (!(list[i] == null))
                {
                    Console.WriteLine($"Equipamento Número {i + 1}");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Nome do Equipamento: {list[i].Nome}");
                    Console.WriteLine($"Preço do Equipamento: {list[i].Preco}");
                    Console.WriteLine($"Data do Equipamento: {list[i].Data}");
                    Console.WriteLine($"Fabricante do Equipamento: {list[i].Fabricante}");
                    Console.WriteLine($"Número Série do Equipamento: {list[i].Serie}");
                    Console.WriteLine($"ID do Equipamento: {list[i].Id}");
                }
                else return;
                Console.WriteLine("------------------------------------");
            }
        }
        public bool VerificarExistenciaEquipamento(string nome, string numeroSerie)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Nome == nome && list[i].Serie == Convert.ToInt32(numeroSerie))
                {
                    return true;
                }
            }
            return false;
        }

        public Equipamento BuscarEquipamento(string nome, string numeroSerie)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Nome == nome && list[i].Serie == Convert.ToInt32( numeroSerie))
                {
                    return list[i];
                }
            }
            return null;
        }

        public void EditarEquipamento(Equipamento equipamentOriginal)
        {

            Console.WriteLine("Insira o Novo Nome: ");
            equipamentOriginal.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Novo Preço do Equipamento: ");
            equipamentOriginal.Preco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o Novo Nº série: : ");
            equipamentOriginal.Serie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a Nova Data de fabricação: ");
            equipamentOriginal.Data = Console.ReadLine();

            Console.WriteLine("Insira o Novo Fabricante: ");
            equipamentOriginal.Fabricante = Console.ReadLine();


        }
        public void AdicionarEquipamento(Equipamento equipamento)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == null)
                {
                    list[i] = equipamento;
                    return;
                }
            }
        }
        public void RemoverEquipamento(string nome)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Nome == nome)
                {
                    list[i] = null;
                    return;
                }
            }
        }
        public void TexteAdicionarEquipamento()
        {
            Equipamento x = new Equipamento(10, "leonardo", 2, "10/10/2021", "veronica");
            x.Id = new Random().Next(0,10000);
            AdicionarEquipamento(x);
        }
        public void CriarEquipamento()
        {
            Equipamento equipamento = new Equipamento();
            //pegando dados
            Console.WriteLine("Insira o Nome: ");
            equipamento.Nome = Console.ReadLine();

            Console.WriteLine("Insira o Preço do Equipamento: ");
            equipamento.Preco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o Nº série: : ");
            equipamento.Serie = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a Data de fabricação: ");
            equipamento.Data = Console.ReadLine();

            Console.WriteLine("Insira o Fabricante: ");
            equipamento.Fabricante = Console.ReadLine();
            //Criando um Id
            equipamento.Id = new Random().Next(0,10000);
            //adicionando
            AdicionarEquipamento(equipamento);
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
