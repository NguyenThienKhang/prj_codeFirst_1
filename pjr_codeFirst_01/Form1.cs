using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjr_codeFirst_01
{
    public partial class Form1 : Form
    {
        QLPHIMDBContext db = new QLPHIMDBContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cau1b();
        }

        private void Cau1a()
        {
            var kq = from ph in db.phims
                     where ph.SoTap > 10
                     select ph;
            dgvKq.DataSource = kq.ToList();
        }
        private void Cau1b()
        {
            var kq = db.phims.Where(p => p.SoTap > 10);
            
            dgvKq.DataSource = kq.ToList();
        }
    }
}
