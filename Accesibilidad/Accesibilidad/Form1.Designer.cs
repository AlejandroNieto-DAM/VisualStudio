namespace Accesibilidad
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.sizeOptions = new System.Windows.Forms.GroupBox();
            this.smallPizza = new System.Windows.Forms.RadioButton();
            this.largePizza = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sizeOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AccessibleDescription = "Porción de pizza";
            this.logo.AccessibleName = "Logotipo de la compañia";
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(45, 44);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(99, 100);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // companyLabel
            // 
            this.companyLabel.AccessibleDescription = "Nombre de la compañia";
            this.companyLabel.AccessibleName = "Nombre de la compañia";
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.ForeColor = System.Drawing.Color.Yellow;
            this.companyLabel.Location = new System.Drawing.Point(167, 82);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(136, 29);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Good Pizza";
            this.companyLabel.Click += new System.EventHandler(this.companyLabel_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AccessibleDescription = "Etiqueta de nombre de cliente";
            this.customerLabel.AccessibleName = "Etiqueta de nombre de cliente";
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(90, 197);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(44, 13);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "&Nombre";
            // 
            // customerName
            // 
            this.customerName.AccessibleDescription = "Nombre de cliente";
            this.customerName.AccessibleName = "Nombre de cliente";
            this.customerName.Location = new System.Drawing.Point(151, 194);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(100, 20);
            this.customerName.TabIndex = 3;
            // 
            // sizeOptions
            // 
            this.sizeOptions.AccessibleDescription = "Opciones de tamaño de pizza";
            this.sizeOptions.AccessibleName = "Opciones de tamaño de pizza";
            this.sizeOptions.Controls.Add(this.largePizza);
            this.sizeOptions.Controls.Add(this.smallPizza);
            this.sizeOptions.Location = new System.Drawing.Point(80, 249);
            this.sizeOptions.Name = "sizeOptions";
            this.sizeOptions.Size = new System.Drawing.Size(138, 87);
            this.sizeOptions.TabIndex = 4;
            this.sizeOptions.TabStop = false;
            this.sizeOptions.Text = "Pizza Size";
            // 
            // smallPizza
            // 
            this.smallPizza.AccessibleDescription = "Pizza pequeña";
            this.smallPizza.AccessibleName = "Pizza pequeña";
            this.smallPizza.AutoSize = true;
            this.smallPizza.Location = new System.Drawing.Point(23, 28);
            this.smallPizza.Name = "smallPizza";
            this.smallPizza.Size = new System.Drawing.Size(80, 17);
            this.smallPizza.TabIndex = 0;
            this.smallPizza.TabStop = true;
            this.smallPizza.Text = "&Small $6.00";
            this.smallPizza.UseVisualStyleBackColor = true;
            // 
            // largePizza
            // 
            this.largePizza.AutoSize = true;
            this.largePizza.Location = new System.Drawing.Point(23, 51);
            this.largePizza.Name = "largePizza";
            this.largePizza.Size = new System.Drawing.Size(88, 17);
            this.largePizza.TabIndex = 1;
            this.largePizza.TabStop = true;
            this.largePizza.Text = "&Large $10.00";
            this.largePizza.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(396, 242);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 6;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Formulario de pedido";
            this.AccessibleName = "Formulario de pedido";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 411);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeOptions);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.logo);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.sizeOptions.ResumeLayout(false);
            this.sizeOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.GroupBox sizeOptions;
        private System.Windows.Forms.RadioButton largePizza;
        private System.Windows.Forms.RadioButton smallPizza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

