namespace Storage_Database
{
    partial class Dashboard
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
            this.listPCInfo = new System.Windows.Forms.ListView();
            this.INHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OSHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RamHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPUHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StorageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GPUHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeletePC = new System.Windows.Forms.Button();
            this.btnAddPC = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPCInfo
            // 
            this.listPCInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.INHeader,
            this.OSHeader,
            this.RamHeader,
            this.CPUHeader,
            this.StorageHeader,
            this.GPUHeader});
            this.listPCInfo.FullRowSelect = true;
            this.listPCInfo.GridLines = true;
            this.listPCInfo.Location = new System.Drawing.Point(12, 47);
            this.listPCInfo.Name = "listPCInfo";
            this.listPCInfo.Scrollable = false;
            this.listPCInfo.Size = new System.Drawing.Size(733, 215);
            this.listPCInfo.TabIndex = 0;
            this.listPCInfo.UseCompatibleStateImageBehavior = false;
            this.listPCInfo.View = System.Windows.Forms.View.Details;
            this.listPCInfo.SelectedIndexChanged += new System.EventHandler(this.listPCInfo_SelectedIndexChanged);
            // 
            // INHeader
            // 
            this.INHeader.Text = "Inventory Number";
            this.INHeader.Width = 150;
            // 
            // OSHeader
            // 
            this.OSHeader.Text = "OS";
            this.OSHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OSHeader.Width = 175;
            // 
            // RamHeader
            // 
            this.RamHeader.Text = "Ram*";
            this.RamHeader.Width = 58;
            // 
            // CPUHeader
            // 
            this.CPUHeader.Text = "CPU";
            this.CPUHeader.Width = 115;
            // 
            // StorageHeader
            // 
            this.StorageHeader.Text = "Storage*";
            this.StorageHeader.Width = 97;
            // 
            // GPUHeader
            // 
            this.GPUHeader.Text = "GPU";
            this.GPUHeader.Width = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Computer Inventory";
            // 
            // btnDeletePC
            // 
            this.btnDeletePC.Location = new System.Drawing.Point(511, 268);
            this.btnDeletePC.Name = "btnDeletePC";
            this.btnDeletePC.Size = new System.Drawing.Size(76, 36);
            this.btnDeletePC.TabIndex = 2;
            this.btnDeletePC.Text = "Delete";
            this.btnDeletePC.UseVisualStyleBackColor = true;
            this.btnDeletePC.Click += new System.EventHandler(this.btnDeletePC_Click);
            // 
            // btnAddPC
            // 
            this.btnAddPC.Location = new System.Drawing.Point(669, 268);
            this.btnAddPC.Name = "btnAddPC";
            this.btnAddPC.Size = new System.Drawing.Size(76, 36);
            this.btnAddPC.TabIndex = 3;
            this.btnAddPC.Text = "Add";
            this.btnAddPC.UseVisualStyleBackColor = true;
            this.btnAddPC.Click += new System.EventHandler(this.btnAddPC_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(593, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 36);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Ram and Storage are in GBs";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddPC);
            this.Controls.Add(this.btnDeletePC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listPCInfo);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listPCInfo;
        private System.Windows.Forms.ColumnHeader INHeader;
        private System.Windows.Forms.ColumnHeader OSHeader;
        private System.Windows.Forms.ColumnHeader RamHeader;
        private System.Windows.Forms.ColumnHeader CPUHeader;
        private System.Windows.Forms.ColumnHeader StorageHeader;
        private System.Windows.Forms.ColumnHeader GPUHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeletePC;
        private System.Windows.Forms.Button btnAddPC;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
    }
}