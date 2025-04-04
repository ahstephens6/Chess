// See https://aka.ms/new-console-template for more information

// Create the board for the game.
// Serves as the handler between the chess game and the frontend UI.

using Chess.Pieces;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.ForegroundColor = ConsoleColor.White;
ChessBoard game1 = new ChessBoard();
game1.PrintBoard();

public class ChessBoard
{
    private IChessPiece[,] Board = new IChessPiece[8, 8];

    public ChessBoard()
    {
        Board[0, 0] = new Rook(Color.White, 0, 0);
        Board[0, 1] = new Knight(Color.White, 0, 1);
        Board[0, 2] = new Bishop(Color.White, 0, 2);
        Board[0, 3] = new Queen(Color.White, 0, 3);
        Board[0, 4] = new King(Color.White, 0, 4);
        Board[0, 5] = new Bishop(Color.White, 0, 5);
        Board[0, 6] = new Knight(Color.White, 0, 6);
        Board[0, 7] = new Rook(Color.White, 0, 7);
        for (int i = 0; i < 8; i++)
        {
            Board[1, i] = new Pawn(Color.White, 0, i);
            Board[6, i] = new Pawn(Color.Black, 6, i);
        }
        Board[7, 0] = new Rook(Color.Black, 7, 0);
        Board[7, 1] = new Knight(Color.Black, 7, 1);
        Board[7, 2] = new Bishop(Color.Black, 7, 2);
        Board[7, 3] = new Queen(Color.Black, 7, 3);
        Board[7, 4] = new King(Color.Black, 7, 4);
        Board[7, 5] = new Bishop(Color.Black, 7, 5);
        Board[7, 6] = new Knight(Color.Black, 7, 6);
        Board[7, 7] = new Rook(Color.Black, 7, 7);
    }

    public void PrintBoard()
    {
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (Board[row, col] != null)
                {
                    Board[row, col].PrintPiece();
                    Console.Write(" ");
                }
                else
                {
                    if ((row + col) % 2 == 0)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }
            }
            Console.WriteLine();
        }
    }
}

