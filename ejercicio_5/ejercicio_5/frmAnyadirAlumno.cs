using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_5
{
    public partial class frmAnyadirAlumno : Form
    {

        public ListaPersonas personas;
        public frmAnyadirAlumno(ListaPersonas personas)
        {
            InitializeComponent();

            this.personas = personas;
        }

        private void btnAnyadirNotas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnyadirAlumno_Click(object sender, EventArgs e)
        {

        }
    }
}
