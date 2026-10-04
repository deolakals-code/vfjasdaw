// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[Serializable]
public struct Rectangle : IEquatable<Rectangle> // TypeDefIndex: 17319
{
	// Fields
	private int x; // 0x0
	private int y; // 0x4
	private int width; // 0x8
	private int height; // 0xC

	// Properties
	public int X { get; }
	public int Y { get; }
	public int Width { get; }
	public int Height { get; }

	// Methods

	// RVA: 0x329D544 Offset: 0x3299544 VA: 0x329D544
	public int get_X() { }

	// RVA: 0x329D54C Offset: 0x329954C VA: 0x329D54C
	public int get_Y() { }

	// RVA: 0x329D554 Offset: 0x3299554 VA: 0x329D554
	public int get_Width() { }

	// RVA: 0x329D55C Offset: 0x329955C VA: 0x329D55C
	public int get_Height() { }

	// RVA: 0x329D564 Offset: 0x3299564 VA: 0x329D564 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329D614 Offset: 0x3299614 VA: 0x329D614 Slot: 4
	public bool Equals(Rectangle other) { }

	// RVA: 0x329D658 Offset: 0x3299658 VA: 0x329D658
	public static bool op_Equality(Rectangle left, Rectangle right) { }

	// RVA: 0x329D694 Offset: 0x3299694 VA: 0x329D694 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329D710 Offset: 0x3299710 VA: 0x329D710 Slot: 3
	public override string ToString() { }
}
