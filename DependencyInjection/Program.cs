// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



IDataRepository repo = new DataRepository();
BusinessLogic logic = new BusinessLogic(repo);
logic.ProcessData("Example data");


public interface IDataRepository
{
    void Save(string data);
}

public class DataRepository : IDataRepository
{
    public void Save(string data)
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
        _dataRepository.Save(data);
    }
}


