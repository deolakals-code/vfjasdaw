// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeType("Runtime/Math/Vector2Int.h")]
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 16305
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; }
	public int y { get; }

	// Methods

	// RVA: 0x37E7580 Offset: 0x37E3580 VA: 0x37E7580
	public int get_x() { }

	// RVA: 0x37E7588 Offset: 0x37E3588 VA: 0x37E7588
	public int get_y() { }

	// RVA: 0x37E7590 Offset: 0x37E3590 VA: 0x37E7590
	public void .ctor(int x, int y) { }

	// RVA: 0x37E7598 Offset: 0x37E3598 VA: 0x37E7598 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E7620 Offset: 0x37E3620 VA: 0x37E7620 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x37E7648 Offset: 0x37E3648 VA: 0x37E7648 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E7690 Offset: 0x37E3690 VA: 0x37E7690 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E76A0 Offset: 0x37E36A0 VA: 0x37E76A0 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E7830 Offset: 0x37E3830 VA: 0x37E7830
	private static void .cctor() { }
}
