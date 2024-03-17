namespace EngineerCalculator
{
    partial class EngineerCalculator
    {
        //Виконав: Ткаченко Владислав, група ПЗ-2204
        //Дата 29.02.2024, email:vladtk.fm@gmail.com

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineerCalculator));
            seven = new Button();
            eight = new Button();
            nine = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            divide = new Button();
            multiply = new Button();
            minus = new Button();
            plus = new Button();
            remove = new Button();
            zero = new Button();
            clear = new Button();
            output = new RichTextBox();
            Equals = new Button();
            percent = new Button();
            power = new Button();
            sqrt = new Button();
            dot = new Button();
            cotan = new Button();
            tan = new Button();
            cos = new Button();
            sin = new Button();
            exponent = new Button();
            pi = new Button();
            logarifm = new Button();
            radian = new Button();
            factorial = new Button();
            nlogarifn = new Button();
            mod = new Button();
            SuspendLayout();
            // 
            // seven
            // 
            seven.BackColor = Color.Gray;
            resources.ApplyResources(seven, "seven");
            seven.ForeColor = SystemColors.ButtonHighlight;
            seven.Name = "seven";
            seven.UseVisualStyleBackColor = false;
            seven.Click += OnNumberClick;
            // 
            // eight
            // 
            eight.BackColor = Color.Gray;
            resources.ApplyResources(eight, "eight");
            eight.ForeColor = SystemColors.ButtonHighlight;
            eight.Name = "eight";
            eight.UseVisualStyleBackColor = false;
            eight.Click += OnNumberClick;
            // 
            // nine
            // 
            nine.BackColor = Color.Gray;
            resources.ApplyResources(nine, "nine");
            nine.ForeColor = SystemColors.ButtonHighlight;
            nine.Name = "nine";
            nine.UseVisualStyleBackColor = false;
            nine.Click += OnNumberClick;
            // 
            // four
            // 
            four.BackColor = Color.Gray;
            resources.ApplyResources(four, "four");
            four.ForeColor = SystemColors.ButtonHighlight;
            four.Name = "four";
            four.UseVisualStyleBackColor = false;
            four.Click += OnNumberClick;
            // 
            // five
            // 
            five.BackColor = Color.Gray;
            resources.ApplyResources(five, "five");
            five.ForeColor = SystemColors.ButtonHighlight;
            five.Name = "five";
            five.UseVisualStyleBackColor = false;
            five.Click += OnNumberClick;
            // 
            // six
            // 
            six.BackColor = Color.Gray;
            resources.ApplyResources(six, "six");
            six.ForeColor = SystemColors.ButtonHighlight;
            six.Name = "six";
            six.UseVisualStyleBackColor = false;
            six.Click += OnNumberClick;
            // 
            // one
            // 
            one.BackColor = Color.Gray;
            resources.ApplyResources(one, "one");
            one.ForeColor = SystemColors.ButtonHighlight;
            one.Name = "one";
            one.UseVisualStyleBackColor = false;
            one.Click += OnNumberClick;
            // 
            // two
            // 
            two.BackColor = Color.Gray;
            resources.ApplyResources(two, "two");
            two.ForeColor = SystemColors.ButtonHighlight;
            two.Name = "two";
            two.UseVisualStyleBackColor = false;
            two.Click += OnNumberClick;
            // 
            // three
            // 
            three.BackColor = Color.Gray;
            resources.ApplyResources(three, "three");
            three.ForeColor = SystemColors.ButtonHighlight;
            three.Name = "three";
            three.UseVisualStyleBackColor = false;
            three.Click += OnNumberClick;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(divide, "divide");
            divide.ForeColor = SystemColors.ButtonHighlight;
            divide.Name = "divide";
            divide.UseVisualStyleBackColor = false;
            divide.Click += OnActionClick;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(multiply, "multiply");
            multiply.ForeColor = SystemColors.ButtonHighlight;
            multiply.Name = "multiply";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += OnActionClick;
            // 
            // minus
            // 
            minus.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(minus, "minus");
            minus.ForeColor = SystemColors.ButtonHighlight;
            minus.Name = "minus";
            minus.UseVisualStyleBackColor = false;
            minus.Click += OnActionClick;
            // 
            // plus
            // 
            plus.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(plus, "plus");
            plus.ForeColor = SystemColors.ButtonHighlight;
            plus.Name = "plus";
            plus.UseVisualStyleBackColor = false;
            plus.Click += OnActionClick;
            // 
            // remove
            // 
            remove.BackColor = Color.RosyBrown;
            resources.ApplyResources(remove, "remove");
            remove.ForeColor = SystemColors.ButtonHighlight;
            remove.Name = "remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += OnRemoveClick;
            // 
            // zero
            // 
            zero.BackColor = Color.Gray;
            resources.ApplyResources(zero, "zero");
            zero.ForeColor = SystemColors.ButtonHighlight;
            zero.Name = "zero";
            zero.UseVisualStyleBackColor = false;
            zero.Click += OnNumberClick;
            // 
            // clear
            // 
            clear.BackColor = Color.RosyBrown;
            resources.ApplyResources(clear, "clear");
            clear.ForeColor = SystemColors.ButtonHighlight;
            clear.Name = "clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += OnClearClick;
            // 
            // output
            // 
            output.BackColor = SystemColors.ActiveCaptionText;
            output.BorderStyle = BorderStyle.None;
            resources.ApplyResources(output, "output");
            output.ForeColor = Color.White;
            output.Name = "output";
            // 
            // Equals
            // 
            Equals.BackColor = Color.Tomato;
            resources.ApplyResources(Equals, "Equals");
            Equals.ForeColor = SystemColors.ButtonHighlight;
            Equals.Name = "Equals";
            Equals.UseVisualStyleBackColor = false;
            Equals.Click += OnEqualsClick;
            // 
            // percent
            // 
            percent.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(percent, "percent");
            percent.ForeColor = SystemColors.ButtonHighlight;
            percent.Name = "percent";
            percent.UseVisualStyleBackColor = false;
            percent.Click += OnActionClick;
            // 
            // power
            // 
            power.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(power, "power");
            power.ForeColor = SystemColors.ButtonHighlight;
            power.Name = "power";
            power.UseVisualStyleBackColor = false;
            power.Click += OnActionClick;
            // 
            // sqrt
            // 
            sqrt.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(sqrt, "sqrt");
            sqrt.ForeColor = SystemColors.ButtonHighlight;
            sqrt.Name = "sqrt";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += OnActionClick;
            // 
            // dot
            // 
            dot.BackColor = Color.Gray;
            resources.ApplyResources(dot, "dot");
            dot.ForeColor = SystemColors.ButtonHighlight;
            dot.Name = "dot";
            dot.UseVisualStyleBackColor = false;
            dot.Click += OnNumberClick;
            // 
            // cotan
            // 
            cotan.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(cotan, "cotan");
            cotan.ForeColor = SystemColors.ButtonHighlight;
            cotan.Name = "cotan";
            cotan.UseVisualStyleBackColor = false;
            cotan.Click += OnActionClick;
            // 
            // tan
            // 
            tan.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(tan, "tan");
            tan.ForeColor = SystemColors.ButtonHighlight;
            tan.Name = "tan";
            tan.UseVisualStyleBackColor = false;
            tan.Click += OnActionClick;
            // 
            // cos
            // 
            cos.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(cos, "cos");
            cos.ForeColor = SystemColors.ButtonHighlight;
            cos.Name = "cos";
            cos.UseVisualStyleBackColor = false;
            cos.Click += OnActionClick;
            // 
            // sin
            // 
            sin.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(sin, "sin");
            sin.ForeColor = SystemColors.ButtonHighlight;
            sin.Name = "sin";
            sin.UseVisualStyleBackColor = false;
            sin.Click += OnActionClick;
            // 
            // exponent
            // 
            exponent.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(exponent, "exponent");
            exponent.ForeColor = SystemColors.ButtonHighlight;
            exponent.Name = "exponent";
            exponent.UseVisualStyleBackColor = false;
            exponent.Click += OnNumberClick;
            // 
            // pi
            // 
            pi.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(pi, "pi");
            pi.ForeColor = SystemColors.ButtonHighlight;
            pi.Name = "pi";
            pi.UseVisualStyleBackColor = false;
            pi.Click += OnNumberClick;
            // 
            // logarifm
            // 
            logarifm.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(logarifm, "logarifm");
            logarifm.ForeColor = SystemColors.ButtonHighlight;
            logarifm.Name = "logarifm";
            logarifm.UseVisualStyleBackColor = false;
            logarifm.Click += OnActionClick;
            // 
            // radian
            // 
            radian.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(radian, "radian");
            radian.ForeColor = SystemColors.ButtonHighlight;
            radian.Name = "radian";
            radian.UseVisualStyleBackColor = false;
            radian.Click += OnActionClick;
            // 
            // factorial
            // 
            factorial.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(factorial, "factorial");
            factorial.ForeColor = SystemColors.ButtonHighlight;
            factorial.Name = "factorial";
            factorial.UseVisualStyleBackColor = false;
            factorial.Click += OnActionClick;
            // 
            // nlogarifn
            // 
            nlogarifn.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(nlogarifn, "nlogarifn");
            nlogarifn.ForeColor = SystemColors.ButtonHighlight;
            nlogarifn.Name = "nlogarifn";
            nlogarifn.UseVisualStyleBackColor = false;
            nlogarifn.Click += OnActionClick;
            // 
            // mod
            // 
            mod.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(mod, "mod");
            mod.ForeColor = SystemColors.ButtonHighlight;
            mod.Name = "mod";
            mod.UseVisualStyleBackColor = false;
            mod.Click += OnActionClick;
            // 
            // EngineerCalculator
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(mod);
            Controls.Add(nlogarifn);
            Controls.Add(factorial);
            Controls.Add(radian);
            Controls.Add(logarifm);
            Controls.Add(pi);
            Controls.Add(exponent);
            Controls.Add(sin);
            Controls.Add(cos);
            Controls.Add(tan);
            Controls.Add(cotan);
            Controls.Add(dot);
            Controls.Add(sqrt);
            Controls.Add(power);
            Controls.Add(percent);
            Controls.Add(Equals);
            Controls.Add(output);
            Controls.Add(clear);
            Controls.Add(zero);
            Controls.Add(remove);
            Controls.Add(plus);
            Controls.Add(minus);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(seven);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EngineerCalculator";
            ResumeLayout(false);
        }

        #endregion

        private Button one;
        private Button two;
        private Button three;
        private Button four;
        private Button five;
        private Button six;
        private Button seven;
        private Button eight;
        private Button nine;
        private Button divide;
        private Button multiply;
        private Button minus;
        private Button plus;
        private Button remove;
        private Button zero;
        private Button clear;
        private RichTextBox output;
        private Button Equals;
        private Button percent;
        private Button power;
        private Button sqrt;
        private Button dot;
        private Button cotan;
        private Button tan;
        private Button cos;
        private Button sin;
        private Button exponent;
        private Button pi;
        private Button logarifm;
        private Button radian;
        private Button factorial;
        private Button nlogarifn;
        private Button mod;
    }
}
