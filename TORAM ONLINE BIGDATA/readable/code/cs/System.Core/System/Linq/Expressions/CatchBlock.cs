// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions
[DebuggerTypeProxy(typeof(Expression.CatchBlockProxy))]
public sealed class CatchBlock // TypeDefIndex: 15270
{
	// Fields
	[CompilerGenerated]
	private readonly ParameterExpression <Variable>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <Test>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly Expression <Body>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Expression <Filter>k__BackingField; // 0x28

	// Properties
	public ParameterExpression Variable { get; }
	public Type Test { get; }
	public Expression Body { get; }
	public Expression Filter { get; }

	// Methods

	// RVA: 0x3132DFC Offset: 0x312EDFC VA: 0x3132DFC
	internal void .ctor(Type test, ParameterExpression variable, Expression body, Expression filter) { }

	[CompilerGenerated]
	// RVA: 0x3132E70 Offset: 0x312EE70 VA: 0x3132E70
	public ParameterExpression get_Variable() { }

	[CompilerGenerated]
	// RVA: 0x3132E78 Offset: 0x312EE78 VA: 0x3132E78
	public Type get_Test() { }

	[CompilerGenerated]
	// RVA: 0x3132E80 Offset: 0x312EE80 VA: 0x3132E80
	public Expression get_Body() { }

	[CompilerGenerated]
	// RVA: 0x3132E88 Offset: 0x312EE88 VA: 0x3132E88
	public Expression get_Filter() { }

	// RVA: 0x3132E90 Offset: 0x312EE90 VA: 0x3132E90 Slot: 3
	public override string ToString() { }

	// RVA: 0x3132F10 Offset: 0x312EF10 VA: 0x3132F10
	public CatchBlock Update(ParameterExpression variable, Expression filter, Expression body) { }
}
