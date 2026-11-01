public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> d = new Dictionary<char, int>();
        Dictionary<char, int> d1 = new Dictionary<char, int>();

        foreach (char a in s) {
            if (!d.TryAdd(a, 1)) {
                d[a] = d[a] + 1;
            }
        }
        foreach (char a in t) {
            if (!d1.TryAdd(a, 1)) {
                d1[a] = d1[a] + 1;
            }
        }

        if (d.Count != d1.Count) {
            return false;
        }

        foreach (var (k, v) in d) {
            if (d1.TryGetValue(k, out int v1)) {
                if (v != v1) {
                    return false;
                }
            }
            else{
                return false;
            }
        }

        return true;
    }
}

