using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herramientas
{
    public abstract class Pregunta
    {
      
            public string Texto { get; set; }
            public List<string> Opciones { get; set; }
            public string RespuestaCorrecta { get; set; }
            public string Nivel { get; set; }
        public string Categoria { get; internal set; }

        public abstract int ObtenerPuntaje();
        public bool EvaluarRespuesta(string respuestaUsuario)
        {
            return respuestaUsuario == RespuestaCorrecta;
        }
    }
    public class PreguntaFacil : Pregunta
    {
        public override int ObtenerPuntaje() => 5;
    }

    public class PreguntaMedia : Pregunta
    {
        public override int ObtenerPuntaje() => 10;
    }

    public class PreguntaDificil : Pregunta
    {
        public override int ObtenerPuntaje() => 15;
    }
}
