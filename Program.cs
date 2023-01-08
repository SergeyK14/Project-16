// Программа формирует из имеющегося массива строк новый массив 
//из элементов с количеством символов больше либо равно 3.
void ThreeSymbolArray()
{
    int size = 7;
    string [] Array = new string [size];
    FillStringArray(Array);
    PrintStringArray(Array);
    
    int secondSize = size; //
    string [] SecondArray = new string [secondSize];
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
        {
            if (Array [i].Length < 4)
            {
                SecondArray [count] = Array [i];
                count+=1;
            }
        }
    PrintStringArray(SecondArray);
}
ThreeSymbolArray();

void FillStringArray (string [] StrAr)
{
    int length = StrAr.Length;
    string abc = "ABCDEFGHIJK1234-+*/^&";
    int abcLength = abc.Length;
    Random rand = new Random ();
    for (int i = 0; i < length; i++)
    {
        int rowLength = rand.Next (1, abcLength);
        for (int j = 0; j < rowLength; j++)
        {
            int indexRow = rand.Next (0, abcLength);
            StrAr [i] += abc[indexRow];
        }    
    }
}

void PrintStringArray (string [] StrAr)
{
    int length = StrAr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"{StrAr [i]}\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}