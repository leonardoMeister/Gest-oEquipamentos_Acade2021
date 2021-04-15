using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoEquipamentos_Acade2021
{
    class Equipamento
    {
        private float preco;
        private string nome;
        private int serie;
        private string data;
        private string fabricante;
        private int id;

        public float Preco { get => preco; set => preco = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Serie { get => serie; set => serie = value; }
        public string Data { get => data; set => data = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public int Id { get => id; set => id = value; }

        public Equipamento(float preco, string nome, int serie, string data, string fabricante)
        {
            this.Preco = preco;
            this.Nome = nome;
            this.Serie = serie;
            this.Data = data;
            this.Fabricante = fabricante;
        }
      
    }
}
