using System;

namespace Examples
{
    class Program
    {

        static void Main()
        {
            // Tam sayı türleri
            short a = 10;
            int b = 10;
            long c = 10;
            long d = a + b + c;

            //Yazdırma İşlemi
            Console.WriteLine($"d = {d}\n a = {a}\n b = {b}\n c = {c}\n d = a + b + c = {d}\n");

            // Ondalıklı sayı türleri
            float e = 10.5f;
            double f = 10.5;
            decimal g = 10.5m;

            //Yazdırma İşlemi
            Console.WriteLine($"e = {e}\n f = {f}\n g = {g}\n");

            //Operatörler
            int x = 10 + 7; //toplama
            x += 5; //toplama
            x = x - 3; //çıkarma
            float y = 105.9f - 25.2f; //çıkarma
            y -= 5.3f; //çıkarma
            y = y + 7.3f; //toplama
            double z = 47.3 * 5.7; //çarpma
            z *= 3.5; //çarpma
            z = z / 2.5; //bölme
            int t = 10 / 3; //bölme
            t /= 3; //bölme
            t = t * 3; //çarpma
            int u = 10 % 3; //mod alma
            int v = u++; //arttırma
            v++; //arttırma
            v--; //azaltma
            Console.WriteLine($"x = {x}\n y = {y}\n z = {z}\n t = {t}\n u = {u}\n v = {v}\n");

            //Mantıksal Değerler ve Operatörler
            bool hungry = true;
            bool tired = false;

            hungry = !hungry; //Değeri tersine çevirme
            bool tiredOrHungry = hungry || tired; //veya
            bool tiredAndHungry = hungry && tired; //ve
            bool notHungryAndTired = !hungry && tired; //ve
            bool hungryAndNotTired = hungry && !tired; //ve
            bool hungryOrTiredButNotBoth = hungry ^ tired; //ya da

            //Karşılaştırma Operatörleri
            //== eşittir
            //!= eşit değildir
            //< küçüktür
            //> büyüktür
            //<= küçük eşittir
            //>= büyük eşittir

            bool b1 = 7 < 15; //true
            bool b2 = 7 > 15; //false
            bool b3 = 7 <= 15; //true
            bool b4 = 7 >= 15; //false
            bool b5 = 7 == 15; //false
            bool b6 = 7 != 15; //true
            bool b7 = 7 < 15 && 7 > 5; //true
            bool b8 = 7 < 15 || 7 > 5; //true
            bool b9 = 7 < 15 ^ 7 > 5; //false


            //true && true = true
            //true && false = false
            //false && true = false
            //false && false = false
            //true || true = true
            //true || false = true
            //false || true = true
            //false || false = false
            //true ^ true = false
            //true ^ false = true
            //false ^ true = true
            //false ^ false = false

            //Kontrol Yapıları
            //İlk kontrol yapısı
            if (tiredOrHungry)
            {
                Console.WriteLine("You are tired or hungry");
            }
            //Alternatif kontrol yapısı
            else if (tiredAndHungry)
            {
                Console.WriteLine("You are tired and hungry");
            }
            //Alternatif kontrol yapısı
            else if (notHungryAndTired)
            {
                Console.WriteLine("You are not hungry and tired");
            }
            //Eğer yukarıdaki koşullar sağlanmazsa
            else
            {
                Console.WriteLine("You are hungry and not tired");
            }

            int age = 20;

            switch (age)
            {
                case < 18:
                    Console.WriteLine("You are a minor");
                    break;
                case 19:
                    Console.WriteLine("You are 19 years old");
                    break;
                case 20:
                    Console.WriteLine("You are 20 years old");
                    break;
                case > 20:
                    Console.WriteLine("You are an adult");
                    break;
            }

            string city = "Ankara";

            switch (city)
            {
                case "Ankara" or "Antalya" or "Adana" or "İstanbul" or "İzmir":
                    Console.WriteLine("You are living in Turkey");
                    if (city.ToLower().StartsWith("a")) Console.WriteLine("You are living in a city starting with 'A'");
                    break;
                case "Berlin" or "München" or "Hamburg":
                    Console.WriteLine("You are living in Germany");
                    break;
                case "Paris" or "Lyon" or "Marseille":
                    Console.WriteLine("You are living in France");
                    break;
                case "Tokyo" or "Kyoto" or "Osaka":
                    Console.WriteLine("You are living in Japan");
                    if (city.ToLower().Contains("to")) Console.WriteLine("You are living in Tokyo or Kyoto");
                    break;
                default:
                    Console.WriteLine("You are living in another country");
                    break;
            }

            //Döngüler
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int q = 0;
            while (q < 10)
            {
                Console.WriteLine(q);
                q++;
            }
            q = 0;
            do
            {
                Console.WriteLine(q);
                q++;
            }
            while (q < 10);

            //Diziler ve Koleksiyonlar
            //Dizi
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Dizi elemanlarına erişim
            int num0 = numbers[0];
            int num1 = numbers[6];
            //Dizi elemanlarını değiştirme
            numbers[0] = 10;
            numbers[6] = 70;
            //Dizi elemanlarını döngü ile yazdırma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            //veya
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Liste
            List<int> numberList = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numberList.Add(i);
            }
            //Liste elemanlarını döngü ile yazdırma
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
            //Liste elemanlarını silme
            numberList.Remove(5);
            //Liste elemanlarını indise göre silme
            numberList.RemoveAt(5);

