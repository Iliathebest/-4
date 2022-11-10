// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int []array=GetArray(8);
int []GetArray(int size)
{
    int []array=new int [size];
     
     for( int i=0;i< size;i++)
     {
        array[i]=new Random().Next(0,9);
     }
     return array;
}
Console.WriteLine(String.Join(",",array));



