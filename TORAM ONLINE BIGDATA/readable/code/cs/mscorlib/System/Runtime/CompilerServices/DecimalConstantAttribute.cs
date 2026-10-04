// Assembly: mscorlib.dll
// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DecimalConstantAttribute : Attribute // TypeDefIndex: 10493
{
	// Fields
	private Decimal _dec; // 0x10

	// Properties
	public Decimal Value { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x2F1FE2C Offset: 0x2F1BE2C VA: 0x2F1FE2C
	public void .ctor(byte scale, byte sign, uint hi, uint mid, uint low) { }

	// RVA: 0x2F1FEC8 Offset: 0x2F1BEC8 VA: 0x2F1FEC8
	public Decimal get_Value() { }
}
