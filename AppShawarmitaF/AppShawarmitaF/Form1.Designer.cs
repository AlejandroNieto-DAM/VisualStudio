﻿namespace AppShawarmitaF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.complementos1 = new AppShawarmitaF.Complementos();
            this.bebida1 = new AppShawarmitaF.Bebida();
            this.burguers2 = new AppShawarmitaF.burguers();
            this.kebab1 = new AppShawarmitaF.Kebab();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.ForestGreen;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(802, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 420);
            this.panel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gold;
            this.panel10.Location = new System.Drawing.Point(3, 300);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(6, 25);
            this.panel10.TabIndex = 15;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gold;
            this.button5.Location = new System.Drawing.Point(0, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 34);
            this.button5.TabIndex = 16;
            this.button5.Text = "Carrito";
            this.toolTip1.SetToolTip(this.button5, "Producto Añadidos");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(3, 390);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(6, 25);
            this.panel9.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(0, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(28, 3, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Administrador";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Location = new System.Drawing.Point(3, 265);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(6, 25);
            this.panel8.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Gold;
            this.button6.Location = new System.Drawing.Point(0, 261);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 34);
            this.button6.TabIndex = 11;
            this.button6.Text = "Otros";
            this.toolTip1.SetToolTip(this.button6, "Seccion Complementos");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Location = new System.Drawing.Point(3, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 25);
            this.panel5.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Gold;
            this.button4.Location = new System.Drawing.Point(0, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Bebida";
            this.toolTip1.SetToolTip(this.button4, "Seccion Bebidas");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(3, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 25);
            this.panel4.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(0, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Kebabs";
            this.toolTip1.SetToolTip(this.button3, "Seccion Kebabs");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 25);
            this.panel2.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(6, 25);
            this.panel7.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-75, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(-87, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 25);
            this.panel3.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(0, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Burguers";
            this.toolTip1.SetToolTip(this.button1, "Seccion Hamburguesas");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.complementos1);
            this.panel6.Controls.Add(this.bebida1);
            this.panel6.Controls.Add(this.burguers2);
            this.panel6.Controls.Add(this.kebab1);
            this.panel6.Location = new System.Drawing.Point(205, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(583, 360);
            this.panel6.TabIndex = 2;
            // 
            // complementos1
            // 
            this.complementos1.Location = new System.Drawing.Point(-13, -26);
            this.complementos1.Name = "complementos1";
            this.complementos1.Size = new System.Drawing.Size(596, 400);
            this.complementos1.TabIndex = 3;
            // 
            // bebida1
            // 
            this.bebida1.Location = new System.Drawing.Point(-13, -26);
            this.bebida1.Name = "bebida1";
            this.bebida1.Size = new System.Drawing.Size(596, 400);
            this.bebida1.TabIndex = 2;
            // 
            // burguers2
            // 
            this.burguers2.Location = new System.Drawing.Point(-13, -26);
            this.burguers2.Name = "burguers2";
            this.burguers2.Size = new System.Drawing.Size(596, 400);
            this.burguers2.TabIndex = 1;
            // 
            // kebab1
            // 
            this.kebab1.Location = new System.Drawing.Point(-13, -26);
            this.kebab1.Name = "kebab1";
            this.kebab1.Size = new System.Drawing.Size(596, 400);
            this.kebab1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(406, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "SHAWARMITA APP ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private burguers burguers1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private Kebab kebab1;
        private burguers burguers2;
        private Bebida bebida1;
        private Complementos complementos1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

