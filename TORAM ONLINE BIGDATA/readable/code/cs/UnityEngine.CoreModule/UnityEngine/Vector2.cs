// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector2f")]
[DefaultMember("Item")]
public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 16304
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 down { get; }
	public static Vector2 right { get; }

	// Methods

	// RVA: 0x37E6C60 Offset: 0x37E2C60 VA: 0x37E6C60
	public void .ctor(float x, float y) { }

	// RVA: 0x37E6C68 Offset: 0x37E2C68 VA: 0x37E6C68
	public static Vector2 Lerp(Vector2 a, Vector2 b, float t) { }

	// RVA: 0x37E6C98 Offset: 0x37E2C98 VA: 0x37E6C98
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x37E6CA4 Offset: 0x37E2CA4 VA: 0x37E6CA4
	public void Normalize() { }

	// RVA: 0x37E6D68 Offset: 0x37E2D68 VA: 0x37E6D68
	public Vector2 get_normalized() { }

	// RVA: 0x37E6E18 Offset: 0x37E2E18 VA: 0x37E6E18 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E6E28 Offset: 0x37E2E28 VA: 0x37E6E28 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E6FC8 Offset: 0x37E2FC8 VA: 0x37E6FC8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E6FFC Offset: 0x37E2FFC VA: 0x37E6FFC Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E7084 Offset: 0x37E3084 VA: 0x37E7084 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x37E70A8 Offset: 0x37E30A8 VA: 0x37E70A8
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x37E70B8 Offset: 0x37E30B8 VA: 0x37E70B8
	public float get_magnitude() { }

	// RVA: 0x37E7124 Offset: 0x37E3124 VA: 0x37E7124
	public float get_sqrMagnitude() { }

	// RVA: 0x37E7138 Offset: 0x37E3138 VA: 0x37E7138
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x37E722C Offset: 0x37E322C VA: 0x37E722C
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x37E72B0 Offset: 0x37E32B0 VA: 0x37E72B0
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x37E72BC Offset: 0x37E32BC VA: 0x37E72BC
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x37E72C8 Offset: 0x37E32C8 VA: 0x37E72C8
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x37E72D4 Offset: 0x37E32D4 VA: 0x37E72D4
	public static Vector2 op_UnaryNegation(Vector2 a) { }

	// RVA: 0x37E72E0 Offset: 0x37E32E0 VA: 0x37E72E0
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x37E72EC Offset: 0x37E32EC VA: 0x37E72EC
	public static Vector2 op_Multiply(float d, Vector2 a) { }

	// RVA: 0x37E72FC Offset: 0x37E32FC VA: 0x37E72FC
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x37E7308 Offset: 0x37E3308 VA: 0x37E7308
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x37E7330 Offset: 0x37E3330 VA: 0x37E7330
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x37E7358 Offset: 0x37E3358 VA: 0x37E7358
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x37E735C Offset: 0x37E335C VA: 0x37E735C
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x37E7364 Offset: 0x37E3364 VA: 0x37E7364
	public static Vector2 get_zero() { }

	// RVA: 0x37E73AC Offset: 0x37E33AC VA: 0x37E73AC
	public static Vector2 get_one() { }

	// RVA: 0x37E73F4 Offset: 0x37E33F4 VA: 0x37E73F4
	public static Vector2 get_up() { }

	// RVA: 0x37E743C Offset: 0x37E343C VA: 0x37E743C
	public static Vector2 get_down() { }

	// RVA: 0x37E7484 Offset: 0x37E3484 VA: 0x37E7484
	public static Vector2 get_right() { }

	// RVA: 0x37E74CC Offset: 0x37E34CC VA: 0x37E74CC
	private static void .cctor() { }
}
