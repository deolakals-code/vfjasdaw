// Assembly: System.Core.dll
// Namespace: 
internal sealed class NumericConvertInstruction.Checked : NumericConvertInstruction // TypeDefIndex: 15672
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x3179590 Offset: 0x3175590 VA: 0x3179590 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x31795D0 Offset: 0x31755D0 VA: 0x31795D0
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x317960C Offset: 0x317560C VA: 0x317960C Slot: 11
	protected override object Convert(object obj) { }

	// RVA: 0x3179974 Offset: 0x3175974 VA: 0x3179974
	private object ConvertInt32(int obj) { }

	// RVA: 0x3179C18 Offset: 0x3175C18 VA: 0x3179C18
	private object ConvertInt64(long obj) { }

	// RVA: 0x3179EA8 Offset: 0x3175EA8 VA: 0x3179EA8
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x317A138 Offset: 0x3176138 VA: 0x317A138
	private object ConvertDouble(double obj) { }
}
