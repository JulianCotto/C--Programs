using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Program12
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            DialogResult dialogOpen = MessageBox.Show("This is Program12", "Welcome!", MessageBoxButtons.OK);
            DialogResult dialoOpen = MessageBox.Show("I would give myself an A on this assignment due to the amount of extra work and research I did for it", "Welcome!", MessageBoxButtons.OK);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        
        
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Visible = false;
                pictureProgram01.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program01.mp4";
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;    
            }
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
                pictureProgram02.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program02.mp4";
                pictureProgram01.Visible = false;                
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Visible = false;
                pictureProgram03.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program03.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;                
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Visible = false;
                pictureProgram04.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program04.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;                
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.Visible = false;
                pictureProgram05.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program05.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;               
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;

            }
            if (comboBox1.SelectedIndex == 5)
            {
                pictureBox1.Visible = false;
                pictureProgram06.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program06.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;                
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                pictureBox1.Visible = false;
                pictureProgram07.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program07.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;               
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                pictureBox1.Visible = false;
                pictureProgram08.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program08.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;                
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                pictureBox1.Visible = false;
                pictureProgram09.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program09.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;                
                pictureProgram10.Visible = false;
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                pictureBox1.Visible = false;
                pictureProgram10.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program10.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;                
                pictureProgram11.Visible = false;
            }
            if (comboBox1.SelectedIndex == 10)
            {
                pictureBox1.Visible = false;
                pictureProgram11.Visible = true;
                axWindowsMediaPlayer1.URL = @"C# Projects\Program11.mp4";
                pictureProgram01.Visible = false;
                pictureProgram02.Visible = false;
                pictureProgram03.Visible = false;
                pictureProgram04.Visible = false;
                pictureProgram05.Visible = false;
                pictureProgram06.Visible = false;
                pictureProgram07.Visible = false;
                pictureProgram08.Visible = false;
                pictureProgram09.Visible = false;
                pictureProgram10.Visible = false;
                
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for running Program12");
            MessageBox.Show("I have had a lot of fun in this C# class. I especially had fun building this program in particular. I look forward to doing more work in furture classes!!");
            
        }
    }
}
