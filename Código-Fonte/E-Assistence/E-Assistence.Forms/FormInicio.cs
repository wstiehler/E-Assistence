using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using E_Assistence.Data.Context;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Assistence.Forms
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            MySql coon = new MySql(Properties.Settings.Default.connectionDataBase);
        }
    }
}
