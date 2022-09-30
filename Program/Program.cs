Console.Clear();

string[] array = new string[] { "Russia", ":-)", "Denmark", "123", "4321" };
string[] result = new string[array.Length];
int symbols = 3;
int count = 0;

WordSearch(array, result);
PrintArray(result);

void WordSearch(string[] array, string[] result)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= symbols)
        {
            result[count] = array[i];
        }
        count++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}