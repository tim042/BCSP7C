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
    public partial class frmUnit : Form
    {
        public frmUnit()
        {
            InitializeComponent();
        }
        classConnectDatabase ccd = new classConnectDatabase();
        private void frmUnit_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            ShowData();
            DGV.Columns[0].HeaderText = "ລະຫັດຫົວໜ່ວຍ";
            DGV.Columns[1].HeaderText = "ຊື່ຫົວໜ່ວຍ";
            DGV.Columns[0].Width = 150;
            DGV.Columns[1].Width = 150;
            DGV.DefaultCellStyle.BackColor = Color.Azure;
            DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.Bisque;
        }
        void ShowData()
        {
            ccd.da = new SqlDataAdapter("select * from tbUnit", ccd.conn);
            ccd.da.Fill(ccd.ds, "unit");
            ccd.ds.Tables["unit"].Clear();
            ccd.da.Fill(ccd.ds, "unit");
            DGV.DataSource = ccd.ds.Tables["unit"];
            DGV.Refresh();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUnitID.Text=="")
                {
                    MessageBox.Show("ກະລຸນາປ້ອນລະຫັດຫົວໜ່ວຍກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitID.Focus();
                }
                else if(txtUnitName.Text=="")
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຊື່ຫົວໜ່ວຍກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUnitName.Focus();
                }
                else
                {
                    bool ch;
                    int num;
                    ch = int.TryParse(txtUnitID.Text, out num);
                    if(ch==false)
                    {
                        MessageBox.Show("ກະລຸນາປ້ອນລະຫັດຫົວໜ່ວຍເປັນຕົວເລກເທົ່ານັ້ນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnitID.Clear();
                        txtUnitID.Focus();
                    }
                    else
                    {
                       if(MessageBox.Show("ເຈົ້າຕ້ອງການບັນທຶກຂໍ້ມູນຫຼືບໍ່?","ຄຳຢືນຢັນ",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            ccd.cmd = new SqlCommand("insert into tbUnit values(@unitID,@unitName)", ccd.conn);
                            ccd.cmd.Parameters.Add("unitID", SqlDbType.Int).Value = txtUnitID.Text;
                            ccd.cmd.Parameters.Add("unitName", SqlDbType.NVarChar).Value = txtUnitName.Text;
                            ccd.cmd.ExecuteNonQuery();
                            ShowData();
                            AllClear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
           
        }
        void AllClear()
        {
            txtUnitID.Clear();
            txtUnitName.Clear();
            txtUnitID.Focus();
        }

        private void DGV_Click(object sender, EventArgs e)
        {
            txtUnitID.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[0].Value.ToString();
            txtUnitName.Text = DGV.Rows[DGV.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("update tbUnit Set UnitName=@unitName where unitID=@unitID", ccd.conn);
            ccd.cmd.Parameters.Add("unitID", SqlDbType.Int).Value = txtUnitID.Text;
            ccd.cmd.Parameters.Add("unitName", SqlDbType.NVarChar).Value = txtUnitName.Text;
            ccd.cmd.ExecuteNonQuery();
            ShowData();
            AllClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ccd.cmd = new SqlCommand("delete from tbUnit where unitID=@unitID", ccd.conn);
            ccd.cmd.Parameters.Add("unitID", SqlDbType.Int).Value = txtUnitID.Text;
            ccd.cmd.ExecuteNonQuery();
            ShowData();
            AllClear();
        }
    }
}
