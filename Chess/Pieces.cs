﻿// This file will house the piece interfaces that will be implemented later

using System.Drawing;
using System.Runtime.InteropServices;

namespace Chess.Pieces
{
    public interface IChessPiece
    {
        public void Move(int x, int y);
        public void TakePiece(IChessPiece piece);
        public void PrintPiece();
    }

    public class Pawn : IChessPiece
    {
        private PieceType Type = PieceType.Pawn;
        private Color Color;
        public Coordinate Location;

        public Pawn(Color color, int x, int y)
        {
            Color = color;
            Location = new Coordinate(x, y);
        }

        public void Move(int x, int y)
        {
            Location.SetCoordinate(x, y);
        }

        public void PrintPiece()
        {
            if (Color == Color.White)
                Console.Write("\u2659");
            else
                Console.Write("\u265F");
        }

        public void TakePiece(IChessPiece piece)
        {

        }
    }

    public class Knight : IChessPiece
    {
        private PieceType Type = PieceType.Knight;
        private Color Color;
        public Coordinate Location;

        public Knight(Color color, int x, int y)
        {
            Color = color;
            Location = new Coordinate(x, y);
        }

        public void Move(int x, int y)
        {
            Location.SetCoordinate(x, y);
        }

        public void PrintPiece()
        {
            if (Color == Color.White) 
                Console.Write("\u2658");
            else
                Console.Write("\u265E");
        }

        public void TakePiece(IChessPiece piece)
        {

        }
    }

    public class Bishop : IChessPiece
    {
        private PieceType Type = PieceType.Bishop;
        private Color Color;
        public Coordinate Location;

        public Bishop(Color color, int x, int y)
        {
            Color = color;
            Location = new Coordinate(x, y);
        }

        public void Move(int x, int y)
        {
            Location.SetCoordinate(x, y);
        }

        public void PrintPiece()
        {
            if (Color == Color.White)
                Console.Write("\u2657");
            else
                Console.Write("\u265D");
        }

        public void TakePiece(IChessPiece piece)
        {

        }
    }

    public class Rook : IChessPiece
    {
        private PieceType Type = PieceType.Rook;
        private Color Color;
        public Coordinate Location;

        public Rook(Color color, int x, int y)
        {
            Color = color;
            Location = new Coordinate(x, y);
        }

        public void Move(int x, int y)
        {
            Location.SetCoordinate(x, y);
        }

        public void PrintPiece()
        {
            if (Color == Color.White)
                Console.Write("\u2656");
            else
                Console.Write("\u265C");
        }

        public void TakePiece(IChessPiece piece)
        {

        }
    }

    public class Queen : IChessPiece
    {
        private PieceType Type = PieceType.Queen;
        private Color Color;
        public Coordinate Location;

        public Queen(Color color, int x, int y)
        {
            Color = color;
            Location = new Coordinate(x, y);
        }

        public void Move(int x, int y)
        {
            Location.SetCoordinate(x, y);
        }

        public void PrintPiece()
        {
            if (Color == Color.White)
                Console.Write("\u2655");
            else
                Console.Write("\u265B");
        }

        public void TakePiece(IChessPiece piece)
        {

        }
    }

    public class King : IChessPiece
    {
        private PieceType Type = PieceType.King;
        private Color Color;
        public Coordinate Location;
        private bool IsInCheck;
        private bool IsInCheckMate;

        public King(Color color, int x, int y)
        {
            Color = color;
            Location = new Coordinate(x, y);
            IsInCheck = false;
            IsInCheckMate = false;
        }

        public void Move(int x, int y)
        {
            Location.SetCoordinate(x, y);
        }

        public void PrintPiece()
        {
            if (Color == Color.White)
                Console.Write("\u2654");
            else
                Console.Write("\u265A");
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

    public enum PieceType { Pawn=0, Rook, Knight, Bishop, Queen, King, Empty };
    public enum Color { White=0, Black };
}