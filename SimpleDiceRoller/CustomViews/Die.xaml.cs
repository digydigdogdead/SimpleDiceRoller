using System.Threading.Tasks;

namespace SimpleDiceRoller.CustomViews;

public partial class Die : ContentView
{
	public Die(MainPage main)
	{
		InitializeComponent();
		Main = main;
	}

	public static readonly BindableProperty dNameProperty =
		BindableProperty.Create("dName", typeof(string), typeof(Die));

	public int MaxValue { get; set; }
	public MainPage Main { get; set; }

	public string dName
	{
		get => (string)GetValue(dNameProperty);
		set => SetValue(dNameProperty, value);
	}

	public static readonly BindableProperty RollValueProperty =
		BindableProperty.Create("RollValue", typeof(string), typeof(Die));

	public string RollValue
	{
		get => (string)GetValue(RollValueProperty);
		set => SetValue(RollValueProperty, value);
	}

	public void ReRoll(object sender, TappedEventArgs args)
	{
		Random rand = new();
		int newValue = rand.Next(MaxValue) + 1;
		RollValue = newValue.ToString();
	}

    private void RemoveButton_Clicked(object sender, TappedEventArgs args)
    {
        bool worked = Main.diceGrid.Remove(this);
    }
}