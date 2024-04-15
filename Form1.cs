using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace лаба_11_з2
{
    public partial class Form1 : Form
    {
        List<worker> workers = new List<worker>();
        public struct worker
        {
            public string name;
            public string dol;
            public double stag;
            public worker(string name, string dol, double stag)
            {
                this.name = name;
                this.dol = dol;
                this.stag = stag;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            worker w = new worker();
            Random random = new Random();
            string[] n = { "Иванов И.И.", "Петров П.П.", "Смирнов С.А.", "Козлов К.Д.", "Лебедев Л.С.", "Соколов С.Г.", "Морозов М.В.", "Никитин Н.М.", "Кузнецов К.И.", "Белов Б.О.", "Васильев В.П.", "Захаров З.Р.", "Гаврилов Г.Ю.", "Титов Т.Ф.", "Жуков Ж.Е.", "Макаров М.К.", "Федоров Ф.Л.", "Дмитриев Д.Ю.", "Калинин К.Б.", "Алексеев А.Н.", "Фомин Ф.Т.", "Орлов О.Х.", "Богданов Б.У.", "Медведев М.П.", "Егоров Е.Р.", "Григорьев Г.У.", "Яковлев Я.С.", "Романов Р.Ц.", "Степанов С.Ч.", "Игнатьев И.Э." };
            string[] d = { "Software Engineer", "Marketing Manager", "Accountant", "Sales Representative", "Human Resources Manager", "Project Manager", "Customer Service Representative", "Graphic Designer", "Web Developer", "Operations Manager", "Financial Analyst", "Business Development Manager", "Administrative Assistant", "Quality Assurance Analyst", "Product Manager" };
            for (int i = 0; i < 10; i++)
            {
                w.name = n[random.Next(n.Length)];
                w.dol = d[random.Next(d.Length)];
                w.stag = random.Next(1, 21);
                workers.Add(w);
            }
            workers.Sort((x, y) => string.Compare(x.name.Split(' ')[0], y.name.Split(' ')[0]));
            using (StreamWriter writer = new StreamWriter("1.txt"))
            {
                string str = "";
                for (int i = 0; i < 10; i++)
                {
                    str += workers[i].name + " " + workers[i].dol + " " + workers[i].stag.ToString() + "лет" + '\n';
                }
                richTextBox1.Text = str;
                writer.WriteLine(str);
            }
            textBox1.Text = "Генерация прошла успешно";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("1.txt"))
            {
                string str = r.ReadToEnd();
                using (StreamWriter writer = new StreamWriter("2.txt"))
                {
                    writer.WriteLine(str);
                }
            }
            textBox1.Text = "Сохранено";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            File.Delete("1.txt");
            File.Delete("2.txt");
            textBox1.Text = "Файл очищен";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(textBox2.Text);
            string str = "";
            for (int i = 0;i < 10;i++)
            {
                if (n < workers[i].stag)
                {
                    str += workers[i].name + '\n';
                }
            }
            if (str == "")
            {
                richTextBox2.Text = "Таких работников нет";
            }
            else
            {
                richTextBox2.Text = str;
            }
        }
    }
}
