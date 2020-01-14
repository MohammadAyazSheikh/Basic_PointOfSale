namespace POS_Medical
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.PictureBox();
            this.BtnOrder = new System.Windows.Forms.PictureBox();
            this.btnCustomer = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.Controls.Add(this.labelHeading);
            this.panelHeader.Location = new System.Drawing.Point(4, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(977, 128);
            this.panelHeader.TabIndex = 1;
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeading.Location = new System.Drawing.Point(346, 17);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(294, 83);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Heading";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.BtnOrder);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Location = new System.Drawing.Point(4, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 347);
            this.panel1.TabIndex = 2;
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProduct.BackgroundImage")));
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.Location = new System.Drawing.Point(629, 74);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(206, 165);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.TabStop = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOrder.BackgroundImage")));
            this.BtnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOrder.Location = new System.Drawing.Point(390, 74);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(206, 165);
            this.BtnOrder.TabIndex = 1;
            this.BtnOrder.TabStop = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.BackgroundImage")));
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.ErrorImage = null;
            this.btnCustomer.InitialImage = null;
            this.btnCustomer.Location = new System.Drawing.Point(152, 74);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(206, 165);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.Text = "Home";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnProduct;
        private System.Windows.Forms.PictureBox BtnOrder;
        private System.Windows.Forms.PictureBox btnCustomer;
    }
}

