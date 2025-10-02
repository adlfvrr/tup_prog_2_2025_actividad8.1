namespace ej
{
    partial class FormPrincipal
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
            label3 = new Label();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            tbImporte = new TextBox();
            btnConfirmar = new Button();
            lsbActualizar = new ListBox();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 55);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 92);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 127);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(124, 52);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(222, 23);
            tbNombre.TabIndex = 3;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(124, 89);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(222, 23);
            tbDNI.TabIndex = 4;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(124, 124);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(222, 23);
            tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(454, 74);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(164, 50);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lsbActualizar
            // 
            lsbActualizar.FormattingEnabled = true;
            lsbActualizar.ItemHeight = 15;
            lsbActualizar.Location = new Point(55, 166);
            lsbActualizar.Name = "lsbActualizar";
            lsbActualizar.Size = new Size(363, 214);
            lsbActualizar.TabIndex = 7;
            lsbActualizar.SelectedValueChanged += lsbActualizar_SelectedValueChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(454, 244);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(164, 50);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 392);
            Controls.Add(btnActualizar);
            Controls.Add(lsbActualizar);
            Controls.Add(btnConfirmar);
            Controls.Add(tbImporte);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNombre;
        private TextBox tbDNI;
        private TextBox tbImporte;
        private Button btnConfirmar;
        private ListBox lsbActualizar;
        private Button btnActualizar;
    }
}
