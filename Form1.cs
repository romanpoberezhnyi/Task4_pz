using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace task4
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
                string[] zmin = { "x", "y" };
                foreach (var zmini in zmin)
                {
                    switch (zmini)
                    {
                        case "x" when x == 0:
                        case "y" when y == 0:
                            MessageBox.Show($"Зміні '{zmini}' не може бути нулем.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
                double modulRiznKvadr = Math.Abs(Math.Pow(x, 2) - Math.Pow(y, 2));
                double RiznKvadr = Math.Pow(x - y, 2);
                textBox3.Text = $"|{x}^2 - {y}^2| = {modulRiznKvadr}";
                textBox4.Text = $"({x} - {y})^2 = {RiznKvadr}";
                if (modulRiznKvadr > RiznKvadr)
                {
                    textBox5.Text = "Модуль різниці квадратів більше";
                }
                else
                {
                    textBox5.Text = "Різниця квадратів більше";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введіть коректні значення для коефіцієнтів.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Визначник, що більше: модуль різниці квадрата чи різниця квадратів\n програма написана Побережним Романом Дмитровичем, студентом групи КН21-1", "about program", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
