public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> h_set = new Dictionary<char, int>();

        int max_substring = 0;
        int sub_str_start = 0;
    
        for(int i=0; i<s.Length; i++){
            //Console.WriteLine(i + " " + sub_str_start + " " + String.Join(",", h_set.ToArray()));

            if(!h_set.TryAdd(s[i], i)){
                if(h_set.Count > max_substring){
                    max_substring = h_set.Count;
                }
                int old_sub_str_start = sub_str_start;
                sub_str_start = h_set[s[i]] + 1;
                
                for(int x=old_sub_str_start; x<sub_str_start; x++){
                    h_set.Remove(s[x]);
                }
                h_set.Add(s[i], i);
                //Console.WriteLine(String.Join(",", h_set.ToArray()));

                
            }
        }
        // if(sub_str_start==0){
        //     return s.Length;
        // }
        if(h_set.Count > max_substring){
            max_substring = h_set.Count;
        }
        return max_substring;

        //abcdbxyz
    }
}
