using System; 
 
public class Student { 
    public string LastName { get; set; } 
    public DateTime DateOfBirth { get; set; } 
    public string GroupNumber { get; set; } 
    public int[] Grades { get; set; } 
 
    public void ChangeLastName(string newLastName) { 
        LastName = newLastName; 
    } 
 
    public void ChangeDateOfBirth(DateTime newDateOfBirth) { 
        DateOfBirth = newDateOfBirth; 
    } 
 
    public void ChangeGroupNumber(string newGroupNumber) { 
        GroupNumber = newGroupNumber; 
    } 
 
    public void PrintInfo() { 
        Console.WriteLine($"Фамилия: {LastName}"); 
        Console.WriteLine($"Дата рождения: {DateOfBirth}"); 
        Console.WriteLine($"Номер группы: {GroupNumber}"); 
        Console.WriteLine($"Успеваемость: {string.Join(", ", Grades)}"); 
    } 
} 
 
public class Program { 
    public static void Main(string[] args) { 
        Student student = new Student(); 
        student.LastName = "Иванов"; 
        student.DateOfBirth = new DateTime(2000, 1, 1); 
        student.GroupNumber = "Группа 1"; 
        student.Grades = new int[] { 5, 4, 3, 4, 5 }; 
 
        Console.WriteLine("Информация о студенте:"); 
        student.PrintInfo(); 
 
        Console.WriteLine(); 
 
        Console.WriteLine("Введите новую фамилию:"); 
        string newLastName = Console.ReadLine(); 
        student.ChangeLastName(newLastName); 
 
        Console.WriteLine("Введите новую дату рождения (в формате дд.мм.гггг):"); 
        string newDateOfBirthString = Console.ReadLine(); 
        DateTime newDateOfBirth = DateTime.ParseExact(newDateOfBirthString, "dd.MM.yyyy", null); 
        student.ChangeDateOfBirth(newDateOfBirth); 
 
        Console.WriteLine("Введите новый номер группы:"); 
        string newGroupNumber = Console.ReadLine(); 
        student.ChangeGroupNumber(newGroupNumber); 
 
        Console.WriteLine(); 
 
        Console.WriteLine("Обновленная информация о студенте:"); 
        student.PrintInfo(); 
    } 
}