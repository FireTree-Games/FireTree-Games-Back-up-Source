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
using System.Speech.Synthesis;
using System.Speech;

namespace EAS_Maker
{
    public partial class Form1 : Form
    {
        string[] States;
        string[] EASTYPES;
        string[] EASSENDERS;
        System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"Assets\basicEOM.wav");
        System.Media.SoundPlayer simpleSound2 = new System.Media.SoundPlayer(@"Assets\basicSAMEandAttention.wav");
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speechSynthesizerObj;
        private void Form1_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            //States = File.ReadAllText("Assets\\States.txt").Split(new Char[] { '\r'});
            EASTYPES = File.ReadAllText("Assets\\EASTypes.txt").Split(new Char[] { '\r'});
            EASSENDERS = File.ReadAllText("Assets\\EASSenders.txt").Split(new Char[] { '\r' });
            //TODO Fix this.
            /*for (int s = 0; s < States.Length; s++)
            {
                stateDrop.Items.Add(States[s]);
            }*/
            for (int s = 0; s < EASTYPES.Length; s++)
            {
                easTypes.Items.Add(EASTYPES[s]);
            }
            for (int s = 0; s < EASSENDERS.Length; s++)
            {
                EASSenderTypes.Items.Add(EASSENDERS[s]);
            }
            Start_Speech.Enabled = false;
            maintext.Location = new Point(maintext.Location.X, maintext.Location.Y - 25);
        }


        private void stateDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            EASSenderTypes.Enabled = true;
        }
        private void easTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            stateDrop.Enabled = true;
            AlertTypeText.Text = easTypes.SelectedItem.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            maintext.Location = new Point(maintext.Location.X + 1, maintext.Location.Y);
            if(maintext.Location.X >= 780)
            {
                maintext.Location = new Point(-928, 175);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (easTypes.SelectedItem != null && stateDrop.SelectedItem != null && EASSenderTypes.SelectedItem != null)
            {
                maintext.Text = "A(n) " + easTypes.SelectedItem.ToString() + " Was Issued For " + stateDrop.SelectedItem.ToString() + " ";
                Start_Speech.Enabled = true;
            }
            else
                MessageBox.Show("Select EAS Type, State, and Sender");
        }

        private void Preview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Start_Speech_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                simpleSound2.PlaySync();
                speechSynthesizerObj.Dispose();
                speechSynthesizerObj = new SpeechSynthesizer();
                //Asynchronously speaks the contents present in RichTextBox1   
                speechSynthesizerObj.Speak(textBox1.Text);
                simpleSound.PlaySync();
            }
            else
            {
                MessageBox.Show("No Text In Text After Intro Box");
            }
        }

        private void EASSenderTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            issuerText.Text = EASSenderTypes.SelectedItem.ToString();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EAS_Editor editor = new EAS_Editor();
            editor.ShowDialog();
        }
    }
}
