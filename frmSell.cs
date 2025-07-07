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
    public partial class frmSell : Form
    {
        public frmSell()
        {
            InitializeComponent();
        }
        classConnectDatabase ccd = new classConnectDatabase();
        string price, total, amount,qty;
        ListViewItem lvi = new ListViewItem();

        private void frmSell_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            timer1.Start();
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtProductName.Enabled = false;
            txtPrice.Enabled = false;
            txtQty.Enabled = false;
            txtTotal.Enabled = false;
            txtAmount.Enabled = false;
            txtChange.Enabled = false;
            cbAuto.Checked = true;
            LV.Columns.Add("ລະຫັດສິນຄ້າ", 150, HorizontalAlignment.Left);
            LV.Columns.Add("ຊື່ສິນຄ້າ", 250, HorizontalAlignment.Left);
            LV.Columns.Add("ລາຄາ", 120, HorizontalAlignment.Center);
            LV.Columns.Add("ຈຳນວນ", 100, HorizontalAlignment.Center);
            LV.Columns.Add("ຫົວໜ່ວຍ", 100, HorizontalAlignment.Center);
            LV.Columns.Add("ລວມເປັນເງິນ", 150, HorizontalAlignment.Right);
            LV.View = View.Details;
            AutoBill();
        }
        void AutoBill()
        {
            SqlDataAdapter daB = new SqlDataAdapter("select Max(billNo) from tbSell", ccd.conn);
            DataSet dsB = new DataSet();
            daB.Fill(dsB);
            dsB.Tables[0].Clear();
            daB.Fill(dsB);
            string billNo;
            if(dsB.Tables[0].Rows[0].ItemArray[0].ToString()=="")
            {
                billNo = "00001";
            }
            else
            {
                billNo = dsB.Tables[0].Rows[0].ItemArray[0].ToString();
                billNo = (int.Parse(billNo) + 1).ToString("00000");
            }
            lbBillNo.Text = billNo;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text != "")
            {
                bool ch;
                int num;
                ch = int.TryParse(txtQty.Text, out num);
                if (ch == false)
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນສິນຄ້າເປັນຕົວເລກເທົ່ານັ້ນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Clear();
                    txtTotal.Text = "0";
                }
                else
                {
                    if(int.Parse(qty)<int.Parse(txtQty.Text))
                    {
                        string msg = "ສິນຄ້າລາຍການນີ້ມີ " + qty + lbUnit.Text;
                        MessageBox.Show(msg, "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        price = txtPrice.Text;
                        price = price.Replace(",", "");
                        txtTotal.Text = (int.Parse(price) * (int.Parse(txtQty.Text))).ToString("#,###");
                    }                   
                }
            }
            else
            {
                txtTotal.Text = "0";
            }
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "" || txtProductName.Text=="")
            {
                MessageBox.Show("ກະລຸນາປ້ອນສິນຄ້າທີ່ຈະຂາຍກ່ອນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductID.Focus();
            }
            else
            {
                string[] AllData;
                AllData = new string[] { txtProductID.Text, txtProductName.Text, txtPrice.Text, txtQty.Text, lbUnit.Text, txtTotal.Text };
                lvi = new ListViewItem(AllData);
                LV.Items.Add(lvi);
                total = txtTotal.Text;
                total = total.Replace(",", "");
                amount = txtAmount.Text;
                amount = amount.Replace(",", "");
                txtAmount.Text = (int.Parse(amount) + int.Parse(total)).ToString("#,###");
                AllClear();
            }           
        }
        void AllClear()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            lbUnit.Text = "ຫົວໜ່ວຍ";
            txtTotal.Text = "0";
            txtProductID.Focus();
        }
        private void txtCancel_Click(object sender, EventArgs e)
        {
            int i;
            for(i=0; i<LV.SelectedItems.Count;i++)
            {
                lvi = LV.SelectedItems[i];
                total = LV.SelectedItems[i].SubItems[5].Text;
            }
            LV.Items.Remove(lvi);
            total = total.Replace(",", "");
            amount = txtAmount.Text;
            amount = amount.Replace(",", "");
            if(int.Parse(amount)==int.Parse(total))
            {
                txtAmount.Text = "0";
            }
            else
            {
                txtAmount.Text = (int.Parse(amount) - int.Parse(total)).ToString("#,###");
            }
           
        }
    
        private void btnAllCancel_Click(object sender, EventArgs e)
        {
            LV.Items.Clear();
            txtAmount.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = "ນາງນ້ອຍ";
            ccd.cmd = new SqlCommand("Insert into tbSell values(@billNo,@sellDate,@sellTime,@amount,@username)", ccd.conn);
            ccd.cmd.Parameters.AddWithValue("billNo", lbBillNo.Text);
            ccd.cmd.Parameters.AddWithValue("sellDate", Convert.ToDateTime(lbDate.Text).ToString("yyyy-MM-dd"));
            ccd.cmd.Parameters.AddWithValue("sellTime", lbTime.Text);
            amount = txtAmount.Text;
            amount = amount.Replace(",", "");
            ccd.cmd.Parameters.AddWithValue("amount", amount);
            ccd.cmd.Parameters.AddWithValue("username", username);
            ccd.cmd.ExecuteNonQuery();
            int i;
            for(i=0;i<LV.Items.Count;i++)
            {
                ccd.cmd = new SqlCommand("insert into tbSellDetail values(@billNo,@productID,@price,@qty,@total)", ccd.conn);
                ccd.cmd.Parameters.AddWithValue("billNo", lbBillNo.Text);
                ccd.cmd.Parameters.AddWithValue("productID", LV.Items[i].SubItems[0].Text);
                price = LV.Items[i].SubItems[2].Text;
                price = price.Replace(",", "");
                ccd.cmd.Parameters.AddWithValue("price", price);
                ccd.cmd.Parameters.AddWithValue("qty", LV.Items[i].SubItems[3].Text);
                total= LV.Items[i].SubItems[5].Text;
                total= total.Replace(",", "");
                ccd.cmd.Parameters.AddWithValue("total", total);
                ccd.cmd.ExecuteNonQuery();
                // ຕັດສະຕອກ
                SqlDataAdapter daQ = new SqlDataAdapter("select qty from tbProduct where productID='"+ LV.Items[i].SubItems[0].Text+"'", ccd.conn);
                DataSet dsQ = new DataSet();
                daQ.Fill(dsQ);
                dsQ.Tables[0].Clear();
                daQ.Fill(dsQ);
                qty = dsQ.Tables[0].Rows[0].ItemArray[0].ToString();
                //MessageBox.Show(qty);
                qty = (int.Parse(qty) - int.Parse(LV.Items[i].SubItems[3].Text)).ToString();
                //MessageBox.Show(qty);
                ccd.cmd = new SqlCommand("update tbProduct Set qty=@qty where productID=@productID", ccd.conn);
                ccd.cmd.Parameters.AddWithValue("qty", qty);
                ccd.cmd.Parameters.AddWithValue("productID", LV.Items[i].SubItems[0].Text);
                ccd.cmd.ExecuteNonQuery();
            }
            MessageBox.Show("ບັນທຶກຂໍ້ມູນການຂາຍແລ້ວ");
            LV.Items.Clear();
            txtAmount.Text = "0";
            txtPay.Clear();
            txtChange.Text = "0";
            AutoBill();
            txtProductID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            if(txtPay.Text!="")
            {
                bool ch;
                int num;
                ch = int.TryParse(txtPay.Text, out num);
                if(ch==false)
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຈຳນວນຮັບມາເປັນຕົວເລກເທົ່ານັ້ນ", "ຜົນການກວດສອບ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPay.Clear();
                    txtChange.Text = "0";
                    txtPay.Focus();
                }
                else
                {
                    amount = txtAmount.Text;
                    amount = amount.Replace(",", "");
                    if(int.Parse(txtPay.Text) == int.Parse(amount))
                    {
                        txtChange.Text = "0";
                    }
                    else
                    {
                        txtChange.Text = (int.Parse(txtPay.Text) - int.Parse(amount)).ToString("#,###");
                    }                       
                }
            }
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked == true) 
            {
                txtQty.Enabled = false;                
            }
            else
            {
                txtQty.Enabled = true;
            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ccd.da = new SqlDataAdapter("select p.productName,p.price,p.qty,u.unitName from tbProduct p inner join tbUnit u On p.unitID = u.unitID where p.productID = '"+txtProductID.Text+"'", ccd.conn);
                ccd.da.Fill(ccd.ds);
                ccd.ds.Tables[0].Clear();
                ccd.da.Fill(ccd.ds);
                txtProductName.Text = ccd.ds.Tables[0].Rows[0].ItemArray[0].ToString();
                price= ccd.ds.Tables[0].Rows[0].ItemArray[1].ToString();
                txtPrice.Text = (int.Parse(price)).ToString("#,###");
                qty = ccd.ds.Tables[0].Rows[0].ItemArray[2].ToString();
                lbUnit.Text = ccd.ds.Tables[0].Rows[0].ItemArray[3].ToString();
                txtQty.Text = "1";
                txtTotal.Text = txtPrice.Text;
                
            }
            catch (Exception ex)
            {

            }
        }
    }
}
