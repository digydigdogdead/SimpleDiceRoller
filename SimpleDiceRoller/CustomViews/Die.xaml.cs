namespace SimpleDiceRoller.CustomViews;

public partial class Die : ContentView
{
	public Die()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty dNameProperty =
		BindableProperty.Create("dName", typeof(string), typeof(Die));

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
}