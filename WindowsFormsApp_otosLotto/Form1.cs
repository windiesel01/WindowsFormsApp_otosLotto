using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_otosLotto
{
    public partial class Form_otosLotto : Form
    {
        private List<Button> buttons = new List<Button>();
        private List<int> generatedNumbers = new List<int>();
        private List<int> selectedNumbers = new List<int>();
        private Random random = new Random();

        public Form_otosLotto()
        {
            InitializeComponent();
            GenerateNumbers();
            CreateButtons();

        }

        private void GenerateNumbers()
        {
            for (int i = 1; i <= 90; i++)
            {
                generatedNumbers.Add(i);
            }
            generatedNumbers = generatedNumbers.OrderBy(x => random.Next()).ToList();
        }
        private void CreateButtons()
        {
            const int buttonWidth = 40;
            const int buttonHeight = 30;
            const int spacing = 0;

            for (int i = 1; i <= 90; i++)
            {
                Button button = new Button();
                button.Name = "button_" + i.ToString();
                button.Text = i.ToString();
                button.Width = buttonWidth;
                button.Height = buttonHeight;
                button.Font = new Font(button.Font.FontFamily, 10);
                button.Location = new Point(
                    ((i - 1) % 10) * (buttonWidth + spacing),
                    ((i - 1) / 10) * (buttonHeight + spacing)
                );
                button.Click += new EventHandler(Button_Click);
                panel_szamok.Controls.Add(button);
            }

            panel_szamok.Width = 10 * buttonWidth + 11 * spacing;
            panel_szamok.Height = 9 * buttonHeight + 10 * spacing;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            int selectedNumber = int.Parse(clickedButton.Text);

            if (selectedNumbers.Contains(selectedNumber))
            {
                selectedNumbers.Remove(selectedNumber);
                clickedButton.BackColor = default;
            }
            else if (selectedNumbers.Count < 5)
            {
                selectedNumbers.Add(selectedNumber);
                clickedButton.BackColor = Color.Red;
            }

            while (selectedNumbers.Count > 5)
            {
                int numberToRemove = selectedNumbers[selectedNumbers.Count - 1];
                Button buttonToRemove = panel_szamok.Controls["button_" + numberToRemove] as Button;
                selectedNumbers.Remove(numberToRemove);
                buttonToRemove.BackColor = default;
            }
            label_megjatszott.Text = "Megjátszott -> " + string.Join(", ", selectedNumbers);
        }

        private void button1_Click(object sender, EventArgs e)
            {
            List<int> winningNumbers = generatedNumbers.Take(5).ToList();
            int hits = selectedNumbers.Intersect(winningNumbers).Count();
            label_nyeroSzamok.Text = "Nyerőszámok -> " + string.Join(", ", winningNumbers);
            label_talalat.Text = "Találat -> " +hits.ToString();
            
        }

        private void Form_otosLotto_Load(object sender, EventArgs e)
        {

        }
    }
}
