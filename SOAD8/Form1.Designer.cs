namespace SOAD8
{
    partial class HashForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.multiplyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.foldingTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.midSquareTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.divisionMethodTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comparisonAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openAdressingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openAdressingFoundTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.openAdressingComparesTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chainingComparesTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chainingFoundTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chainingTimeTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лабораторная работа №8";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.calculateButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.multiplyTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.foldingTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.midSquareTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.divisionMethodTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comparisonAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 272);
            this.panel1.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(135, 225);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(125, 30);
            this.calculateButton.TabIndex = 12;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.onCalculateClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Метод умножения";
            // 
            // multiplyTextBox
            // 
            this.multiplyTextBox.Location = new System.Drawing.Point(216, 183);
            this.multiplyTextBox.Name = "multiplyTextBox";
            this.multiplyTextBox.Size = new System.Drawing.Size(104, 22);
            this.multiplyTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Метод свертывания";
            // 
            // foldingTextBox
            // 
            this.foldingTextBox.Location = new System.Drawing.Point(216, 155);
            this.foldingTextBox.Name = "foldingTextBox";
            this.foldingTextBox.Size = new System.Drawing.Size(104, 22);
            this.foldingTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Метод середины квадрата";
            // 
            // midSquareTextBox
            // 
            this.midSquareTextBox.Location = new System.Drawing.Point(216, 127);
            this.midSquareTextBox.Name = "midSquareTextBox";
            this.midSquareTextBox.Size = new System.Drawing.Size(104, 22);
            this.midSquareTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Метод деления";
            // 
            // divisionMethodTextBox
            // 
            this.divisionMethodTextBox.Location = new System.Drawing.Point(216, 99);
            this.divisionMethodTextBox.Name = "divisionMethodTextBox";
            this.divisionMethodTextBox.Size = new System.Drawing.Size(104, 22);
            this.divisionMethodTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество сравнений";
            // 
            // comparisonAmount
            // 
            this.comparisonAmount.Location = new System.Drawing.Point(207, 53);
            this.comparisonAmount.Name = "comparisonAmount";
            this.comparisonAmount.Size = new System.Drawing.Size(123, 22);
            this.comparisonAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сравнение функций хэширования";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 271);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 270);
            this.panel3.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(30, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Сравнение методов разрешения коллизий";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(89, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Метод открытой адресации";
            // 
            // openAdressingTimeTextBox
            // 
            this.openAdressingTimeTextBox.Location = new System.Drawing.Point(43, 409);
            this.openAdressingTimeTextBox.Name = "openAdressingTimeTextBox";
            this.openAdressingTimeTextBox.Size = new System.Drawing.Size(85, 22);
            this.openAdressingTimeTextBox.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Время";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Найдено";
            // 
            // openAdressingFoundTextBox
            // 
            this.openAdressingFoundTextBox.Location = new System.Drawing.Point(266, 409);
            this.openAdressingFoundTextBox.Name = "openAdressingFoundTextBox";
            this.openAdressingFoundTextBox.Size = new System.Drawing.Size(85, 22);
            this.openAdressingFoundTextBox.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(162, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Сравнения";
            // 
            // openAdressingComparesTextBox
            // 
            this.openAdressingComparesTextBox.Location = new System.Drawing.Point(156, 409);
            this.openAdressingComparesTextBox.Name = "openAdressingComparesTextBox";
            this.openAdressingComparesTextBox.Size = new System.Drawing.Size(85, 22);
            this.openAdressingComparesTextBox.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 484);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Сравнения";
            // 
            // chainingComparesTextBox
            // 
            this.chainingComparesTextBox.Location = new System.Drawing.Point(156, 503);
            this.chainingComparesTextBox.Name = "chainingComparesTextBox";
            this.chainingComparesTextBox.Size = new System.Drawing.Size(85, 22);
            this.chainingComparesTextBox.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 484);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "Найдено";
            // 
            // chainingFoundTextBox
            // 
            this.chainingFoundTextBox.Location = new System.Drawing.Point(266, 503);
            this.chainingFoundTextBox.Name = "chainingFoundTextBox";
            this.chainingFoundTextBox.Size = new System.Drawing.Size(85, 22);
            this.chainingFoundTextBox.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 484);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 12;
            this.label15.Text = "Время";
            // 
            // chainingTimeTextBox
            // 
            this.chainingTimeTextBox.Location = new System.Drawing.Point(43, 503);
            this.chainingTimeTextBox.Name = "chainingTimeTextBox";
            this.chainingTimeTextBox.Size = new System.Drawing.Size(85, 22);
            this.chainingTimeTextBox.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(141, 456);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 10;
            this.label16.Text = "Метод цепочек";
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(122, 542);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(138, 27);
            this.compareButton.TabIndex = 17;
            this.compareButton.Text = "Сравнить";
            this.compareButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(122, 587);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(133, 29);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Выйти";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.onCloseClick);
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 628);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chainingComparesTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chainingFoundTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chainingTimeTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.openAdressingComparesTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.openAdressingFoundTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.openAdressingTimeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "HashForm";
            this.Text = "Фомин 24ВП1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox multiplyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox foldingTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox midSquareTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox divisionMethodTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown comparisonAmount;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox openAdressingTimeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox openAdressingFoundTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox openAdressingComparesTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox chainingComparesTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox chainingFoundTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox chainingTimeTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.Button closeButton;
    }
}

