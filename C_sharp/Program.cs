// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.


string[] array = {"Hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};

int GetCountRelevantElm(string[] array) {
  int count = 0;

  for(int i = 0; i < array.Length; i++) {
    if(array[i].Length <= 3) count++;
  }

  return count;
}

void PrintArray(string[] array) {
  foreach (var item in array)
  {
    Console.WriteLine($"{item} ");
  }
}

void CreateNewArray(string[] array) {
  int count = GetCountRelevantElm(array);
  string[] newArr = new string[count];
  count = 0;

  for(int i = 0; i < array.Length; i++) {
    if(array[i].Length <= 3) {
      newArr[count] = array[i];
      count++;
    }
  }

  PrintArray(newArr);
}

CreateNewArray(array);
