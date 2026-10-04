// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[Serializable]
public struct Size : IEquatable<Size> // TypeDefIndex: 17321
{
	// Fields
	private int width; // 0x0
	private int height; // 0x4

	// Properties
	public int Width { get; }
	public int Height { get; }

	// Methods

	// RVA: 0x329DD94 Offset: 0x3299D94 VA: 0x329DD94
	public static bool op_Equality(Size sz1, Size sz2) { }

	// RVA: 0x329DDB4 Offset: 0x3299DB4 VA: 0x329DDB4
	public int get_Width() { }

	// RVA: 0x329DDBC Offset: 0x3299DBC VA: 0x329DDBC
	public int get_Height() { }

	// RVA: 0x329DDC4 Offset: 0x3299DC4 VA: 0x329DDC4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329DE48 Offset: 0x3299E48 VA: 0x329DE48 Slot: 4
	public bool Equals(Size other) { }

	// RVA: 0x329DE68 Offset: 0x3299E68 VA: 0x329DE68 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329DEC8 Offset: 0x3299EC8 VA: 0x329DEC8 Slot: 3
	public override string ToString() { }
}
