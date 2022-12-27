string[] mass = {"jojo", ":-)", "ko", "php"};
string[] result = {};
Getresult(mass);

string[] Getresult (string[] mass)
{
   for (int i = 0; i <= mass.Length; i++) 
   {
       if(mass[i].Length >= 3)
       {
        result = mass[i];
       }
   }
    return (result);
}
