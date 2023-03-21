
using Algorithms_Data_Structures.Algorithms;
using Algorithms_Data_Structures.Arrays;
using Algorithms_Data_Structures.Data_Structures.LinkedList;
using Algorithms_Data_Structures.Data_Structures.Stacks;

TestStacks();
// Parei em Stacks: https://youtu.be/KezSGYuYOMA?list=PL82C6-O4XrHf49SjEZWSa5DHN--ZRrcN_&t=1206

static void TestLinkedLists()
{
    LinkedList myList = new LinkedList();

    myList.InsertFirst(13);
    myList.DisplayList();

    myList.InsertFirst(29);
    myList.DisplayList();

    myList.InsertLast(135);
    myList.DisplayList();

    myList.DeleteLast();
    myList.DisplayList();
}

static void TestStacks()
{
    Stack myStack = new Stack(10);

    for(int i = 0; i < 3; i++)
    {
        myStack.Push("Squirtle");
        myStack.Push("Pikachu");
        myStack.Push("Charmander");
    }

    myStack.Pop();
    myStack.Peek();

    while(!myStack.IsEmpty())
    {
        var val = myStack.Pop();
        Console.WriteLine(val);
    }
}




