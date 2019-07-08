namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectNumTours = new System.Windows.Forms.NumericUpDown();
            this.moveSmart = new System.Windows.Forms.RadioButton();
            this.moveDumb = new System.Windows.Forms.RadioButton();
            this.selectRow = new System.Windows.Forms.NumericUpDown();
            this.selectColumn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectNumTours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(148, 191);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Tour";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Move Method";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectNumTours
            // 
            this.selectNumTours.Location = new System.Drawing.Point(125, 155);
            this.selectNumTours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectNumTours.Name = "selectNumTours";
            this.selectNumTours.Size = new System.Drawing.Size(120, 20);
            this.selectNumTours.TabIndex = 2;
            this.selectNumTours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectNumTours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectNumTours.ValueChanged += new System.EventHandler(this.selectNumTours_ValueChanged);
            // 
            // moveSmart
            // 
            this.moveSmart.AutoSize = true;
            this.moveSmart.Checked = true;
            this.moveSmart.Location = new System.Drawing.Point(219, 60);
            this.moveSmart.Name = "moveSmart";
            this.moveSmart.Size = new System.Drawing.Size(66, 17);
            this.moveSmart.TabIndex = 3;
            this.moveSmart.TabStop = true;
            this.moveSmart.Text = "Heuristic";
            this.moveSmart.UseVisualStyleBackColor = true;
            this.moveSmart.CheckedChanged += new System.EventHandler(this.moveSmart_CheckedChanged);
            // 
            // moveDumb
            // 
            this.moveDumb.AutoSize = true;
            this.moveDumb.Location = new System.Drawing.Point(219, 83);
            this.moveDumb.Name = "moveDumb";
            this.moveDumb.Size = new System.Drawing.Size(87, 17);
            this.moveDumb.TabIndex = 4;
            this.moveDumb.TabStop = true;
            this.moveDumb.Text = "Non-heuristic";
            this.moveDumb.UseVisualStyleBackColor = true;
            this.moveDumb.CheckedChanged += new System.EventHandler(this.moveDumb_CheckedChanged);
            // 
            // selectRow
            // 
            this.selectRow.Location = new System.Drawing.Point(29, 102);
            this.selectRow.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.selectRow.Name = "selectRow";
            this.selectRow.Size = new System.Drawing.Size(120, 20);
            this.selectRow.TabIndex = 5;
            this.selectRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectRow.ValueChanged += new System.EventHandler(this.selectRow_ValueChanged);
            // 
            // selectColumn
            // 
            this.selectColumn.Location = new System.Drawing.Point(29, 44);
            this.selectColumn.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.Size = new System.Drawing.Size(120, 20);
            this.selectColumn.TabIndex = 6;
            this.selectColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.selectColumn.ValueChanged += new System.EventHandler(this.selectColumn_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose a Row(0-7)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose a Column (0-7)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "How Many Times Would You Like to Run The Tour?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 226);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectColumn);
            this.Controls.Add(this.selectRow);
            this.Controls.Add(this.moveDumb);
            this.Controls.Add(this.moveSmart);
            this.Controls.Add(this.selectNumTours);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Knight\'s Tour";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectNumTours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectColumn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown selectNumTours;
        private System.Windows.Forms.RadioButton moveSmart;
        private System.Windows.Forms.RadioButton moveDumb;
        private System.Windows.Forms.NumericUpDown selectRow;
        private System.Windows.Forms.NumericUpDown selectColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

