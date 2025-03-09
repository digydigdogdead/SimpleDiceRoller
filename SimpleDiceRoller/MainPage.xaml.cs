namespace SimpleDiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public void GenerateDie(object sender, EventArgs e)
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

            // Replace the following code with code that generates a Die object when I know how to do that.
            Random rand = new();
            int result = rand.Next(maxValue) + 1;

            Label label = new();
            label.Text = result.ToString();

            diceGrid.Add(label);
        }

        public void MakeCustomDie(object sender, EventArgs e)
        {

        }
    }

}
