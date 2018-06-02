using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiteAurora.Models
{
    public class MelhorJogada
    {
        ValoresDoDado valorDoDado = new ValoresDoDado();
        CategoriaAurora categoriaAurora = new CategoriaAurora();
        CategoriaUns categoriaUns = new CategoriaUns();
        CategoriaDois categoriaDois = new CategoriaDois();
        CategoriaTres categoriaTres = new CategoriaTres();
        CategoriaQuatro categoriaQuatro = new CategoriaQuatro();
        CategoriaCinco categoriaCinco = new CategoriaCinco();
        CategoriaSeis categoriaSeis = new CategoriaSeis();
        CategoriaPar categoriaPar = new CategoriaPar();
        CategoriaDoisPares categoriaDoisPares = new CategoriaDoisPares();
        CategoriaTrio categoriaTrio = new CategoriaTrio();
        CategoriaQuadra categoriaQuadra = new CategoriaQuadra();
        CategoriaFullHouse categoriaFullHouse = new CategoriaFullHouse();
        CategoriaSequenciaMaior categoriaSequenciaMaior = new CategoriaSequenciaMaior();
        CategoriaSequenciaMenor categoriaSequenciaMenor = new CategoriaSequenciaMenor();

        public int pontosTotal { get; set; }                     

        public string MostrarMelhorJogada(ValoresDoDado valoresDoDado)
        {
            int[] pontos = new int[]
            {
                categoriaAurora.calcularPontos(valorDoDado),
                categoriaUns.calcularPontos(valorDoDado),
                categoriaDois.calcularPontos(valorDoDado),
                categoriaTres.calcularPontos(valorDoDado),
                categoriaQuatro.calcularPontos(valorDoDado),
                categoriaCinco.calcularPontos(valorDoDado),
                categoriaSeis.calcularPontos(valorDoDado),
                categoriaPar.calcularPontos(valorDoDado),
                categoriaDoisPares.calcularPontos(valorDoDado, categoriaPar.calcularPontos(valorDoDado)),
                categoriaTrio.calcularPontos(valorDoDado),
                categoriaQuadra.calcularPontos(valorDoDado),
                categoriaFullHouse.calcularPontos(valorDoDado),
                categoriaSequenciaMaior.calcularPontos(valorDoDado),
                categoriaSequenciaMenor.calcularPontos(valorDoDado)
            };            

            Array.Sort(pontos);                     

            pontosTotal = pontos[13];

            if (pontos[13] == categoriaAurora.calcularPontos(valorDoDado))
            {
                return "Aurora";
            }

            else if (pontos[13] == categoriaFullHouse.calcularPontos(valorDoDado))
            {
                return "Full House";
            }

            else if (pontos[13] == categoriaSequenciaMaior.calcularPontos(valorDoDado))
            {
                return "Sequência maior";
            }

            else if (pontos[13] == categoriaSequenciaMenor.calcularPontos(valorDoDado))
            {
                return "Sequência menor";
            }

            else if (pontos[13] == categoriaQuadra.calcularPontos(valorDoDado))
            {
                return "quadra";
            }

            else if (pontos[13] == categoriaTrio.calcularPontos(valorDoDado))
            {
                return "trio";
            }

            else if (pontos[13] == categoriaDoisPares.calcularPontos(valorDoDado, categoriaPar.calcularPontos(valorDoDado)))
            {
                return "dois pares";
            }

            else if (pontos[13] == categoriaPar.calcularPontos(valorDoDado))
            {
                return "par";
            }

            else if (pontos[13] == categoriaSeis.calcularPontos(valorDoDado))
            {
                return "seis";
            }

            else if (pontos[13] == categoriaCinco.calcularPontos(valorDoDado))
            {
                return "cinco";
            }

            else if (pontos[13] == categoriaQuatro.calcularPontos(valorDoDado))
            {
                return "quatro";
            }

            else if (pontos[13] == categoriaTres.calcularPontos(valorDoDado))
            {
                return "três";
            }

            else if (pontos[13] == categoriaDois.calcularPontos(valorDoDado))
            {
                return "dois";
            }

            else if (pontos[13] == categoriaUns.calcularPontos(valorDoDado))
            {
                return "uns";
            }
            return null;
        }
    }
}