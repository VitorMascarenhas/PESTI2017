using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaRPHD.Web.ViewModels
{
    public class DataViewModel
    {
        public int PedidosAbertos { get; set; }

        public int PedidosPendentes { get; set; }

        public int PedidosFechados { get; set; }

        public int TarefasAbertos { get; set; }

        public int TarefasPendentes { get; set; }

        public int TarefasFechadas { get; set; }
    }
}