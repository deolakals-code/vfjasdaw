// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[Serializable]
public struct RectangleF : IEquatable<RectangleF> // TypeDefIndex: 17320
{
	// Fields
	private float x; // 0x0
	private float y; // 0x4
	private float width; // 0x8
	private float height; // 0xC

	// Properties
	public float X { get; }
	public float Y { get; }
	public float Width { get; }
	public float Height { get; }

	// Methods

	// RVA: 0x329D94C Offset: 0x329994C VA: 0x329D94C
	public float get_X() { }

	// RVA: 0x329D954 Offset: 0x3299954 VA: 0x329D954
	public float get_Y() { }

	// RVA: 0x329D95C Offset: 0x329995C VA: 0x329D95C
	public float get_Width() { }

	// RVA: 0x329D964 Offset: 0x3299964 VA: 0x329D964
	public float get_Height() { }

	// RVA: 0x329D96C Offset: 0x329996C VA: 0x329D96C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329DA1C Offset: 0x3299A1C VA: 0x329DA1C Slot: 4
	public bool Equals(RectangleF other) { }

	// RVA: 0x329DA58 Offset: 0x3299A58 VA: 0x329DA58
	public static bool op_Equality(RectangleF left, RectangleF right) { }

	// RVA: 0x329DA80 Offset: 0x3299A80 VA: 0x329DA80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329DB58 Offset: 0x3299B58 VA: 0x329DB58 Slot: 3
	public override string ToString() { }
}
