using DOTNET___POO.src.Entities;



namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23,"knigth");
        
            Wizard wizard = new Wizard ("Jennica",23,"White Wizard");
           
            Console.WriteLine(wizard.Attack(1));

          
        }
    }
}

