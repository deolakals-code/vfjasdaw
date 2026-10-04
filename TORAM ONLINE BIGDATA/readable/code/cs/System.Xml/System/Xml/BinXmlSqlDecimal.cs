// Assembly: System.Xml.dll
// Namespace: System.Xml
internal struct BinXmlSqlDecimal // TypeDefIndex: 13260
{
	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x32AB35C Offset: 0x32A735C VA: 0x32AB35C
	public bool get_IsPositive() { }

	// RVA: 0x32AB36C Offset: 0x32A736C VA: 0x32AB36C
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x32AB608 Offset: 0x32A7608 VA: 0x32AB608
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x32AB844 Offset: 0x32A7844 VA: 0x32AB844
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x32AB91C Offset: 0x32A791C VA: 0x32AB91C
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x32AB974 Offset: 0x32A7974 VA: 0x32AB974
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x32AB97C Offset: 0x32A797C VA: 0x32AB97C
	public Decimal ToDecimal() { }

	// RVA: 0x32AB67C Offset: 0x32A767C VA: 0x32AB67C
	private void TrimTrailingZeros() { }

	// RVA: 0x32ABA94 Offset: 0x32A7A94 VA: 0x32ABA94 Slot: 3
	public override string ToString() { }

	// RVA: 0x32ABD58 Offset: 0x32A7D58 VA: 0x32ABD58
	private static void .cctor() { }
}
