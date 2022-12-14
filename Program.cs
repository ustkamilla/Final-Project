string[] FirstArray = new string [5] {"func", "852", "ref", "final", "12"};
string[] SecondArray = new string[FirstArray.Length];

int count = 0;
for (int i = 0; i < FirstArray.Length; i++)
{
    if(FirstArray[i].Length <= 3)
    {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }

for (int i = 0; i < SecondArray.Length; i++)
{
    Console.Write($"{SecondArray[i]} ");
    }
Console.WriteLine();