using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using ToiletPaperLopushok.Classes;
using ToiletPaperLopushok.Model;

namespace ToiletPaperLopushok.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Page
    {
        public ViewPage()
        {
            InitializeComponent();
            Manager.TitlePage = "Производственная компания \"Лопушок\". Информация о продукции."; /* Задаем заголовок страницы с информацией о продукции. */
        }
        /* Метод происходит при изменении значения свойства IsVisible страницы с информацией о продукции */
        private void ViewPage_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            MainListView_Controller();
        }
        private void MainListView_Controller()
        {
            List<Product> products = ConnectToDataBase.ToiletPaperLopushok.Product.ToList(); /* Получаем записи с продукцией компании */
            MainListView.ItemsSource = products; /* Выводим список продукции компании */
        }
    }
}
