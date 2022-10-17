namespace PSI_FileExplorer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lstvFiles = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.rdbLarge = new System.Windows.Forms.RadioButton();
            this.rdbDetail = new System.Windows.Forms.RadioButton();
            this.grbView = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.grbView.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 39);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(400, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lstvFiles
            // 
            this.lstvFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstvFiles.Location = new System.Drawing.Point(15, 65);
            this.lstvFiles.Name = "lstvFiles";
            this.lstvFiles.Size = new System.Drawing.Size(400, 396);
            this.lstvFiles.TabIndex = 2;
            this.lstvFiles.UseCompatibleStateImageBehavior = false;
            this.lstvFiles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data de Modificação";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tamanho";
            this.columnHeader4.Width = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rdbLarge
            // 
            this.rdbLarge.AutoSize = true;
            this.rdbLarge.Location = new System.Drawing.Point(6, 26);
            this.rdbLarge.Name = "rdbLarge";
            this.rdbLarge.Size = new System.Drawing.Size(52, 17);
            this.rdbLarge.TabIndex = 4;
            this.rdbLarge.Text = "Large";
            this.rdbLarge.UseVisualStyleBackColor = true;
            this.rdbLarge.Click += new System.EventHandler(this.rdbLarge_Click);
            // 
            // rdbDetail
            // 
            this.rdbDetail.AutoSize = true;
            this.rdbDetail.Checked = true;
            this.rdbDetail.Location = new System.Drawing.Point(6, 49);
            this.rdbDetail.Name = "rdbDetail";
            this.rdbDetail.Size = new System.Drawing.Size(64, 17);
            this.rdbDetail.TabIndex = 4;
            this.rdbDetail.TabStop = true;
            this.rdbDetail.Text = "Detailed";
            this.rdbDetail.UseVisualStyleBackColor = true;
            // 
            // grbView
            // 
            this.grbView.Controls.Add(this.rdbDetail);
            this.grbView.Controls.Add(this.rdbLarge);
            this.grbView.Location = new System.Drawing.Point(430, 110);
            this.grbView.Name = "grbView";
            this.grbView.Size = new System.Drawing.Size(91, 83);
            this.grbView.TabIndex = 5;
            this.grbView.TabStop = false;
            this.grbView.Text = "View";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drive";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(436, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "Generic_36503.png");
            this.img.Images.SetKeyName(1, "maximizethewindow_theapplication_maximizar_2873.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 474);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grbView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstvFiles);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbView.ResumeLayout(false);
            this.grbView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ListView lstvFiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbLarge;
        private System.Windows.Forms.RadioButton rdbDetail;
        private System.Windows.Forms.GroupBox grbView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList img;
    }
}

