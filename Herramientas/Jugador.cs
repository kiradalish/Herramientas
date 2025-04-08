using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public class Jugador
    {
        public int Puntaje { get; private set; } = 0;

        public void SumarPuntos(int puntos)
        {
            Puntaje += puntos;
        }

        public void RestarPuntos(int puntos)
        {
            Puntaje = Math.Max(0, Puntaje - puntos);
        }
    }
}
