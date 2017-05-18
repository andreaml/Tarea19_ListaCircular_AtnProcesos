using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea19_ListasCirculares_AtnProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarCiclos_Click(object sender, EventArgs e)
        {
            Procesador miProcesador = new Procesador();
            miProcesador.iniciarCiclos();
            txtReporteCiclos.Text = "Procesos formados: " + miProcesador.procesosFormados().ToString() + Environment.NewLine;
            txtReporteCiclos.Text += "Procesos atendidos en totalidad: " + miProcesador.procesosAtendidosEnTotalidad().ToString() + Environment.NewLine;
            txtReporteCiclos.Text += "Procesos pendientes: " + miProcesador.procesosPendientes().ToString() + Environment.NewLine;
            txtReporteCiclos.Text += "Ciclos pendientes: " + miProcesador.ciclosPendientes() + Environment.NewLine;
            txtReporteCiclos.Text += "Ciclos vacia: " + miProcesador.ciclosVacia() + Environment.NewLine;
        }
    }
}
