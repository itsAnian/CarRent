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

        Assert.AreEqual(expectedID, vehicle.GetID());
        Assert.AreEqual(expectedManufacturer, vehicle.GetManufacturer());
        Assert.AreEqual(expectedModel, vehicle.GetModel());
        Assert.AreEqual(expectedYear, vehicle.GetYear());
        Assert.AreEqual(expectedMileage, vehicle.GetMileage());
        Assert.AreEqual(expectedAvailability, vehicle.GetAvailability());
        Assert.AreEqual(expectedRentalCost, vehicle.GetRentalCost());
    }
}