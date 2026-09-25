namespace TicTacToe;

/// <summary>
/// A rectangular grid of cells that pieces are placed on. Holds only what every
/// game type needs from a board; rules such as winning lines belong to the game.
/// </summary>
public interface IBoard
{
    /// <summary>The number of cells along one side of the board.</summary>
    int Size { get; }

    /// <summary>The height of the board in cells.</summary>
    int Height { get; }

    /// <summary>The width of the board in cells.</summary>
    int Width { get; }

    /// <summary>The moves played on this board so far, in order.</summary>
    IReadOnlyList<Move> Moves { get; }

    /// <summary>Gets the piece at the given row and column, or null if the cell is empty.</summary>
    Piece? GetCell(int row, int column);

    /// <summary>
    /// Places a piece at the given row and column.
    /// Returns true if the move was made, false if the cell was already taken.
    /// </summary>
    bool PlacePiece(int row, int column, Piece piece);

    /// <summary>
    /// Takes the most recent move back off the board. Returns the move that was
    /// undone, or null if no moves have been played.
    /// </summary>
    Move? UndoLastMove();

    /// <summary>Returns true if the given row and column fall within the board.</summary>
    bool IsInBounds(int row, int column);

    /// <summary>True when no empty cells remain.</summary>
    bool IsFull();

    /// <summary>The coordinates of every empty cell, in reading order.</summary>
    IEnumerable<(int Row, int Column)> EmptyCells();
}
