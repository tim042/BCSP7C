namespace BCSP7C
{
    partial class frmSell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbBillNo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LV = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbUnit = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.brnAdd = new System.Windows.Forms.Button();
            this.txtCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAllCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAmount.Font = new System.Drawing.Font("Saysettha OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(31, 86);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(212, 44);
            this.txtAmount.TabIndex = 36;
            this.txtAmount.Text = "0";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Saysettha OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 34);
            this.label13.TabIndex = 34;
            this.label13.Text = "ລວມເປັນເງິນທັງໝົດ:";
            // 
            // lbBillNo
            // 
            this.lbBillNo.AutoSize = true;
            this.lbBillNo.Location = new System.Drawing.Point(933, 158);
            this.lbBillNo.Name = "lbBillNo";
            this.lbBillNo.Size = new System.Drawing.Size(51, 24);
            this.lbBillNo.TabIndex = 41;
            this.lbBillNo.Text = "billNo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(838, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 24);
            this.label12.TabIndex = 40;
            this.label12.Text = "ເລກທີໃບບິນ:";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(702, 158);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(46, 24);
            this.lbTime.TabIndex = 39;
            this.lbTime.Text = "Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(648, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "ເວລາ:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(564, 158);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 24);
            this.lbDate.TabIndex = 37;
            this.lbDate.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "ວັນທີ:";
            // 
            // LV
            // 
            this.LV.Location = new System.Drawing.Point(41, 210);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(965, 343);
            this.LV.TabIndex = 33;
            this.LV.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ລະຫັດສິນຄ້າ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbUnit);
            this.groupBox1.Controls.Add(this.cbAuto);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 130);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ຂໍ້ມູນສິນຄ້າ";
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(650, 76);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(67, 24);
            this.lbUnit.TabIndex = 21;
            this.lbUnit.Text = "ຫົວໜ່ວຍ";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(323, 39);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(67, 28);
            this.cbAuto.TabIndex = 20;
            this.cbAuto.Text = "ໂອໂຕ";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(789, 74);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(152, 35);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(743, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "ລວມ";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(468, 73);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(176, 35);
            this.txtQty.TabIndex = 11;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "ຈຳນວນ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 73);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(176, 35);
            this.txtPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "ລາຄາ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(468, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(473, 35);
            this.txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ຊື່ສິນຄ້າ";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(130, 32);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(176, 35);
            this.txtProductID.TabIndex = 1;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 570);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 44);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "ບັນທຶກການຂາຍ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(207, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 44);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "ອອກ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // brnAdd
            // 
            this.brnAdd.Location = new System.Drawing.Point(45, 148);
            this.brnAdd.Name = "brnAdd";
            this.brnAdd.Size = new System.Drawing.Size(140, 44);
            this.brnAdd.TabIndex = 31;
            this.brnAdd.Text = "ເພີ້ມລາຍການຂາຍ";
            this.brnAdd.UseVisualStyleBackColor = true;
            this.brnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(191, 148);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(149, 44);
            this.txtCancel.TabIndex = 32;
            this.txtCancel.Text = "ຍົກເລີກລາຍການຂາຍ";
            this.txtCancel.UseVisualStyleBackColor = true;
            this.txtCancel.Click += new System.EventHandler(this.txtCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.txtChange);
            this.groupBox2.Controls.Add(this.txtAmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtPay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Saysettha OT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1029, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 359);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ຂໍ້ມູນການຈ່າຍ";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(36, 276);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(207, 44);
            this.txtChange.TabIndex = 25;
            this.txtChange.Text = "0";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "ເງິນທອນ";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(32, 180);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(211, 44);
            this.txtPay.TabIndex = 23;
            this.txtPay.TextChanged += new System.EventHandler(this.txtPay_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 34);
            this.label8.TabIndex = 22;
            this.label8.Text = "ຮັບມາ";
            // 
            // btnAllCancel
            // 
            this.btnAllCancel.Location = new System.Drawing.Point(346, 148);
            this.btnAllCancel.Name = "btnAllCancel";
            this.btnAllCancel.Size = new System.Drawing.Size(149, 44);
            this.btnAllCancel.TabIndex = 43;
            this.btnAllCancel.Text = "ຍົກເລີກທັງໝົດ";
            this.btnAllCancel.UseVisualStyleBackColor = true;
            this.btnAllCancel.Click += new System.EventHandler(this.btnAllCancel_Click);
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1318, 631);
            this.Controls.Add(this.btnAllCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbBillNo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.brnAdd);
            this.Controls.Add(this.txtCancel);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSell";
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbBillNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button brnAdd;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAllCancel;
    }
}