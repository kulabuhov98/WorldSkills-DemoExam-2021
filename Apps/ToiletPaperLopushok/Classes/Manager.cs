using System.Windows.Controls;

namespace ToiletPaperLopushok.Classes
{
    class Manager
    {
        public static string TitlePage = "Информационная система произодственной компании \"Лопушок\""; /* Статичное свойство TitlePage для заголовка страницы. Задаем значение по умолчанию. */
        public static Frame MainFrame { get; set; } /* Статичное свойство MainFrame, для взаимодействия с Frame, размещенным в основном окне приложения. */
    }
}
