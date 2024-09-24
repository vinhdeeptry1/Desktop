using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab04_2212493
{
    public partial class Form1 : Form
    {
        ArrayList DSSV = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDSSV.SelectedItems.Count > 0)
            {
                ListViewItem lvitem = lvDSSV.SelectedItems[0];

                mtxtMSSV.Text = lvitem.SubItems[0].Text;
                txtHoTen.Text = lvitem.SubItems[1].Text;
                if (lvitem.SubItems[2].Text=="Nam")
                    rdNam.Checked = true;
                else rdNu.Checked = true;
                dtpNgaySinh.Value = Convert.ToDateTime(lvitem.SubItems[3].Text);
                cboLop.Text = lvitem.SubItems[4].Text;
                txtEmail.Text = lvitem.SubItems[5].Text;
                txtDiaChi.Text = lvitem.SubItems[6].Text;
                txtHinh.Text = lvitem.SubItems[8].Text;
                pbHinh.Image = Image.FromFile(lvitem.SubItems[8].Text);
            }
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            if(o.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = o.FileName;
                pbHinh.Image = Image.FromFile(o.FileName);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            pbHinh.Image = null;
            this.mtxtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.txtEmail.Text = "";
            this.txtDiaChi.Text = "";
            this.txtHinh.Text = "";
            this.dtpNgaySinh.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.cboLop.Text = null;
            this.mtxtSDT.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mssv = mtxtMSSV.Text;
            string ht = txtHoTen.Text;
            bool phai = rdNam.Checked;
            DateTime ns = dtpNgaySinh.Value;
            string lop = cboLop.Text;
            string sdt = mtxtSDT.Text;
            string email = txtEmail.Text;
            string dc = txtDiaChi.Text;
            string hinh = txtHinh.Text;

            bool svTonTai = false;

            foreach (SinhVien sv in DSSV)
            {
                if(sv.MSSV == mssv)
                {
                    sv.HoTen = ht;
                    sv.Phai = phai;
                    sv.NgaySinh = ns;
                    sv.Lop = lop;
                    sv.SDT = sdt;
                    sv.Email = email;
                    sv.DiaChi = dc;
                    sv.Hinh = hinh;
                    svTonTai=true;
                    break;
                }
            }
            if (!svTonTai)
            {
                SinhVien svm = new SinhVien(mssv, ht, phai, ns, lop, sdt, email, dc, hinh);
                DSSV.Add(svm);
            }

            UpdateDSSV();

            mtxtMSSV.Clear();
            txtHoTen.Clear();
            rdNam.Checked = true;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            cboLop.Text = null;
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtHinh.Clear();
            pbHinh.Image = null;
        }
        private void UpdateDSSV()
        {
            lvDSSV.Items.Clear();

            foreach(SinhVien sv in DSSV)
            {
                ListViewItem item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoTen);
                item.SubItems.Add(sv.Phai ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh.ToString());
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SDT.ToString());
                item.SubItems.Add(sv.Email);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.Hinh);
                lvDSSV.Items.Add(item);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lvDSSV.SelectedItems.Count > 0)
            {
                lvDSSV.Items.RemoveAt(lvDSSV.SelectedItems[0].Index);
            }
        }
    }
}
