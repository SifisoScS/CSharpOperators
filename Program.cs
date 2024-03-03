
        // Arithmetic Operators
        int num1 = 10;
        int num2 = 5;
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");
        Console.WriteLine($"Division: {num1 / num2}");
        Console.WriteLine($"Modulus: {num1 % num2}");
        Console.WriteLine();

        // Comparison Operators
        int a = 8;
        int b = 7;
        Console.WriteLine("Comparison Operators:");
        Console.WriteLine($"Equal: {a == b}");
        Console.WriteLine($"Not Equal: {a != b}");
        Console.WriteLine($"Greater Than: {a > b}");
        Console.WriteLine($"Less Than: {a < b}");
        Console.WriteLine($"Greater Than or Equal To: {a >= b}");
        Console.WriteLine($"Less Than or Equal To: {a <= b}");
        Console.WriteLine();

        // Logical Operators
        bool isTrue = true;
        bool isFalse = false;
        Console.WriteLine("Logical Operators:");
        Console.WriteLine($"Logical AND: {isTrue && isFalse}");
        Console.WriteLine($"Logical OR: {isTrue || isFalse}");
        Console.WriteLine($"Logical NOT: {!isTrue}");
        Console.WriteLine();

        // Bitwise Operators
        int bitwiseNum1 = 5; // Binary: 0101
        int bitwiseNum2 = 3; // Binary: 0011
        Console.WriteLine("Bitwise Operators:");
        Console.WriteLine($"Bitwise AND: {bitwiseNum1 & bitwiseNum2}"); // Result: 0001 (1 in decimal)
        Console.WriteLine($"Bitwise OR: {bitwiseNum1 | bitwiseNum2}"); // Result: 0111 (7 in decimal)
        Console.WriteLine($"Bitwise XOR: {bitwiseNum1 ^ bitwiseNum2}"); // Result: 0110 (6 in decimal)
        Console.WriteLine($"Bitwise NOT: {~bitwiseNum1}"); // Result: 11111111111111111111111111111010 (-6 in decimal)
        Console.WriteLine($"Left Shift: {bitwiseNum1 << 1}"); // Result: 10 (10 in decimal)
        Console.WriteLine($"Right Shift: {bitwiseNum1 >> 1}"); // Result: 2 (2 in decimal)
        Console.WriteLine();

        // Assignment Operators
        int x = 10;
        Console.WriteLine("Assignment Operators:");
        x += 5; // Equivalent to x = x + 5
        Console.WriteLine($"x += 5: {x}");
        x -= 3; // Equivalent to x = x - 3
        Console.WriteLine($"x -= 3: {x}");
        x *= 2; // Equivalent to x = x * 2
        Console.WriteLine($"x *= 2: {x}");
        x /= 4; // Equivalent to x = x / 4
        Console.WriteLine($"x /= 4: {x}");
        x %= 3; // Equivalent to x = x % 3
        Console.WriteLine($"x %= 3: {x}");
        Console.WriteLine();
