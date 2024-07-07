namespace CarRent;
public class CVehicle {
    private int ID;
    private string Manufacturer;
    private string Model;
    private short Year;
    private int Mileage;
    private bool Availability;
    private float RentalCost;

    public CVehicle(int id, string manufacturer, string model, short year, int milage, bool availability, float rentalCost){
        ID = id;
        Manufacturer = manufacturer;
        Model = model;
        Year = year;
        Mileage = milage;
        Availability = availability;
        RentalCost = rentalCost;
    }

    public float CalculateRentalCost(){
        float prize;
        Console.WriteLine("Enter how much days you wanna rent the car");
        int days = Convert.ToInt16(Console.ReadLine());
        prize = RentalCost * days;
        Console.WriteLine("You have to pay: " + prize + "€");
        return prize;
    }

    public string ToString(){
        string information;
        information = $"""
                      ID = {ID} 
                      Manufacturer = {Manufacturer}
                      Model = {Model}
                      Year = {Year}
                      Mileage = {Mileage}
                      Availability = {Availability} 
                      RentalCost = {RentalCost}
                      """;
        return information;
    }
    
    //GETTER
    public int GetID(){
        return ID;
    }
    public string GetManufacturer(){
        return Manufacturer;
    }
    public string GetModel(){
        return Model;
    }
    public short GetYear(){
        return Year;
    }
    public int GetMileage(){
        return Mileage;
    }
    public bool GetAvailability(){
        return Availability;
    }
    public float GetRentalCost(){
        return RentalCost;
    }
}