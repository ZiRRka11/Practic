namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1.Показать данные о водителях");
        Console.WriteLine("2.Добавить нового водителя");
        Console.WriteLine("3.Показать данные о типах автомобиля");
        Console.WriteLine("4.Добавить новый тип автомобиля");
        Console.WriteLine("5.Показать список машин");
        Console.WriteLine("6.Добавить новую машину");
        Console.WriteLine("7.Показать маршруты");
        Console.WriteLine("8.Добавить новый маршрут");
        Console.WriteLine("9.Показать данные рейсов");
        Console.WriteLine("10.Добавить новый рейс");
        Console.WriteLine("0.Выход");

        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                DatabaseRequests.GetDriverQuery();
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine("Введите Имя, Фамилию, Дату рождения: ");
                var driver = Console.WriteLine();
                DatabaseRequests.AddDriverQuery(driver);
                DatabaseRequests.GetDriverQuery();
                Console.WriteLine();
                break;
            case 3:
                DatabaseRequests.GetTypeCarQuery();
                Console.WriteLine();
                break;
            case 4:
                Console.WriteLine("Введите тип машины: ");
                string type_car = Console.ReadLine();
                DatabaseRequests.AddTypeCarQuery(type_car);
                DatabaseRequests.GetDriverQuery();
                Console.WriteLine();
                break;
            case 5:
                DatabaseRequests.ViewCars();
                Console.WriteLine();
                break;
            case 6:
                Console.WriteLine("Введите название автомобиля, гос.номер и количество мест: ");
                var car = Console.ReadLine();
                DatabaseRequests.AddingCars(car);
                DatabaseRequests.ViewCars();
                Console.WriteLine();
                break;
            case 7:
                DatabaseRequests.ViewItinerary();
                Console.WriteLine();
                break;
            case 8:
                Console.WriteLine("Введите новый маршрут через дефис: ");
                string itirnerary = Console.ReadLine(); 
                DatabaseRequests.AddingItinerary(itirnerary);
                DatabaseRequests.ViewItinerary();
                Console.WriteLine();
                break;
            case 9:
                DatabaseRequests.ViewRoute();
                Console.WriteLine();
                break;
            case 10:
                Console.WriteLine("Введите новый рейс: id_Водителя,id_Машины,id_Маршрута и количество пассажиров ");
                var route = Console.ReadLine();
                DatabaseRequests.AddingRoute(route);
                DatabaseRequests.ViewRoute();
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Выход");
                break;


        }
       
        // Вызовем метод для получения данных о водителях
        DatabaseRequests.GetDriverQuery();
        Console.WriteLine();
        // Добавим нового водителя в БД
        DatabaseRequests.AddDriverQuery();
        // Вызовем метод для получения данных о водителях
        DatabaseRequests.GetDriverQuery();
        
        // Вызовем метод для получения данных о типах автомобилей
        DatabaseRequests.GetTypeCarQuery();
        Console.WriteLine();
        // Добавим новый тип автомобиля в БД
        DatabaseRequests.AddTypeCarQuery();
        // Вызовем метод для получения данных о типах автомобилей
        DatabaseRequests.GetTypeCarQuery();
        //Получение списка машин
        DatabaseRequests.ViewCars();
        Console.WriteLine();
        //Добавление машин
        DatabaseRequests.AddingCars();
        ///Получение данных о автомобилях
        DatabaseRequests.ViewCars();
        ///Просмотр маршрутов
        DatabaseRequests.ViewItinerary();
        Console.WriteLine();
        ///Добавление маршрутов
        DatabaseRequests.AddingItinerary();
        ///Просмотр рейсов
        DatabaseRequests.ViewRoute();
        Console.WriteLine();
        ///Добавление рейсов
        DatabaseRequests.AddingRoute();
      
    }
}