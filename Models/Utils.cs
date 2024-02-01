namespace dotNet.Models
{
    public class Utils
    {
        public static string ValidaTexto(string texto)
        {
            if (texto == "")
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }

            return texto;
        }
        
        public virtual void Aprersentar()
        {
            Console.WriteLine($"Nome: ");
        }

    }
}