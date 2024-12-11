using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModeloCataTreco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string EstadoConservacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public decimal ValorEstimado { get; set; }
        public string Localizacao { get; set; }
        public DateTime? DataUltimaManutencao { get; set; }
        public string Proprietario { get; set; }
    }
}
