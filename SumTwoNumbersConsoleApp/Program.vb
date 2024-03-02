Option Explicit Off

Module ComputeModule
    Sub main()
        Console.WriteLine("Enter any number: ")
        Number1 = Val(Console.ReadLine())
        Console.WriteLine("Enter another Number: ")
        Number2 = Val(Console.ReadLine())
        Sum = Number1 + Number2
        Console.WriteLine("The sum of these numbers is " & Sum)
        Console.ReadKey()

    End Sub
End Module