public class Solution {
    public bool IsPalindrome(string s) {
        
        int p1 = 0;
        int p2 = s.Length-1;
        string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        while(p1 < p2){
            Console.WriteLine(p1 + " " + p2);

            while((p1 < s.Length && p2 >= 0) && alpha.IndexOf(s[p1]) < 0){
                p1++;
            }    
            while((p1 < s.Length && p2 >= 0) && alpha.IndexOf(s[p2]) < 0){
                p2--;
            }

            if(p1 >= p2 || p1 >= s.Length || p2 < 0){
                return true;
            }  

            if(Char.ToLower(s[p1]) != Char.ToLower(s[p2])){
                return false;
            }

            p1++;
            p2--;
        }

        return true;
    }
}
