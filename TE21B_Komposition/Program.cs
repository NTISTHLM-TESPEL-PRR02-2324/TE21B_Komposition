Car myCar = new();

myCar.driver.name = "Micke";

// Console.WriteLine(myCar.trunk.humans[0].name);

Human martin = new();
martin.isCop = true;

Human micke = new();

myCar.AddPassenger(martin);
myCar.AddPassenger(micke);

Console.WriteLine(myCar.passengers.Count);

Console.ReadLine();