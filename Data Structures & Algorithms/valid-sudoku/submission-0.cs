public class Solution {
    public bool IsValidSudoku(char[][] board) {
    
        List<HashSet<char>> rows = new List<HashSet<char>>();
        List<HashSet<char>> cols = new List<HashSet<char>>();
        List<HashSet<char>> squares = new List<HashSet<char>>();

        foreach(var i in Enumerable.Range(0,9)){
            rows.Add(new HashSet<char>());
            cols.Add(new HashSet<char>());
            squares.Add(new HashSet<char>());
        }

        for(int r=0; r<board.Length; r++){
            
            for(int c=0; c<board[r].Length; c++){
                Console.WriteLine(r + " " + c);

                if(board[r][c] == '.'){ continue; }
                if(!rows[r].Add(board[r][c])){
                    return false;
                }
                if(!cols[c].Add(board[r][c])){
                    return false;
                }
                int square_index = ((r/3) * 3 ) + (c/3);
                Console.WriteLine("square_index:" + square_index);
                if(!squares[square_index].Add(board[r][c])){
                    return false;
                }
            }
        }
        // 0 1 2
        // 3 4 5
        // 6 7 8

        // 0,0 0,1 0,2  0,3 4 5 6 7 8
        // 1,0 1,1 1,2  1,3 4 5 6 7 8
        // 2,0 2,1 2,2  2,3 4 5 6 7 8

        // 3
        // 4
        // 5

        // 6
        // 7
        // 8

        return true;
    }
}
