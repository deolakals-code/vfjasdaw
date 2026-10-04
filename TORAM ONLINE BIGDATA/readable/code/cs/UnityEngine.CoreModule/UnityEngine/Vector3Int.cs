// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[DefaultMember("Item")]
[UsedByNativeCode]
[Il2CppEagerStaticClassConstruction]
public struct Vector3Int : IEquatable<Vector3Int>, IFormattable // TypeDefIndex: 16306
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private int m_Z; // 0x8
	private static readonly Vector3Int s_Zero; // 0x0
	private static readonly Vector3Int s_One; // 0xC
	private static readonly Vector3Int s_Up; // 0x18
	private static readonly Vector3Int s_Down; // 0x24
	private static readonly Vector3Int s_Left; // 0x30
	private static readonly Vector3Int s_Right; // 0x3C
	private static readonly Vector3Int s_Forward; // 0x48
	private static readonly Vector3Int s_Back; // 0x54

	// Properties
	public int x { get; }
	public int y { get; }
	public int z { get; }

	// Methods

	// RVA: 0x37E78B8 Offset: 0x37E38B8 VA: 0x37E78B8
	public int get_x() { }

	// RVA: 0x37E78C0 Offset: 0x37E38C0 VA: 0x37E78C0
	public int get_y() { }

	// RVA: 0x37E78C8 Offset: 0x37E38C8 VA: 0x37E78C8
	public int get_z() { }

	// RVA: 0x37E78D0 Offset: 0x37E38D0 VA: 0x37E78D0
	public void .ctor(int x, int y, int z) { }

	// RVA: 0x37E78DC Offset: 0x37E38DC VA: 0x37E78DC
	public static bool op_Equality(Vector3Int lhs, Vector3Int rhs) { }

	// RVA: 0x37E790C Offset: 0x37E390C VA: 0x37E790C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E79A8 Offset: 0x37E39A8 VA: 0x37E79A8 Slot: 4
	public bool Equals(Vector3Int other) { }

	// RVA: 0x37E79E0 Offset: 0x37E39E0 VA: 0x37E79E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E7A58 Offset: 0x37E3A58 VA: 0x37E7A58 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E7A68 Offset: 0x37E3A68 VA: 0x37E7A68 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E7C4C Offset: 0x37E3C4C VA: 0x37E7C4C
	private static void .cctor() { }
}
