using System.Threading.Tasks.Sources;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             int sayı1 =4, sayı2 = 465;

             Console.WriteLine("hangi işlemi istiyorsunuz");
             char c = Convert.ToChar(Console.ReadLine());
             double ss = c switch {

                 '+' => sayı1 + sayı2,
                 '-' => sayı1 - sayı2,
                 '*'=> sayı1*sayı2,
                 _ => double.NaN             



             };       

            Console.WriteLine("hangi ay");
            string mevsım= Console.ReadLine()
                ;

            string takvım = mevsım switch
            {
                "ocak" or "subat" or "mart" => "kıs",
                "nisan" or "mayıs" or "hazıran" => "yaz",
                _=>"gecersiiiiiiiz"

            };
            Console.WriteLine(takvım);


        }
    }
}
