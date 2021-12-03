using System;
using System.IO;

namespace AdventOfCode.Abstractions;

public abstract class DaySolver : IDisposable
{
	private readonly TextReader _inputReader;
	private string? _input;
	private bool _disposed;

	public string Input
	{
		get
		{
			if (_input == null)
			{
				_input = _inputReader.ReadToEnd();
				_inputReader.Dispose();
			}
			return _input;
		}
	}

	public DaySolver(TextReader inputReader)
	{
		_inputReader = inputReader;
	}

	public DaySolver(string inputFilePath)
	{
		FileStream? fs = new(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
		_inputReader = new StreamReader(fs);
	}

	public abstract string SolvePart1();

	public abstract string SolvePart2();


	public void Dispose()
	{
		if (!_disposed)
		{
			_inputReader.Dispose();
			_disposed = true;
		}
		GC.SuppressFinalize(this);
	}
}
