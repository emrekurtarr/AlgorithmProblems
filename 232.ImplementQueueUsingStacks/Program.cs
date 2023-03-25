



MyQueue myQueue = new MyQueue();
myQueue.Push(1); // queue is: [1]
myQueue.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
myQueue.Peek(); // return 1
myQueue.Pop(); // return 1, queue is [2]
myQueue.Empty(); // return false



public class MyQueue
{
    private Stack<int> stack1 { get; set; }
     

    public MyQueue()
    {
        stack1 = new Stack<int>();
    }

    public void Push(int x)
    {
        Stack<int> tempStack = new Stack<int>();

        if (stack1.Count > 0)
        {
            while (stack1.Count > 0)
            {
                tempStack.Push(stack1.Pop());
            }

            tempStack.Push(x);

            while (tempStack.Count > 0)
            {
                stack1.Push(tempStack.Pop());
            }
        }
        else
            stack1.Push(x);
        

    }

    public int Pop()
    {
        if(stack1.Count > 0)
            return stack1.Pop();

        return -1;
    }

    public int Peek()
    {
        if (stack1.Count > 0)
            return stack1.ElementAt(0);

        else
            return -1;
    }

    public bool Empty()
    {
        return !stack1.Any();
    }
}







