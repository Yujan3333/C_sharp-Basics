using Class_new;

apple food = new apple();

Ifruit food1 = food;
food.eating();
food1.riding();

//Ivehicle food2 = food;
//food2.riding();

//banana food3=new banana();
//food3.eating(); 
//food3.riding();


//List like array in .NET
List<int> number=new List<int> { 1,4,3,2,6};
number.Add(100);
number.Remove(number[4]);
number.Sort();
foreach(int item in number)
{
    Console.WriteLine(item);
}