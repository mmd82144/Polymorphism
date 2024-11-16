namespace tamrin6
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
            this.ButtonCar = new System.Windows.Forms.Button();
            this.ButtonBike = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCar
            // 
            this.ButtonCar.Location = new System.Drawing.Point(12, 12);
            this.ButtonCar.Name = "ButtonCar";
            this.ButtonCar.Size = new System.Drawing.Size(309, 114);
            this.ButtonCar.TabIndex = 0;
            this.ButtonCar.Text = "Car info";
            this.ButtonCar.UseVisualStyleBackColor = true;
            this.ButtonCar.Click += new System.EventHandler(this.ButtonCar_Click);
            // 
            // ButtonBike
            // 
            this.ButtonBike.Location = new System.Drawing.Point(12, 141);
            this.ButtonBike.Name = "ButtonBike";
            this.ButtonBike.Size = new System.Drawing.Size(309, 114);
            this.ButtonBike.TabIndex = 1;
            this.ButtonBike.Text = "Bike info";
            this.ButtonBike.UseVisualStyleBackColor = true;
            this.ButtonBike.Click += new System.EventHandler(this.ButtonBike_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 278);
            this.Controls.Add(this.ButtonBike);
            this.Controls.Add(this.ButtonCar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCar;
        private System.Windows.Forms.Button ButtonBike;
    }
}

