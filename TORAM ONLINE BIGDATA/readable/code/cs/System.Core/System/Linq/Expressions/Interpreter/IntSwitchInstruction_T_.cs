// Assembly: System.Core.dll
// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 15410
{
	// Fields
	private readonly Dictionary<T, int> _cases; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A210E4 Offset: 0x2A1D0E4 VA: 0x2A210E4
	|-IntSwitchInstruction<int>..ctor
	|
	|-RVA: 0x2A2120C Offset: 0x2A1D20C VA: 0x2A2120C
	|-IntSwitchInstruction<object>..ctor
	|
	|-RVA: 0x2A21334 Offset: 0x2A1D334 VA: 0x2A21334
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override string get_InstructionName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A21114 Offset: 0x2A1D114 VA: 0x2A21114
	|-IntSwitchInstruction<int>.get_InstructionName
	|
	|-RVA: 0x2A2123C Offset: 0x2A1D23C VA: 0x2A2123C
	|-IntSwitchInstruction<object>.get_InstructionName
	|
	|-RVA: 0x2A21364 Offset: 0x2A1D364 VA: 0x2A21364
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_InstructionName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_ConsumedStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A21154 Offset: 0x2A1D154 VA: 0x2A21154
	|-IntSwitchInstruction<int>.get_ConsumedStack
	|
	|-RVA: 0x2A2127C Offset: 0x2A1D27C VA: 0x2A2127C
	|-IntSwitchInstruction<object>.get_ConsumedStack
	|
	|-RVA: 0x2A213A4 Offset: 0x2A1D3A4 VA: 0x2A213A4
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_ConsumedStack
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A2115C Offset: 0x2A1D15C VA: 0x2A2115C
	|-IntSwitchInstruction<int>.Run
	|
	|-RVA: 0x2A21284 Offset: 0x2A1D284 VA: 0x2A21284
	|-IntSwitchInstruction<object>.Run
	|
	|-RVA: 0x2A213AC Offset: 0x2A1D3AC VA: 0x2A213AC
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.Run
	*/
}
