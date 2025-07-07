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
    public partial class frmOrderProduct : Form
    {
        public frmOrderProduct()
        {
            InitializeComponent();
        }
        classConnectDatabase ccd = new classConnectDatabase();
        SqlDataAdapter daCh = new SqlDataAdapter();
        DataSet dsCh = new DataSet();
        DataTable dt = new DataTable();
        private void frmOrderProduct_Load(object sender, EventArgs e)
        {
            ccd.connectDatabase();
            daCh = new SqlDataAdapter("Select p.productID,p.productName,p.price,p.qty,u.unitName from tbProduct p inner join tbUnit u on p.unitID=u.unitID", ccd.conn);
            daCh.Fill(dsCh);
            dsCh.Tables[0].Clear();
            daCh.Fill(dsCh);
            DGV1.DataSource = dsCh.Tables[0];
            DGV1.Refresh();
            DGV1.Columns[0].HeaderText = "ລະຫັດສິນຄ້າ";
            DGV1.Columns[1].HeaderText = "ຊື່ສິນຄ້າ";
            DGV1.Columns[2].HeaderText = "ລາຄາ";
            DGV1.Columns[3].HeaderText = "ຈຳນວນມີຢູ່ໃນຮ້ານ";
            DGV1.Columns[4].HeaderText = "ຫົວໜ່ວຍ";
            DGV1.Columns[0].Width = 150;
            DGV1.Columns[1].Width = 250;
            DGV1.Columns[2].Width = 120;
            DGV1.Columns[3].Width = 130;
            DGV1.Columns[4].Width = 120;

            dt.Columns.Add("ລະຫັດສິນຄ້າ");
            dt.Columns.Add("ຊື່ສິນຄ້າ");
            dt.Columns.Add("ຈຳນວນສັ່ງຊື້");
            dt.Columns.Add("ຫົວໜ່ວຍ");
            DGV2.DataSource = dt;
            DGV2.Refresh();
            DGV2.Columns[0].Width = 150;
            DGV2.Columns[1].Width = 250;
            DGV2.Columns[2].Width = 120;
            DGV2.Columns[3].Width = 130;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            daCh = new SqlDataAdapter("Select p.productID,p.productName,p.price,p.qty,u.unitName from tbProduct p inner join tbUnit u on p.unitID=u.unitID where p.qty <= p.conditionCheck", ccd.conn);
            daCh.Fill(dsCh);
            dsCh.Tables[0].Clear();
            daCh.Fill(dsCh);
            DGV1.DataSource = dsCh.Tables[0];
            DGV1.Refresh();
        }
    }
}
