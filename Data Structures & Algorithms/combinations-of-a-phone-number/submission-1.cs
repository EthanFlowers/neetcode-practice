public class Solution {
    private static readonly Dictionary<int, List<char>> alphabet =
        new() { [2] = ['a', 'b', 'c'], [3] = ['d', 'e', 'f'],     [4] = ['g', 'h', 'i'],
                [5] = ['j', 'k', 'l'], [6] = ['m', 'n', 'o'],     [7] = ['p', 'q', 'r', 's'],
                [8] = ['t', 'u', 'v'], [9] = ['w', 'x', 'y', 'z'] };
    public List<string> LetterCombinations(string digits) {
        List<List<char>> choices = [];
        List<string> result = [];
        List<char> state = [];

        if(digits == ""){
            return [];
        }

        foreach (char d in digits) {
            choices.Add(alphabet[d - '0']);
        }
        backtrack(digits, choices, 0, "", result);

        return result;
    }

    void backtrack(string digits, List<List<char>> choices, int start_digit, 
                   string state, List<string> result) {
        
        if (state.Length == digits.Length) {
            result.Add(state);
            return;
        }

        for (int l = 0; l < choices[start_digit].Count; l++) {
            // Console.WriteLine($"state {string.Join(",",state.ToArray())}

            // explore
            backtrack(digits, choices, start_digit+1, state + alphabet[digits[start_digit] - '0'][l], result);
            // backtrack
           // state.RemoveAt(state.Count - 1);
        }
    }
}

