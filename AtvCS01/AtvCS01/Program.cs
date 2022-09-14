class program
{
    static void Main()
    {
        string[] names = { "Marlos", "Thiago", "Mell" };

        if (names[0] == "Marlos")
        {
            Console.WriteLine("Igual");
        }
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

    }
}