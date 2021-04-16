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
        Chamados[] listChamado = new Chamados[10];
        public Program()
        {
            while (0 == 0)
            {
                string nome;
                string serie;
                string titulo;
                try
                {
                    switch (OperacaoDesejada())
                    {
                        case 1:
                            CriarEquipamento();
                            break;
                        case 2:
                            Console.WriteLine("Informe o Nome do Equipamento para Remover: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Informe o Número de série do Equipamento: ");
                            serie = Console.ReadLine();
                            if (VerificarExistenciaEquipamento(nome, serie))
                            {
                                RemoverEquipamento(nome, serie);
                                Console.WriteLine("Equipamento Removido com sucesso!");
                            }
                            else Console.WriteLine("Equipamento não existente ou não localizado!");
                            break;
                        case 3:
                            MostrarEquipamentos();
                            break;
                        case 4:
                            Console.WriteLine("Informe o Nome do Equipamento para Pesquisar: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Informe o Número de série do Equipamento: ");
                            serie = Console.ReadLine();

                            if (VerificarExistenciaEquipamento(nome, serie))
                            {
                                Equipamento equipamentoSelecionado = BuscarEquipamento(nome, serie);
                                Console.WriteLine("Equipamento Localizado!");
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine($"Nome do Equipamento: {equipamentoSelecionado.Nome}");
                                Console.WriteLine($"Preço do Equipamento: {equipamentoSelecionado.Preco}");
                                Console.WriteLine($"Data do Equipamento: {equipamentoSelecionado.Data}");
                                Console.WriteLine($"Fabricante do Equipamento: {equipamentoSelecionado.Fabricante}");
                                Console.WriteLine($"Número Série do Equipamento: {equipamentoSelecionado.Serie}");
                                Console.WriteLine($"ID do Equipamento: {equipamentoSelecionado.Id}");
                            }
                            else Console.WriteLine("Equipamento não existente ou Não Localizado!");

                            break;
                        case 5:
                            Console.WriteLine("Informe o Nome do Equipamento para Pesquisar: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("Informe o Número de série do Equipamento: ");
                            serie = Console.ReadLine();
                            if (VerificarExistenciaEquipamento(nome, serie))
                            {
                                EditarEquipamento(BuscarEquipamento(nome, serie));
                            }
                            else Console.WriteLine("Equipamento Não existente ou Não Localizado!");
                            break;
                        case 6:
                            CriarChamados();
                            break;
                        case 7:
                            Console.WriteLine("Informe o Titulo do Equipamento para Remover: ");
                            titulo = Console.ReadLine();
                            
                            if (VerificarExistenciaChamado(titulo))
                            {
                                RemoverChamados(titulo);
                                Console.WriteLine("Equipamento Removido com sucesso!");
                            }
                            else Console.WriteLine("Equipamento não existente ou não localizado!");
                            break;
                        case 8:
                            MostrarChamado();
                            break;
                        case 9:
                            Console.WriteLine("Informe o Titulo do chamado para Pesquisar: ");
                            titulo = Console.ReadLine();
                            
                            if (VerificarExistenciaChamado(titulo))
                            {
                                EditarChamado(BuscarChamados(titulo));
                            }
                            else Console.WriteLine("Chamado Não existente ou Não Localizado!");
                            break;
                        default:
                            Console.WriteLine("Valor inválido");
                            break;
                    }
                    Console.WriteLine("Press Entrer to continue!");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }
        }

        public int OperacaoDesejada()
        {
            Console.WriteLine("Selecione e Operação Desejada:\n[1] Adicionar Equipamento\n[2] Remover Equipamento\n" +
                              "[3] Mostrar Equipamentos\n[4] Visualizar um Equipamento\n[5] Editar Equipamento\n" +
                              "[6] Adicionar Chamado\n[7] Remover Chamado\n[8] Mostrar Chamados\n[9] Editar Chamado");
            int aux = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            return aux;
        }
        //-------------------------------------------------------------------------------------------------------------------
        //CHAMADOS

        public void MostrarChamado()
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (!(listChamado[i] == null))
                {
                    Console.WriteLine($"Chamado Número {i + 1}");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Titulo do chamado: {listChamado[i].Titulo}");
                    Console.WriteLine($"Data de abertura do chamado: {listChamado[i].DataAbertura}");
                    Console.WriteLine($"Equipamento do chamado: {listChamado[i].Equipamento.Nome}");
                    Console.WriteLine($"Fabricante do Equipamento: {list[i].Fabricante}");
                    Console.WriteLine($"Descrição do Chamado: {listChamado[i].Descricao}");
                    Console.WriteLine($"Tempo de abertura do chamado: {listChamado[i].DateTime}");
                }
                else return;
                Console.WriteLine("------------------------------------");
            }
        }

        public bool VerificarExistenciaChamado(string titulo)
        {
            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (listChamado[i].Titulo == titulo)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Invalido");
                return false;
            }
        }

        public Chamados BuscarChamados(string titulo)
        {
            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (listChamado[i].Titulo == titulo)
                    {
                        return listChamado[i];
                    }
                }
                return null;
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Invalido");
                return null;
            }
        }

        public void EditarChamado(Chamados chamadosOriginal)
        {
            Console.WriteLine("Insira o Novo Titulo: ");
            chamadosOriginal.Titulo = Console.ReadLine();

            Console.WriteLine("Insira a Nova descrição: ");
            chamadosOriginal.Descricao = Console.ReadLine();
        }

        public void AdicionarChamado(Chamados chamados)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (listChamado[i] == null)
                {
                    listChamado[i] = chamados;
                    return;
                }
            }
        }
        public void RemoverChamados(string titulo)
        {
            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (listChamado[i].Titulo == titulo)
                    {
                        list[i] = null;
                        return;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Invalido");
            }
        }

        public void CriarChamados()
        {
            try
            {
                Chamados chamados = new Chamados();
                Equipamento equipamento;
                string nome, serie;

                //pegando dados
                Console.WriteLine("Insira o Titulo: ");
                chamados.Titulo = Console.ReadLine();
                if (chamados.Titulo.Length < 6)
                {
                    Console.WriteLine("titulo Não contem 6 digitos!");
                    return;
                }

                Console.WriteLine("Insira a decrição do chamado: ");
                chamados.Descricao = Console.ReadLine();

                Console.WriteLine("Insira a data de abertura: ");
                chamados.DataAbertura = Console.ReadLine();
                chamados.DateTime = Convert.ToDateTime(chamados.DataAbertura);

                Console.WriteLine("Insira o Nome do Equipamento da Chamada: ");
                nome = Console.ReadLine();

                Console.WriteLine("Insira o Número de Série do Equipamento da Chamada: ");
                serie = Console.ReadLine();

                if (VerificarExistenciaEquipamento(nome, serie))
                {
                    equipamento = BuscarEquipamento(nome, serie);
                }
                else
                {
                    Console.WriteLine("Equipamento inválido!");
                    return;
                }
                chamados.Equipamento = equipamento;

                AdicionarChamado(chamados);
            }
            catch (Exception)
            {
                Console.WriteLine("Data inválida!");

            }
        }

        //-------------------------------------------------------------------------------------------------------------------
        //EQUIPAMENTOS
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
            try
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
            catch (Exception)
            {
                Console.WriteLine("Valor Invalido");
                return false;
            }
        }

        public Equipamento BuscarEquipamento(string nome, string numeroSerie)
        {
            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Nome == nome && list[i].Serie == Convert.ToInt32(numeroSerie))
                    {
                        return list[i];
                    }
                }
                return null;
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Invalido");
                return null;
            }
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

        public void RemoverEquipamento(string nome, string numeroSerie)
        {
            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i].Nome == nome && list[i].Serie == Convert.ToInt32(numeroSerie))
                    {
                        list[i] = null;
                        return;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Valor Invalido");
            }
        }

        public void TexteAdicionarEquipamento()
        {
            Equipamento x = new Equipamento(10, "leonardo", 2, "10/10/2021", "veronica");
            x.Id = new Random().Next(0, 10000);
            AdicionarEquipamento(x);
        }
        public void CriarEquipamento()
        {
            try
            {
                Equipamento equipamento = new Equipamento();
                //pegando dados
                Console.WriteLine("Insira o Nome: ");
                equipamento.Nome = Console.ReadLine();
                if (equipamento.Nome.Length < 6)
                {
                    Console.WriteLine("Nome Não contem 6 digitos!");
                    return;
                }

                Console.WriteLine("Insira o Preço do Equipamento: ");
                equipamento.Preco = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o Nº série: ");
                equipamento.Serie = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira a Data de fabricação: ");
                equipamento.Data = Console.ReadLine();
                equipamento.DataTime = Convert.ToDateTime(equipamento.Data);

                Console.WriteLine("Insira o Fabricante: ");
                equipamento.Fabricante = Console.ReadLine();
                //Criando um Id
                equipamento.Id = new Random().Next(0, 10000);
                //adicionando
                AdicionarEquipamento(equipamento);
            }
            catch (Exception)
            {
                Console.WriteLine("Data inválida!");

            }
        }

        static void Main(string[] args)
        {
            new Program();
        }
    }
}
