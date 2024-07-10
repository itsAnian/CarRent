using CarRent;

namespace UnitTests;

public class TestConstructor {
    [Test]
    public void TestConstructorInitialization(){
        int expectedID = 1;
        string expectedManufacturer = "TestManufacturer";
        string expectedModel = "TestModel";
        short expectedYear = 2022;
        int expectedMileage = 10000;
        bool expectedAvailability = true;
        float expectedRentalCost = 50.0f;
        
        CVehicle vehicle = new CVehicle(expectedID, expectedManufacturer, expectedModel, expectedYear, expectedMileage, expectedAvailability, expectedRentalCost);

        Assert.That(vehicle.ID, Is.EqualTo(expectedID));
        Assert.That(vehicle.Manufacturer, Is.EqualTo(expectedManufacturer));
        Assert.That(vehicle.Model, Is.EqualTo(expectedModel));
        Assert.That(vehicle.Year, Is.EqualTo(expectedYear));
        Assert.That(vehicle.Mileage, Is.EqualTo(expectedMileage));
        Assert.That(vehicle.Availability, Is.EqualTo(expectedAvailability));
        Assert.That(vehicle.RentalCost, Is.EqualTo(expectedRentalCost));
    }
}