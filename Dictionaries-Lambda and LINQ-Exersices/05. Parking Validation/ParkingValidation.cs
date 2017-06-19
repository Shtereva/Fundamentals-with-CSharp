using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Parking_Validation
{
    class ParkingValidation
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var parkingLot = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                string command = line[0];

                if (command == "register")
                {
                    string username = line[1];
                    string licensePlate = line[2];
                    bool isValid = CheckLicenseValidation(licensePlate);
                    bool isRegistered = TryToRegisterUser(parkingLot, username, licensePlate, isValid);

                    if (!isRegistered)
                    {
                        parkingLot[username] = licensePlate;
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }

                else
                {
                    UnregisterUser(parkingLot, line);
                }
            }

            parkingLot
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Key} => {x.Value}"));
        }

        private static void UnregisterUser(Dictionary<string, string> parkingLot, string[] line)
        {
            if (!parkingLot.ContainsKey(line[1]))
            {
                Console.WriteLine($"ERROR: user {line[1]} not found");
            }

            else
            {
                parkingLot.Remove(line[1]);
                Console.WriteLine($"user {line[1]} unregistered successfully");
            }
        }

        private static bool TryToRegisterUser(Dictionary<string, string> parkingLot, string username, string licensePlate, bool isValid)
        {
            if (parkingLot.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {parkingLot[username]}");
                return true;
            }

            if (!isValid)
            {
                Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
                return true;
            }

            else if (parkingLot.ContainsValue(licensePlate))
            {
                Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
                return true;
            }

            return false;
        }

        private static bool CheckLicenseValidation(string licensePlate)
        {
            if (licensePlate.Length == 8)
            {
                var arr = licensePlate.ToCharArray();
                var isUpper = arr.Take(2).Concat(arr.Skip(6).Take(2).ToArray()).All(char.IsUpper);
                var middleChars = arr.Skip(2).Take(4).All(char.IsDigit);

                if (isUpper && middleChars)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
