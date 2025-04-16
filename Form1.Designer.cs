namespace Repaso_Disenio_y_Desarrollo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tDescripcion = new TextBox();
            bAgregar = new Button();
            pProducto = new Panel();
            mtCodigo = new MaskedTextBox();
            panel1 = new Panel();
            lbListadoProductos = new ListBox();
            lCantidadProductos = new Label();
            lListado = new Label();
            label3 = new Label();
            pProducto.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 45);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción";
            // 
            // tDescripcion
            // 
            tDescripcion.Location = new Point(147, 103);
            tDescripcion.Name = "tDescripcion";
            tDescripcion.Size = new Size(100, 23);
            tDescripcion.TabIndex = 3;
            // 
            // bAgregar
            // 
            bAgregar.Location = new Point(251, 153);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(75, 23);
            bAgregar.TabIndex = 4;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            bAgregar.Click += bAgregar_Click;
            // 
            // pProducto
            // 
            pProducto.BackColor = Color.FromArgb(128, 255, 128);
            pProducto.Controls.Add(mtCodigo);
            pProducto.Controls.Add(bAgregar);
            pProducto.Controls.Add(label2);
            pProducto.Controls.Add(label1);
            pProducto.Controls.Add(tDescripcion);
            pProducto.Location = new Point(12, 12);
            pProducto.Name = "pProducto";
            pProducto.Size = new Size(360, 465);
            pProducto.TabIndex = 5;
            // 
            // mtCodigo
            // 
            mtCodigo.Location = new Point(147, 45);
            mtCodigo.Mask = "999";
            mtCodigo.Name = "mtCodigo";
            mtCodigo.Size = new Size(100, 23);
            mtCodigo.TabIndex = 5;
            mtCodigo.ValidatingType = typeof(int);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lbListadoProductos);
            panel1.Controls.Add(lCantidadProductos);
            panel1.Controls.Add(lListado);
            panel1.Location = new Point(388, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 465);
            panel1.TabIndex = 6;
            // 
            // lbListadoProductos
            // 
            lbListadoProductos.FormattingEnabled = true;
            lbListadoProductos.ItemHeight = 15;
            lbListadoProductos.Location = new Point(34, 63);
            lbListadoProductos.Name = "lbListadoProductos";
            lbListadoProductos.Size = new Size(272, 154);
            lbListadoProductos.TabIndex = 3;
            // 
            // lCantidadProductos
            // 
            lCantidadProductos.AutoSize = true;
            lCantidadProductos.Location = new Point(284, 220);
            lCantidadProductos.Name = "lCantidadProductos";
            lCantidadProductos.Size = new Size(13, 15);
            lCantidadProductos.TabIndex = 2;
            lCantidadProductos.Text = "0";
            // 
            // lListado
            // 
            lListado.AutoSize = true;
            lListado.Location = new Point(34, 45);
            lListado.Name = "lListado";
            lListado.Size = new Size(45, 15);
            lListado.TabIndex = 1;
            lListado.Text = "Listado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 220);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad de productos: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 489);
            Controls.Add(panel1);
            Controls.Add(pProducto);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pProducto.ResumeLayout(false);
            pProducto.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tDescripcion;
        private Button bAgregar;
        private Panel pProducto;
        private Panel panel1;
        private Label lCantidadProductos;
        private Label lListado;
        private ListBox lbListadoProductos;
        private MaskedTextBox mtCodigo;
        private Label label3;
    }
}
