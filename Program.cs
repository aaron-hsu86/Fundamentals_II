// Three Basic Arrays
int[] intArray = new int[] {0,1,2,3,4,5,6,7,8,9};
string[] strArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
bool[] boolArray = new bool[10];
for (int i = 0;i<10;i++){
    if (i%2 == 0 ){
        boolArray[i]=true;
    } else {
        boolArray[i]=false;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", intArray));
Console.WriteLine("[{0}]", string.Join(", ", strArray));
Console.WriteLine("[{0}]", string.Join(", ", boolArray));

// List of Flavors
List<string> flavors = new List<string>{"vanilla", "chocolate", "strawberry", "pistachio", "fudge"};
Console.WriteLine(flavors.Count);
Console.WriteLine(flavors[2]);
flavors.Remove("strawberry");
Console.WriteLine(flavors.Count);

// User Dictionary
Dictionary<string,string> dictionary = new Dictionary<string,string>();
for (int i = 0;i<strArray.Length; i++){
    Random random= new Random();
    dictionary.Add(strArray[i],flavors[random.Next(flavors.Count)]);
}
foreach (KeyValuePair<string,string> entry in dictionary){
    Console.WriteLine($"{entry.Key} - {entry.Value}");
}