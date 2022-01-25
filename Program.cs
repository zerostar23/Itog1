
string[] Izm(string[] ArrayS)
    {
    string[] ArrayVtor = new string[0]; 
    int j = 0;

    for (int i = 0; i < ArrayS.Length; i++)
    {
        if (ArrayS[i].Length <= 3) 
        {
            Array.Resize(ref ArrayVtor, ArrayVtor.Length+1);
            ArrayVtor[j] = ArrayS[i];
            j++;
        }
    }
        return ArrayVtor;
}

void Print(string[] ArrayVtor)
{	
for (int i = 0; i < ArrayVtor.Length; i++)
{
    Console.WriteLine(ArrayVtor[i]);
}
}

string[] ArrayS = {"1234", "1567", "-2", "computer science"};
Print(Izm(ArrayS));