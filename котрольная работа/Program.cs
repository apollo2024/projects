string[] mass = {"jojo", ":-)", "ko", "php"};

Getresult(mass);

void Getresult (string[] mass)
{
   for (int i = 0; i <= mass.Length; i++) 
   {
       if(mass[i].Length >= 3)
       {
        System.Console.WriteLine((mass[i]) );
       }
   }
}
