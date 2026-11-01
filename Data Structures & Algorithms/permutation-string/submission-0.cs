public class Solution {
    private bool checkDictionary(Dictionary<char, int> d1, Dictionary<char, int> d2) {
        if (d1.Count == d2.Count) {
            foreach (var kvp1 in d1) {
                if (d2.TryGetValue(kvp1.Key, out var v2)) {
                    if (v2 != kvp1.Value) {
                        return false;
                    }
                } else {
                    return false;
                }
            }
        }
        else {
            return false;
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2) {
        int l = 0;

        Dictionary<char, int> d1 = new Dictionary<char, int>();
        Dictionary<char, int> d2 = new Dictionary<char, int>();

        if (s1.Length > s2.Length) {
            return false;
        }

        for (int i = 0; i < s1.Length; i++) {
            if (!d1.TryAdd(s1[i], 1)) {
                d1[s1[i]] = d1[s1[i]] + 1;
            }
        }
        for (int r = 0; r < s2.Length; r++) {
            if (!d2.TryAdd(s2[r], 1)) {
                d2[s2[r]] = d2[s2[r]] + 1;
            }
            if (r >= s1.Length-1) {
                // Console.WriteLine(string.Join(",", d2.ToArray()));
                // Console.WriteLine(string.Join(",", d1.ToArray()));
                if (checkDictionary(d1, d2)) {
                    return true;
                }
                if(d2[s2[l]] == 1){
                    d2.Remove(s2[l]);
                }
                else{
                    d2[s2[l]] = d2[s2[l]] - 1;
                }
                l++;
            }
        }

        return false;
    }
}
