namespace ImageFilters
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.setButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.size3radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.size9radioButton = new System.Windows.Forms.RadioButton();
            this.size7radioButton = new System.Windows.Forms.RadioButton();
            this.size5radioButton = new System.Windows.Forms.RadioButton();
            this.setDefaultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setButton.Location = new System.Drawing.Point(345, 12);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(120, 31);
            this.setButton.TabIndex = 1;
            this.setButton.Text = "Set custom";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(16, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(461, 342);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // size3radioButton
            // 
            this.size3radioButton.AutoSize = true;
            this.size3radioButton.Location = new System.Drawing.Point(16, 21);
            this.size3radioButton.Name = "size3radioButton";
            this.size3radioButton.Size = new System.Drawing.Size(39, 24);
            this.size3radioButton.TabIndex = 4;
            this.size3radioButton.TabStop = true;
            this.size3radioButton.Text = "3";
            this.size3radioButton.UseVisualStyleBackColor = true;
            this.size3radioButton.CheckedChanged += new System.EventHandler(this.size3radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.size9radioButton);
            this.groupBox1.Controls.Add(this.size7radioButton);
            this.groupBox1.Controls.Add(this.size5radioButton);
            this.groupBox1.Controls.Add(this.size3radioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structure element size";
            // 
            // size9radioButton
            // 
            this.size9radioButton.AutoSize = true;
            this.size9radioButton.Location = new System.Drawing.Point(80, 48);
            this.size9radioButton.Name = "size9radioButton";
            this.size9radioButton.Size = new System.Drawing.Size(39, 24);
            this.size9radioButton.TabIndex = 7;
            this.size9radioButton.TabStop = true;
            this.size9radioButton.Text = "9";
            this.size9radioButton.UseVisualStyleBackColor = true;
            this.size9radioButton.CheckedChanged += new System.EventHandler(this.size9radioButton_CheckedChanged);
            // 
            // size7radioButton
            // 
            this.size7radioButton.AutoSize = true;
            this.size7radioButton.Location = new System.Drawing.Point(80, 21);
            this.size7radioButton.Name = "size7radioButton";
            this.size7radioButton.Size = new System.Drawing.Size(39, 24);
            this.size7radioButton.TabIndex = 6;
            this.size7radioButton.TabStop = true;
            this.size7radioButton.Text = "7";
            this.size7radioButton.UseVisualStyleBackColor = true;
            this.size7radioButton.CheckedChanged += new System.EventHandler(this.size7radioButton_CheckedChanged);
            // 
            // size5radioButton
            // 
            this.size5radioButton.AutoSize = true;
            this.size5radioButton.Location = new System.Drawing.Point(16, 48);
            this.size5radioButton.Name = "size5radioButton";
            this.size5radioButton.Size = new System.Drawing.Size(39, 24);
            this.size5radioButton.TabIndex = 5;
            this.size5radioButton.TabStop = true;
            this.size5radioButton.Text = "5";
            this.size5radioButton.UseVisualStyleBackColor = true;
            this.size5radioButton.CheckedChanged += new System.EventHandler(this.size5radioButton_CheckedChanged);
            // 
            // setDefaultButton
            // 
            this.setDefaultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setDefaultButton.Location = new System.Drawing.Point(345, 53);
            this.setDefaultButton.Name = "setDefaultButton";
            this.setDefaultButton.Size = new System.Drawing.Size(120, 31);
            this.setDefaultButton.TabIndex = 6;
            this.setDefaultButton.Text = "Set default";
            this.setDefaultButton.UseVisualStyleBackColor = true;
            this.setDefaultButton.Click += new System.EventHandler(this.setDefaultButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 484);
            this.Controls.Add(this.setDefaultButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.setButton);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton size3radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton size9radioButton;
        private System.Windows.Forms.RadioButton size7radioButton;
        private System.Windows.Forms.RadioButton size5radioButton;
        private System.Windows.Forms.Button setDefaultButton;
    }
}