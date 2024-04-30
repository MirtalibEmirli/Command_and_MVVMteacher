using MvvmLesson.Models;
using System.Collections.ObjectModel;

namespace MvvmLesson.DataBases;

public static class CarDataBase
{
    public static ObservableCollection<Car>? CarsDB { get; set; } = new ObservableCollection<Car>();
    public static ObservableCollection<Person>? SellersDB { get; set; } = new ObservableCollection<Person>();

    static CarDataBase()
    {
        SellersDB = new ObservableCollection<Person>
        {
            new Person { Name = "Elon", Surname = "Musk", Age = 49 },
            new Person { Name = "Jeff", Surname = "Bezos", Age = 57 },
            new Person { Name = "Bill", Surname = "Gates", Age = 65 },
            new Person { Name = "Warren", Surname = "Buffett", Age = 90 },
            new Person { Name = "Larry", Surname = "Page", Age = 48 },
            new Person { Name = "Sergey", Surname = "Brin", Age = 47 },
            new Person { Name = "Mark", Surname = "Zuckerberg", Age = 36 },
            new Person { Name = "Larry", Surname = "Ellison", Age = 76 },
            new Person { Name = "Michael", Surname = "Dell", Age = 55 },
            new Person { Name = "Steve", Surname = "Jobs", Age = 56 },
        };
    }


}
