// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
public sealed class ElementInit : IArgumentProvider // TypeDefIndex: 15281
{
	// Fields
	[CompilerGenerated]
	private readonly MethodInfo <AddMethod>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ReadOnlyCollection<Expression> <Arguments>k__BackingField; // 0x18

	// Properties
	public MethodInfo AddMethod { get; }
	public ReadOnlyCollection<Expression> Arguments { get; }
	public int ArgumentCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x31338D4 Offset: 0x312F8D4 VA: 0x31338D4
	public MethodInfo get_AddMethod() { }

	[CompilerGenerated]
	// RVA: 0x31338DC Offset: 0x312F8DC VA: 0x31338DC
	public ReadOnlyCollection<Expression> get_Arguments() { }

	// RVA: 0x31338E4 Offset: 0x312F8E4 VA: 0x31338E4 Slot: 4
	public Expression GetArgument(int index) { }

	// RVA: 0x313393C Offset: 0x312F93C VA: 0x313393C Slot: 5
	public int get_ArgumentCount() { }
}
