namespace Variant09.Models;

public class Seat
{
    public int Id { get; }

    public int Row { get; }

    public int Column { get; }

    public bool IsBooked { get; set; }

    public Seat(int id, int row, int column)
    {
        Id = id;
        Row = row;
        Column = column;
        IsBooked = false; 
    }

    public override string ToString() => $"Место [{Row},{Column}] (ID: {Id})";
}