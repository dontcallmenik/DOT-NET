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

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                startStopButton.Text = "Старт";
            }
            else
            {
                timer1.Start();
                startStopButton.Text = "Стоп";
            }
            isRunning = !isRunning;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            // Зчитуємо інтервали з NumericUpDown
            int minuteInterval = (int)numericUpDownMinutes.Value;
            int secondInterval = (int)numericUpDownSeconds.Value;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            if (minutes >= minuteInterval && seconds >= secondInterval)
            {
                timer1.Stop();
                isRunning = false;
                startStopButton.Text = "Старт";
                minutes = 0;
                seconds = 0;
            }

            label1.Text = minutes.ToString("D2") + " : " + seconds.ToString("D2");

            // Змінюємо розташування кнопок кожні 5 секунд
            changeIntervalCounter++;
            if (changeIntervalCounter == 5)
            {
                ToggleButtonPositions();
                changeIntervalCounter = 0;
            }
        }

        private void ToggleButtonPositions()
        {
            var tempLocation = startStopButton.Location;
            startStopButton.Location = numericUpDownMinutes.Location;
            numericUpDownMinutes.Location = numericUpDownSeconds.Location;
            numericUpDownSeconds.Location = tempLocation;
        }
    }
}
