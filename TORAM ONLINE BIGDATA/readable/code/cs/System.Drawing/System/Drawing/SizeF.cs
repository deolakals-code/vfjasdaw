// Assembly: System.Drawing.dll
// Namespace: System.Drawing
[Serializable]
public struct SizeF : IEquatable<SizeF> // TypeDefIndex: 17322
{
	// Fields
	private float width; // 0x0
	private float height; // 0x4

	// Properties
	public float Width { get; }
	public float Height { get; }

	// Methods

	// RVA: 0x329E018 Offset: 0x329A018 VA: 0x329E018
	public static bool op_Equality(SizeF sz1, SizeF sz2) { }

	// RVA: 0x329E030 Offset: 0x329A030 VA: 0x329E030
	public float get_Width() { }

	// RVA: 0x329E038 Offset: 0x329A038 VA: 0x329E038
	public float get_Height() { }

	// RVA: 0x329E040 Offset: 0x329A040 VA: 0x329E040 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x329E0C4 Offset: 0x329A0C4 VA: 0x329E0C4 Slot: 4
	public bool Equals(SizeF other) { }

	// RVA: 0x329E0E0 Offset: 0x329A0E0 VA: 0x329E0E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x329E178 Offset: 0x329A178 VA: 0x329E178 Slot: 3
	public override string ToString() { }
}
