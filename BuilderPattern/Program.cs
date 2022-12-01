using BuilderPattern.CarParts;
using System;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var car = new Car(4,
                        new SeatBelt("Seat"),
                        "red",
                        new Windscreen("Windscreen"),
                        new Engine("Engine"));

            var carByBuilder = new CarBuilder()
                                .AddWheels(4)
                                .AddSeatBelts(new SeatBelt("Seat Belt"))
                                .AddWindscreen(new Windscreen("Wind screen"))
                                .AddEngine(new Engine("Engine"))
                                .Paint("blue")
                                .Build();

            Console.WriteLine(car.ToString());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(carByBuilder.ToString());
        }
    }
}