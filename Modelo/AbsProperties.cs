using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_tarefas.Modelo
{
    class AbsProperties
    {
        public bool Existe { get; set; }
        public string Mensagem { get; set; }
        public int id { get; set; }
        public string descricao { get; set; }
        public string situacao { get; set; }
        public string categoria { get; set; }
        public TimeSpan horaEstimada { get; set; }
    }
}
