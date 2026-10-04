// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct LocalDefinition // TypeDefIndex: 15595
{
	// Fields
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ParameterExpression <Parameter>k__BackingField; // 0x8

	// Properties
	public int Index { get; }
	public ParameterExpression Parameter { get; }

	// Methods

	// RVA: 0x3171020 Offset: 0x316D020 VA: 0x3171020
	internal void .ctor(int localIndex, ParameterExpression parameter) { }

	[CompilerGenerated]
	// RVA: 0x3171030 Offset: 0x316D030 VA: 0x3171030
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x3171038 Offset: 0x316D038 VA: 0x3171038
	public ParameterExpression get_Parameter() { }

	// RVA: 0x3171040 Offset: 0x316D040 VA: 0x3171040 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x31710C8 Offset: 0x316D0C8 VA: 0x31710C8 Slot: 2
	public override int GetHashCode() { }
}
