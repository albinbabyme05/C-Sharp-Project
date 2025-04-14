# RentACar System

A simple C# console-based vehicle rental management system. It supports renting and returning different types of vehicles (Car, Bike, Truck) and tracks multiple customers and their rental history.

---

## Project Structure

- Vehicle (Abstract Class):
  - Base class for all vehicle types.
  - Stores common properties like Vehicle ID, Model, Brand, Rent Status, and Rent Duration.
  - Includes an abstract method CalculateRent() to be implemented by subclasses.

- Car, Bike, Truck (Derived Classes):
  - Inherit from Vehicle.
  - Implement CalculateRent() using base rate and daily rate specific to each type.

- RentManager:
  - Manages all vehicles and rental operations.
  - Functions:
    - AddVehicle(): Add vehicles to the system.
    - RentedAVehicle(): Rent a vehicle to a customer.
    - Return(): Mark a vehicle as returned.
    - DisplayDetails(): Show all vehicles and their status.
    - RentReport(): View details for a specific vehicle rental.
    - PrintRentReport(): Print all rental records.

- RentalRecord:
  - Keeps track of which customer rented which vehicle and for how long.

---

## Key Features

- Supports multiple customers renting different vehicles.
- Tracks rental history using RentalRecord.
- Calculates rent based on vehicle type and rental duration.
- Prints detailed rent reports.

---

## Notes

- Make sure to define Customer and RentalRecord classes with necessary methods like GetName().
- All data is stored in-memory using lists.
-
- ![renta car output](https://github.com/user-attachments/assets/7decb5f7-563a-410f-817a-89b491feabc1)

