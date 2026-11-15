public class Solution {
    bool found = false;
    int count = 0;
    public bool Exist(char[][] board, string word) {
        for(int r=0; r<board.Length; r++){
            for(int c=0; c<board[r].Length; c++){
                backtrace(board, word, [(r,c)]);
                if(found == true){
                    return true;
                }
            }
        }
        
        return found;
    }

    private void backtrace(char[][] board, string word, List<(int,int)> curr_path){
        // basecase
        //Console.WriteLine(string.Join("",curr_path.Select(x=> board[x.Item1][x.Item2])));
        if(string.Join("",curr_path.Select(x=> board[x.Item1][x.Item2])).ToUpper() == word.ToUpper() ){
            found = true;
            return;
        }

        List<(int,int)> options = [
            (0,1), // right
            (0,-1), // left
            (1,0), // down
            (-1,0) // up
        ];
        foreach(var o in options){
            // choose
            int new_y = curr_path.Count > 0 ? curr_path[curr_path.Count-1].Item1 + o.Item1 : o.Item1;
            int new_x = curr_path.Count > 0 ? curr_path[curr_path.Count-1].Item2 + o.Item2 : o.Item2;
            //Console.WriteLine($"{new_y}, {new_x}");

            if(new_y < 0 || new_y >= board.Length || new_x < 0 || new_x >= board[0].Length || curr_path.Any(x => x.Item1 == new_y && x.Item2 == new_x)){
                continue;
            }
            if(board[curr_path[curr_path.Count-1].Item1][curr_path[curr_path.Count-1].Item2] != word[curr_path.Count-1]){
            continue;
        }
            curr_path.Add((new_y,new_x));

            //explore
            backtrace(board, word , curr_path);

            //unchoose
            curr_path.RemoveAt(curr_path.Count-1);

        }
    }
}
