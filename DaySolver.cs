using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode.Abstractions;

public abstract class DaySolver
{
	public string Input { get; }

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

	public DaySolver(string inputFilePath)
	{
		ArgumentNullException.ThrowIfNull(inputFilePath);
		Input = File.ReadAllText(inputFilePath);
	}

	public abstract string SolvePart1();

	public abstract string SolvePart2();
}
