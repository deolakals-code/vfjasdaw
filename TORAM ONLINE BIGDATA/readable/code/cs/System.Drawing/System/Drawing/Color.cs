// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[IsReadOnly]
[DebuggerDisplay("{NameAndARGBValue}")]
[Serializable]
public struct Color : IEquatable<Color> // TypeDefIndex: 17316
{
	// Fields
	private readonly string name; // 0x0
	private readonly long value; // 0x8
	private readonly short knownColor; // 0x10
	private readonly short state; // 0x12

	// Properties
	public byte R { get; }
	public byte G { get; }
	public byte B { get; }
	public byte A { get; }
	public bool IsKnownColor { get; }
	public string Name { get; }
	private long Value { get; }

	// Methods

	// RVA: 0x329CA30 Offset: 0x3298A30 VA: 0x329CA30
	public byte get_R() { }

	// RVA: 0x329CA78 Offset: 0x3298A78 VA: 0x329CA78
	public byte get_G() { }

	// RVA: 0x329CA8C Offset: 0x3298A8C VA: 0x329CA8C
	public byte get_B() { }

	// RVA: 0x329CA9C Offset: 0x3298A9C VA: 0x329CA9C
	public byte get_A() { }

	// RVA: 0x329CAB0 Offset: 0x3298AB0 VA: 0x329CAB0
	public bool get_IsKnownColor() { }

	// RVA: 0x329CABC Offset: 0x3298ABC VA: 0x329CABC
	public string get_Name() { }

	// RVA: 0x329CA44 Offset: 0x3298A44 VA: 0x329CA44
	private long get_Value() { }

	// RVA: 0x329CB48 Offset: 0x3298B48 VA: 0x329CB48 Slot: 3
	public override string ToString() { }

	// RVA: 0x329CE08 Offset: 0x3298E08 VA: 0x329CE08
	public static bool op_Equality(Color left, Color right) { }

	// RVA: 0x329CE50 Offset: 0x3298E50 VA: 0x329CE50 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329CEE0 Offset: 0x3298EE0 VA: 0x329CEE0 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x329CF28 Offset: 0x3298F28 VA: 0x329CF28 Slot: 2
	public override int GetHashCode() { }
}
