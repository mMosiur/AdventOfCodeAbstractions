using System;
using System.Runtime.Serialization;

namespace AdventOfCode;

/// <summary>
/// Exception thrown when a day solver fails to solve a puzzle.
/// </summary>
[Serializable]
public class DaySolverException : AdventOfCodeException
{
	/// <inheritdoc />
	public DaySolverException() { }

	/// <inheritdoc />
	public DaySolverException(string message) : base(message) { }

	/// <inheritdoc />
	public DaySolverException(string message, Exception innerException) : base(message, innerException) { }

	/// <inheritdoc />
	protected DaySolverException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
