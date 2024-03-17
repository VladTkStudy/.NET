namespace ProgrammerCalculator
{
    partial class CalculatorManager
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 03.03.2024, email:vladtk.fm@gmail.com

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorManager));
            start = new Button();
            options = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(start, "start");
            start.Name = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += StartClick;
            // 
            // options
            // 
            options.BackColor = Color.Silver;
            resources.ApplyResources(options, "options");
            options.Name = "options";
            options.UseVisualStyleBackColor = false;
            options.Click += OptionsClick;
            // 
            // radioButton1
            // 
            resources.ApplyResources(radioButton1, "radioButton1");
            radioButton1.ForeColor = SystemColors.Control;
            radioButton1.Name = "radioButton1";
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RadioButtonChecked;
            // 
            // radioButton2
            // 
            resources.ApplyResources(radioButton2, "radioButton2");
            radioButton2.ForeColor = SystemColors.Control;
            radioButton2.Name = "radioButton2";
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += RadioButtonChecked;
            // 
            // radioButton3
            // 
            resources.ApplyResources(radioButton3, "radioButton3");
            radioButton3.ForeColor = SystemColors.Control;
            radioButton3.Name = "radioButton3";
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += RadioButtonChecked;
            // 
            // CalculatorManager
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(options);
            Controls.Add(start);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CalculatorManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button start;
        private Button options;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}
