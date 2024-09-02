namespace mycontacte
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grupbox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgcontact = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bnew = new System.Windows.Forms.ToolStripButton();
            this.Brefresh = new System.Windows.Forms.ToolStripButton();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnREMOV = new System.Windows.Forms.Button();
            this.idcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbermelli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupbox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcontact)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupbox1
            // 
            this.grupbox1.Controls.Add(this.label1);
            this.grupbox1.Controls.Add(this.search);
            this.grupbox1.Location = new System.Drawing.Point(12, 28);
            this.grupbox1.Name = "grupbox1";
            this.grupbox1.Size = new System.Drawing.Size(610, 49);
            this.grupbox1.TabIndex = 1;
            this.grupbox1.TabStop = false;
            this.grupbox1.Text = "جستجو";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(88, 20);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(432, 21);
            this.search.TabIndex = 0;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgcontact);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "لیست";
            // 
            // dgcontact
            // 
            this.dgcontact.AllowUserToAddRows = false;
            this.dgcontact.AllowUserToDeleteRows = false;
            this.dgcontact.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgcontact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcontact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcontact,
            this.name,
            this.family,
            this.numbermelli,
            this.age,
            this.phone,
            this.addres});
            this.dgcontact.Location = new System.Drawing.Point(0, 20);
            this.dgcontact.Name = "dgcontact";
            this.dgcontact.ReadOnly = true;
            this.dgcontact.Size = new System.Drawing.Size(601, 262);
            this.dgcontact.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bnew,
            this.Brefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bnew
            // 
            this.Bnew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Bnew.Image = ((System.Drawing.Image)(resources.GetObject("Bnew.Image")));
            this.Bnew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bnew.Name = "Bnew";
            this.Bnew.Size = new System.Drawing.Size(106, 22);
            this.Bnew.Text = "افزودن شخص جدید";
            this.Bnew.Click += new System.EventHandler(this.Bnew_Click);
            // 
            // Brefresh
            // 
            this.Brefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Brefresh.Image = ((System.Drawing.Image)(resources.GetObject("Brefresh.Image")));
            this.Brefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Brefresh.Name = "Brefresh";
            this.Brefresh.Size = new System.Drawing.Size(60, 22);
            this.Brefresh.Text = "بروزرسانی";
            this.Brefresh.Click += new System.EventHandler(this.Brefresh_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(538, 339);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(75, 23);
            this.btnEDIT.TabIndex = 1;
            this.btnEDIT.Text = "ویرایش";
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnREMOV
            // 
            this.btnREMOV.Location = new System.Drawing.Point(457, 339);
            this.btnREMOV.Name = "btnREMOV";
            this.btnREMOV.Size = new System.Drawing.Size(75, 23);
            this.btnREMOV.TabIndex = 2;
            this.btnREMOV.Text = "حذف";
            this.btnREMOV.UseVisualStyleBackColor = true;
            this.btnREMOV.Click += new System.EventHandler(this.btnREMOV_Click);
            // 
            // idcontact
            // 
            this.idcontact.DataPropertyName = "IDcontact";
            this.idcontact.HeaderText = "کد شخص";
            this.idcontact.Name = "idcontact";
            this.idcontact.ReadOnly = true;
            this.idcontact.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // family
            // 
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.Name = "family";
            this.family.ReadOnly = true;
            // 
            // numbermelli
            // 
            this.numbermelli.DataPropertyName = "kodemeli";
            this.numbermelli.HeaderText = "کد ملی";
            this.numbermelli.Name = "numbermelli";
            this.numbermelli.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "سن";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "شماره تلفن";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // addres
            // 
            this.addres.DataPropertyName = "addres";
            this.addres.HeaderText = "آدرس";
            this.addres.Name = "addres";
            this.addres.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 377);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnREMOV);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupbox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفتر تلفن";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grupbox1.ResumeLayout(false);
            this.grupbox1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcontact)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grupbox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgcontact;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Bnew;
        private System.Windows.Forms.ToolStripButton Brefresh;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnREMOV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbermelli;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn addres;
    }
}

