namespace ClickerGame
{
    partial class UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.picb_EnemyPic = new System.Windows.Forms.PictureBox();
            this.progb_EnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgl_Enemies = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_DamagePerSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_EnemyLevel = new System.Windows.Forms.Label();
            this.lbl_DamagePerClick = new System.Windows.Forms.Label();
            this.lbl_Money = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_EnemyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // picb_EnemyPic
            // 
            this.picb_EnemyPic.Image = global::ClickerGame.Properties.Resources.Iron_Warrior;
            this.picb_EnemyPic.Location = new System.Drawing.Point(175, 12);
            this.picb_EnemyPic.Name = "picb_EnemyPic";
            this.picb_EnemyPic.Size = new System.Drawing.Size(250, 250);
            this.picb_EnemyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picb_EnemyPic.TabIndex = 0;
            this.picb_EnemyPic.TabStop = false;
            this.picb_EnemyPic.Click += new System.EventHandler(this.picb_EnemyPic_Click);
            // 
            // progb_EnemyHealthBar
            // 
            this.progb_EnemyHealthBar.Location = new System.Drawing.Point(175, 239);
            this.progb_EnemyHealthBar.Name = "progb_EnemyHealthBar";
            this.progb_EnemyHealthBar.Size = new System.Drawing.Size(250, 23);
            this.progb_EnemyHealthBar.Step = 1;
            this.progb_EnemyHealthBar.TabIndex = 1;
            this.progb_EnemyHealthBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Damage per second";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Damage per click";
            // 
            // imgl_Enemies
            // 
            this.imgl_Enemies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgl_Enemies.ImageStream")));
            this.imgl_Enemies.TransparentColor = System.Drawing.Color.Transparent;
            this.imgl_Enemies.Images.SetKeyName(0, "Eee.png");
            this.imgl_Enemies.Images.SetKeyName(1, "Hell_Dog.png");
            this.imgl_Enemies.Images.SetKeyName(2, "Iron_Warrior.png");
            this.imgl_Enemies.Images.SetKeyName(3, "Little_Demon.png");
            this.imgl_Enemies.Images.SetKeyName(4, "Rare_Maw.png");
            this.imgl_Enemies.Images.SetKeyName(5, "Snow_Monster.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Money";
            // 
            // lbl_DamagePerSecond
            // 
            this.lbl_DamagePerSecond.AutoSize = true;
            this.lbl_DamagePerSecond.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DamagePerSecond.Location = new System.Drawing.Point(18, 46);
            this.lbl_DamagePerSecond.Name = "lbl_DamagePerSecond";
            this.lbl_DamagePerSecond.Size = new System.Drawing.Size(16, 18);
            this.lbl_DamagePerSecond.TabIndex = 5;
            this.lbl_DamagePerSecond.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "LEVEL :";
            // 
            // lbl_EnemyLevel
            // 
            this.lbl_EnemyLevel.AutoSize = true;
            this.lbl_EnemyLevel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnemyLevel.Location = new System.Drawing.Point(314, 18);
            this.lbl_EnemyLevel.Name = "lbl_EnemyLevel";
            this.lbl_EnemyLevel.Size = new System.Drawing.Size(20, 21);
            this.lbl_EnemyLevel.TabIndex = 7;
            this.lbl_EnemyLevel.Text = "1";
            // 
            // lbl_DamagePerClick
            // 
            this.lbl_DamagePerClick.AutoSize = true;
            this.lbl_DamagePerClick.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DamagePerClick.Location = new System.Drawing.Point(18, 104);
            this.lbl_DamagePerClick.Name = "lbl_DamagePerClick";
            this.lbl_DamagePerClick.Size = new System.Drawing.Size(16, 18);
            this.lbl_DamagePerClick.TabIndex = 8;
            this.lbl_DamagePerClick.Text = "1";
            // 
            // lbl_Money
            // 
            this.lbl_Money.AutoSize = true;
            this.lbl_Money.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Money.Location = new System.Drawing.Point(462, 46);
            this.lbl_Money.Name = "lbl_Money";
            this.lbl_Money.Size = new System.Drawing.Size(21, 24);
            this.lbl_Money.TabIndex = 9;
            this.lbl_Money.Text = "0";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(574, 409);
            this.Controls.Add(this.lbl_Money);
            this.Controls.Add(this.lbl_DamagePerClick);
            this.Controls.Add(this.lbl_EnemyLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_DamagePerSecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progb_EnemyHealthBar);
            this.Controls.Add(this.picb_EnemyPic);
            this.Name = "UI";
            this.Text = "Clicker Game";
            ((System.ComponentModel.ISupportInitialize)(this.picb_EnemyPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picb_EnemyPic;
        private System.Windows.Forms.ProgressBar progb_EnemyHealthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imgl_Enemies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_DamagePerSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_EnemyLevel;
        private System.Windows.Forms.Label lbl_DamagePerClick;
        private System.Windows.Forms.Label lbl_Money;
    }
}

