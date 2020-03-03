using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrlenLaboratorium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGazySuche_Click(object sender, EventArgs e)
        {
            CreateForm();
        }
        public void CreateForm()
        {
            gazySuche gazySuche = new gazySuche();
            gazySuche.Show();
        }

        private void btnOdzyskWodoru_Click(object sender, EventArgs e)
        {
            odzyskWodoru odzyskWodoru = new odzyskWodoru();
            odzyskWodoru.Show();
        }
    }
}

