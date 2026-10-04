// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CastInstruction : Instruction // TypeDefIndex: 15731
{
	// Fields
	private static CastInstruction s_Boolean; // 0x0
	private static CastInstruction s_Byte; // 0x8
	private static CastInstruction s_Char; // 0x10
	private static CastInstruction s_DateTime; // 0x18
	private static CastInstruction s_Decimal; // 0x20
	private static CastInstruction s_Double; // 0x28
	private static CastInstruction s_Int16; // 0x30
	private static CastInstruction s_Int32; // 0x38
	private static CastInstruction s_Int64; // 0x40
	private static CastInstruction s_SByte; // 0x48
	private static CastInstruction s_Single; // 0x50
	private static CastInstruction s_String; // 0x58
	private static CastInstruction s_UInt16; // 0x60
	private static CastInstruction s_UInt32; // 0x68
	private static CastInstruction s_UInt64; // 0x70

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x317F34C Offset: 0x317B34C VA: 0x317F34C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x317F354 Offset: 0x317B354 VA: 0x317F354 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x317F35C Offset: 0x317B35C VA: 0x317F35C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x317F39C Offset: 0x317B39C VA: 0x317F39C
	public static Instruction Create(Type t) { }

	// RVA: 0x317FAF0 Offset: 0x317BAF0 VA: 0x317FAF0
	protected void .ctor() { }
}
