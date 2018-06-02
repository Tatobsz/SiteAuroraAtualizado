using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiteAurora.Models
{
    public class Dado
    {
        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [RegularExpression(@"^[0-6]+$",ErrorMessage = "Apenas numeros de 1 e 6")]
        public int[] Faces { get; set; } = new int[6];

        [Required(ErrorMessage = "O campo deve ser preenchido")]
        [RegularExpression(@"^[0-6]+$", ErrorMessage = "Apenas numeros de 1 e 6")]
        public string[] FotoFace { get; set; } = new string[6];

        public Dado()
        {
            Faces[0] = 1;
            Faces[1] = 2;
            Faces[2] = 3;
            Faces[3] = 4;
            Faces[4] = 5;
            Faces[5] = 6;

            FotoFace[0] = "";
            FotoFace[1] = "";
            FotoFace[2] = "";
            FotoFace[3] = "";
            FotoFace[4] = "";
            FotoFace[5] = "";
        }

        public int JogarDados()
        {
            Random random = new Random();
            int aux = random.Next(1, 7);

            switch (aux)
            {
                case 1:
                    return Faces[0];                    
                    
                case 2:
                    return Faces[1];

                case 3:
                    return Faces[2];

                case 4:
                    return Faces[3];
                    
                case 5:
                    return Faces[4];

                case 6:
                    return Faces[5];
            }

            return aux;
        }
    }
}