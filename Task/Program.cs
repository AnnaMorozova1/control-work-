string[] mass1 = new string[5] {"Hello", "2", "world", ":-)", "@"};
string[] mass2 = new string[mass1.Length];
void SecondMass(string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}
void PrintMass(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]} ");
    }
    Console.WriteLine();
}
SecondMass(mass1, mass2);
PrintMass(mass2);