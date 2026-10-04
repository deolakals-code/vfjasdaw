// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeClass("Vector4f")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Il2CppEagerStaticClassConstruction]
[NativeHeader("Runtime/Math/Vector4.h")]
public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 16307
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public static Vector4 zero { get; }
	public static Vector4 one { get; }

	// Methods

	// RVA: 0x37E7D18 Offset: 0x37E3D18 VA: 0x37E7D18
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x37E7D24 Offset: 0x37E3D24 VA: 0x37E7D24 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E7D88 Offset: 0x37E3D88 VA: 0x37E7D88 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E7E30 Offset: 0x37E3E30 VA: 0x37E7E30 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x37E7E6C Offset: 0x37E3E6C VA: 0x37E7E6C
	public static Vector4 get_zero() { }

	// RVA: 0x37E7EB8 Offset: 0x37E3EB8 VA: 0x37E7EB8
	public static Vector4 get_one() { }

	// RVA: 0x37E7F04 Offset: 0x37E3F04 VA: 0x37E7F04
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x37E7F44 Offset: 0x37E3F44 VA: 0x37E7F44
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x37E7F84 Offset: 0x37E3F84 VA: 0x37E7F84
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x37E7F8C Offset: 0x37E3F8C VA: 0x37E7F8C
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x37E7F90 Offset: 0x37E3F90 VA: 0x37E7F90
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x37E7F9C Offset: 0x37E3F9C VA: 0x37E7F9C Slot: 3
	public override string ToString() { }

	// RVA: 0x37E7FAC Offset: 0x37E3FAC VA: 0x37E7FAC Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E81E4 Offset: 0x37E41E4 VA: 0x37E81E4
	private static void .cctor() { }
}
