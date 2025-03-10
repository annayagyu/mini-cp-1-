namespace mini_cp_1
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelIdade = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.labelTempoContribuicao = new System.Windows.Forms.Label();
            this.textBoxTempoContribuicao = new System.Windows.Forms.TextBox();
            this.buttonEnviar = new System.Windows.Forms.Button();

            this.SuspendLayout();
            
            this.labelIdade.AutoSize = true;
            this.labelIdade.Location = new System.Drawing.Point(30, 30);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(34, 13);
            this.labelIdade.TabIndex = 0;
            this.labelIdade.Text = "Idade";
            
            this.textBoxIdade.Location = new System.Drawing.Point(150, 30);
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdade.TabIndex = 1;
            
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(30, 70);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 2;
            this.labelGenero.Text = "Gênero";
          
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
    "Masculino",
    "Feminino"});
            this.comboBoxGenero.Location = new System.Drawing.Point(150, 70);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGenero.TabIndex = 3;
           
            this.labelTempoContribuicao.AutoSize = true;
            this.labelTempoContribuicao.Location = new System.Drawing.Point(30, 110);
            this.labelTempoContribuicao.Name = "labelTempoContribuicao";
            this.labelTempoContribuicao.Size = new System.Drawing.Size(114, 13);
            this.labelTempoContribuicao.TabIndex = 4;
            this.labelTempoContribuicao.Text = "Tempo de Contribuição";
           
            this.textBoxTempoContribuicao.Location = new System.Drawing.Point(150, 110);
            this.textBoxTempoContribuicao.Name = "textBoxTempoContribuicao";
            this.textBoxTempoContribuicao.Size = new System.Drawing.Size(100, 20);
            this.textBoxTempoContribuicao.TabIndex = 5;
            
            this.buttonEnviar.Location = new System.Drawing.Point(100, 150);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 6;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.textBoxTempoContribuicao);
            this.Controls.Add(this.labelTempoContribuicao);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.labelIdade);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);

            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label labelTempoContribuicao;
        private System.Windows.Forms.TextBox textBoxTempoContribuicao;
        private System.Windows.Forms.Button buttonEnviar;
    }
}
