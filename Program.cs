


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