namespace CarRent;
public class CVehicle {
    private int id;
    private string manufacturer;
    private string model;
    private short year;
    private int mileage;
    private bool availability;
    private float rentalCost;

    public CVehicle(int s_id, string s_manufacturer, string s_model, short s_year, int s_mileage, bool s_availability, float s_rentalCost) {
        id = s_id;
        manufacturer = s_manufacturer;
        model = s_model;
        year = s_year;
        mileage = s_mileage;
        availability = s_availability;
        rentalCost = s_rentalCost;
    }

    public float CalculateRentalCost() {
        float prize;
        Console.WriteLine("Enter how much days you wanna rent the car");
        int days = Convert.ToInt32(Console.ReadLine());
        prize = rentalCost * days;
        Console.WriteLine("You have to pay: " + prize + "€");
        return prize;
    }

    public string ToString() {
        string information;
        information = $"""
                      ID = {id} 
                      Manufacturer = {manufacturer}
                      Model = {model}
                      Year = {year}
                      Mileage = {mileage}
                      Availability = {availability} 
                      RentalCost = {rentalCost}
                      """;
        return information;
    }
    
    //GETTER
    public int ID {
        get { return id; }
    }
    public string Manufacturer {
        get { return manufacturer; }
    }
    public string Model {
        get { return model; }
    }
    public short Year {
        get { return year; }
    }
    public int Mileage {
        get { return mileage; }
    }
    public bool Availability {
        get { return availability; }
    }
    public float RentalCost {
        get { return rentalCost; }
    }
}