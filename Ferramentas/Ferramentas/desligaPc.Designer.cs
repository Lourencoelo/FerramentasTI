namespace Ferramentas
{
    partial class desligaPc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bntEscolhaH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntDesligarMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntDesligarAgr = new System.Windows.Forms.Button();
            this.bntCancelaDesl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntEscolhaH);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Horario que Deseja Desligar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // bntEscolhaH
            // 
            this.bntEscolhaH.Location = new System.Drawing.Point(99, 71);
            this.bntEscolhaH.Name = "bntEscolhaH";
            this.bntEscolhaH.Size = new System.Drawing.Size(75, 23);
            this.bntEscolhaH.TabIndex = 1;
            this.bntEscolhaH.Text = "Agendar";
            this.bntEscolhaH.UseVisualStyleBackColor = true;
            this.bntEscolhaH.Click += new System.EventHandler(this.bntEscolhaH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bntDesligarMin);
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desligar Aqui a:";
            // 
            // bntDesligarMin
            // 
            this.bntDesligarMin.Location = new System.Drawing.Point(99, 71);
            this.bntDesligarMin.Name = "bntDesligarMin";
            this.bntDesligarMin.Size = new System.Drawing.Size(75, 23);
            this.bntDesligarMin.TabIndex = 1;
            this.bntDesligarMin.Text = "Agendar";
            this.bntDesligarMin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite em MInutos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntCancelaDesl);
            this.groupBox3.Controls.Add(this.bntDesligarAgr);
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Desligar";
            // 
            // bntDesligarAgr
            // 
            this.bntDesligarAgr.Location = new System.Drawing.Point(99, 39);
            this.bntDesligarAgr.Name = "bntDesligarAgr";
            this.bntDesligarAgr.Size = new System.Drawing.Size(75, 23);
            this.bntDesligarAgr.TabIndex = 1;
            this.bntDesligarAgr.Text = "Desligar";
            this.bntDesligarAgr.UseVisualStyleBackColor = true;
            // 
            // bntCancelaDesl
            // 
            this.bntCancelaDesl.Location = new System.Drawing.Point(68, 68);
            this.bntCancelaDesl.Name = "bntCancelaDesl";
            this.bntCancelaDesl.Size = new System.Drawing.Size(149, 23);
            this.bntCancelaDesl.TabIndex = 2;
            this.bntCancelaDesl.Text = "Cancelar o Desligamento";
            this.bntCancelaDesl.UseVisualStyleBackColor = true;
            this.bntCancelaDesl.Click += new System.EventHandler(this.bntCancelaDesl_Click);
            // 
            // desligaPc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 412);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "desligaPc";
            this.Text = "desligaPc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntEscolhaH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntDesligarMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntDesligarAgr;
        private System.Windows.Forms.Button bntCancelaDesl;
    }
}