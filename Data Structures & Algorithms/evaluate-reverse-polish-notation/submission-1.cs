public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> s = new Stack<string>();
        List<string> ops = ["+", "-", "*", "/"];

        for(int i=0; i<tokens.Length; i++){
            if(ops.Contains(tokens[i])){
                // do ops
                int a = 0;
                int l = int.Parse(s.Pop());
                int r = int.Parse(s.Pop());
                switch(tokens[i]){
                    case "+":
                        a = l + r;
                        break;
                    case "-":
                        a = r - l;
                        break;
                    case "*":
                        a = l * r;
                        break;
                    case "/":
                        a = r / l;
                        break;
                }
                s.Push(a.ToString());
            }
            else {
                // number
                s.Push(tokens[i]);
            }
        }
        return int.Parse(s.Pop());
    }
}

