using ToiletPaperLopushok.Model;

namespace ToiletPaperLopushok.Classes
{
    class ConnectToDataBase
    {
        public static ToiletPaperLopushokEntities ToiletPaperLopushok = new ToiletPaperLopushokEntities(); /* Статичное свойство ToiletPaperLopushok для взаимодействия с Базой Данных. */
    }
}
