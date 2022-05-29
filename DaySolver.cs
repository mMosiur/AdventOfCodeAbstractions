using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Abstractions;

/// <summary>
/// Abstract class that represents a generic solver for a day of Advent of Code.
/// It is a base class for all solvers and provides a common interface of methods for them,
/// as well as a common implementation for input file reading.
/// </summary>
public abstract class DaySolver
{
	/// <summary>
	/// The content that was read from the input file.
	/// </summary>
	public string Input { get; }

	/// <summary>
	/// The lines of the input file (excluding one last empty line after newline break).
	/// </summary>
	public IEnumerable<string> InputLines
	{
		get
		{
			using StringReader reader = new(Input);
			string? line;
			while ((line = reader.ReadLine()) is not null)
			{
				yield return line;
			}
		}
	}

	/// <summary>
	/// A constructor that reads the input text from according to <paramref name="options"/> and stores its content.
	/// </summary>
	public DaySolver(DaySolverOptions options)
	{
		TextReader? reader = options.InputReader;
		reader ??= File.OpenText(options.InputFilepath);
		Input = reader.ReadToEnd();
		reader.Dispose();
	}

	/// <summary>
	/// A method that solves the first part of the day puzzle.
	/// </summary>
	/// <returns>The solution of the first part of the day puzzle.</returns>
	public abstract string SolvePart1();

	/// <summary>
	/// A method that solves the second part of the day puzzle.
	/// </summary>
	/// <returns>The solution of the second part of the day puzzle.</returns>
	public abstract string SolvePart2();
}
