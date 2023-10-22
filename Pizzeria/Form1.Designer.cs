namespace Pizzeria
{
    partial class Form1
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
            this.cheese = new System.Windows.Forms.Button();
            this.mushrum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ananas = new System.Windows.Forms.Button();
            this.peperoni = new System.Windows.Forms.Button();
            this.pomodoro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cheese
            // 
            this.cheese.Location = new System.Drawing.Point(81, 24);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(120, 43);
            this.cheese.TabIndex = 0;
            this.cheese.Text = "add";
            this.cheese.UseVisualStyleBackColor = true;
            this.cheese.Click += new System.EventHandler(this.cheese_Click);
            // 
            // mushrum
            // 
            this.mushrum.Location = new System.Drawing.Point(81, 75);
            this.mushrum.Name = "mushrum";
            this.mushrum.Size = new System.Drawing.Size(120, 40);
            this.mushrum.TabIndex = 1;
            this.mushrum.Text = "add";
            this.mushrum.UseVisualStyleBackColor = true;
            this.mushrum.Click += new System.EventHandler(this.mushrum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cheese";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mushrum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 4;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(246, 175);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(75, 23);
            this.result.TabIndex = 5;
            this.result.Text = "result";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Annanas";
            // 
            // ananas
            // 
            this.ananas.Location = new System.Drawing.Point(81, 125);
            this.ananas.Name = "ananas";
            this.ananas.Size = new System.Drawing.Size(120, 40);
            this.ananas.TabIndex = 7;
            this.ananas.Text = "add";
            this.ananas.UseVisualStyleBackColor = true;
            this.ananas.Click += new System.EventHandler(this.ananas_Click);
            // 
            // peperoni
            // 
            this.peperoni.Location = new System.Drawing.Point(235, 27);
            this.peperoni.Name = "peperoni";
            this.peperoni.Size = new System.Drawing.Size(120, 40);
            this.peperoni.TabIndex = 8;
            this.peperoni.Text = "peperoni";
            this.peperoni.UseVisualStyleBackColor = true;
            this.peperoni.Click += new System.EventHandler(this.peperoni_Click);
            // 
            // pomodoro
            // 
            this.pomodoro.Location = new System.Drawing.Point(235, 88);
            this.pomodoro.Name = "pomodoro";
            this.pomodoro.Size = new System.Drawing.Size(120, 40);
            this.pomodoro.TabIndex = 9;
            this.pomodoro.Text = "pomodoro";
            this.pomodoro.UseVisualStyleBackColor = true;
            this.pomodoro.Click += new System.EventHandler(this.pomodoro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 242);
            this.Controls.Add(this.pomodoro);
            this.Controls.Add(this.peperoni);
            this.Controls.Add(this.ananas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mushrum);
            this.Controls.Add(this.cheese);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cheese;
        private System.Windows.Forms.Button mushrum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ananas;
        private System.Windows.Forms.Button peperoni;
        private System.Windows.Forms.Button pomodoro;
    }
}

