using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int otritchet;//переменная для открытия счета
                Console.WriteLine("Сколько открыть счетов?");  
                otritchet = Convert.ToInt32(Console.ReadLine());
                Chetvbanke[] bank = new Chetvbanke[otritchet+1];
                for (int i = 1; i < bank.Length; i++)// цикл для создания n кол-во счетов
                {
                    bank[i] = new Chetvbanke();
                    ((Chetvbanke)bank[i]).nom = i;// счет номера равен его номеру в массиве
                }
                for (int i = 0; bank.Length > 0; )
                {
                    Console.WriteLine($"На данный момент создано {otritchet} счетов .На какой счет перейти?");
                    int operachet = Convert.ToInt32(Console.ReadLine());
                    bank[operachet].zapolneniecheta(operachet);
                    Console.WriteLine($"На какой счет положить деньги?.");
                   int schet2 = Convert.ToInt32(Console.ReadLine());
                    ((Chetvbanke)bank[schet2]).sum = bank[operachet].perenos(operachet, schet2);  // метод возвращает новую сумму с последующим присваиванием
                    
                }
             
            
        }   
    }      
}
