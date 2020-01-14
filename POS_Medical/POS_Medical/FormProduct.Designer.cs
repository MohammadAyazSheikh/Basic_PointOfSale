namespace POS_Medical
{
    partial class FormProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Panel();
            this.btnDlt = new System.Windows.Forms.Panel();
            this.panelActive = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.labelNameAdd = new System.Windows.Forms.Label();
            this.txtNameAdd = new System.Windows.Forms.TextBox();
            this.labelPriceAdd = new System.Windows.Forms.Label();
            this.txtPriceAdd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceUpdate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDUpdate = new System.Windows.Forms.NumericUpDown();
            this.labelID = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceAdd)).BeginInit();
            this.panelUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Controls.Add(this.btnBack);
            this.panelContainer.Controls.Add(this.btnSearch);
            this.panelContainer.Controls.Add(this.btnAdd);
            this.panelContainer.Controls.Add(this.btnUpdate);
            this.panelContainer.Controls.Add(this.btnDlt);
            this.panelContainer.Controls.Add(this.panelActive);
            this.panelContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelContainer.Location = new System.Drawing.Point(4, 3);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(112, 477);
            this.panelContainer.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(25, 398);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 55);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSerach_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(25, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 55);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Location = new System.Drawing.Point(25, 311);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 55);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDlt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDlt.BackgroundImage")));
            this.btnDlt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDlt.Location = new System.Drawing.Point(25, 222);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(65, 55);
            this.btnDlt.TabIndex = 1;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // panelActive
            // 
            this.panelActive.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelActive.ForeColor = System.Drawing.SystemColors.Highlight;
            this.panelActive.Location = new System.Drawing.Point(7, -52);
            this.panelActive.Name = "panelActive";
            this.panelActive.Size = new System.Drawing.Size(93, 78);
            this.panelActive.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(25, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAdd.Controls.Add(this.btnAddProduct);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.txtPriceAdd);
            this.panelAdd.Controls.Add(this.labelPriceAdd);
            this.panelAdd.Controls.Add(this.txtNameAdd);
            this.panelAdd.Controls.Add(this.labelNameAdd);
            this.panelAdd.Location = new System.Drawing.Point(268, 344);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(860, 477);
            this.panelAdd.TabIndex = 2;
            // 
            // labelNameAdd
            // 
            this.labelNameAdd.AutoSize = true;
            this.labelNameAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNameAdd.Location = new System.Drawing.Point(193, 167);
            this.labelNameAdd.Name = "labelNameAdd";
            this.labelNameAdd.Size = new System.Drawing.Size(100, 38);
            this.labelNameAdd.TabIndex = 0;
            this.labelNameAdd.Text = "Name";
            // 
            // txtNameAdd
            // 
            this.txtNameAdd.Location = new System.Drawing.Point(312, 183);
            this.txtNameAdd.Name = "txtNameAdd";
            this.txtNameAdd.Size = new System.Drawing.Size(240, 20);
            this.txtNameAdd.TabIndex = 1;
            // 
            // labelPriceAdd
            // 
            this.labelPriceAdd.AutoSize = true;
            this.labelPriceAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPriceAdd.Location = new System.Drawing.Point(197, 229);
            this.labelPriceAdd.Name = "labelPriceAdd";
            this.labelPriceAdd.Size = new System.Drawing.Size(85, 38);
            this.labelPriceAdd.TabIndex = 2;
            this.labelPriceAdd.Text = "Price";
            // 
            // txtPriceAdd
            // 
            this.txtPriceAdd.Location = new System.Drawing.Point(312, 234);
            this.txtPriceAdd.Name = "txtPriceAdd";
            this.txtPriceAdd.Size = new System.Drawing.Size(240, 20);
            this.txtPriceAdd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(247, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Prodcut";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(385, 300);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(117, 55);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelUpdate.Controls.Add(this.txtIDUpdate);
            this.panelUpdate.Controls.Add(this.labelID);
            this.panelUpdate.Controls.Add(this.Update);
            this.panelUpdate.Controls.Add(this.label2);
            this.panelUpdate.Controls.Add(this.txtPriceUpdate);
            this.panelUpdate.Controls.Add(this.label3);
            this.panelUpdate.Controls.Add(this.txtNameUpdate);
            this.panelUpdate.Controls.Add(this.label4);
            this.panelUpdate.Location = new System.Drawing.Point(425, 74);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(860, 477);
            this.panelUpdate.TabIndex = 9;
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Update.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Update.Location = new System.Drawing.Point(385, 300);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(117, 55);
            this.Update.TabIndex = 8;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 64);
            this.label2.TabIndex = 7;
            this.label2.Text = "Update Prodcut";
            // 
            // txtPriceUpdate
            // 
            this.txtPriceUpdate.Location = new System.Drawing.Point(312, 234);
            this.txtPriceUpdate.Name = "txtPriceUpdate";
            this.txtPriceUpdate.Size = new System.Drawing.Size(240, 20);
            this.txtPriceUpdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(197, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // txtNameUpdate
            // 
            this.txtNameUpdate.Location = new System.Drawing.Point(312, 183);
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.Size = new System.Drawing.Size(240, 20);
            this.txtNameUpdate.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(193, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name";
            // 
            // txtIDUpdate
            // 
            this.txtIDUpdate.Location = new System.Drawing.Point(312, 119);
            this.txtIDUpdate.Name = "txtIDUpdate";
            this.txtIDUpdate.Size = new System.Drawing.Size(240, 20);
            this.txtIDUpdate.TabIndex = 10;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelID.Location = new System.Drawing.Point(197, 114);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(48, 38);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 485);
            this.Controls.Add(this.panelUpdate);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelContainer);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.panelContainer.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceAdd)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel btnAdd;
        private System.Windows.Forms.Panel btnUpdate;
        private System.Windows.Forms.Panel btnDlt;
        private System.Windows.Forms.Panel panelActive;
        private System.Windows.Forms.Panel btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtPriceAdd;
        private System.Windows.Forms.Label labelPriceAdd;
        private System.Windows.Forms.TextBox txtNameAdd;
        private System.Windows.Forms.Label labelNameAdd;
        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.NumericUpDown txtIDUpdate;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtPriceUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameUpdate;
        private System.Windows.Forms.Label label4;
    }
}