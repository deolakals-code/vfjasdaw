// Assembly: System.Core.dll
// Namespace: 
internal sealed class NumericConvertInstruction.Unchecked : NumericConvertInstruction // TypeDefIndex: 15671
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3178820 Offset: 0x3174820 VA: 0x3178820 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x3178860 Offset: 0x3174860 VA: 0x3178860
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x317889C Offset: 0x317489C VA: 0x317889C Slot: 11
	protected override object Convert(object obj) { }

	// RVA: 0x3178C04 Offset: 0x3174C04 VA: 0x3178C04
	private object ConvertInt32(int obj) { }

	// RVA: 0x3178E60 Offset: 0x3174E60 VA: 0x3178E60
	private object ConvertInt64(long obj) { }

	// RVA: 0x3179090 Offset: 0x3175090 VA: 0x3179090
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x31792C4 Offset: 0x31752C4 VA: 0x31792C4
	private object ConvertDouble(double obj) { }
}
