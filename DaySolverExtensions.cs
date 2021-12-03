using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Abstractions.Extensions;

public static class DaySolverExtensions
{
	public static IEnumerable<string> GetInputLines(this DaySolver solver)
	{
		using StringReader reader = new(solver.Input);
		string? line;
		while ((line = reader.ReadLine()) is not null)
		{
			yield return line;
		}
	}
}
