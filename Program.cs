namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("mario", "Rossi", 25);
            Console.WriteLine(persona.GetDettagli());

            Persona persona2 = new Persona("Giovanni", "Muchaccha", 25);
            Console.WriteLine(persona2.GetDettagli());





        }
    }
}
