using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoEquipamentos_Acade2021
{
    class Chamados
    {
        private string titulo;
        private string descricao;
        private Equipamento equipamento;
        private string dataAbertura;
        private DateTime dateTime;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string DataAbertura { get => dataAbertura; set => dataAbertura = value; }
        public Equipamento Equipamento { get => equipamento; set => equipamento = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }

        public Chamados()
        {
            this.titulo = "";
            this.Descricao = "";
            this.DataAbertura = "";
        }
    }
}
