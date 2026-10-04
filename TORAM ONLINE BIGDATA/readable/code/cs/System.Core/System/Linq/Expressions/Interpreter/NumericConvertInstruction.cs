// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 15674
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x31784F0 Offset: 0x31744F0 VA: 0x31784F0
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x317852C Offset: 0x317452C VA: 0x317852C Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract object Convert(object obj);

	// RVA: 0x3178600 Offset: 0x3174600 VA: 0x3178600 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3178640 Offset: 0x3174640 VA: 0x3178640 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x3178648 Offset: 0x3174648 VA: 0x3178648 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3178650 Offset: 0x3174650 VA: 0x3178650 Slot: 3
	public override string ToString() { }
}
