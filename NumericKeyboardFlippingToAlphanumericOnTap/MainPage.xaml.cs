using System.Globalization;

namespace NumericKeyboardFlippingToAlphanumericOnTap
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            _ = Shell.Current?.CurrentPage.DisplayPromptAsync(
                "Numeric Value",
                "Enter a numeric value",
                accept: "OK",
                cancel: "Cancel",
                initialValue: 1.ToString(CultureInfo.CurrentCulture),
                keyboard: Keyboard.Numeric,
                maxLength: 6);
        }
    }
}
