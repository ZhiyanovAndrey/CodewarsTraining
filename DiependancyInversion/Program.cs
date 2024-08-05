// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* В этом примере зависимость IDataRepository 
 * внедряется в BusinessLogic через конструктор, 
 * что обеспечивает слабую связанность и упрощает тестирование компонентов.*/

    IDataRepository repo = new DataRepository();
    BusinessLogic logic = new BusinessLogic(repo);
    logic.ProcessData("Example data");
Console.ReadKey();



public interface IDataRepository
{
    void Save(string data);
}

public class DataRepository : IDataRepository
{
    public void Save(string data) // принимает "Example data" 
    {
        Console.WriteLine("Data saved: " + data);
    }
}

public class BusinessLogic
{
    private readonly

 IDataRepository _dataRepository;

    // Constructor injection
    public BusinessLogic(IDataRepository dataRepository)
    {
        _dataRepository = dataRepository;
    }

    public void ProcessData(string data)
    {
        _dataRepository.Save(data); //DataRepository.Save передает "Example data"
    }
}




