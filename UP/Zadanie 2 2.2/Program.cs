using System;

public class Train{
    public string Destination {get; set;}
    public int TrainNumber {get; set;}
    public DateTime DepartureTime {get; set;}
    
    public Train(string destination, int trainNumber, DateTime departureTime){
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }
    
    public void Info(int InputTrainNumber){
        if (InputTrainNumber == TrainNumber){
            Console.WriteLine($"Номер поезда: {TrainNumber}");
            Console.WriteLine($"Пункт назначения: {Destination}");
            Console.WriteLine($"Время отправления: {DepartureTime}");
        }
        else {
            Console.WriteLine("Поезд не найден");
        }
    }
}
class Program{
    static void Main(){
        Train train = new Train("Томск", 432, new DateTime(2024, 3, 4, 17, 25, 0));
        int userInput = 432;
        train.Info(userInput);
    }
}