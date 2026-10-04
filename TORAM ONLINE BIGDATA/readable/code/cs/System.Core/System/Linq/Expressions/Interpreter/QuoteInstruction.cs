// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 15735
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x31802F8 Offset: 0x317C2F8 VA: 0x31802F8
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x318033C Offset: 0x317C33C VA: 0x318033C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x3180344 Offset: 0x317C344 VA: 0x3180344 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3180384 Offset: 0x317C384 VA: 0x3180384 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}
