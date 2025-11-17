using Avalonia.Controls;
using Avalonia.Interactivity;
namespace CS_VSC_AvaloniaTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Button1Handler(object sender, RoutedEventArgs Event_Args)
    {
        NetworkClass.TestConnect("https://rmm.itmasters.net.au/index.php");
        TB_WebStatus.Text = NetworkClass.ResponseStatucCode;
        TB_WebMessage.Text = NetworkClass.ResponseMessage;
    }
}