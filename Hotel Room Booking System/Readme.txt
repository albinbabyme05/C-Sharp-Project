# Hotel Room Booking System

This project is a simple **Hotel Room Booking System** built in C#. It uses **encapsulation**, **inheritance**, and **polymorphism** to manage room types, bookings, and availability.

## Project Structure

- **Room (Base Class)**: Common details for all rooms like room number, type, price, and status.
- **Subclasses**: `StandardRoom`, `DeluxeRoom`, `SuiteRoom`, each with its own price calculation logic.
- **BookingManager**: Handles room bookings, check-ins, check-outs, and room availability.

---

## Classes and Their Purpose

### 1. **Room (Base Class)**
- **Properties**:
  - `RoomNumber` (public): Room number.
  - `RoomType` (public): Type of room (Standard, Deluxe, Suite).
  - `Status` (private): Room status ("Available", "Booked", "Occupied").
  - `PricePerNight` (protected): Price for one night.
  
- **Methods**:
  - `CalculateBill(int nights)`: Calculates the total bill for the room. Each subclass overrides this.
  - `CheckAvailability()`: Returns true if the room is available.
  - `BookRoom()`: Marks the room as booked.
  - `CheckOutRoom()`: Resets room status to available.

---

### 2. **Subclasses: StandardRoom, DeluxeRoom, SuiteRoom**
Each of these subclasses inherits from the `Room` class. They override `CalculateBill()` to handle their own specific price calculations.

- **StandardRoom**: Base price per night.
- **DeluxeRoom**: Base price + extra charges (e.g., room service).
- **SuiteRoom**: Base price + luxury charges (spa, food, etc.).

---

### 3. **BookingManager**
Manages all bookings and room availability.

- **Properties**:
  - `Rooms`: A list of all rooms in the hotel.
  - `Bookings`: Records which rooms are booked.

- **Methods**:
  - `AddRoom(Room room)`: Adds a room to the system.
  - `FindAvailableRooms()`: Returns a list of rooms that are available.
  - `BookRoom(int roomNumber)`: Books a room (marks it as "Booked").
  - `CheckOutRoom(int roomNumber)`: Marks a room as "Available".

---

## Key Rules and Logic
- **Rooms cannot be booked if already booked**.
- **SuiteRoom**: Minimum stay of 2 nights.
- **Discount**: A 10% discount for bookings over 7 nights.
- **Extra charges** for Deluxe and Suite rooms based on services (e.g., room service, food, spa).

---

## Instructions to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/hotel-booking-system.git
