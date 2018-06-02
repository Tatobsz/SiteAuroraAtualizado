﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteAurora.Models
{
    public class CategoriaTres: Categoria
    {
        public int calcularPontos(ValoresDoDado valoresDoDado)
        {
            ordenarDado(valoresDoDado);
            Pontos = 0;

            
            foreach (var face in valoresDoDado.ValorDados)
            {
                if (face == 3)
                {
                    Pontos += face;
                }
            }
            return Pontos;
        }
    }
}