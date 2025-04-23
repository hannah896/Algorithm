using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsCollect(char ch, string[] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i][0] == ch && (board[i][0] == board[i][1] && board[i][1] == board[i][2]))
            {
                return true;
            }
            if (board[0][i] == ch && (board[0][i] == board[1][i] && board[1][i] == board[2][i]))
            {
                return true;
            }
        }

        if (board[0][0] == ch && (board[0][0] == board[1][1] && board[1][1] == board[2][2]))
        {
            return true;
        }
        if (board[2][0] == ch &&(board[2][0] == board[1][1] && board[1][1] == board[0][2]))
        {
            return true;
        }
        return false;
    }
    public int solution(string[] board)
    {
        int countO = 0;
        int countX = 0;

        bool OLine = IsCollect('O', board);
        bool XLine = IsCollect('X', board);

        foreach (string row in board)
        {
            for (int i = 0; i< row.Length; i++)
            {
                if (row[i] == 'O')
                {
                    countO++;
                }
                else if (row[i]== 'X')
                {
                    countX++;
                }
            }
        }

        //갯수가 2개 차이나는경우
        if (countO - countX > 1)
        {
            return 0;
        }

        //X의 갯수가 O의 갯수보다 많을때
        if (countO < countX)
        {
            return 0;
        }
        
        //둘다 맞춘경우
        if (OLine&& XLine)
        {
            return 0;
        }

        if (XLine&& (countO != countX))
        {
            return 0;
        }

        if (OLine&& (countO - countX != 1))
        {
            return 0;
        }

        //정상적인 경우의 수일 경우
        return 1;
    }
}