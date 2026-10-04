// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[Serializable]
public struct PointF : IEquatable<PointF> // TypeDefIndex: 17318
{
	// Fields
	private float x; // 0x0
	private float y; // 0x4

	// Properties
	public float X { get; }
	public float Y { get; }

	// Methods

	// RVA: 0x329D294 Offset: 0x3299294 VA: 0x329D294
	public float get_X() { }

	// RVA: 0x329D29C Offset: 0x329929C VA: 0x329D29C
	public float get_Y() { }

	// RVA: 0x329D2A4 Offset: 0x32992A4 VA: 0x329D2A4
	public static bool op_Equality(PointF left, PointF right) { }

	// RVA: 0x329D2BC Offset: 0x32992BC VA: 0x329D2BC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329D340 Offset: 0x3299340 VA: 0x329D340 Slot: 4
	public bool Equals(PointF other) { }

	// RVA: 0x329D35C Offset: 0x329935C VA: 0x329D35C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329D3F4 Offset: 0x32993F4 VA: 0x329D3F4 Slot: 3
	public override string ToString() { }
}
