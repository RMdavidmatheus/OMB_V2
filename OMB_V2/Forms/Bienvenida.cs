using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_V2.Forms
{
    public partial class Bienvenida : Form
    {
        public Bienvenida()
        {
            InitializeComponent();
        }
        private void Hora_fecha_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            Fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