            //Sözlük
            Dictionary<int, string> plateCodes = new Dictionary<int, string>();
            plateCodes.Add(6, "Ankara");
            plateCodes.Add(34, "İstanbul");
            plateCodes.Add(35, "İzmir");
            plateCodes.Add(7, "Antalya");
            //Sözlük elemanlarına erişim
            string city1 = plateCodes[6];
            string city2 = plateCodes[34];
            //Sözlük elemanlarını döngü ile yazdırma
            foreach (KeyValuePair<int, string> plateCode in plateCodes)
            {
                Console.WriteLine($"Plate code: {plateCode.Key}, City: {plateCode.Value}");
            }
            //Sözlük elemanlarını silme
            plateCodes.Remove(6);

            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Turkey", "Ankara");
            capitals.Add("Germany", "Berlin");
            capitals.Add("France", "Paris");
            capitals.Add("Japan", "Tokyo");
            //Sözlük elemanlarına erişim
            string capital1 = capitals["Turkey"];
            string capital2 = capitals["Germany"];
            //Sözlük elemanlarını döngü ile yazdırma
            foreach (KeyValuePair<string, string> capital in capitals)
            {
                Console.WriteLine($"Country: {capital.Key}, Capital: {capital.Value}");
            }


            //Polimorfizm
            Organism[] organisms = new Organism[]
            {
                new Fish("Fish", 0.5f),
                new Bird("Bird", 0.3f),
                new Animal("Animal", 5),
                new Plant("Rose"),
                new Fruit("Apple"),
                new Vegetable("Carrot")
            };
            foreach (Organism organism in organisms)
            {
                if (organism is Animal animal)
                {
                    Console.WriteLine("Organism is an animal and weight is " + animal.Weight + " kg");
                }
                else if (organism is Plant plant)
                {
                    Console.WriteLine("Organism is a plant and name is " + plant.WaterAmount + " kg");
                }
                else
                {
                    Console.WriteLine("Organism is not an animal or a plant");
                }
            }
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sum(params int[] nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        public static char[] GetFirstChars(params string[] texts)
        {
            List<char> firstChars = new List<char>();
            foreach (string text in texts)
            {
                if (text != null)
                    firstChars.Add(text[0]);
            }
            return firstChars.ToArray();
        }
        public static void PrintNameAndSurname(string name, string surname)
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}");
        }
        public static void PrintNameAndSurname(string name, string surname, int age)
        {
            Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {age}");
        }

    }
}