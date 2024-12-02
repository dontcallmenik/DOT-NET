using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace StopwatchApp
{
    public partial class Form1 : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        private bool isRunning = false;
        private int changeIntervalCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
            isRunning = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            label1.Text = minutes.ToString("D2");
            label2.Text = ":";
            label3.Text = seconds.ToString("D2");

            changeIntervalCounter++;
            if (changeIntervalCounter == 5)
            {
                ToggleButtonPositions();
                changeIntervalCounter = 0;
            }
        }

        private void ToggleButtonPositions()
        {
            // Змінюємо розташування кнопок "Старт" і "Стоп"
            var tempLocation = startButton.Location;
            startButton.Location = stopButton.Location;
            stopButton.Location = tempLocation;
        }
    }
}
