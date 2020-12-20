namespace Weather_app
{
    partial class Forecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forecast));
            this.feels_like = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.temp = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.visibility = new System.Windows.Forms.Label();
            this.posibility = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // feels_like
            // 
            this.feels_like.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feels_like.AutoSize = true;
            this.feels_like.BackColor = System.Drawing.Color.Transparent;
            this.feels_like.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feels_like.Location = new System.Drawing.Point(148, 128);
            this.feels_like.Name = "feels_like";
            this.feels_like.Size = new System.Drawing.Size(0, 25);
            this.feels_like.TabIndex = 0;
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon.Location = new System.Drawing.Point(104, 34);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(107, 91);
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // temp
            // 
            this.temp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temp.Location = new System.Drawing.Point(187, 54);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(0, 62);
            this.temp.TabIndex = 2;
            // 
            // wind
            // 
            this.wind.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wind.AutoSize = true;
            this.wind.BackColor = System.Drawing.Color.Transparent;
            this.wind.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wind.Location = new System.Drawing.Point(51, 227);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(0, 25);
            this.wind.TabIndex = 3;
            // 
            // humidity
            // 
            this.humidity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.humidity.Location = new System.Drawing.Point(253, 227);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(0, 25);
            this.humidity.TabIndex = 4;
            // 
            // pressure
            // 
            this.pressure.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pressure.AutoSize = true;
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pressure.Location = new System.Drawing.Point(51, 301);
            this.pressure.Name = "pressure";
            this.pressure.Size = new System.Drawing.Size(0, 25);
            this.pressure.TabIndex = 5;
            // 
            // visibility
            // 
            this.visibility.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.visibility.AutoSize = true;
            this.visibility.BackColor = System.Drawing.Color.Transparent;
            this.visibility.CausesValidation = false;
            this.visibility.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visibility.Location = new System.Drawing.Point(253, 301);
            this.visibility.Name = "visibility";
            this.visibility.Size = new System.Drawing.Size(0, 25);
            this.visibility.TabIndex = 6;
            // 
            // posibility
            // 
            this.posibility.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.posibility.AutoSize = true;
            this.posibility.BackColor = System.Drawing.Color.Transparent;
            this.posibility.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.posibility.Location = new System.Drawing.Point(118, 370);
            this.posibility.Name = "posibility";
            this.posibility.Size = new System.Drawing.Size(0, 25);
            this.posibility.TabIndex = 7;
            // 
            // condition
            // 
            this.condition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.condition.Location = new System.Drawing.Point(148, 167);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(0, 25);
            this.condition.TabIndex = 8;
            // 
            // date
            // 
            this.date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Location = new System.Drawing.Point(161, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 20);
            this.date.TabIndex = 9;
            // 
            // Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(472, 460);
            this.Controls.Add(this.date);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.posibility);
            this.Controls.Add(this.visibility);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.feels_like);
            this.Name = "Forecast";
            this.Text = "Forecast";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label feels_like;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.Label visibility;
        private System.Windows.Forms.Label posibility;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label date;
    }
}