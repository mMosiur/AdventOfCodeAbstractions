using System;

namespace AdventOfCode.Abstractions;

/// <summary>
/// Exception thrown when a day solver fails to solve a puzzle.
/// </summary>
[Serializable]
public class DaySolverException : ApplicationException
{
	public DaySolverException() { }
	public DaySolverException(string message) : base(message) { }
	public DaySolverException(string message, Exception inner) : base(message, inner) { }
	protected DaySolverException(
		System.Runtime.Serialization.SerializationInfo info,
		System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
