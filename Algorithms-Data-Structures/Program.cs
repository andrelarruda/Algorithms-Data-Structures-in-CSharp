
using Algorithms_Data_Structures.Algorithms;
using Algorithms_Data_Structures.Arrays;
using Algorithms_Data_Structures.Data_Structures.LinkedList;
using Algorithms_Data_Structures.Data_Structures.Queue;
using Algorithms_Data_Structures.Data_Structures.Stacks;

TestQueues();

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

static void TestQueues()
{
    Queue queue = new Queue(10);

    queue.Enqueue(1);
    queue.Enqueue(2);
    queue.Enqueue(3);
    queue.Enqueue(4);

    queue.Dequeue();
    queue.Dequeue();

    Console.WriteLine(queue.Peek());
}




