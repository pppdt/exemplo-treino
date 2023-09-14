namespace exemplo_treino
{
    partial class FormRelatorio
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.txtcidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.txtuf = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialComboBox1 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.materialComboBox2 = new ReaLTaiizor.Controls.MaterialComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtuf);
            this.groupBox1.Controls.Add(this.txtcidade);
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialComboBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(788, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agrupamento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialComboBox2);
            this.groupBox3.Location = new System.Drawing.Point(6, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(788, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imprimir";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.HighEmphasis = true;
            this.btnSalvar.Icon = null;
            this.btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.btnSalvar.Location = new System.Drawing.Point(691, 363);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSalvar.Size = new System.Drawing.Size(103, 36);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Visualizar";
            this.btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSalvar.UseAccentColor = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.materialButton1.Location = new System.Drawing.Point(596, 363);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(87, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Imprimir";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.AnimateReadOnly = false;
            this.txtcidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtcidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtcidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcidade.Depth = 0;
            this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcidade.HideSelection = true;
            this.txtcidade.Hint = "Cidade";
            this.txtcidade.LeadingIcon = null;
            this.txtcidade.Location = new System.Drawing.Point(6, 22);
            this.txtcidade.MaxLength = 32767;
            this.txtcidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.PasswordChar = '\0';
            this.txtcidade.PrefixSuffixText = null;
            this.txtcidade.ReadOnly = false;
            this.txtcidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcidade.SelectedText = "";
            this.txtcidade.SelectionLength = 0;
            this.txtcidade.SelectionStart = 0;
            this.txtcidade.ShortcutsEnabled = true;
            this.txtcidade.Size = new System.Drawing.Size(649, 48);
            this.txtcidade.TabIndex = 13;
            this.txtcidade.TabStop = false;
            this.txtcidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcidade.TrailingIcon = null;
            this.txtcidade.UseSystemPasswordChar = false;
            // 
            // txtuf
            // 
            this.txtuf.AutoResize = false;
            this.txtuf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtuf.Depth = 0;
            this.txtuf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtuf.DropDownHeight = 174;
            this.txtuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtuf.DropDownWidth = 121;
            this.txtuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtuf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Hint = "UF";
            this.txtuf.IntegralHeight = false;
            this.txtuf.ItemHeight = 43;
            this.txtuf.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MS",
            "MT",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(661, 21);
            this.txtuf.MaxDropDownItems = 4;
            this.txtuf.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(121, 49);
            this.txtuf.StartIndex = 0;
            this.txtuf.TabIndex = 14;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Hint = "Agrupamento";
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Nenhum",
            "Cidade",
            "Estado"});
            this.materialComboBox1.Location = new System.Drawing.Point(6, 22);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(776, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 15;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.Hint = "Impressora";
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(6, 22);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(776, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 16;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtcidade;
        private ReaLTaiizor.Controls.MaterialComboBox txtuf;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox1;
        private ReaLTaiizor.Controls.MaterialComboBox materialComboBox2;
    }
}