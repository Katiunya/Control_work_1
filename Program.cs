Console.WriteLine("Input the number of array elements: ");
int size  = Convert.ToInt32(Console.ReadLine());


string[] array = new string[size];

for (int i = 0; i < size; i++){
	Console.Write("Input an array element: ");
    string result = Convert.ToString(Console.ReadLine());

	array[i] = result;  
}

Console.WriteLine();
Console.Write("The entered array: [");
Console.Write(string.Join(",", array));
Console.Write("]");

int count = 0;
int maxChar = 3;

for (int i = 0; i < array.Length; i++){
	if(array[i].Length <= maxChar){
		count++;
	}   
}

Console.WriteLine();
Console.Write("The resulting array: [");

string[] newArray = new string[count];
int j = 0;

for (int i = 0; i < array.Length; i++){
    if(array[i].Length <= maxChar){
        newArray[j] = array[i];
        Console.Write(newArray[j] + ",");
        j++;
    }
}

Console.Write("]");

