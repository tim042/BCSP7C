using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BCSP7C
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        classConnectDatabase ccd = new classConnectDatabase();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        string username, author;
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                pictureBox2.Image= Properties.Resources.open1;
            }
            else
            {               
                txtPassword.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.closeeyes;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຊື່ຜູ້ໃຊ້ກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
            }
            else if(txtPassword.Text=="")
            {
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດຜ່ານກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else
            {
                ccd.cmd = new SqlCommand("select * from tbUser where username=@username and userPassword=@password", ccd.conn);
                ccd.cmd.Parameters.AddWithValue("username", txtUsername.Text);
                ccd.cmd.Parameters.AddWithValue("password", txtPassword.Text);
                dr = ccd.cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dt.Load(dr);
                    username = txtUsername.Text;
                    author = dt.Rows[0].ItemArray[2].ToString();
                    dr.Close();
                    frmMain frm = new frmMain(username,author);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    //dr.Close();
                    MessageBox.Show("ຊື່ຜູ້ໃຊ້ ແລະ ລະຫັດຜ່ານບໍຖືກຕ້ອງ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }
    }
}
