public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) {
            return "";
        }
       
        Dictionary<char, int> ds = new Dictionary<char, int>();
        Dictionary<char, int> dt = new Dictionary<char, int>();

        // populate dictioary t
        for (int i = 0; i < t.Length; i++) {
            if (!dt.TryAdd(t[i], 1)) {
                dt[t[i]] = dt[t[i]] + 1;
            }
        }

        int window_size = t.Length;
        int l = 0;
        int r = window_size - 1;
        int min_size = int.MaxValue;
        int ans = 0;
        // populate at start
        for (int i = 0; i < window_size; i++) {
            if (!ds.TryAdd(s[i], 1)) {
                ds[s[i]] = ds[s[i]] + 1;
            }
        }

        while (r < s.Length) {
             //Console.WriteLine($"l {l} r {r} window {window_size} ds {string.Join("",ds.ToArray())}");
            if (d2Ind1(ds, dt)) {
                if ((r - l) < min_size) {
                    min_size = r - l;
                    ans = l;
                }
                if(ds[s[l]] != 1){
                    ds[s[l]] = ds[s[l]] - 1;
                }
                else {
                    ds.Remove(s[l]);
                }
                l++;
            } else {
                r++;
                if(r < s.Length && !ds.TryAdd(s[r],1)){
                    ds[s[r]] = ds[s[r]] + 1;
                }
            }
        }
        if(min_size == int.MaxValue){
            return "";
        }
        return s[ans..(ans+min_size+1)];
    }

    private bool d2Ind1(Dictionary<char, int> d1, Dictionary<char, int> d2) {
        foreach (var kvp in d2) {
            if (!d1.TryGetValue(kvp.Key, out var v1)) {
                return false;
            }
            if (!(kvp.Value <= v1)) {
                return false;
            }
        }

        return true;
    }
}
