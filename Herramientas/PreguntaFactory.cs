using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public static class PreguntaFactory
    {
        public static Pregunta CrearPregunta(string categoria, string nivel, string texto, List<string> opciones, string respuestaCorrecta)
        {
            Pregunta pregunta;

            switch (nivel)
            {
                case "Fácil":
                    pregunta = new PreguntaFacil();
                    break;
                case "Medio":
                    pregunta = new PreguntaMedia();
                    break;
                case "Difícil":
                    pregunta = new PreguntaDificil();
                    break;
                default:
                    throw new ArgumentException("Nivel no válido");
            }

            pregunta.Texto = texto;
            pregunta.Opciones = opciones;
            pregunta.RespuestaCorrecta = respuestaCorrecta;
            pregunta.Categoria = categoria;
            pregunta.Nivel = nivel;

            return pregunta;
        }
    }
}
