using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PasswordBase
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }
        private void LogField1_Click(object sender, EventArgs e)
        {
         Clipboard.SetText((string)((Button)sender).Tag);               //Копирование в буфер обмена
        }

        private void LinkField1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     //Переход по ссылке
        { //На удивление , работает только с IE , при (не)указании другого браузера , выкидывает исключение не нахождения файла
            Process.Start("C:\\Program Files (x86)\\Internet Explorer\\iexplore.exe", (string)((LinkLabel)sender).Tag);
        }

        private void PassField1_Click(object sender, EventArgs e)
        {//Копирование в буфер обмена пароля и закрытие программы
            Clipboard.SetText((string)((Button)sender).Tag);
            Close();
        }
    }
}
