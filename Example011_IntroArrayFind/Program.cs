int [] array = {1, 12, 16, 48, 96, 65, 75, 4 };

int n = array.Length; //возвращает количество элементов
int find = 48;

int index = 0;
while (index < n) 
{
  if(array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  //index = index + 1;
  index++;
}