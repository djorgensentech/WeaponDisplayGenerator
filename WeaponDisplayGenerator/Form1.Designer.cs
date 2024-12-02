namespace WeaponDisplayGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tbX = new TextBox();
            lbX = new Label();
            tbY = new TextBox();
            lbY = new Label();
            lbZ = new Label();
            tbZ = new TextBox();
            pnInput = new Panel();
            pbWeapon = new PictureBox();
            cbWeaponType = new ComboBox();
            lbWeaponType = new Label();
            cbSide = new ComboBox();
            lbSide = new Label();
            lbCommandTitle = new Label();
            pnOutput = new Panel();
            lbCopied = new Label();
            btCopy = new Button();
            lbCommand = new Label();
            pnInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbWeapon).BeginInit();
            pnOutput.SuspendLayout();
            SuspendLayout();
            // 
            // tbX
            // 
            tbX.Location = new Point(33, 17);
            tbX.Name = "tbX";
            tbX.Size = new Size(49, 23);
            tbX.TabIndex = 0;
            tbX.TextChanged += tbX_TextChanged;
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbX.ForeColor = SystemColors.ButtonHighlight;
            lbX.Location = new Point(10, 20);
            lbX.Name = "lbX";
            lbX.Size = new Size(15, 15);
            lbX.TabIndex = 1;
            lbX.Text = "X";
            lbX.Click += label1_Click;
            // 
            // tbY
            // 
            tbY.Location = new Point(120, 17);
            tbY.Name = "tbY";
            tbY.Size = new Size(49, 23);
            tbY.TabIndex = 2;
            tbY.TextChanged += tbY_TextChanged;
            // 
            // lbY
            // 
            lbY.AutoSize = true;
            lbY.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbY.ForeColor = SystemColors.ButtonHighlight;
            lbY.Location = new Point(93, 20);
            lbY.Name = "lbY";
            lbY.Size = new Size(14, 15);
            lbY.TabIndex = 3;
            lbY.Text = "Y";
            // 
            // lbZ
            // 
            lbZ.AutoSize = true;
            lbZ.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbZ.ForeColor = SystemColors.ButtonHighlight;
            lbZ.Location = new Point(182, 20);
            lbZ.Name = "lbZ";
            lbZ.Size = new Size(14, 15);
            lbZ.TabIndex = 4;
            lbZ.Text = "Z";
            lbZ.Click += label3_Click;
            // 
            // tbZ
            // 
            tbZ.Location = new Point(209, 17);
            tbZ.Name = "tbZ";
            tbZ.Size = new Size(49, 23);
            tbZ.TabIndex = 5;
            tbZ.TextChanged += tbZ_TextChanged;
            // 
            // pnInput
            // 
            pnInput.BackColor = SystemColors.WindowFrame;
            pnInput.Controls.Add(pbWeapon);
            pnInput.Controls.Add(cbWeaponType);
            pnInput.Controls.Add(lbWeaponType);
            pnInput.Controls.Add(cbSide);
            pnInput.Controls.Add(lbSide);
            pnInput.Controls.Add(tbZ);
            pnInput.Controls.Add(lbX);
            pnInput.Controls.Add(lbZ);
            pnInput.Controls.Add(tbX);
            pnInput.Controls.Add(tbY);
            pnInput.Controls.Add(lbY);
            pnInput.Location = new Point(0, 0);
            pnInput.Name = "pnInput";
            pnInput.Size = new Size(434, 158);
            pnInput.TabIndex = 6;
            // 
            // pbWeapon
            // 
            pbWeapon.BackgroundImageLayout = ImageLayout.Stretch;
            pbWeapon.Location = new Point(298, 17);
            pbWeapon.Name = "pbWeapon";
            pbWeapon.Size = new Size(116, 116);
            pbWeapon.TabIndex = 10;
            pbWeapon.TabStop = false;
            // 
            // cbWeaponType
            // 
            cbWeaponType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWeaponType.FormattingEnabled = true;
            cbWeaponType.Items.AddRange(new object[] { "Trident", "Mace", "Axe", "Sword", "Bow" });
            cbWeaponType.Location = new Point(120, 110);
            cbWeaponType.Name = "cbWeaponType";
            cbWeaponType.Size = new Size(76, 23);
            cbWeaponType.TabIndex = 9;
            cbWeaponType.SelectedValueChanged += cbWeaponType_SelectedValueChanged;
            cbWeaponType.TextChanged += cbWeaponType_TextChanged;
            // 
            // lbWeaponType
            // 
            lbWeaponType.AutoSize = true;
            lbWeaponType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbWeaponType.ForeColor = SystemColors.ButtonHighlight;
            lbWeaponType.Location = new Point(10, 113);
            lbWeaponType.Name = "lbWeaponType";
            lbWeaponType.Size = new Size(82, 15);
            lbWeaponType.TabIndex = 8;
            lbWeaponType.Text = "Weapon Type";
            // 
            // cbSide
            // 
            cbSide.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSide.FormattingEnabled = true;
            cbSide.Items.AddRange(new object[] { "-X", "-Z", "+X", "+Z" });
            cbSide.Location = new Point(120, 64);
            cbSide.Name = "cbSide";
            cbSide.Size = new Size(76, 23);
            cbSide.TabIndex = 7;
            cbSide.TextChanged += cbSide_TextChanged;
            // 
            // lbSide
            // 
            lbSide.AutoSize = true;
            lbSide.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbSide.ForeColor = SystemColors.ButtonHighlight;
            lbSide.Location = new Point(10, 67);
            lbSide.Name = "lbSide";
            lbSide.Size = new Size(97, 15);
            lbSide.TabIndex = 6;
            lbSide.Text = "Facing Direction";
            // 
            // lbCommandTitle
            // 
            lbCommandTitle.AutoSize = true;
            lbCommandTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCommandTitle.ForeColor = SystemColors.WindowFrame;
            lbCommandTitle.Location = new Point(10, 172);
            lbCommandTitle.Name = "lbCommandTitle";
            lbCommandTitle.Size = new Size(63, 15);
            lbCommandTitle.TabIndex = 10;
            lbCommandTitle.Text = "Command";
            // 
            // pnOutput
            // 
            pnOutput.BackColor = SystemColors.WindowFrame;
            pnOutput.Controls.Add(lbCopied);
            pnOutput.Controls.Add(btCopy);
            pnOutput.Controls.Add(lbCommand);
            pnOutput.Location = new Point(12, 202);
            pnOutput.Name = "pnOutput";
            pnOutput.Size = new Size(402, 134);
            pnOutput.TabIndex = 11;
            // 
            // lbCopied
            // 
            lbCopied.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCopied.ForeColor = SystemColors.Control;
            lbCopied.Location = new Point(25, 5);
            lbCopied.Name = "lbCopied";
            lbCopied.Size = new Size(67, 17);
            lbCopied.TabIndex = 2;
            lbCopied.Click += label1_Click_1;
            // 
            // btCopy
            // 
            btCopy.BackColor = Color.Transparent;
            btCopy.BackgroundImage = Properties.Resources.white_small_no_border;
            btCopy.BackgroundImageLayout = ImageLayout.Stretch;
            btCopy.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btCopy.FlatAppearance.BorderSize = 0;
            btCopy.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btCopy.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btCopy.FlatStyle = FlatStyle.Flat;
            btCopy.Location = new Point(3, 3);
            btCopy.Name = "btCopy";
            btCopy.Size = new Size(19, 19);
            btCopy.TabIndex = 1;
            btCopy.UseVisualStyleBackColor = false;
            btCopy.MouseUp += btCopy_MouseUp;
            // 
            // lbCommand
            // 
            lbCommand.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCommand.ForeColor = SystemColors.Control;
            lbCommand.Location = new Point(18, 30);
            lbCommand.Name = "lbCommand";
            lbCommand.Size = new Size(362, 74);
            lbCommand.TabIndex = 0;
            lbCommand.Text = "summon armor_stand";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(lbCommandTitle);
            Controls.Add(pnInput);
            Controls.Add(pnOutput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Weapon Display Generator";
            pnInput.ResumeLayout(false);
            pnInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbWeapon).EndInit();
            pnOutput.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbX;
        private Label lbX;
        private TextBox tbY;
        private Label lbY;
        private Label lbZ;
        private TextBox tbZ;
        private Panel pnInput;
        private ComboBox cbWeaponType;
        private Label lbWeaponType;
        private ComboBox cbSide;
        private Label lbSide;
        private Label lbCommandTitle;
        private Panel pnOutput;
        private Button btCopy;
        private Label lbCommand;
        private Label lbCopied;
        private PictureBox pbWeapon;
    }
}
