using System;

namespace consoleExceptionHandling
{
    class exceptionHandling
    {
        static void Main()
        {
            Stack S = new Stack(5);

            S.push(10);
            S.push(20);
            S.push(30);
            S.push(40); 
            S.push(50);
            

            Console.WriteLine("Items : ");
            //Printing Stack values
            S.printStack();

            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();
            S.pop();

        }
    }
    class Stack
    {
        private int[] ele;
        private int top;
        private int max;
        //Stack class construction
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }
        //Push values
        public void push(int item)
        {
            if (top == max - 1)
            {
               throw new StackOverFlowException("Stack Over flow");
                
            }
            else
            {
                ele[++top] = item;
            }
        }
        //POP Values
        public int pop()
        {
            if (top == -1)
            {
               throw new StackUnderFlowException("Stack Under flow");
                
            }

            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }
        }
        //Printing Stack values
        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }

	public class StackOverFlowException : Exception
    {
        public StackOverFlowException(string msg) : base(msg)
        {

        }
    }
    public class StackUnderFlowException : Exception
    {
        public StackUnderFlowException(string msg) : base(msg)
        {

        }
    }

}
