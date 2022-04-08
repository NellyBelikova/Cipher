
namespace Шифратор
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_keyword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_decoder = new System.Windows.Forms.RadioButton();
            this.rd_encoder = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rd_eng = new System.Windows.Forms.RadioButton();
            this.rd_rus = new System.Windows.Forms.RadioButton();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_keyword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rd_decoder);
            this.groupBox1.Controls.Add(this.rd_encoder);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(389, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // textBox_keyword
            // 
            this.textBox_keyword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_keyword.Location = new System.Drawing.Point(17, 114);
            this.textBox_keyword.Multiline = true;
            this.textBox_keyword.Name = "textBox_keyword";
            this.textBox_keyword.Size = new System.Drawing.Size(159, 22);
            this.textBox_keyword.TabIndex = 4;
            this.textBox_keyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_keyword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ключевое слово:";
            // 
            // rd_decoder
            // 
            this.rd_decoder.AutoSize = true;
            this.rd_decoder.Location = new System.Drawing.Point(17, 55);
            this.rd_decoder.Name = "rd_decoder";
            this.rd_decoder.Size = new System.Drawing.Size(114, 23);
            this.rd_decoder.TabIndex = 0;
            this.rd_decoder.Text = "Дешифратор";
            this.rd_decoder.UseVisualStyleBackColor = true;
            // 
            // rd_encoder
            // 
            this.rd_encoder.AutoSize = true;
            this.rd_encoder.Checked = true;
            this.rd_encoder.Location = new System.Drawing.Point(17, 26);
            this.rd_encoder.Name = "rd_encoder";
            this.rd_encoder.Size = new System.Drawing.Size(98, 23);
            this.rd_encoder.TabIndex = 0;
            this.rd_encoder.TabStop = true;
            this.rd_encoder.Text = "Шифратор";
            this.rd_encoder.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(16, 41);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(351, 94);
            this.textBox.TabIndex = 2;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonStart.Location = new System.Drawing.Point(16, 141);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 26);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Пуск";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_result.Location = new System.Drawing.Point(16, 218);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(351, 94);
            this.textBox_result.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат:";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonCopy.Location = new System.Drawing.Point(16, 318);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(115, 26);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonClear.Location = new System.Drawing.Point(137, 318);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 26);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rd_eng);
            this.groupBox2.Controls.Add(this.rd_rus);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(389, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 94);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Алфавит";
            // 
            // rd_eng
            // 
            this.rd_eng.AutoSize = true;
            this.rd_eng.Location = new System.Drawing.Point(17, 55);
            this.rd_eng.Name = "rd_eng";
            this.rd_eng.Size = new System.Drawing.Size(108, 23);
            this.rd_eng.TabIndex = 0;
            this.rd_eng.Text = "Английский";
            this.rd_eng.UseVisualStyleBackColor = true;
            // 
            // rd_rus
            // 
            this.rd_rus.AutoSize = true;
            this.rd_rus.Checked = true;
            this.rd_rus.Location = new System.Drawing.Point(17, 26);
            this.rd_rus.Name = "rd_rus";
            this.rd_rus.Size = new System.Drawing.Size(81, 23);
            this.rd_rus.TabIndex = 0;
            this.rd_rus.TabStop = true;
            this.rd_rus.Text = "Русский";
            this.rd_rus.UseVisualStyleBackColor = true;
            // 
            // buttonPaste
            // 
            this.buttonPaste.Font = new System.Drawing.Font("Calibri", 10F);
            this.buttonPaste.Location = new System.Drawing.Point(137, 141);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(115, 26);
            this.buttonPaste.TabIndex = 8;
            this.buttonPaste.Text = "Вставить";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Шифр Виженера";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_decoder;
        private System.Windows.Forms.RadioButton rd_encoder;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox_keyword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_eng;
        private System.Windows.Forms.RadioButton rd_rus;
        private System.Windows.Forms.Button buttonPaste;
    }
}

