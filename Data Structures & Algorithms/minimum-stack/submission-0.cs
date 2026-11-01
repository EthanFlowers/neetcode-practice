public class MinStack {

    private Stack<int> s;
    
    public MinStack() {
        s = new Stack<int>();
    }
    
    public void Push(int val) {
        s.Push(val);
    }
    
    public void Pop() {
        s.Pop();
    }
    
    public int Top() {
        return s.Peek();
    }
    
    public int GetMin() {
        return s.Min();
    }
}
