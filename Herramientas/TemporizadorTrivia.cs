using System;
using System.Windows.Forms;

namespace TriviaPro
{
    public class TemporizadorTrivia
    {
        private Timer temporizador;
        private int tiempoRestante;

        public Action TiempoTerminado { get; internal set; }

        public event Action<int> TiempoActualizado;
        public event Action TiempoFinalizado;

        public TemporizadorTrivia()
        {
            temporizador = new Timer();
            temporizador.Interval = 1000; // 1 segundo
            temporizador.Tick += Temporizador_Tick;
        }

        public void Iniciar(int segundos)
        {
            tiempoRestante = segundos;
            TiempoActualizado?.Invoke(tiempoRestante);
            temporizador.Start();
        }

        public void Detener()
        {
            temporizador.Stop();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            tiempoRestante--;

            if (tiempoRestante <= 0)
            {
                temporizador.Stop();
                TiempoFinalizado?.Invoke();
            }
            else
            {
                TiempoActualizado?.Invoke(tiempoRestante);
            }
        }
    }
}