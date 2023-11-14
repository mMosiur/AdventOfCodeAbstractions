using System;
using System.Runtime.Serialization;

namespace AdventOfCode;

/// <summary>
/// Base exception for Advent of Code exceptions.
/// </summary>
/// <remarks>
/// This exception is not thrown directly, but is the base class for all other exceptions thrown by Advent of Code.
/// Current subclass exceptions:
/// <list type="bullet">
/// <item><see cref="CommandLineException"/></item>
/// <item><see cref="DaySolverException"/></item>
/// <item><see cref="InputException"/></item>
/// </list>
/// </remarks>
public abstract class AdventOfCodeException : Exception
{
	/// <inheritdoc />
	public AdventOfCodeException() { }

	/// <inheritdoc />
	public AdventOfCodeException(string message) : base(message) { }

	/// <inheritdoc />
	public AdventOfCodeException(string message, Exception innerException) : base(message, innerException) { }
}
