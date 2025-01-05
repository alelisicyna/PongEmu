using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Raylib_cs;

namespace PongEmu;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    Emulator emu = new Emulator();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void RunEmulation(object sender, RoutedEventArgs e)
    {
        emu.Run("./roms/", "pong.ch8", Color.Black, Color.White);
    }

    private void StopEmulation(object sender, RoutedEventArgs e)
    {
        emu.Close();
    }
}