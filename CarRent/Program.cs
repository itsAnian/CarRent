namespace CarRent;

class Program
{ 
    static void Main() {
        int[] IDs = {1, 2, 3, 4, 5};
        string[] Manufacturers = { "Mercedes", "Ford", "VW", "Ferrari", "Kia"};
        string[] Models = { "AMG", "Fusion", "Golf", "911", "Carnival" };
        short[] Years = { 2022, 2009, 1999, 2015, 2012};
        int[] Milages = { 100000, 130000, 170000, 30000, 250000 };
        bool[] Availability = { true, true, true, true, true };
        float[] RentalCost = { 59.30f, 49.20f, 29.99f, 77.77f, 29.74f };

        CVehicle[] cars = new CVehicle[5];
        
        for (int i = 0; i < IDs.Length; i++)
        {
            cars[i] = new CVehicle(IDs[i], Manufacturers[i], Models[i], Years[i], Milages[i], Availability[i], RentalCost[i]);
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
        
        cars[4].CalculateRentalCost();
    }
}