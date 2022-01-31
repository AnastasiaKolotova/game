using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.body;

        // Наложение элементов pictureBox друг на друга с сохранением прозрачного фона
            // pictureBox2
            pictureBox1.Controls.Add(pictureBox2); // Добавление слоя в родительский контейнер (в pictureBox1)
            pictureBox2.Location = new Point(0, 0); // Положение слоя относительно родительского контейнера

            // pictureBox3 (аналогично с pictureBox2)
            pictureBox1.Controls.Add(pictureBox3);
            pictureBox2.Controls.Add(pictureBox3); // Также добавление слоя в еще один родительский контейнер (в pictureBox2)
            pictureBox3.Location = new Point(0, 0);

            // pictureBox4 (аналогично с pictureBox3)
            pictureBox1.Controls.Add(pictureBox4);
            pictureBox2.Controls.Add(pictureBox4);
            pictureBox3.Controls.Add(pictureBox4);
            pictureBox4.Location = new Point(0, 0);

            // pictureBox5 (аналогично с pictureBox3)
            pictureBox1.Controls.Add(pictureBox5);
            pictureBox2.Controls.Add(pictureBox5);
            pictureBox3.Controls.Add(pictureBox5);
            pictureBox4.Controls.Add(pictureBox5);
            pictureBox5.Location = new Point(0, 0);
        }

// Описание всех кнопок
    // Кнопки сброса - Обнуление содержимого pictureBox-ов
        private void button1_Click(object sender, EventArgs e) // Категория Прически
        { pictureBox2.Image = null; } 
        private void button2_Click(object sender, EventArgs e) // Категория Верх
        { pictureBox5.Image = null; } 
        private void button3_Click(object sender, EventArgs e) // Категория Низ
        { pictureBox4.Image = null; } 
        private void button4_Click(object sender, EventArgs e) // Категория Обувь
        { pictureBox3.Image = null; } 
        private void button5_Click(object sender, EventArgs e) // Сброс всего
        {
            // Обнуление содержимого всех pictureBox-ов одновременно
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
        }

    // Кнопки в категории Прически - Добавление изображения в pictureBox2 при нажатии той или иной кнопки
        private void button6_Click(object sender, EventArgs e)
        { pictureBox2.Image = Properties.Resources.hair1; } 
        private void button7_Click(object sender, EventArgs e)
        { pictureBox2.Image = Properties.Resources.hair2; }
        private void button8_Click(object sender, EventArgs e)
        { pictureBox2.Image = Properties.Resources.hair3; }

    // Кнопки в категории Верх - аналогично принципу кода выше 
        private void button9_Click(object sender, EventArgs e)
        { pictureBox5.Image = Properties.Resources.up1; }
        private void button10_Click(object sender, EventArgs e)
        { pictureBox5.Image = Properties.Resources.up2; }
        private void button11_Click(object sender, EventArgs e)
        { pictureBox5.Image = Properties.Resources.up3; }

    // Кнопки в категории Низ - аналогично принципу кода выше 
        private void button14_Click(object sender, EventArgs e)
        { pictureBox4.Image = Properties.Resources.down1; }
        private void button13_Click(object sender, EventArgs e)
        { pictureBox4.Image = Properties.Resources.down2; }
        private void button12_Click(object sender, EventArgs e)
        { pictureBox4.Image = Properties.Resources.down3; }

    // Кнопки в категории Обувь - аналогично принципу кода выше 
        private void button17_Click(object sender, EventArgs e)
        { pictureBox3.Image = Properties.Resources.shoes1; }
        private void button16_Click(object sender, EventArgs e)
        { pictureBox3.Image = Properties.Resources.shoes2; }
        private void button15_Click(object sender, EventArgs e)
        { pictureBox3.Image = Properties.Resources.shoes3; }

    // Кнопка по завершению игры
        private void button18_Click(object sender, EventArgs e)
        {
            // При нажатии всплывает диалоговое окно с вопросом, на который можно дать два ответа - Да или Нет
            DialogResult dialog = MessageBox.Show(
                "Вы действительно хотите покинуть игру?  (=_=)",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            // В случае положительного ответа появляется следующее сообщение:
            if (dialog == DialogResult.Yes)
            {
                DialogResult mess = MessageBox.Show(
                "Спасибо за игру!  (っ˘ω˘ς)" +
                "\nХорошего дня!  (ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", "",
                MessageBoxButtons.OK);

                Application.Exit();
            }  
            // Иначе игрок возвращается к форме и может продолжить игру
        }

    // Кнопки на начальном экране
        private void button19_Click(object sender, EventArgs e) // Описание кнопки Начать - При нажатии панель со всем ее содержимым "исчезает"
        {
            panel2.Visible = false;
        }
        private void button20_Click(object sender, EventArgs e) // Описание кнопки Правила - При нажатии появляется сообщение с правилами игры
        {
            DialogResult mess = MessageBox.Show(
                "Правила просты:" +
                "\nНажимайте на кнопки в соответствующих категориях " +
                "\nи создавайте уникальные образы!  o(≧▽≦)o", 
                "Правила",
                MessageBoxButtons.OK);
        }
        private void button21_Click(object sender, EventArgs e) // Описание кнопки Об авторе - При нажатии появляется сообщение с описанием создателя
        {
            DialogResult mess = MessageBox.Show(
                "Реализация: КАВ, ИР-19-4  (o´▽`o)ﾉ" +
                "\nИдейный вдохновитель: ЛАА  ~(˘▾˘~)", "Об авторе",
                MessageBoxButtons.OK);
        }
    }
}