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

        Assert.That(vehicle.GetID(), Is.EqualTo(expectedID));
        Assert.That(vehicle.GetManufacturer(), Is.EqualTo(expectedManufacturer));
        Assert.That(vehicle.GetModel(), Is.EqualTo(expectedModel));
        Assert.That(vehicle.GetYear(), Is.EqualTo(expectedYear));
        Assert.That(vehicle.GetMileage(), Is.EqualTo(expectedMileage));
        Assert.That(vehicle.GetAvailability(), Is.EqualTo(expectedAvailability));
        Assert.That(vehicle.GetRentalCost(), Is.EqualTo(expectedRentalCost));
    }
}