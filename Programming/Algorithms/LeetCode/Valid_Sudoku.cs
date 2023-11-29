using System.Reflection.Metadata;

public class ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            columns[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char num = board[i][j];


                //skip if cell is empty
                if (num == '.') 
                {
                    continue;
                }

                //check if the number is already in the row,column or box.
                if(rows[i].Contains(num) || columns[j].Contains(num) || boxes[3*(i /3) + j / 3].Contains(num))
                {
                    return false;
                }

                //adding the number to the current row, column and box
                rows[i].Add(num);
                columns[j].Add(num);
                boxes[3 * (i / 3) + j / 3].Add(num);
            }
        }
        return true;
    }
}

public static class ValidSudokus
{
    static void ValidSudokusOutput()
    {
        //not testable. i think.


    }
}