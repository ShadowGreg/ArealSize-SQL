namespace ArealSize.Abstractions;

public interface ICommand
{
    /// <summary>
    /// Executes the command to get the area of a figure.
    /// </summary>
    /// <returns>The area of the figure as a double.</returns>
    double Execute();
}