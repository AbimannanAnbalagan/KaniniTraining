using AbstractFactory;

VehicleFamilyFactory vehicleFamilyFactory= new BikeFamilyFactory();

VehicleFactory carFactory = vehicleFamilyFactory.CreateCarFactory();

Vehicle car = carFactory.CreateVehicle();

Vehicle bike = bikeFactory.CreateVehicle();

car.Drive();
bike.Drive();