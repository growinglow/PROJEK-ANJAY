using PROJEK_ANJAY.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEK_ANJAY.View
{
    public partial class V_StatusTransaksi : Form
    {
        private LaporanController laporanController;
        private bool isInitializing = true;
        public V_StatusTransaksi()
        {
            InitializeComponent();
            laporanController = new LaporanController();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
