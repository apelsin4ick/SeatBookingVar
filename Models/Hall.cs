namespace Variant09.Models;

public class Hall
{
    public string Name { get; }

    public int Rows { get; }

    public int Columns { get; }

    public Seat[] Seats { get; }

    public Hall(string name, int rows, int columns)
    {
        Name = name;
        Rows = rows;
        Columns = columns;
        Seats = new Seat[rows * columns];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                int id = r * columns + c + 1;
                Seats[id - 1] = new Seat(id, r + 1, c + 1);
            }
        }
    }

    public Seat? GetSeatById(int id)
    {
        if (id < 1 || id > Seats.Length) return null;
        return Seats[id - 1];
    }
}