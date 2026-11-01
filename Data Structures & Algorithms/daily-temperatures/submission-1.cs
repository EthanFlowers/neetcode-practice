public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] ans = new int[temperatures.Length];
        Stack<int> s = new Stack<int>();
        for(int i=0; i<temperatures.Length; i++){
            while(s.Count > 0 && temperatures[s.Peek()] < temperatures[i] ){    
                int a = s.Pop();
                //Console.WriteLine($"a {a} {temperatures[a]} temp[i] {i} {temperatures[i]}");

                ans[a] = i-a;
            }
            s.Push(i);
        }
        return ans;
    }
}
