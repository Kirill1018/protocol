namespace UdpShapesClient
{
    partial class Col_chang
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
            this.color1 = new System.Windows.Forms.TextBox();
            this.color2 = new System.Windows.Forms.TextBox();
            this.color3 = new System.Windows.Forms.TextBox();
            this.red_col = new System.Windows.Forms.Label();
            this.green_col = new System.Windows.Forms.Label();
            this.blue_col = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.TextBox();
            this.name_of_play = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.TextBox();
            this.type_of_mess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(120, 46);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(184, 20);
            this.color1.TabIndex = 14;
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(120, 83);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(184, 20);
            this.color2.TabIndex = 15;
            // 
            // color3
            // 
            this.color3.Location = new System.Drawing.Point(120, 122);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(184, 20);
            this.color3.TabIndex = 16;
            // 
            // red_col
            // 
            this.red_col.AutoSize = true;
            this.red_col.Location = new System.Drawing.Point(12, 46);
            this.red_col.Name = "red_col";
            this.red_col.Size = new System.Drawing.Size(77, 13);
            this.red_col.TabIndex = 17;
            this.red_col.Text = "красный цвет";
            // 
            // green_col
            // 
            this.green_col.AutoSize = true;
            this.green_col.Location = new System.Drawing.Point(12, 83);
            this.green_col.Name = "green_col";
            this.green_col.Size = new System.Drawing.Size(77, 13);
            this.green_col.TabIndex = 18;
            this.green_col.Text = "зелёный цвет";
            // 
            // blue_col
            // 
            this.blue_col.AutoSize = true;
            this.blue_col.Location = new System.Drawing.Point(12, 122);
            this.blue_col.Name = "blue_col";
            this.blue_col.Size = new System.Drawing.Size(63, 13);
            this.blue_col.TabIndex = 19;
            this.blue_col.Text = "синий цвет";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(455, 114);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(184, 40);
            this.buttonConnect.TabIndex = 24;
            this.buttonConnect.Text = "поменять цвет";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // player
            // 
            this.player.Location = new System.Drawing.Point(455, 78);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(184, 20);
            this.player.TabIndex = 23;
            // 
            // name_of_play
            // 
            this.name_of_play.AutoSize = true;
            this.name_of_play.Location = new System.Drawing.Point(367, 78);
            this.name_of_play.Name = "name_of_play";
            this.name_of_play.Size = new System.Drawing.Size(65, 13);
            this.name_of_play.TabIndex = 22;
            this.name_of_play.Text = "имя игрока";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(455, 46);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(184, 20);
            this.message.TabIndex = 21;
            // 
            // type_of_mess
            // 
            this.type_of_mess.AutoSize = true;
            this.type_of_mess.Location = new System.Drawing.Point(367, 46);
            this.type_of_mess.Name = "type_of_mess";
            this.type_of_mess.Size = new System.Drawing.Size(84, 13);
            this.type_of_mess.TabIndex = 20;
            this.type_of_mess.Text = "тип сообщения";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 188);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.player);
            this.Controls.Add(this.name_of_play);
            this.Controls.Add(this.message);
            this.Controls.Add(this.type_of_mess);
            this.Controls.Add(this.blue_col);
            this.Controls.Add(this.green_col);
            this.Controls.Add(this.red_col);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox color1;
        private System.Windows.Forms.TextBox color2;
        private System.Windows.Forms.TextBox color3;
        private System.Windows.Forms.Label red_col;
        private System.Windows.Forms.Label green_col;
        private System.Windows.Forms.Label blue_col;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox player;
        private System.Windows.Forms.Label name_of_play;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label type_of_mess;
    }
}