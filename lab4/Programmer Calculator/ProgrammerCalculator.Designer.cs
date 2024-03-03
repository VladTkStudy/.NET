namespace Calculator
{
    partial class ProgrammerCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgrammerCalculator));
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
            equals = new Button();
            percent = new Button();
            power = new Button();
            sqrt = new Button();
            dot = new Button();
            a = new Button();
            b = new Button();
            c = new Button();
            d = new Button();
            e = new Button();
            f = new Button();
            bin = new Button();
            oct = new Button();
            dec = new Button();
            hex = new Button();
            left = new Button();
            right = new Button();
            nand = new Button();
            nor = new Button();
            not = new Button();
            xor = new Button();
            or = new Button();
            and = new Button();
            SuspendLayout();
            // 
            // seven
            // 
            seven.BackColor = Color.Gray;
            resources.ApplyResources(seven, "seven");
            seven.ForeColor = SystemColors.ActiveCaptionText;
            seven.Name = "seven";
            seven.UseVisualStyleBackColor = false;
            seven.Click += OnSignClick;
            // 
            // eight
            // 
            eight.BackColor = Color.Gray;
            resources.ApplyResources(eight, "eight");
            eight.ForeColor = SystemColors.ActiveCaptionText;
            eight.Name = "eight";
            eight.UseVisualStyleBackColor = false;
            eight.Click += OnSignClick;
            // 
            // nine
            // 
            nine.BackColor = Color.Gray;
            resources.ApplyResources(nine, "nine");
            nine.ForeColor = SystemColors.ActiveCaptionText;
            nine.Name = "nine";
            nine.UseVisualStyleBackColor = false;
            nine.Click += OnSignClick;
            // 
            // four
            // 
            four.BackColor = Color.Gray;
            resources.ApplyResources(four, "four");
            four.ForeColor = SystemColors.ActiveCaptionText;
            four.Name = "four";
            four.UseVisualStyleBackColor = false;
            four.Click += OnSignClick;
            // 
            // five
            // 
            five.BackColor = Color.Gray;
            resources.ApplyResources(five, "five");
            five.ForeColor = SystemColors.ActiveCaptionText;
            five.Name = "five";
            five.UseVisualStyleBackColor = false;
            five.Click += OnSignClick;
            // 
            // six
            // 
            six.BackColor = Color.Gray;
            resources.ApplyResources(six, "six");
            six.ForeColor = SystemColors.ActiveCaptionText;
            six.Name = "six";
            six.UseVisualStyleBackColor = false;
            six.Click += OnSignClick;
            // 
            // one
            // 
            one.BackColor = Color.Gray;
            resources.ApplyResources(one, "one");
            one.ForeColor = SystemColors.ActiveCaptionText;
            one.Name = "one";
            one.UseVisualStyleBackColor = false;
            one.Click += OnSignClick;
            // 
            // two
            // 
            two.BackColor = Color.Gray;
            resources.ApplyResources(two, "two");
            two.ForeColor = SystemColors.ActiveCaptionText;
            two.Name = "two";
            two.UseVisualStyleBackColor = false;
            two.Click += OnSignClick;
            // 
            // three
            // 
            three.BackColor = Color.Gray;
            resources.ApplyResources(three, "three");
            three.ForeColor = SystemColors.ActiveCaptionText;
            three.Name = "three";
            three.UseVisualStyleBackColor = false;
            three.Click += OnSignClick;
            // 
            // divide
            // 
            divide.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(divide, "divide");
            divide.ForeColor = SystemColors.ActiveCaptionText;
            divide.Name = "divide";
            divide.UseVisualStyleBackColor = false;
            divide.Click += OnActionClick;
            // 
            // multiply
            // 
            multiply.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(multiply, "multiply");
            multiply.ForeColor = SystemColors.ActiveCaptionText;
            multiply.Name = "multiply";
            multiply.UseVisualStyleBackColor = false;
            multiply.Click += OnActionClick;
            // 
            // minus
            // 
            minus.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(minus, "minus");
            minus.ForeColor = SystemColors.ActiveCaptionText;
            minus.Name = "minus";
            minus.UseVisualStyleBackColor = false;
            minus.Click += OnActionClick;
            // 
            // plus
            // 
            plus.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(plus, "plus");
            plus.ForeColor = SystemColors.ActiveCaptionText;
            plus.Name = "plus";
            plus.UseVisualStyleBackColor = false;
            plus.Click += OnActionClick;
            // 
            // remove
            // 
            remove.BackColor = Color.RosyBrown;
            resources.ApplyResources(remove, "remove");
            remove.ForeColor = SystemColors.ActiveCaptionText;
            remove.Name = "remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += OnRemoveClick;
            // 
            // zero
            // 
            zero.BackColor = Color.Gray;
            resources.ApplyResources(zero, "zero");
            zero.ForeColor = SystemColors.ActiveCaptionText;
            zero.Name = "zero";
            zero.UseVisualStyleBackColor = false;
            zero.Click += OnSignClick;
            // 
            // clear
            // 
            clear.BackColor = Color.RosyBrown;
            resources.ApplyResources(clear, "clear");
            clear.ForeColor = SystemColors.ActiveCaptionText;
            clear.Name = "clear";
            clear.UseVisualStyleBackColor = false;
            clear.Click += OnClearClick;
            // 
            // output
            // 
            output.BackColor = SystemColors.ButtonShadow;
            output.BorderStyle = BorderStyle.None;
            resources.ApplyResources(output, "output");
            output.ForeColor = Color.Black;
            output.Name = "output";
            // 
            // equals
            // 
            equals.BackColor = Color.Tomato;
            resources.ApplyResources(equals, "equals");
            equals.ForeColor = SystemColors.ActiveCaptionText;
            equals.Name = "equals";
            equals.UseVisualStyleBackColor = false;
            equals.Click += OnEqualsClick;
            // 
            // percent
            // 
            percent.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(percent, "percent");
            percent.ForeColor = SystemColors.ActiveCaptionText;
            percent.Name = "percent";
            percent.UseVisualStyleBackColor = false;
            percent.Click += OnActionClick;
            // 
            // power
            // 
            power.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(power, "power");
            power.ForeColor = SystemColors.ActiveCaptionText;
            power.Name = "power";
            power.UseVisualStyleBackColor = false;
            power.Click += OnActionClick;
            // 
            // sqrt
            // 
            sqrt.BackColor = SystemColors.WindowFrame;
            resources.ApplyResources(sqrt, "sqrt");
            sqrt.ForeColor = SystemColors.ActiveCaptionText;
            sqrt.Name = "sqrt";
            sqrt.UseVisualStyleBackColor = false;
            sqrt.Click += OnActionClick;
            // 
            // dot
            // 
            dot.BackColor = Color.Gray;
            resources.ApplyResources(dot, "dot");
            dot.ForeColor = SystemColors.ActiveCaptionText;
            dot.Name = "dot";
            dot.UseVisualStyleBackColor = false;
            dot.Click += OnSignClick;
            // 
            // a
            // 
            a.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(a, "a");
            a.ForeColor = SystemColors.ActiveCaptionText;
            a.Name = "a";
            a.UseVisualStyleBackColor = false;
            a.Click += OnSignClick;
            // 
            // b
            // 
            b.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(b, "b");
            b.ForeColor = SystemColors.ActiveCaptionText;
            b.Name = "b";
            b.UseVisualStyleBackColor = false;
            b.Click += OnSignClick;
            // 
            // c
            // 
            c.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(c, "c");
            c.ForeColor = SystemColors.ActiveCaptionText;
            c.Name = "c";
            c.UseVisualStyleBackColor = false;
            c.Click += OnSignClick;
            // 
            // d
            // 
            d.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(d, "d");
            d.ForeColor = SystemColors.ActiveCaptionText;
            d.Name = "d";
            d.UseVisualStyleBackColor = false;
            d.Click += OnSignClick;
            // 
            // e
            // 
            e.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(e, "e");
            e.ForeColor = SystemColors.ActiveCaptionText;
            e.Name = "e";
            e.UseVisualStyleBackColor = false;
            e.Click += OnSignClick;
            // 
            // f
            // 
            f.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(f, "f");
            f.ForeColor = SystemColors.ActiveCaptionText;
            f.Name = "f";
            f.UseVisualStyleBackColor = false;
            f.Click += OnSignClick;
            // 
            // bin
            // 
            bin.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(bin, "bin");
            bin.ForeColor = SystemColors.ActiveCaptionText;
            bin.Name = "bin";
            bin.UseVisualStyleBackColor = false;
            bin.Click += OnSwitchBitRateClick;
            // 
            // oct
            // 
            oct.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(oct, "oct");
            oct.ForeColor = SystemColors.ActiveCaptionText;
            oct.Name = "oct";
            oct.UseVisualStyleBackColor = false;
            oct.Click += OnSwitchBitRateClick;
            // 
            // dec
            // 
            dec.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(dec, "dec");
            dec.ForeColor = SystemColors.ActiveCaptionText;
            dec.Name = "dec";
            dec.UseVisualStyleBackColor = false;
            dec.Click += OnSwitchBitRateClick;
            // 
            // hex
            // 
            hex.BackColor = SystemColors.InactiveCaption;
            resources.ApplyResources(hex, "hex");
            hex.ForeColor = SystemColors.ActiveCaptionText;
            hex.Name = "hex";
            hex.UseVisualStyleBackColor = false;
            hex.Click += OnSwitchBitRateClick;
            // 
            // left
            // 
            left.BackColor = Color.BurlyWood;
            resources.ApplyResources(left, "left");
            left.ForeColor = SystemColors.ActiveCaptionText;
            left.Name = "left";
            left.UseVisualStyleBackColor = false;
            left.Click += OnActionClick;
            // 
            // right
            // 
            right.BackColor = Color.BurlyWood;
            resources.ApplyResources(right, "right");
            right.ForeColor = SystemColors.ActiveCaptionText;
            right.Name = "right";
            right.UseVisualStyleBackColor = false;
            right.Click += OnActionClick;
            // 
            // nand
            // 
            nand.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(nand, "nand");
            nand.ForeColor = SystemColors.ActiveCaptionText;
            nand.Name = "nand";
            nand.UseVisualStyleBackColor = false;
            nand.Click += OnActionClick;
            // 
            // nor
            // 
            nor.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(nor, "nor");
            nor.ForeColor = SystemColors.ActiveCaptionText;
            nor.Name = "nor";
            nor.UseVisualStyleBackColor = false;
            nor.Click += OnActionClick;
            // 
            // not
            // 
            not.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(not, "not");
            not.ForeColor = SystemColors.ActiveCaptionText;
            not.Name = "not";
            not.UseVisualStyleBackColor = false;
            not.Click += OnActionClick;
            // 
            // xor
            // 
            xor.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(xor, "xor");
            xor.ForeColor = SystemColors.ActiveCaptionText;
            xor.Name = "xor";
            xor.UseVisualStyleBackColor = false;
            xor.Click += OnActionClick;
            // 
            // or
            // 
            or.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(or, "or");
            or.ForeColor = SystemColors.ActiveCaptionText;
            or.Name = "or";
            or.UseVisualStyleBackColor = false;
            or.Click += OnActionClick;
            // 
            // and
            // 
            and.BackColor = Color.FromArgb(80, 80, 80);
            resources.ApplyResources(and, "and");
            and.ForeColor = SystemColors.ActiveCaptionText;
            and.Name = "and";
            and.UseVisualStyleBackColor = false;
            and.Click += OnActionClick;
            // 
            // ProgrammerCalculator
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(nand);
            Controls.Add(nor);
            Controls.Add(not);
            Controls.Add(xor);
            Controls.Add(or);
            Controls.Add(and);
            Controls.Add(right);
            Controls.Add(left);
            Controls.Add(hex);
            Controls.Add(dec);
            Controls.Add(oct);
            Controls.Add(bin);
            Controls.Add(f);
            Controls.Add(e);
            Controls.Add(d);
            Controls.Add(c);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(dot);
            Controls.Add(sqrt);
            Controls.Add(power);
            Controls.Add(percent);
            Controls.Add(equals);
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
            Name = "ProgrammerCalculator";
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
        private Button equals;
        private Button percent;
        private Button power;
        private Button sqrt;
        private Button dot;
        private Button a;
        private Button b;
        private Button c;
        private Button d;
        private Button e;
        private Button f;
        private Button bin;
        private Button oct;
        private Button dec;
        private Button hex;
        private Button left;
        private Button right;
        private Button nand;
        private Button nor;
        private Button not;
        private Button xor;
        private Button or;
        private Button and;
    }
}
