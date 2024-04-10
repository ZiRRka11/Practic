using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

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
        Console.WriteLine("3.Добавить категорию прав");
        Console.WriteLine("4.Добавить категорию прав водителю");
        Console.WriteLine("5.Показать категорию прав водителей");
        Console.WriteLine("6.Показать тип машин");
        Console.WriteLine("7.Добавить тип машины");
        Console.WriteLine("8.Показать машины");
        Console.WriteLine("9.Добавить машину");
        Console.WriteLine("10.Показать маршруты");
        Console.WriteLine("11.Добавить маршрут");
        Console.WriteLine("12.Показать рейс");
        Console.WriteLine("13.Добавить рейс");
        Console.WriteLine("0.Выход");

        int choice = Convert.ToInt32(Console.ReadLine());
        string? name;
        int number_passengers;
        switch(choice)
        {
            case 1:
                DatabaseRequests.GetDriverQuery();
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine("Введите Имя: ");
                string first_name = Console.ReadLine();

                Console.WriteLine("Введите Фамилию:");
                string last_name = Console.ReadLine();

                DateTime birthdate;
                while (true)
                {
                    Console.WriteLine("Введите дату рождения: ");
                    string Date = Console.ReadLine();

                    if (DateTime.TryParse(Date, out birthdate))
                    {


                        break;
                    } else
                    {
                        Console.WriteLine("Некорректный формат даты рождения ");
                    }
                }
                DatabaseRequests.AddDriverQuery(first_name,last_name,birthdate);
                break;
                   case 3:
                  Console.WriteLine("Введите категорию прав:");
                  name = Console.ReadLine(); 
                  switch (name)
                  {
                      case "A":
                          Console.WriteLine("Вы выбрали категорию A");
                          break;
                      case "B":
                          Console.WriteLine("Вы выбрали категорию B");
                          break;
                      case "C":
                          Console.WriteLine("Вы выбрали категорию C");
                          break;
                      case "D":
                          Console.WriteLine("Вы выбрали категорию D");
                          break;
                      default:
                          Console.WriteLine("Неверный ввод.");
                          break;
                  }
                DatabaseRequests.AddRightsCategoryQuery(name);
                  break;
                
            case 4:
                Console.WriteLine("Введите номер водителя:");
                int id_driver = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер категории прав: ");
                int id_rights_category = Int32.Parse(Console.ReadLine());
                DatabaseRequests.AddDriverRightsCategoryQuery(id_driver,id_rights_category);
                break;
            case 5:
                Console.WriteLine("Введите номер водителя которому хотите дать категорию прав: ");
                id_driver = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите номер категории: ");
                id_rights_category = Int32.Parse(Console.ReadLine());
                DatabaseRequests.GetDriverRightsCategoryQuery(id_driver,id_rights_category);
                Console.WriteLine();
                break;
            case 6:
                DatabaseRequests.GetTypeCarQuery();
                Console.WriteLine();
                break;
            case 7:
                Console.WriteLine("Введите тип машины: ");
                string type_car = Console.ReadLine();
                DatabaseRequests.AddTypeCarQuery(type_car);
                DatabaseRequests.GetDriverQuery();
                Console.WriteLine();
                break;
            case 8:
                DatabaseRequests.ViewCars();
                Console.WriteLine();
                break;
            case 9:
                Console.WriteLine("Введите id машины: ");
                int Id_type_car = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите название машины:");
                name = Console.ReadLine();
                Console.WriteLine("Введите гос. номер: ");
                var state_number = Console.ReadLine();
                Console.WriteLine("Введите колчество мест: ");
                number_passengers = Int32.Parse(Console.ReadLine());
                DatabaseRequests.AddingCars(Id_type_car,name,state_number,number_passengers);
                DatabaseRequests.ViewCars();
                Console.WriteLine();
                break;
            case 10:
                DatabaseRequests.ViewItinerary();
                Console.WriteLine();
                break;
            case 11:
                Console.WriteLine("Введите новый маршрут через дефис: ");
                name = Console.ReadLine();
                DatabaseRequests.AddingItinerary(name);
                DatabaseRequests.ViewItinerary();
                Console.WriteLine();
                break;
            case 12:
                DatabaseRequests.ViewRoute();
                Console.WriteLine();
                break;
            case 13:
                Console.WriteLine("Введите Номер водителя: ");
                int id_Driver  = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите Номер машины: ");
                int id_car = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите Номер маршрута:");
                int id_itinerary = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество пассажиров: ");
                number_passengers = Int32.Parse(Console.ReadLine());
                DatabaseRequests.AddingRoute(id_Driver,id_car,id_itinerary,number_passengers);
                DatabaseRequests.ViewRoute();
                Console.WriteLine();
                break;
            default:
                Console.WriteLine("Выход");
                break;


        }
        
        
    }
}