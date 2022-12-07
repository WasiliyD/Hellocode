// Вид1
void Method1() {
    Console.WriteLine("Автор ...");
}

Method1();

//Вид2
void Method2(string msg) {
    Console.WriteLine(msg);
}
Method2("Текст сообщения");

void Method21(string msg, int count ) {
    int i = 0;
    while (i < count) {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 2);
Method21(msg:"еще текст", count: 3);
Method21(count: 2, msg:" Новый текст");

//Вид3
int Method3() {
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//вид4

string Method4(int count, string text) {
    int i = 0;
    string result = String.Empty; // string result = "";
    while (i < count) {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "текст");
Console.WriteLine(res);


//вид4 с циклом for

string Method4For(int count, string text) {
    
    string result = String.Empty; // string result = "";
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string resFor = Method4For(10, "текст1");
Console.WriteLine(resFor);

//цикл в цикле for
for (int i = 2; i <= 10; i++) {
    for (int j = 2; j <= 10; j++) {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

//=============================================================================================
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue) {
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++) { 
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
//=============================================================================================

// Упорядочить массивы от меньшего
// Было: 6 8 3 2 1 4 5 7
// Стало: 1 2 3 4 5 6 7 8
int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arr);

void SelectionSort(int[] array) {
    for (int i = 0; i < array.Length - 1; i++) {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++) {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

// Упорядочить массивы от большего
// Было: 6 8 3 2 1 4 5 7
// Стало: 8 7 6 5 4 3 2 1
int[] arrmax = { 6, 8, 3, 2, 1, 4, 5, 7 };

void PrintArraymax(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArraymax(arr);

void SelectionSortMax(int[] array) {
    for (int i = 0; i < array.Length - 1; i++) {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++) {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArraymax(arr);
SelectionSortMax(arr);
PrintArraymax(arr);
Console.WriteLine();
Console.WriteLine();
PrintArraymax(arr);
Array.Reverse(arr, 0, arr.Length );
PrintArraymax(arr);

Array.Reverse(arr);
PrintArraymax(arr);