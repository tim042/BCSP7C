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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }
        classConnectDatabase ccd = new classConnectDatabase();
        private void frmCategory_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            ShowData();
            DGV.Columns[0].HeaderText = "ລະຫັດປະເພດສິນຄ້າ";
            DGV.Columns[1].HeaderText = "ຊື້ປະເພດສິນຄ້າ";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 200;
        }
        void ShowData()
        {
            ccd.da = new SqlDataAdapter("Select * from tbCategory", ccd.conn);
            ccd.da.Fill(ccd.ds);
            ccd.ds.Tables[0].Clear();
            ccd.da.Fill(ccd.ds);
            DGV.DataSource = ccd.ds.Tables[0];
            DGV.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("Insert into tbCategory values(@CategoryID,@categoryName)", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("categoryID", txtCategoryID.Text);
            ccd.cmd.Parameters.AddWithValue("categoryName", txtCategoryName.Text);
            ccd.cmd.ExecuteNonQuery();
            ShowData();
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtCategoryID.Focus();
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            txtCategoryID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtCategoryName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("update tbCategory Set CategoryName=@categoryName where CategoryID=@categoryID ", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("categoryID", txtCategoryID.Text);
            ccd.cmd.Parameters.AddWithValue("categoryName", txtCategoryName.Text);
            ccd.cmd.ExecuteNonQuery();
            ShowData();
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtCategoryID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("delete from tbCategory where CategoryID=@categoryID ", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("@categoryID", txtCategoryID.Text);
            ccd.cmd.ExecuteNonQuery();
            ShowData();
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            txtCategoryID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
