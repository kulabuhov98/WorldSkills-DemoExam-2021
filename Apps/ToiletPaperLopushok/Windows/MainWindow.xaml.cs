using System.Windows;
using ToiletPaperLopushok.Classes;

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
            TitlePageLabel.Content = Manager.TitlePage; /* Выводим основной заголовок страницы */
            this.Title = "Информационная система производственной компании \"Лопушок\""; /* Задаем заголовок основного окна приложения */
        }
    }
}
