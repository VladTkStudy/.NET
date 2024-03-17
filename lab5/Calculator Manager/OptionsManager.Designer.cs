namespace CalculatorManager
{
    partial class OptionsManager
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
            apply = new Button();
            cancel = new Button();
            colorLabel = new Label();
            fontLabel = new Label();
            dark = new RadioButton();
            white = new RadioButton();
            otherLabel = new Label();
            fontStyle = new ComboBox();
            fontSize = new ComboBox();
            showHints = new CheckBox();
            hideOnStart = new CheckBox();
            SuspendLayout();
            // 
            // apply
            // 
            apply.BackColor = Color.FromArgb(192, 255, 192);
            apply.FlatStyle = FlatStyle.Flat;
            apply.Font = new Font("Segoe UI", 12F);
            apply.ImeMode = ImeMode.NoControl;
            apply.Location = new Point(179, 370);
            apply.Name = "apply";
            apply.Size = new Size(151, 68);
            apply.TabIndex = 1;
            apply.Text = "Apply";
            apply.UseVisualStyleBackColor = false;
            apply.Click += ApplyClick;
            // 
            // cancel
            // 
            cancel.BackColor = Color.FromArgb(255, 192, 192);
            cancel.FlatStyle = FlatStyle.Flat;
            cancel.Font = new Font("Segoe UI", 12F);
            cancel.ImeMode = ImeMode.NoControl;
            cancel.Location = new Point(12, 370);
            cancel.Name = "cancel";
            cancel.Size = new Size(151, 68);
            cancel.TabIndex = 2;
            cancel.Text = "Cancel";
            cancel.UseVisualStyleBackColor = false;
            cancel.Click += CancelClick;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 15F);
            colorLabel.ForeColor = SystemColors.ButtonShadow;
            colorLabel.Location = new Point(12, 9);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(157, 35);
            colorLabel.TabIndex = 3;
            colorLabel.Text = "Color Theme";
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Font = new Font("Segoe UI", 15F);
            fontLabel.ForeColor = SystemColors.ButtonShadow;
            fontLabel.Location = new Point(12, 105);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(64, 35);
            fontLabel.TabIndex = 4;
            fontLabel.Text = "Font";
            // 
            // dark
            // 
            dark.AutoSize = true;
            dark.Font = new Font("Segoe UI", 10F);
            dark.ForeColor = SystemColors.Control;
            dark.Location = new Point(15, 47);
            dark.Name = "dark";
            dark.Size = new Size(66, 27);
            dark.TabIndex = 5;
            dark.TabStop = true;
            dark.Text = "Dark";
            dark.UseVisualStyleBackColor = true;
            dark.CheckedChanged += ColorThemeCheckedChanged;
            // 
            // white
            // 
            white.AutoSize = true;
            white.Font = new Font("Segoe UI", 10F);
            white.ForeColor = SystemColors.Control;
            white.Location = new Point(94, 47);
            white.Name = "white";
            white.Size = new Size(76, 27);
            white.TabIndex = 5;
            white.TabStop = true;
            white.Text = "White";
            white.UseVisualStyleBackColor = true;
            white.CheckedChanged += ColorThemeCheckedChanged;
            // 
            // otherLabel
            // 
            otherLabel.AutoSize = true;
            otherLabel.Font = new Font("Segoe UI", 15F);
            otherLabel.ForeColor = SystemColors.ButtonShadow;
            otherLabel.Location = new Point(12, 207);
            otherLabel.Name = "otherLabel";
            otherLabel.Size = new Size(78, 35);
            otherLabel.TabIndex = 6;
            otherLabel.Text = "Other";
            // 
            // fontStyle
            // 
            fontStyle.BackColor = SystemColors.WindowFrame;
            fontStyle.FlatStyle = FlatStyle.Flat;
            fontStyle.ForeColor = SystemColors.Menu;
            fontStyle.FormattingEnabled = true;
            fontStyle.ImeMode = ImeMode.NoControl;
            fontStyle.Location = new Point(12, 143);
            fontStyle.Name = "fontStyle";
            fontStyle.Size = new Size(151, 28);
            fontStyle.TabIndex = 7;
            fontStyle.SelectedIndexChanged += FontStyleSelectedIndexChanged;
            // 
            // fontSize
            // 
            fontSize.BackColor = SystemColors.WindowFrame;
            fontSize.FlatStyle = FlatStyle.Flat;
            fontSize.ForeColor = SystemColors.Menu;
            fontSize.FormattingEnabled = true;
            fontSize.Location = new Point(169, 143);
            fontSize.Name = "fontSize";
            fontSize.Size = new Size(96, 28);
            fontSize.TabIndex = 7;
            fontSize.SelectedIndexChanged += FontSizeSelectedIndexChanged;
            // 
            // showHints
            // 
            showHints.AutoSize = true;
            showHints.Font = new Font("Segoe UI", 10F);
            showHints.ForeColor = SystemColors.Control;
            showHints.Location = new Point(12, 245);
            showHints.Name = "showHints";
            showHints.Size = new Size(115, 27);
            showHints.TabIndex = 8;
            showHints.Text = "Show hints";
            showHints.UseVisualStyleBackColor = true;
            showHints.CheckedChanged += ShowHintsCheckedChanged;
            // 
            // hideOnStart
            // 
            hideOnStart.AutoSize = true;
            hideOnStart.Font = new Font("Segoe UI", 10F);
            hideOnStart.ForeColor = SystemColors.Control;
            hideOnStart.Location = new Point(12, 278);
            hideOnStart.Name = "hideOnStart";
            hideOnStart.Size = new Size(131, 27);
            hideOnStart.TabIndex = 8;
            hideOnStart.Text = "Hide on start";
            hideOnStart.UseVisualStyleBackColor = true;
            hideOnStart.CheckedChanged += HideOnStartCheckedChanged;
            // 
            // OptionsManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(342, 450);
            Controls.Add(hideOnStart);
            Controls.Add(showHints);
            Controls.Add(fontSize);
            Controls.Add(fontStyle);
            Controls.Add(otherLabel);
            Controls.Add(white);
            Controls.Add(dark);
            Controls.Add(fontLabel);
            Controls.Add(colorLabel);
            Controls.Add(cancel);
            Controls.Add(apply);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "OptionsManager";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button apply;
        private Button cancel;
        private Label colorLabel;
        private Label fontLabel;
        private RadioButton dark;
        private RadioButton white;
        private Label otherLabel;
        private ComboBox fontStyle;
        private ComboBox fontSize;
        private CheckBox showHints;
        private CheckBox hideOnStart;
    }
}