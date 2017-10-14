using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerGame
{
    public partial class UI : Form
    {
        public int DamagePerSecond = 0;
        public int DamagePerClick = 2;
        public int Money = 0;
        public int EnemyHealth = 100;
        public int EnemyLevel = 1;
        public int EnemyHealthMax = 100;

        public UI()
        {
            InitializeComponent();
        }

        private void picb_EnemyPic_Click(object sender, EventArgs e)
        {
            EnemyHealth -= DamagePerClick;
            progb_EnemyHealthBar.Value = EnemyHealth;
            RefreshStats();
        }

        private void RefreshStats()
        {
            lbl_Money.Text = Money.ToString();
            lbl_EnemyLevel.Text = EnemyLevel.ToString();
            lbl_DamagePerSecond.Text = DamagePerSecond.ToString();
            lbl_DamagePerClick.Text = DamagePerClick.ToString();
            if (EnemyHealth<=0)
            {
                Random random = new Random();
                Money += EnemyLevel + EnemyHealth / 50;
                EnemyLevel++;
                EnemyHealthMax += 10;
                progb_EnemyHealthBar.Maximum = EnemyHealthMax;
                EnemyHealth = EnemyHealthMax;
                picb_EnemyPic.Image = imgl_Enemies.Images[random.Next(0, imgl_Enemies.Images.Count - 1)];
            }
        }
    }
}
