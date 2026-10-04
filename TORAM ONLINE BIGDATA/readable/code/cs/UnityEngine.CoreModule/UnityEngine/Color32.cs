// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[UsedByNativeCode]
[DefaultMember("Item")]
public struct Color32 : IFormattable // TypeDefIndex: 16297
{
	// Fields
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x37E0624 Offset: 0x37DC624 VA: 0x37E0624
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x37E0638 Offset: 0x37DC638 VA: 0x37E0638
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x37E08FC Offset: 0x37DC8FC VA: 0x37E08FC
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x37E0938 Offset: 0x37DC938 VA: 0x37E0938 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E0948 Offset: 0x37DC948 VA: 0x37E0948 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}
