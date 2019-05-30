using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QLChuyenXe
{
    
    public partial class FormMain : MetroForm
    {
        LichKhoiHanh lkh;
        LichTrinh lt;
        NhanVien nv;
        Schedule sch;
        TraCuu tc;
        Xe x;
          
        public FormMain()
        {
            InitializeComponent();
        }

      

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(nv))
            {
                nv.BringToFront();
            }
            else
            {
                nv = new NhanVien();
                panel1.Controls.Add(nv);
                nv.BringToFront();
            }
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(x))
            {
                x.BringToFront();
            }
            else
            {
                x = new Xe();
                panel1.Controls.Add(x);
                x.BringToFront();
            }
        }

        private void btnDatCho_Click(object sender, EventArgs e)
        {
            if(panel1.Controls.Contains(sch))
            {
                sch.BringToFront();
            }
            else
            {

                sch = new Schedule();
                panel1.Controls.Add(sch);
                sch.BringToFront();
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(tc))
            {
                tc.BringToFront();
            }
            else
            {

                tc = new TraCuu();
                panel1.Controls.Add(tc);
                tc.BringToFront();
            }
        }

        private void btnSapKhoiHanh_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(lkh))
            {
                lkh.BringToFront();
            }
            else
            {

                lkh = new LichKhoiHanh();
                panel1.Controls.Add(lkh);
                lkh.BringToFront();
            }

        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(lt))
            {
                lt.BringToFront();
            }
            else
            {

                lt = new LichTrinh();
                panel1.Controls.Add(lt);
                lt.BringToFront();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            sch = new Schedule();
            panel1.Controls.Add(sch);
            sch.BringToFront();
        }
    }

    
}

