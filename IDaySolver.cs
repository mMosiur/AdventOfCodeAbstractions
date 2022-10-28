namespace AdventOfCode.Abstractions;

public interface IDaySolver
{
	/// <summary>
	/// Property <c>Year</c> represents the year of the Advent of Code event the puzzle of the <see cref="DaySolver"/> belongs to.
	/// </summary>
	public int Year { get; }

	/// <summary>
	/// Property <c>Day</c> represents the day of the Advent of Code event the puzzle of the <see cref="DaySolver"/> belongs to.
	/// </summary>
	public int Day { get; }

	/// <summary>
	/// Property <c>Title</c> represents the title of the day of the Advent of Code event the <see cref="DaySolver"/> belongs to.
	/// </summary>
	public string Title { get; }

	/// <summary>
	/// A method that solves the first part of the day puzzle.
	/// </summary>
	/// <returns>The solution of the first part of the day puzzle.</returns>
	string SolvePart1();

	/// <summary>
	/// A method that solves the second part of the day puzzle.
	/// </summary>
	/// <returns>The solution of the second part of the day puzzle.</returns>
	string SolvePart2();
}
