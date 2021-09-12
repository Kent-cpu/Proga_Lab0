using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Laba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorField.Text = "";
            outputAnswer.Text = "";
            double a, b, h, m;

            if (double.TryParse(aField.Text, out a) && double.TryParse(bField.Text, out b) && double.TryParse(hField.Text, out h) && double.TryParse(mField.Text, out m))
            {

                double answer = 2 * m / (a * b * h);

                if (a * b * h == 0)
                {
                    errorField.Text = "Деление на ноль, проверьте входные данные";
                }
                else if (double.IsInfinity(a) || double.IsInfinity(b) || double.IsInfinity(h) || double.IsInfinity(m) || double.IsInfinity(answer))
                {
                    errorField.Text = "Слишком большие числа";
                }
                else
                {
                    outputAnswer.Text = "Ответ: " + answer.ToString();
                }

            }
            else
            {
                errorField.Text = "Некоректные данные";
            }

        }

        private void generationData()
        {
            errorTask2.Text = "";
            informationUsers.Text = "";
            string[] allSurname = { "Смирнов", "Иванов", "Сидоров", "Морозов", "Петров", "Лебедев", "Волков", "Зайцев", "Воробьев" };
            XmlDocument document = new XmlDocument();
            XmlDeclaration XmlDec = document.CreateXmlDeclaration("1.0", "utf-8", null);
            document.AppendChild(XmlDec);
            XmlElement allSub = document.CreateElement("Allsubscriber");
            document.AppendChild(allSub);

            Random rnd = new Random();

            for (int i = 0; i < 50; ++i)
            {
                string phoneStr = "", yearStr = "";


                for (int j = 0; j < 2; ++j)
                {
                    int phone = rnd.Next(0, 9);
                    int year = rnd.Next(0, 9);
                    phoneStr += phone.ToString() + phone.ToString();
                    yearStr += year.ToString() + year.ToString();
                }


                XmlElement subscriber = document.CreateElement("subscriber");
                XmlElement surname = document.CreateElement("surname");
                surname.InnerText = allSurname[rnd.Next(0, allSurname.Length - 1)];
                XmlElement phoneNubmer = document.CreateElement("phoneNumber");
                phoneNubmer.InnerText = phoneStr;
                XmlElement yearInstallation = document.CreateElement("yearInstallation");
                yearInstallation.InnerText = yearStr;

                subscriber.AppendChild(surname);
                subscriber.AppendChild(phoneNubmer);
                subscriber.AppendChild(yearInstallation);

                document.DocumentElement.InsertAfter(subscriber, document.DocumentElement.LastChild);

            }
            document.Save(@"C:\\Users\rusla\Desktop\Users.xml");
        }


        private void generationDataBtn_Click(object sender, EventArgs e)
        {
            generationData();
        }

        private void findInfromation_Click(object sender, EventArgs e)
        {
            informationUsers.Text = "";
            if (!File.Exists(@"C:\\Users\rusla\Desktop\Users.xml"))
            {
                errorTask2.Text = "Файл не создан, сгенерируйте файл";
                return;
            }

            string[] textFile = File.ReadAllLines(@"C:\\Users\rusla\Desktop\Users.xml");
            if (textFile.Length == 0)
            {
                generationData();
            }

            XmlDocument document = new XmlDocument();
            document.Load(@"C:\\Users\rusla\Desktop\Users.xml");
            int coincidence = 0;
            XmlElement xRoot = document.DocumentElement;

            foreach (XmlNode xnode in xRoot)
            {
                string getPhone = "";
                string getYear = "";
                string getSurname = "";
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    switch (childnode.Name)
                    {
                        case "phoneNumber":
                           getPhone = childnode.InnerText;
                           break;
                        case "yearInstallation":
                            getYear = childnode.InnerText;
                            break;
                        case "surname":
                            getSurname = childnode.InnerText;
                            break;
                    }
                }
                if (getPhone != "" && getYear != "" &&  getPhone[3] == getYear[3] && getPhone[2] == getYear[2])
                {
                    informationUsers.Text += $"Surname: {getSurname} , phone: {getPhone}, year: {getYear}\n";
                    ++coincidence;
                }
            }

            if(coincidence == 0)
            {
                informationUsers.Text = "Совпадений не найдено";
            }
        }
    }
}
