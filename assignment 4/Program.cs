#region part 1
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int? nullableNumber = null;
//        Console.WriteLine($"Nullable Value: {nullableNumber ?? 0}");

//        nullableNumber = 50;
//        Console.WriteLine($"Nullable Value: {nullableNumber.Value}");

//        int result = nullableNumber ?? -1;
//        Console.WriteLine($"Result with Null-Coalescing: {result}");
//    }
//}
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        int value = 42;
//        object boxedValue = value; // Boxing
//        Console.WriteLine($"Boxed Value: {boxedValue}");

//        int unboxedValue = (int)boxedValue; // Unboxing
//        Console.WriteLine($"Unboxed Value: {unboxedValue}");
//    }
//}

#endregion
//part 2 
#region q1
//using System;

//class Program
//{
//    enum WeekDays
//    {
//        Monday,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    static void Main(string[] args)
//    {
//        // Loop through all the values of the enum WeekDays
//        foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
//        {
//            Console.WriteLine(day);
//        }
//    }
//}

#endregion
#region q2
//using System;

//class Program
//{
//    enum Season
//    {
//        Spring,
//        Summer,
//        Autumn,
//        Winter
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
//        string userInput = Console.ReadLine();

//        // Parse the user input to the corresponding enum value
//        if (Enum.TryParse(userInput, true, out Season season))
//        {
//            string seasonRange = GetSeasonMonthRange(season);
//            Console.WriteLine($"The month range for {season} is: {seasonRange}");
//        }
//        else
//        {
//            Console.WriteLine("Invalid season input. Please enter a valid season.");
//        }
//    }

//    static string GetSeasonMonthRange(Season season)
//    {
//        switch (season)
//        {
//            case Season.Spring:
//                return "March to May";
//            case Season.Summer:
//                return "June to August";
//            case Season.Autumn:
//                return "September to November";
//            case Season.Winter:
//                return "December to February";
//            default:
//                return "Unknown season";
//        }
//    }
//}

#endregion
#region q4
//using System;

//[Flags]
//enum Permissions
//{
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Permissions userPermissions = Permissions.Read | Permissions.Write;

//        Console.WriteLine($"Initial Permissions: {userPermissions}");

//        userPermissions = AddPermission(userPermissions, Permissions.Delete);
//        Console.WriteLine($"After Adding Delete: {userPermissions}");

//        userPermissions = RemovePermission(userPermissions, Permissions.Write);
//        Console.WriteLine($"After Removing Write: {userPermissions}");

//        if (HasPermission(userPermissions, Permissions.Execute))
//        {
//            Console.WriteLine("User has Execute permission.");
//        }
//        else
//        {
//            Console.WriteLine("User does not have Execute permission.");
//        }
//    }

//    static Permissions AddPermission(Permissions currentPermissions, Permissions permissionToAdd)
//    {
//        return currentPermissions | permissionToAdd;
//    }

//    static Permissions RemovePermission(Permissions currentPermissions, Permissions permissionToRemove)
//    {
//        return currentPermissions & ~permissionToRemove;
//    }

//    static bool HasPermission(Permissions currentPermissions, Permissions permissionToCheck)
//    {
//        return (currentPermissions & permissionToCheck) == permissionToCheck;
//    }
//}
//using System;

//[Flags]
//enum Permissions
//{
//    Read = 1,
//    Write = 2,
//    Delete = 4,
//    Execute = 8
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Permissions userPermissions = Permissions.Read | Permissions.Write;

//        Console.WriteLine($"Initial Permissions: {userPermissions}");

//        userPermissions = AddPermission(userPermissions, Permissions.Delete);
//        Console.WriteLine($"After Adding Delete: {userPermissions}");

//        userPermissions = RemovePermission(userPermissions, Permissions.Write);
//        Console.WriteLine($"After Removing Write: {userPermissions}");

//        if (HasPermission(userPermissions, Permissions.Execute))
//        {
//            Console.WriteLine("User has Execute permission.");
//        }
//        else
//        {
//            Console.WriteLine("User does not have Execute permission.");
//        }
//    }

//    static Permissions AddPermission(Permissions currentPermissions, Permissions permissionToAdd)
//    {
//        return currentPermissions | permissionToAdd;
//    }

//    static Permissions RemovePermission(Permissions currentPermissions, Permissions permissionToRemove)
//    {
//        return currentPermissions & ~permissionToRemove;
//    }

//    static bool HasPermission(Permissions currentPermissions, Permissions permissionToCheck)
//    {
//        return (currentPermissions & permissionToCheck) == permissionToCheck;
//    }
//}

#endregion
#region q5 
//using System;

//enum Colors
//{
//    Red,
//    Green,
//    Blue
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a color (Red, Green, Blue): ");
//        string userInput = Console.ReadLine();

//        if (Enum.TryParse(userInput, true, out Colors color))
//        {
//            if (IsPrimaryColor(color))
//            {
//                Console.WriteLine($"{color} is a primary color.");
//            }
//            else
//            {
//                Console.WriteLine($"{color} is not a primary color.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid color input. Please enter a valid color.");
//        }
//    }

//    static bool IsPrimaryColor(Colors color)
//    {
//        return color == Colors.Red || color == Colors.Green || color == Colors.Blue;
//    }
//}

#endregion