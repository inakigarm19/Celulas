namespace Ucu.Poo.GameOfLife;

public class Cell
{
    public bool Alive { get; set; }

    public Cell(bool alive)
    {
        Alive = alive;
    }
}