using ConsoleApp6;

Console.WriteLine("Hello, World!");
    vector_3 vector = new vector_3(1, 2, 3);
    Car audi = new Car("audi", vector);
    audi.Start();
    audi.Move(new vector_3(0, 4, 5));
    Console.WriteLine(audi.Getinfo());
    audi.Move(new vector_3(0, 4, 5));
    Console.WriteLine(audi.Getinfo());
    audi.off();
    audi.Move(new vector_3(0, 4, 5));
    Console.WriteLine(audi.Getinfo());
    audi.Move(new vector_3(0, 4, 5));
    Console.WriteLine(audi.Getinfo());
