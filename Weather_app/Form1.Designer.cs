namespace Weather_app
{
    partial class WeatherApp
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherApp));
            this.label1 = new System.Windows.Forms.Label();
            this.search_field = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.City_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search_by = new System.Windows.Forms.Label();
            this.intro = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.pressure = new System.Windows.Forms.Label();
            this.search_type = new System.Windows.Forms.ComboBox();
            this.tooltip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.visibility = new System.Windows.Forms.Label();
            this.feels_like = new System.Windows.Forms.Label();
            this.listViewForecast = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.celcius = new System.Windows.Forms.RadioButton();
            this.farengheit = new System.Windows.Forms.RadioButton();
            this.average_temp = new System.Windows.Forms.Label();
            this.maximum_temp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // search_field
            // 
            resources.ApplyResources(this.search_field, "search_field");
            this.search_field.Name = "search_field";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // City_Name
            // 
            resources.ApplyResources(this.City_Name, "City_Name");
            this.City_Name.BackColor = System.Drawing.Color.Transparent;
            this.City_Name.Name = "City_Name";
            this.City_Name.Enter += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // search_by
            // 
            resources.ApplyResources(this.search_by, "search_by");
            this.search_by.BackColor = System.Drawing.Color.Transparent;
            this.search_by.Name = "search_by";
            // 
            // intro
            // 
            this.intro.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.intro, "intro");
            this.intro.Name = "intro";
            // 
            // temperature
            // 
            resources.ApplyResources(this.temperature, "temperature");
            this.temperature.BackColor = System.Drawing.Color.Transparent;
            this.temperature.Name = "temperature";
            // 
            // wind
            // 
            resources.ApplyResources(this.wind, "wind");
            this.wind.BackColor = System.Drawing.Color.Transparent;
            this.wind.Name = "wind";
            // 
            // condition
            // 
            resources.ApplyResources(this.condition, "condition");
            this.condition.BackColor = System.Drawing.Color.Transparent;
            this.condition.Name = "condition";
            // 
            // humidity
            // 
            resources.ApplyResources(this.humidity, "humidity");
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Name = "humidity";
            // 
            // pressure
            // 
            resources.ApplyResources(this.pressure, "pressure");
            this.pressure.BackColor = System.Drawing.Color.Transparent;
            this.pressure.Name = "pressure";
            // 
            // search_type
            // 
            this.search_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.search_type, "search_type");
            this.search_type.FormattingEnabled = true;
            this.search_type.Items.AddRange(new object[] {
            resources.GetString("search_type.Items"),
            resources.GetString("search_type.Items1"),
            resources.GetString("search_type.Items2")});
            this.search_type.Name = "search_type";
            this.search_type.SelectedIndexChanged += new System.EventHandler(this.search_type_SelectedIndexChanged);
            // 
            // tooltip
            // 
            resources.ApplyResources(this.tooltip, "tooltip");
            this.tooltip.BackColor = System.Drawing.Color.Transparent;
            this.tooltip.Name = "tooltip";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.icon, "icon");
            this.icon.Name = "icon";
            this.icon.TabStop = false;
            // 
            // visibility
            // 
            resources.ApplyResources(this.visibility, "visibility");
            this.visibility.BackColor = System.Drawing.Color.Transparent;
            this.visibility.Name = "visibility";
            // 
            // feels_like
            // 
            resources.ApplyResources(this.feels_like, "feels_like");
            this.feels_like.BackColor = System.Drawing.Color.Transparent;
            this.feels_like.Name = "feels_like";
            // 
            // listViewForecast
            // 
            this.listViewForecast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            resources.ApplyResources(this.listViewForecast, "listViewForecast");
            this.listViewForecast.FullRowSelect = true;
            this.listViewForecast.GridLines = true;
            this.listViewForecast.HideSelection = false;
            this.listViewForecast.Name = "listViewForecast";
            this.listViewForecast.UseCompatibleStateImageBehavior = false;
            this.listViewForecast.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewForecast_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // celcius
            // 
            resources.ApplyResources(this.celcius, "celcius");
            this.celcius.BackColor = System.Drawing.Color.Transparent;
            this.celcius.Checked = true;
            this.celcius.Name = "celcius";
            this.celcius.TabStop = true;
            this.celcius.UseVisualStyleBackColor = false;
            this.celcius.Click += new System.EventHandler(this.celcius_Click);
            // 
            // farengheit
            // 
            resources.ApplyResources(this.farengheit, "farengheit");
            this.farengheit.BackColor = System.Drawing.Color.Transparent;
            this.farengheit.Name = "farengheit";
            this.farengheit.UseVisualStyleBackColor = false;
            this.farengheit.Click += new System.EventHandler(this.farengheit_Click);
            // 
            // average_temp
            // 
            resources.ApplyResources(this.average_temp, "average_temp");
            this.average_temp.BackColor = System.Drawing.Color.Transparent;
            this.average_temp.Name = "average_temp";
            // 
            // maximum_temp
            // 
            resources.ApplyResources(this.maximum_temp, "maximum_temp");
            this.maximum_temp.BackColor = System.Drawing.Color.Transparent;
            this.maximum_temp.Name = "maximum_temp";
            // 
            // WeatherApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.maximum_temp);
            this.Controls.Add(this.average_temp);
            this.Controls.Add(this.farengheit);
            this.Controls.Add(this.celcius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listViewForecast);
            this.Controls.Add(this.visibility);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tooltip);
            this.Controls.Add(this.search_type);
            this.Controls.Add(this.pressure);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.feels_like);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.search_by);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.City_Name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WeatherApp";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label City_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label search_by;
        private System.Windows.Forms.Label intro;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label pressure;
        private System.Windows.Forms.ComboBox search_type;
        private System.Windows.Forms.Label tooltip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label visibility;
        private System.Windows.Forms.Label feels_like;
        private System.Windows.Forms.ListView listViewForecast;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.RadioButton celcius;
        private System.Windows.Forms.RadioButton farengheit;
        private System.Windows.Forms.Label average_temp;
        private System.Windows.Forms.Label maximum_temp;
    }
}

