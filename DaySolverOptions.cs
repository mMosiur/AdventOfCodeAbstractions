using System;

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
	/// Defaults to <c>input.txt</c>.
	/// </summary>
	public string InputFilePath { get; set; } = "input.txt";

	/// <summary>
	/// Returns <typeparamref name="T"/> object that is a result of creating an empty, default one
	/// and applying configurations from <paramref name="configure"/> action if present.
	/// </summary>
	public static T FromConfigureAction<T>(Action<T>? configure) where T : DaySolverOptions, new()
	{
		T options = new();
		configure?.Invoke(options);
		return options;
	}
}
