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

            Console.WriteLine(maxValue);
        }

        public void MakeCustomDie(object sender, EventArgs e)
        {

        }
    }

}
