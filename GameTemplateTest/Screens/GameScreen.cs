using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using GameSystemServices;
using System.Diagnostics;
/// <summary>
/// Created by Sridhar, Calem, and Sammy
/// January 2020
/// We created a game using a game loop, this game brings everything we have learned in class all together.
/// </summary>

namespace GameTemplateTest
{
    public partial class GameScreen : UserControl
    {
        
        public GameScreen()
        {
            InitializeComponent();
            Thread.Sleep(1000);
            Death();
        }
        public void Death()
        {
            fadeLabel.Visible = true;
            int intensity = 0;
            fadeLabel.BackColor = Color.FromArgb(intensity,255,0,0);

            while (intensity < 256)
            {
                intensity++;
                Thread.Sleep(30);
                Refresh();
            }
            //pb.Dispose();


        }

        /// <summary>
        /// This is the Game Engine and repeats on each interval of the timer. For example
        /// if the interval is set to 16 then it will run each 16ms or approx. 50 times
        /// per second
        /// </summary>
        //private void gameTimer_Tick(object sender, EventArgs e)
        //{
        //    //Game Loop
        //    MoveHero();
        //    JumpHero();
        //    BulletMechanics();
        //    CollisionCheck();
        //    NPCMove();
        //    HeroHealthCheck();
        //    HeroDeath();
        //}
    }
}