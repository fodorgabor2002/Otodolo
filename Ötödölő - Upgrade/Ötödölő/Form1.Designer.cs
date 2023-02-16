namespace Ötödölő
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
            this.GameFinalStatusButton = new System.Windows.Forms.Button();
            this.NewGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.n1Box = new System.Windows.Forms.TextBox();
            this.n2Box = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.HideRevealButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.n1Get = new System.Windows.Forms.NumericUpDown();
            this.n2Get = new System.Windows.Forms.NumericUpDown();
            this.LoadNumberText = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.n1Get)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2Get)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadNumberText)).BeginInit();
            this.SuspendLayout();
            // 
            // GameFinalStatusButton
            // 
            this.GameFinalStatusButton.Location = new System.Drawing.Point(1778, 148);
            this.GameFinalStatusButton.Margin = new System.Windows.Forms.Padding(4);
            this.GameFinalStatusButton.Name = "GameFinalStatusButton";
            this.GameFinalStatusButton.Size = new System.Drawing.Size(133, 123);
            this.GameFinalStatusButton.TabIndex = 0;
            this.GameFinalStatusButton.UseVisualStyleBackColor = true;
            this.GameFinalStatusButton.Visible = false;
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(1778, 278);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(133, 123);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "Új Játék";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Visible = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1778, 17);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(133, 123);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // n1Box
            // 
            this.n1Box.Enabled = false;
            this.n1Box.Location = new System.Drawing.Point(17, 31);
            this.n1Box.Margin = new System.Windows.Forms.Padding(4);
            this.n1Box.Name = "n1Box";
            this.n1Box.Size = new System.Drawing.Size(240, 22);
            this.n1Box.TabIndex = 3;
            this.n1Box.Text = "Oszlopok száma";
            this.n1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n1Box.TextChanged += new System.EventHandler(this.n1Box_TextChanged);
            // 
            // n2Box
            // 
            this.n2Box.Enabled = false;
            this.n2Box.Location = new System.Drawing.Point(17, 95);
            this.n2Box.Margin = new System.Windows.Forms.Padding(4);
            this.n2Box.Name = "n2Box";
            this.n2Box.Size = new System.Drawing.Size(240, 22);
            this.n2Box.TabIndex = 4;
            this.n2Box.Text = "Sorok száma";
            this.n2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.n2Box.TextChanged += new System.EventHandler(this.n2Box_TextChanged);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(396, 15);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(133, 123);
            this.StartButton.TabIndex = 7;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // HideRevealButton
            // 
            this.HideRevealButton.Location = new System.Drawing.Point(1778, 409);
            this.HideRevealButton.Margin = new System.Windows.Forms.Padding(4);
            this.HideRevealButton.Name = "HideRevealButton";
            this.HideRevealButton.Size = new System.Drawing.Size(133, 123);
            this.HideRevealButton.TabIndex = 9;
            this.HideRevealButton.Text = "Eltűntet";
            this.HideRevealButton.UseVisualStyleBackColor = true;
            this.HideRevealButton.Visible = false;
            this.HideRevealButton.Click += new System.EventHandler(this.HideRevealButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1778, 539);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(133, 123);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Mentés";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(1778, 670);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(133, 123);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(1778, 800);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(133, 123);
            this.LoadButton.TabIndex = 12;
            this.LoadButton.Text = "Betöltés";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // n1Get
            // 
            this.n1Get.Location = new System.Drawing.Point(267, 32);
            this.n1Get.Margin = new System.Windows.Forms.Padding(4);
            this.n1Get.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.n1Get.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.n1Get.Name = "n1Get";
            this.n1Get.Size = new System.Drawing.Size(71, 22);
            this.n1Get.TabIndex = 14;
            this.n1Get.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // n2Get
            // 
            this.n2Get.Location = new System.Drawing.Point(267, 95);
            this.n2Get.Margin = new System.Windows.Forms.Padding(4);
            this.n2Get.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.n2Get.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.n2Get.Name = "n2Get";
            this.n2Get.Size = new System.Drawing.Size(71, 22);
            this.n2Get.TabIndex = 15;
            this.n2Get.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // LoadNumberText
            // 
            this.LoadNumberText.Location = new System.Drawing.Point(1778, 930);
            this.LoadNumberText.Margin = new System.Windows.Forms.Padding(4);
            this.LoadNumberText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LoadNumberText.Name = "LoadNumberText";
            this.LoadNumberText.Size = new System.Drawing.Size(133, 22);
            this.LoadNumberText.TabIndex = 16;
            this.LoadNumberText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.LoadNumberText);
            this.Controls.Add(this.n2Get);
            this.Controls.Add(this.n1Get);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HideRevealButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.n2Box);
            this.Controls.Add(this.n1Box);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.GameFinalStatusButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n1Get)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n2Get)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadNumberText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameFinalStatusButton;
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox n1Box;
        private System.Windows.Forms.TextBox n2Box;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button HideRevealButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.NumericUpDown n1Get;
        private System.Windows.Forms.NumericUpDown n2Get;
        private System.Windows.Forms.NumericUpDown LoadNumberText;
    }
}

