using CleanArchitecture.Application.Interfaces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CleanArchitecture.Presentation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly IBusinessLogicService businessClassService;

    public MainWindow(IBusinessLogicService service)
    {
        InitializeComponent();
        this.businessClassService = service;
    }

    private void btnContent_Click(object sender, RoutedEventArgs e)
    {
        var result = businessClassService.DoSomething();

        lbContent.Items.Clear();
        foreach (var table in result)
        {
            lbContent.Items.Add($"Material: {table.Material}, WxL: {table.Width} x {table.Lenght}, Fläche: {Math.Round(table.Width * table.Lenght, 2)} m²");
        }
    }
}