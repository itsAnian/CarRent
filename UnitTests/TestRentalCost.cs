using CarRent;

namespace UnitTests;

public class TestRentalCost {
    [Test]
    public void TestRentalCosts(){
        int ID = 1;
        string Manufacturer = "TestManufacturer";
        string Model = "TestModel";
        short Year = 2022;
        int Mileage = 10000;
        bool Availability = true;
        float RentalCost = 50.0f;
        int RentalDays = 5;
        
        CVehicle vehicle = new CVehicle(ID, Manufacturer, Model, Year, Mileage, Availability, RentalCost);
            
        var stringReader = new StringReader(RentalDays.ToString());
        Console.SetIn(stringReader);
        
        Assert.That(vehicle.CalculateRentalCost(), Is.EqualTo(RentalCost * RentalDays));
    }
}