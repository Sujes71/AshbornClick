namespace AshbornClick
{
    partial class AshbornClick
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AshbornClick));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMultiply = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelMultiply = new System.Windows.Forms.Label();
            this.checkBoxPress = new System.Windows.Forms.CheckBox();
            this.labelCounter = new System.Windows.Forms.Label();
            this.checkBoxJump = new System.Windows.Forms.CheckBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.colorPress = new System.Windows.Forms.Button();
            this.colorJump = new System.Windows.Forms.Button();
            this.colorGo = new System.Windows.Forms.Button();
            this.checkboxGo = new System.Windows.Forms.CheckBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiply)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(19, 52);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownSpeed.TabIndex = 3;
            // 
            // numericUpDownMultiply
            // 
            this.numericUpDownMultiply.Location = new System.Drawing.Point(156, 52);
            this.numericUpDownMultiply.Name = "numericUpDownMultiply";
            this.numericUpDownMultiply.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownMultiply.TabIndex = 4;
            this.numericUpDownMultiply.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(49, 33);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(48, 16);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Speed";
            // 
            // labelMultiply
            // 
            this.labelMultiply.AutoSize = true;
            this.labelMultiply.Location = new System.Drawing.Point(182, 33);
            this.labelMultiply.Name = "labelMultiply";
            this.labelMultiply.Size = new System.Drawing.Size(52, 16);
            this.labelMultiply.TabIndex = 9;
            this.labelMultiply.Text = "Multiply";
            // 
            // checkBoxPress
            // 
            this.checkBoxPress.AutoSize = true;
            this.checkBoxPress.Location = new System.Drawing.Point(312, 29);
            this.checkBoxPress.Name = "checkBoxPress";
            this.checkBoxPress.Size = new System.Drawing.Size(64, 20);
            this.checkBoxPress.TabIndex = 10;
            this.checkBoxPress.Text = "Press";
            this.checkBoxPress.UseVisualStyleBackColor = true;
            this.checkBoxPress.CheckedChanged += new System.EventHandler(this.checkBoxPress_CheckedChanged);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(202, 106);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(14, 16);
            this.labelCounter.TabIndex = 11;
            this.labelCounter.Text = "0";
            // 
            // checkBoxJump
            // 
            this.checkBoxJump.AutoSize = true;
            this.checkBoxJump.Location = new System.Drawing.Point(312, 55);
            this.checkBoxJump.Name = "checkBoxJump";
            this.checkBoxJump.Size = new System.Drawing.Size(62, 20);
            this.checkBoxJump.TabIndex = 12;
            this.checkBoxJump.Text = "Jump";
            this.checkBoxJump.UseVisualStyleBackColor = true;
            this.checkBoxJump.CheckedChanged += new System.EventHandler(this.checkBoxJump_CheckedChanged);
            // 
            // timer3
            // 
            this.timer3.Interval = 150;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // colorPress
            // 
            this.colorPress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorPress.Enabled = false;
            this.colorPress.Location = new System.Drawing.Point(382, 27);
            this.colorPress.Name = "colorPress";
            this.colorPress.Size = new System.Drawing.Size(24, 23);
            this.colorPress.TabIndex = 13;
            this.colorPress.UseVisualStyleBackColor = false;
            // 
            // colorJump
            // 
            this.colorJump.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorJump.Enabled = false;
            this.colorJump.Location = new System.Drawing.Point(382, 53);
            this.colorJump.Name = "colorJump";
            this.colorJump.Size = new System.Drawing.Size(24, 23);
            this.colorJump.TabIndex = 14;
            this.colorJump.UseVisualStyleBackColor = false;
            // 
            // colorGo
            // 
            this.colorGo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.colorGo.Enabled = false;
            this.colorGo.Location = new System.Drawing.Point(382, 79);
            this.colorGo.Name = "colorGo";
            this.colorGo.Size = new System.Drawing.Size(24, 23);
            this.colorGo.TabIndex = 16;
            this.colorGo.UseVisualStyleBackColor = false;
            // 
            // checkboxGo
            // 
            this.checkboxGo.AutoSize = true;
            this.checkboxGo.Location = new System.Drawing.Point(312, 81);
            this.checkboxGo.Name = "checkboxGo";
            this.checkboxGo.Size = new System.Drawing.Size(47, 20);
            this.checkboxGo.TabIndex = 15;
            this.checkboxGo.Text = "Go";
            this.checkboxGo.UseVisualStyleBackColor = true;
            this.checkboxGo.CheckedChanged += new System.EventHandler(this.checkboxGo_CheckedChanged);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // AshbornClick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AshbornClick.Properties.Resources.eyes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 131);
            this.Controls.Add(this.colorGo);
            this.Controls.Add(this.checkboxGo);
            this.Controls.Add(this.colorJump);
            this.Controls.Add(this.colorPress);
            this.Controls.Add(this.checkBoxJump);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.checkBoxPress);
            this.Controls.Add(this.labelMultiply);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownMultiply);
            this.Controls.Add(this.numericUpDownSpeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(439, 178);
            this.Name = "AshbornClick";
            this.Text = " AshbornClick";
            this.Load += new System.EventHandler(this.AshbornClick_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMultiply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownMultiply;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelMultiply;
        private System.Windows.Forms.CheckBox checkBoxPress;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.CheckBox checkBoxJump;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button colorPress;
        private System.Windows.Forms.Button colorJump;
        private System.Windows.Forms.Button colorGo;
        private System.Windows.Forms.CheckBox checkboxGo;
        private System.Windows.Forms.Timer timer4;
    }
}

