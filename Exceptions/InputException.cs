using System;
using System.Runtime.Serialization;

namespace AdventOfCode;

/// <summary>
/// An exception thrown when the puzzle input could not be properly interpreted.
/// </summary>
[Serializable]
public class InputException : AdventOfCodeException
{
	/// <inheritdoc />
	public InputException() { }

	/// <inheritdoc />
	public InputException(string message) : base(message) { }

	/// <inheritdoc />
	public InputException(string message, Exception innerException) : base(message, innerException) { }

	/// <inheritdoc />
	protected InputException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
