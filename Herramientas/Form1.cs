using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TriviaPro;

namespace TriviaApp
{
    public partial class Form1 : Form
    {
        private List<Pregunta> preguntas = new List<Pregunta>();
        private Pregunta preguntaActual;
        private TemporizadorTrivia temporizador;

        public Form1()
        {
            InitializeComponent();
            temporizador = new TemporizadorTrivia();
            temporizador.TiempoTerminado += Temporizador_TiempoTerminado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPreguntas();
            MostrarNuevaPregunta();
        }

        private void CargarPreguntas()
        {
            preguntas.Add(new Pregunta
            {
                Texto = "¿Cuál es la capital de Francia?",
                Opciones = new List<string> { "París", "Madrid", "Roma", "Londres" },
                RespuestaCorrecta = "París",
                Nivel = "Fácil"
            });

            preguntas.Add(new Pregunta
            {
                Texto = "¿Cuánto es 9 x 8?",
                Opciones = new List<string> { "72", "81", "64", "56" },
                RespuestaCorrecta = "72",
                Nivel = "Medio"
            });

            preguntas.Add(new Pregunta
            {
                Texto = "¿Quién escribió 'Cien años de soledad'?",
                Opciones = new List<string> { "Gabriel García Márquez", "Mario Vargas Llosa", "Pablo Neruda", "Julio Cortázar" },
                RespuestaCorrecta = "Gabriel García Márquez",
                Nivel = "Difícil"
            });

            // Agrega más si deseas
        }

        private void MostrarNuevaPregunta()
        {
            if (preguntas.Count == 0)
            {
                MessageBox.Show("No hay más preguntas.");
                return;
            }

            preguntaActual = preguntas[0];
            preguntas.RemoveAt(0);

            labelPregunta.Text = preguntaActual.Texto;

            radioButton1.Text = preguntaActual.Opciones[0];
            radioButton2.Text = preguntaActual.Opciones[1];
            radioButton3.Text = preguntaActual.Opciones[2];
            radioButton4.Text = preguntaActual.Opciones[3];

            LimpiarSeleccion();
            HabilitarOpciones(true);
            buttonResponder.Enabled = true;

            int segundos = 15;
            switch (preguntaActual.Nivel)
            {
                case "Fácil": segundos = 20; break;
                case "Medio": segundos = 15; break;
                case "Difícil": segundos = 10; break;
            }

            temporizador.Iniciar(segundos);
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            temporizador.Detener();
            buttonResponder.Enabled = false;
            HabilitarOpciones(false);

            string seleccion = null;

            if (radioButton1.Checked) seleccion = radioButton1.Text;
            else if (radioButton2.Checked) seleccion = radioButton2.Text;
            else if (radioButton3.Checked) seleccion = radioButton3.Text;
            else if (radioButton4.Checked) seleccion = radioButton4.Text;

            if (seleccion == null)
            {
                MessageBox.Show("Selecciona una opción.");
                return;
            }

            if (seleccion == preguntaActual.RespuestaCorrecta)
            {
                MessageBox.Show("¡Respuesta correcta!");
            }
            else
            {
                MessageBox.Show("Incorrecto. La respuesta correcta era: " + preguntaActual.RespuestaCorrecta);
            }

            MostrarNuevaPregunta();
        }

        private void Temporizador_TiempoTerminado()
        {
            Invoke(new Action(() =>
            {
                MessageBox.Show("¡Tiempo terminado!");
                HabilitarOpciones(false);
                buttonResponder.Enabled = false;
                MostrarNuevaPregunta();
            }));
        }

        private void LimpiarSeleccion()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void HabilitarOpciones(bool habilitar)
        {
            radioButton1.Enabled = habilitar;
            radioButton2.Enabled = habilitar;
            radioButton3.Enabled = habilitar;
            radioButton4.Enabled = habilitar;
        }

        
    }

    public class Pregunta
    {
        public string Texto { get; set; }
        public List<string> Opciones { get; set; }
        public string RespuestaCorrecta { get; set; }
        public string Nivel { get; set; }
    }
}