// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class Interpreter // TypeDefIndex: 15513
{
	// Fields
	internal static readonly object NoValue; // 0x0
	private readonly InstructionArray _instructions; // 0x10
	internal readonly object[] _objects; // 0x38
	internal readonly RuntimeLabel[] _labels; // 0x40
	internal readonly DebugInfo[] _debugInfos; // 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; // 0x60

	// Properties
	internal string Name { get; }
	internal int LocalCount { get; }
	internal int ClosureSize { get; }
	internal InstructionArray Instructions { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x315A508 Offset: 0x3156508 VA: 0x315A508
	internal void .ctor(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CompilerGenerated]
	// RVA: 0x315A5B8 Offset: 0x31565B8 VA: 0x315A5B8
	internal string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x315A5C0 Offset: 0x31565C0 VA: 0x315A5C0
	internal int get_LocalCount() { }

	// RVA: 0x315A5C8 Offset: 0x31565C8 VA: 0x315A5C8
	internal int get_ClosureSize() { }

	// RVA: 0x315A620 Offset: 0x3156620 VA: 0x315A620
	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	// RVA: 0x315A634 Offset: 0x3156634 VA: 0x315A634
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x315A63C Offset: 0x315663C VA: 0x315A63C
	public void Run(InterpretedFrame frame) { }

	// RVA: 0x315A6A8 Offset: 0x31566A8 VA: 0x315A6A8
	private static void .cctor() { }
}
