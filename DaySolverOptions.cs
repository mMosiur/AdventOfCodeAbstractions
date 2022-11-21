using System;
using System.IO;

namespace AdventOfCode.Abstractions;

/// <summary>
/// The options class to configure a generic <see cref="DaySolver"/>.
/// </summary>
public class DaySolverOptions
{
	/// <summary>
	/// Constructor that creates empty options with default values.
	/// </summary>
	public DaySolverOptions() { }

	/// <summary>
	/// A path to the input file.
	/// </summary>
	/// <remarks>
	/// Defaults to <c>input.txt</c>, that is, the file named <c>input.txt</c> in the current directory.
	/// If <see cref="InputReader"/> is not <see langword="null"/>, this property should be ignored.
	/// </remarks>
	public string InputFilepath { get; set; } = "input.txt";

	/// <summary>
	/// A <see cref="TextReader"/> that reads the input text.
	/// </summary>
	/// <remarks>
	/// When <see langword="null"/>, the input should be read from file given in <see cref="InputFilepath"/>.
	/// Defaults to <see langword="null"/>.
	/// </remarks>
	public TextReader? InputReader { get; set; } = null;

	/// <summary>
	/// Returns <typeparamref name="T"/> options which are a result of creating an empty, default one
	/// and applying configurations from <paramref name="configure"/> action.
	/// </summary>
	public static T FromConfigureAction<T>(Action<T> configure) where T : DaySolverOptions, new()
	{
		ArgumentNullException.ThrowIfNull(configure);
		T options = new();
		configure?.Invoke(options);
		return options;
	}
}
