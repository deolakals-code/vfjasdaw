// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[Serializable]
public struct Point : IEquatable<Point> // TypeDefIndex: 17317
{
	// Fields
	private int x; // 0x0
	private int y; // 0x4

	// Properties
	public int X { get; }
	public int Y { get; }

	// Methods

	// RVA: 0x329CFF4 Offset: 0x3298FF4 VA: 0x329CFF4
	public int get_X() { }

	// RVA: 0x329CFFC Offset: 0x3298FFC VA: 0x329CFFC
	public int get_Y() { }

	// RVA: 0x329D004 Offset: 0x3299004 VA: 0x329D004
	public static bool op_Equality(Point left, Point right) { }

	// RVA: 0x329D024 Offset: 0x3299024 VA: 0x329D024 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329D0A8 Offset: 0x32990A8 VA: 0x329D0A8 Slot: 4
	public bool Equals(Point other) { }

	// RVA: 0x329D0C8 Offset: 0x32990C8 VA: 0x329D0C8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329D128 Offset: 0x3299128 VA: 0x329D128 Slot: 3
	public override string ToString() { }
}
