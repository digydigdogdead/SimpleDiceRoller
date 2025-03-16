using SimpleDiceRoller.CustomViews;
using System.Threading.Tasks;

namespace SimpleDiceRoller
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void AddDieClicked(object sender, EventArgs e)
        {
            int maxValue;

            if (sender == btn_d2) maxValue = 2;
            else if (sender == btn_d4) maxValue = 4;
            else if (sender == btn_d6) maxValue = 6;
            else if (sender == btn_d8) maxValue = 8;
            else if (sender == btn_d10) maxValue = 10;
            else if (sender == btn_d12) maxValue = 12;
            else if (sender == btn_d20) maxValue = 20;
            else maxValue = 100;

            GenerateDie(maxValue);
        }

        public async void MakeCustomDie(object sender, EventArgs e)
        {
            bool result = int.TryParse(await DisplayPromptAsync(title: "Custom Die", "What is the maximum value of your die?", keyboard: Keyboard.Numeric), out int newDieMax);
            if (!result) return;

            GenerateDie(newDieMax);
        }

        public void GenerateDie(int maxValue)
        {
            Random rand = new();
            int result = rand.Next(maxValue) + 1;

            Die die = new();
            die.dName = "d" + maxValue.ToString();
            die.RollValue = result.ToString();
            die.MaxValue = maxValue;

            diceGrid.Add(die);
        }
    }

}
