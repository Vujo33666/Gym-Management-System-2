using System;

namespace kampusGym.UI
{
    partial class invertarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invertarForm));
            this.dgvInvertar = new System.Windows.Forms.DataGridView();
            this.BrisiBotun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DodajBotun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PromijeniBotun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvertar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvertar
            // 
            this.dgvInvertar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvertar.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvInvertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvInvertar.Location = new System.Drawing.Point(23, 23);
            this.dgvInvertar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvInvertar.Name = "dgvInvertar";
            this.dgvInvertar.RowHeadersWidth = 51;
            this.dgvInvertar.RowTemplate.Height = 24;
            this.dgvInvertar.Size = new System.Drawing.Size(655, 505);
            this.dgvInvertar.TabIndex = 0;
            this.dgvInvertar.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvertar_RowHeaderMouseClick);
            // 
            // BrisiBotun
            // 
            this.BrisiBotun.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BrisiBotun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrisiBotun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrisiBotun.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrisiBotun.ForeColor = System.Drawing.Color.Navy;
            this.BrisiBotun.Location = new System.Drawing.Point(284, 548);
            this.BrisiBotun.Margin = new System.Windows.Forms.Padding(2);
            this.BrisiBotun.Name = "BrisiBotun";
            this.BrisiBotun.Size = new System.Drawing.Size(76, 41);
            this.BrisiBotun.TabIndex = 1;
            this.BrisiBotun.Text = "Briši";
            this.BrisiBotun.UseVisualStyleBackColor = false;
            this.BrisiBotun.Click += new System.EventHandler(this.BrisiBotun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(124, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventar";
            // 
            // DodajBotun
            // 
            this.DodajBotun.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DodajBotun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DodajBotun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajBotun.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajBotun.ForeColor = System.Drawing.Color.Navy;
            this.DodajBotun.Location = new System.Drawing.Point(23, 548);
            this.DodajBotun.Margin = new System.Windows.Forms.Padding(2);
            this.DodajBotun.Name = "DodajBotun";
            this.DodajBotun.Size = new System.Drawing.Size(76, 41);
            this.DodajBotun.TabIndex = 0;
            this.DodajBotun.Text = "Dodaj";
            this.DodajBotun.UseVisualStyleBackColor = false;
            this.DodajBotun.Click += new System.EventHandler(this.DodajBotun_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.PromijeniBotun);
            this.panel1.Controls.Add(this.BrisiBotun);
            this.panel1.Controls.Add(this.DodajBotun);
            this.panel1.Controls.Add(this.dgvInvertar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(373, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 623);
            this.panel1.TabIndex = 1;
            // 
            // PromijeniBotun
            // 
            this.PromijeniBotun.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PromijeniBotun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PromijeniBotun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PromijeniBotun.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromijeniBotun.ForeColor = System.Drawing.Color.Navy;
            this.PromijeniBotun.Location = new System.Drawing.Point(154, 548);
            this.PromijeniBotun.Margin = new System.Windows.Forms.Padding(2);
            this.PromijeniBotun.Name = "PromijeniBotun";
            this.PromijeniBotun.Size = new System.Drawing.Size(76, 41);
            this.PromijeniBotun.TabIndex = 2;
            this.PromijeniBotun.Text = "Promijeni";
            this.PromijeniBotun.UseVisualStyleBackColor = false;
            this.PromijeniBotun.Click += new System.EventHandler(this.PromijeniBotun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(76, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv opreme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(76, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Količina";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(202, 155);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 27);
            this.textBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDown1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(202, 206);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(146, 27);
            this.numericUpDown1.TabIndex = 7;
            // 
            // invertarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1069, 623);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "invertarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "invertarForm";
            this.Load += new System.EventHandler(this.invertarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvertar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dgvInvertar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrisiBotun;
        private System.Windows.Forms.Button DodajBotun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PromijeniBotun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}