using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode.Abstractions;

/// <summary>
/// Abstract class that represents a generic solver for a day of Advent of Code.
/// It is a base class for all solvers and provides a common interface of methods for them,
/// as well as a common implementation for input file reading.
/// </summary>
public abstract class DaySolver : IDaySolver
{
	/// <summary>
	/// Property <c>Year</c> represents the year of the Advent of Code event the puzzle of the <see cref="DaySolver"/> belongs to.
	/// </summary>
	public abstract int Year { get; }

	/// <summary>
	/// Property <c>Day</c> represents the day of the Advent of Code event the puzzle of the <see cref="DaySolver"/> belongs to.
	/// </summary>
	public abstract int Day { get; }

	/// <summary>
	/// Property <c>Title</c> represents the title of the day of the Advent of Code event the <see cref="DaySolver"/> belongs to.
	/// </summary>
	public abstract string Title { get; }

	/// <summary>
	/// The content that was read from the input file.
	/// </summary>
	protected string Input { get; }

	/// <summary>
	/// The lines of the input file (excluding one last empty line after newline break).
	/// </summary>
	protected IEnumerable<string> InputLines
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
	/// A constructor that reads the input text according to <paramref name="options"/> and stores its content.
	/// </summary>
	public DaySolver(DaySolverOptions options)
	{
		try
		{
			using TextReader reader = options.InputReader ?? File.OpenText(options.InputFilepath);
			Input = reader.ReadToEnd();
		}
		catch (FileNotFoundException e)
		{
			throw new InputException($"Input file \"{e.FileName}\" was not found.", e);
		}
		catch (IOException e)
		{
			throw new InputException($"An error occurred while reading the input file \"{options.InputFilepath}\".", e);
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates over <see cref="Input"/> lines using <see cref="ReadOnlySpan{char}"/>.
	/// </summary>
	/// <remarks>
	/// Note that the enumerator does not skip the last empty line after newline break as <see cref="InputLines"/> does.
	/// </remarks>
	protected SpanLineEnumerator EnumerateInputLines() => Input.AsSpan().EnumerateLines();

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
