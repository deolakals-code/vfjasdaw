// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 15390
{
	// Fields
	protected readonly MethodInfo _target; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ArgumentCount { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x3147A40 Offset: 0x3143A40 VA: 0x3147A40 Slot: 11
	public override int get_ArgumentCount() { }

	// RVA: 0x31477CC Offset: 0x31437CC VA: 0x31477CC
	internal void .ctor(MethodInfo target, int argumentCount) { }

	// RVA: 0x3147A48 Offset: 0x3143A48 VA: 0x3147A48 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3147AF8 Offset: 0x3143AF8 VA: 0x3147AF8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x3147E00 Offset: 0x3143E00 VA: 0x3147E00
	protected object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	// RVA: 0x3147F9C Offset: 0x3143F9C VA: 0x3147F9C Slot: 3
	public override string ToString() { }
}
