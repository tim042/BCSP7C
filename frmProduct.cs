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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        classConnectDatabase ccd = new classConnectDatabase();
        SqlDataReader dr;
        private void frmProduct_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            //load data from tbUnit
            SqlDataAdapter daU = new SqlDataAdapter("select * from tbUnit",ccd.conn);
            DataSet dsU = new DataSet();
            daU.Fill(dsU);
            cbUnit.DataSource = dsU.Tables[0];
            cbUnit.DisplayMember = "unitName";
            cbUnit.ValueMember = "unitID";
            // load data from tbCategory
            SqlDataAdapter daC = new SqlDataAdapter("select * from tbCategory", ccd.conn);
            DataSet dsC = new DataSet();
            daC.Fill(dsC);
            cbCategory.DataSource = dsC.Tables[0];
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            ShowProduct();
            DGV.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            DGV.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            DGV.Columns[2].HeaderText = "ລາຄາ";
            DGV.Columns[3].HeaderText = "ຈຳນວນ";
            DGV.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
            DGV.Columns[5].HeaderText = "ປະເພດສິນຄ້າ";
            DGV.Columns[6].HeaderText = "ເງືອນໄຂການສັ່ງຊື້";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 220;
            DGV.Columns[2].Width = 80;
            DGV.Columns[3].Width = 90;
            DGV.Columns[4].Width = 80;
            DGV.Columns[5].Width = 120;
            DGV.Columns[6].Width = 150;
            // count product
            lbCount.Text = (DGV.RowCount - 1).ToString();

        }
        void ShowProduct()
        {
            //ccd.da = new SqlDataAdapter("select * from View_product", ccd.conn);
            ccd.da = new SqlDataAdapter("SELECT  dbo.tbProduct.productID, dbo.tbProduct.productName, dbo.tbProduct.price, dbo.tbProduct.qty, dbo.tbUnit.unitName, dbo.tbCategory.categoryName, dbo.tbProduct.conditionCheck FROM  dbo.tbCategory INNER JOIN  dbo.tbProduct ON dbo.tbCategory.categoryID = dbo.tbProduct.categoryID INNER JOIN  dbo.tbUnit ON dbo.tbProduct.unitID = dbo.tbUnit.unitID", ccd.conn);
            ccd.da.Fill(ccd.ds);
            ccd.ds.Tables[0].Clear();
            ccd.da.Fill(ccd.ds);
            DGV.DataSource = ccd.ds.Tables[0];
            DGV.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtProductID.Text=="")
            {
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສິນຄ່າກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductID.Focus();
            }
            else if(txtProductName.Text=="")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຊື່ສິນຄ່າກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtProductName.Focus();
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນລາຄາສິນຄ່າກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrice.Focus();
            }
            else if (txtQty.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນສິນຄ່າກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQty.Focus();
            }
            else if (txtConditionCheck.Text == "")
            {
                MessageBox.Show("ກະລຸນາປ້ອນເງື່ອນໄຂສັ່ງຊື້ສິນຄ່າກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConditionCheck.Focus();
            }
            else
            {
                ccd.cmd = new SqlCommand("select * from tbproduct where productID=@productID or productName=@productName", ccd.conn);
                ccd.cmd.Parameters.AddWithValue("productID", txtProductID.Text);
                ccd.cmd.Parameters.AddWithValue("productName", txtProductName.Text);
                dr = ccd.cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Close();
                    MessageBox.Show("ສິນຄ້ານີ້ມີຢູ່ໃນຖານຂໍ້ມຸນແລ້ວ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dr.Close();
                    ccd.cmd = new SqlCommand("insert into tbProduct values(@productID,@productName,@price,@qty,@unitID,@categoryID,@conditionCheck)", ccd.conn);
                    ccd.cmd.Parameters.AddWithValue("productID", txtProductID.Text);
                    ccd.cmd.Parameters.AddWithValue("productName", txtProductName.Text);
                    ccd.cmd.Parameters.AddWithValue("price", txtPrice.Text);
                    ccd.cmd.Parameters.AddWithValue("qty", txtQty.Text);
                    ccd.cmd.Parameters.AddWithValue("unitID", cbUnit.SelectedValue);
                    ccd.cmd.Parameters.AddWithValue("categoryID", cbCategory.SelectedValue);
                    ccd.cmd.Parameters.AddWithValue("conditionCheck", txtConditionCheck.Text);
                    ccd.cmd.ExecuteNonQuery();
                    ShowProduct();
                    AllClear();
                    lbCount.Text = (DGV.RowCount - 1).ToString();
                }
            }


        }
        void AllClear()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear(); 
            txtConditionCheck.Clear();
            txtProductID.Focus();
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            txtProductID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtProductName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
            txtPrice.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[2].Value.ToString();
            txtQty.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[3].Value.ToString();
            cbUnit.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[4].Value.ToString();
            cbCategory.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[5].Value.ToString();
            txtConditionCheck.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("update tbProduct SET productName=@productName,price=@price,qty=@qty,unitID=@unitID,categoryID=@categoryID,conditionCheck=@conditionCheck where productID=@productID", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("productID", txtProductID.Text);
            ccd.cmd.Parameters.AddWithValue("productName", txtProductName.Text);
            ccd.cmd.Parameters.AddWithValue("price", txtPrice.Text);
            ccd.cmd.Parameters.AddWithValue("qty", txtQty.Text);
            ccd.cmd.Parameters.AddWithValue("unitID", cbUnit.SelectedValue);
            ccd.cmd.Parameters.AddWithValue("categoryID", cbCategory.SelectedValue);
            ccd.cmd.Parameters.AddWithValue("conditionCheck", txtConditionCheck.Text);
            ccd.cmd.ExecuteNonQuery();
            ShowProduct();
            AllClear();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("delete from tbProduct where productID=@productID", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("productID", txtProductID.Text);         
            ccd.cmd.ExecuteNonQuery();
            ShowProduct();
            AllClear();
            lbCount.Text = (DGV.RowCount - 1).ToString();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int num;
            bool ch;
            ch = int.TryParse(txtPrice.Text, out num);
            if(ch==false)
            {
                MessageBox.Show("ກະລຸນາປ້ອນລາຄາສິນຄ້າເປັນຕົວເລກ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Clear();
                txtPrice.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ccd.da = new SqlDataAdapter("SELECT  dbo.tbProduct.productID, dbo.tbProduct.productName, dbo.tbProduct.price, dbo.tbProduct.qty, dbo.tbUnit.unitName, dbo.tbCategory.categoryName, dbo.tbProduct.conditionCheck FROM  dbo.tbCategory INNER JOIN  dbo.tbProduct ON dbo.tbCategory.categoryID = dbo.tbProduct.categoryID INNER JOIN  dbo.tbUnit ON dbo.tbProduct.unitID = dbo.tbUnit.unitID where dbo.tbProduct.productID='"+txtSearch.Text+"' OR dbo.tbProduct.productName like N'%"+txtSearch.Text+"%'", ccd.conn);
                ccd.da.Fill(ccd.ds);
                ccd.ds.Tables[0].Clear();
                ccd.da.Fill(ccd.ds);
                DGV.DataSource = ccd.ds.Tables[0];
                DGV.Refresh();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
