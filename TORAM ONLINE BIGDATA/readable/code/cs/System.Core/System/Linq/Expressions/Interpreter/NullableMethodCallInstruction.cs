// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 15726
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317EB90 Offset: 0x317AB90 VA: 0x317EB90 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317EB98 Offset: 0x317AB98 VA: 0x317EB98 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317EBA0 Offset: 0x317ABA0 VA: 0x317EBA0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317EBE0 Offset: 0x317ABE0 VA: 0x317EBE0
	private void .ctor() { }

	// RVA: 0x317EBE8 Offset: 0x317ABE8 VA: 0x317EBE8
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x317EFB8 Offset: 0x317AFB8 VA: 0x317EFB8
	public static Instruction CreateGetValue() { }
}
