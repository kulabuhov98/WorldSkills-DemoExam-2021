using System.Windows.Controls;
using ToiletPaperLopushok.Classes;

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
    }
}
