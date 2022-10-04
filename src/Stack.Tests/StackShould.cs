namespace Stack.Tests;
using Xunit;
public class StackShould
{
    [Fact]
    public void StackPeek()
    {
        Stack<int> myStack= new Stack<int>();
        myStack.Push(3);
        myStack.Push(4);
        Assert.Equal(4,myStack.Peek());
    }
    [Fact]
    public void StackPop()
    {
        Stack<int> myStack= new Stack<int>();
        myStack.Push(3);
        myStack.Push(4);
        Assert.Equal(4,myStack.Pop());
        Assert.Equal(3,myStack.Peek());
    }
}
