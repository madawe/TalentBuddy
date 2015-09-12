using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class MyClass {


    public void compute_expression(string expr) {
    System.Collections.Generic.Stack<char> myStack = new System.Collections.Generic.Stack<char>();
    string output = "";
        // Rewriting the string into Reverse Polish Notation(RPN) format
        foreach(char token in expr)
        {
             //Read a token.
            //If the token is a number, then add it to the output queue.
            if (Char.IsNumber(token) == true)
            {
                output = output + ' ' +token;
            }
            if(token == '+' || token == '-')
            {
                if (myStack.Count() != 0)
                {
                        while(myStack.Peek() == '*' || myStack.Peek() == '/' || myStack.Peek() == '-')
                        {
                            if (myStack.Count() != 0)
                            {
                                output = output + ' ' + myStack.Peek();
                                myStack.Pop();
                            }
                            if (myStack.Count() == 0)
                            {
                                break;
                            }
                        }
                }
                myStack.Push(token);
            }
            if(token == '(')
            { 
                myStack.Push(token);
            }

            if (token == ')')
            {
                if (myStack.Count() != 0)
                {
                    while (myStack.Peek() != '(')
                    {
                        if (myStack.Count() != 0)
                        {
                            output = output + ' ' + myStack.Peek();
                            myStack.Pop();
                        }
                    }
                myStack.Pop();
                }
            }
        }
           while(myStack.Count() != 0)
           {
               output = output + " " + myStack.Peek();
               myStack.Pop();
           }
//Done RPN
           //Now we need to Evaluate the RPN
           evalu(output);  
    }
//Evaluating RPN
        public static void evalu(string output){
            int num1 = 0;
            int num2 = 0;
            System.Collections.Generic.Stack<int> myStack = new System.Collections.Generic.Stack<int>();
            foreach (char token in output)
            {
                if (Char.IsNumber(token) == true)
                {
                    myStack.Push(int.Parse(token.ToString())); 
                }
                if (token == '+' || token == '-' || token == '*' || token == '/')
                {
                    if (token == '+')
                    {
                        num1 = myStack.Peek();
                        myStack.Pop();
                        num2 = myStack.Peek();
                        myStack.Pop();
                        myStack.Push(num1 + num2);
                    }

                    if (token == '-')
                    {
                        num1 = myStack.Peek();
                        myStack.Pop();
                        num2 = myStack.Peek();
                        myStack.Pop();
                        myStack.Push(num2 - num1);
                    }
                    if (token == '*')
                    {
                        num1 = myStack.Peek();
                        myStack.Pop();
                        num2 = myStack.Peek();
                        myStack.Pop();
                        myStack.Push(num1 * num2);
                    }
                    if (token == '/')
                    {
                        num1 = myStack.Peek();
                        myStack.Pop();
                        num2 = myStack.Peek();
                        myStack.Pop();
                        myStack.Push(num1 / num2);
                    }
                }
            }
        PrintValues(myStack, ' ');  
        }
    public static void PrintValues(System.Collections.IEnumerable myCollection, char mySeparator)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0}{1}", mySeparator, obj);
        Console.WriteLine();
    }
}