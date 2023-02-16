/* 1 задача
int [] CreatNewArray (int size , int minVal , int maxVal)
{
    int []array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(minVal, maxVal+1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]+" ");
    }
    Console.WriteLine();
}

int Proverka(int [] array)
{
    int result=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2==0)
        {
            result++;
        }
    }
    return result;
}

Console.WriteLine("Введите размер массива: ");
int user_size=Convert.ToInt32(Console.ReadLine());
int minNum=100;
int maxNum=999;

int [] newArray= CreatNewArray(user_size, minNum, maxNum);
ShowArray(newArray);

Console.WriteLine($"Четных чисел в мвссиве: {Proverka(newArray)}");
*/
/*2 задача
int [] CreatNewArray (int size , int minVal , int maxVal)
{
    int []array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(minVal, maxVal+1);
    }
    return array;
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]+" ");
    }
    Console.WriteLine();
}

int Proverka(int [] array)
{
    int result=0;
    for (int i = 1; i < array.Length;i=i+2)
    {
       result+=array[i];
    }
    return result;
}

int size=6;
int minNum=-100;
int maxNum=100;

int [] newArray= CreatNewArray(size, minNum, maxNum);
ShowArray(newArray);

Console.WriteLine($"Сумма чисел: {Proverka(newArray)}");
*/

//3 задача
double []NewArray(int size, double min,double max)
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i]=(min+Math.Round((new Random().NextDouble()*(max-min)),1));
    }
    return array;
}
void PrintArr(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+"  ");
    }
}

void Proverka(double []array)
{
    double min=array[0];
    double max=0;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
           min=array[i];
        else if(array[i]>max)
           max=array[i];
    }
    result=max-min;
    Math.Round(result);
    Console.WriteLine($"Разница: {result}");
}


Console.WriteLine("Введите число: ");
int user_size=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мин число: ");
int user_min=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите мах число: ");
int user_max=Convert.ToInt32(Console.ReadLine());
//NewArray(user_size, user_min, user_max);
double [] newArray= NewArray(user_size, user_min,user_max);
PrintArr(newArray);
Proverka(newArray);
