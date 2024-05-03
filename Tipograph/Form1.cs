using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NLog;
using NLog.Config;

namespace Tipograph
{
    public partial class Tipograph : Form
    {
        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        public Tipograph()
        {
            InitializeComponent();
            log.Info("Запуск приложения");
        }

        private void TipographTextButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = FormatText(InputTextBox.Text);
            log.Info($"Текст {InputTextBox.Text} был отформатирован.");
        }
        static public string FormatText(string input)
        {
            // Правило для добавления пробела справа от знаков препинания
            input = Regex.Replace(input, @"(\w)(\p{P})", "$1$2 ");

            // Правило для удаления лишних пробелов
            input = Regex.Replace(input, @"\s+", " ");

            // Правило для добавления пробела с обеих сторон тире
            input = Regex.Replace(input, @"(\w)(-)(\w)", "$1 $2 $3");

            // Правило для добавления пробелов вокруг скобок и кавычек
            input = Regex.Replace(input, @"(\s*)([«»„“])(\S+)([«»„“])(\s*)", "$1$2$3$4$5");

            // Правило для замены слова "сыр" на "колбаса"
            input = input.Replace("сыр", "колбаса");

            // Правило для добавления пробела после двоеточия
            input = Regex.Replace(input, @":(\S)", ": $1");

            return input;
        }

        private void AboutProgrammButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обыкновенный типограф, \nпоможет вам отформатрировать ваш текст.");
            log.Info($"Было прочитано о программе.");
        }
    }
}
