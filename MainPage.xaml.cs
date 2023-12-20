namespace Maui_IssueScrollViewPosition
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void svTest_Scrolled(object sender, ScrolledEventArgs e)
        {
            txtPosition.Text += ("(x, y) = (" + e.ScrollX + ", " + e.ScrollY + ")" + Environment.NewLine);
        }
    }

}
