using System;
using System.Drawing;
using System.Windows.Forms;

public class Form1 : Form
{
    private Button myButton;
    private Timer myTimer;
    private bool isExpanded;

    public Form1()
    {
        InitializeComponent();
        isExpanded = true; // Начальное состояние формы
    }

    private void InitializeComponent()
    {
        this.myButton = new Button();
        this.myTimer = new Timer();

        // 
        // myButton
        // 
        this.myButton.Text = "Click Me!";
        this.myButton.Size = new Size(100, 50);
        this.myButton.Location = new Point(50, 50);

        // Добавление контекстного меню с элементами
        ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
        ToolStripMenuItem item1 = new ToolStripMenuItem("Item 1");
        ToolStripMenuItem item2 = new ToolStripMenuItem("Item 2");
        ToolStripMenuItem item3 = new ToolStripMenuItem("Item 3");

        // Назначение обработчика событий для пунктов меню
        item1.Click += MenuItem_Click;
        item2.Click += MenuItem_Click;
        item3.Click += MenuItem_Click;

        contextMenuStrip.Items.AddRange(new ToolStripItem[] { item1, item2, item3 });
        this.myButton.ContextMenuStrip = contextMenuStrip;

        // 
        // myTimer
        // 
        this.myTimer.Interval = 250; // Интервал 0,25 секунды
        this.myTimer.Tick += new EventHandler(MyTimer_Tick); // Подписка на событие Tick
        this.myTimer.Enabled = true; // Включаем таймер

        // 
        // Form1
        // 
        this.Controls.Add(this.myButton);
        this.Text = "Form with Timer";
        this.Size = new Size(400, 300);
    }

    private void MyTimer_Tick(object sender, EventArgs e)
    {
        // Переключаем состояние формы и кнопки
        if (isExpanded)
        {
            // Сжимаем форму и изменяем положение
            this.Size = new Size(200, 100); // Изменяем размер формы
            this.Location = new Point(300, 200); // Меняем положение формы
            myButton.Visible = false; // Скрываем кнопку
        }
        else
        {
            // Разворачиваем форму и показываем кнопку
            this.Size = new Size(400, 300); // Восстанавливаем размер
            this.Location = new Point(100, 100); // Восстанавливаем положение
            myButton.Visible = true; // Показываем кнопку
        }

        // Переключаем состояние
        isExpanded = !isExpanded;
    }

    // Обработчик событий для пунктов меню
    private void MenuItem_Click(object sender, EventArgs e)
    {
        // Получаем текст нажатого элемента меню
        ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
        if (menuItem != null)
        {
            MessageBox.Show($"Вы выбрали: {menuItem.Text}");
        }
    }

    // Точка входа в программу
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }
}
