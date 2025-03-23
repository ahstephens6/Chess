// This file will house the piece interfaces that will be implemented later

using System.Drawing;

namespace Pieces
{
    public interface IChessPiece
    {
        public void Move(int x, int y);
        public void TakePiece(IChessPiece piece);
    }

    public class Pawn : IChessPiece
    {
        private PieceType Type = PieceType.Pawn;
        private Color Color;
        public Coordinate Coord;

        public Pawn(Color color, int x, int y)
        {
            Color = color;
            Coord = new Coordinate(x, y);
        }

        public void Move(int x, int y)
        {
            Coord.SetCoordinate(x, y);
        }

        public void TakePiece(IChessPiece piece)
        {

        }
    }

    public class Coordinate
    {
        private (int X, int Y) coord;

        public Coordinate(int x, int y)
        {
            coord = (x, y);
        }

        public (int, int) GetCoordinate()
        {
            return (coord.X, coord.Y);
        }

        public void SetCoordinate(int x, int y)
        {
            coord = (x, y);
        }
    }

    public enum PieceType { Pawn=0, Rook, Knight, Bishop, Queen, King };
    public enum Color { White=0, Black };
}