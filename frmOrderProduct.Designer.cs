namespace BCSP7C
{
    partial class frmOrderProduct
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbOrderBillNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(216, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 33);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "ອອກ";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(33, 543);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 33);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "ບັນທຶກການສັ່ງຊື້";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lbOrderBillNo
            // 
            this.lbOrderBillNo.AutoSize = true;
            this.lbOrderBillNo.Location = new System.Drawing.Point(685, 291);
            this.lbOrderBillNo.Name = "lbOrderBillNo";
            this.lbOrderBillNo.Size = new System.Drawing.Size(89, 24);
            this.lbOrderBillNo.TabIndex = 19;
            this.lbOrderBillNo.Text = "orderBillNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "ເລກທີໃບບິນ:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(203, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(163, 33);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "ຍົກເລີກລາຍການສັ່ງຊື້";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(34, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(163, 33);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "ເພີ້ມລາຍການສັ່ງຊື້";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(33, 10);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(177, 33);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "ກວດສອບສິນຄ້າໃນຮ້ານ";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // DGV2
            // 
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(33, 329);
            this.DGV2.Name = "DGV2";
            this.DGV2.Size = new System.Drawing.Size(839, 204);
            this.DGV2.TabIndex = 12;
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(33, 49);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(839, 232);
            this.DGV1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "ຊື່ຜູ້ສະໜອງ";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(499, 10);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(307, 32);
            this.cbSupplier.TabIndex = 23;
            // 
            // frmOrderProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 590);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbOrderBillNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.DGV2);
            this.Controls.Add(this.DGV1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmOrderProduct";
            this.Text = "frmOrderProduct";
            this.Load += new System.EventHandler(this.frmOrderProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbOrderBillNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView DGV2;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSupplier;
    }
}