using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteAurora.Models
{
    public abstract class Categoria
    {        
        public string Nome { get; set; }
        public int Pontos { get; set; }

        protected void ordenarDado(ValoresDoDado valoresDoDado)
        {
            Array.Sort(valoresDoDado.ValorDados);
            Array.Sort(valoresDoDado.ValorDadosFrequencia);            
        }

        protected void eliminarRepeticoes(ValoresDoDado valoresDoDado)
        {
            valoresDoDado.ValorDadosFrequencia = valoresDoDado.ValorDadosFrequencia.Distinct().ToArray();
        }
    }
}