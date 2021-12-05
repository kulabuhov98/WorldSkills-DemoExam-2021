using System.Windows;
using ToiletPaperLopushok.Classes;
using ToiletPaperLopushok.Pages;

namespace ToiletPaperLopushok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Title = "Информационная система производственной компании \"Лопушок\""; /* Задаем заголовок основного окна приложения. */

            Manager.MainFrame = MainFrame; /* Задаем статичному свойству значение MainFrame, для взаимодействия с Frame, размещенным в основном окне приложения. */
            MainFrame.Navigate(new ViewPage()); /* Задаем основную страницу, загружаемую при запуске приложения. */

            TitlePageLabel.Content = Manager.TitlePage; /* Выводим основной заголовок страницы. */
        }
    }
}
