// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 15409
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x314A8E4 Offset: 0x31468E4 VA: 0x314A8E4
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x314A914 Offset: 0x3146914 VA: 0x314A914 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x314A954 Offset: 0x3146954 VA: 0x314A954 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x314A95C Offset: 0x314695C VA: 0x314A95C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x314A964 Offset: 0x3146964 VA: 0x314A964 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x314A9EC Offset: 0x31469EC VA: 0x314A9EC
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x314AA9C Offset: 0x3146A9C VA: 0x314AA9C
	private static void .cctor() { }
}
