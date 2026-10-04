// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Math/Vector3.h")]
[Il2CppEagerStaticClassConstruction]
[DefaultMember("Item")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[NativeClass("Vector3f")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 16301
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }

	// Methods

	[FreeFunction("VectorScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x37E1F20 Offset: 0x37DDF20 VA: 0x37E1F20
	public static Vector3 Slerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x37E1FF8 Offset: 0x37DDFF8 VA: 0x37E1FF8
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x37E2034 Offset: 0x37DE034 VA: 0x37E2034
	public float get_Item(int index) { }

	// RVA: 0x37E20AC Offset: 0x37DE0AC VA: 0x37E20AC
	public void set_Item(int index, float value) { }

	// RVA: 0x37E2124 Offset: 0x37DE124 VA: 0x37E2124
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x37E2130 Offset: 0x37DE130 VA: 0x37E2130
	public void .ctor(float x, float y) { }

	// RVA: 0x37E213C Offset: 0x37DE13C VA: 0x37E213C
	public void Set(float newX, float newY, float newZ) { }

	// RVA: 0x37E2148 Offset: 0x37DE148 VA: 0x37E2148
	public static Vector3 Scale(Vector3 a, Vector3 b) { }

	// RVA: 0x37E2158 Offset: 0x37DE158 VA: 0x37E2158
	public void Scale(Vector3 scale) { }

	// RVA: 0x37E2178 Offset: 0x37DE178 VA: 0x37E2178
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x37E21A0 Offset: 0x37DE1A0 VA: 0x37E21A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E21E8 Offset: 0x37DE1E8 VA: 0x37E21E8 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E2280 Offset: 0x37DE280 VA: 0x37E2280 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x37E22B0 Offset: 0x37DE2B0 VA: 0x37E22B0
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x37E2380 Offset: 0x37DE380 VA: 0x37E2380
	public void Normalize() { }

	// RVA: 0x37E2468 Offset: 0x37DE468 VA: 0x37E2468
	public Vector3 get_normalized() { }

	// RVA: 0x37E2534 Offset: 0x37DE534 VA: 0x37E2534
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x37E254C Offset: 0x37DE54C VA: 0x37E254C
	public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal) { }

	// RVA: 0x37E2624 Offset: 0x37DE624 VA: 0x37E2624
	public static float Angle(Vector3 from, Vector3 to) { }

	// RVA: 0x37E2740 Offset: 0x37DE740 VA: 0x37E2740
	public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis) { }

	// RVA: 0x37E28B8 Offset: 0x37DE8B8 VA: 0x37E28B8
	public static float Distance(Vector3 a, Vector3 b) { }

	// RVA: 0x37E2958 Offset: 0x37DE958 VA: 0x37E2958
	public static Vector3 ClampMagnitude(Vector3 vector, float maxLength) { }

	// RVA: 0x37E2A0C Offset: 0x37DEA0C VA: 0x37E2A0C
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x37E2A8C Offset: 0x37DEA8C VA: 0x37E2A8C
	public float get_magnitude() { }

	// RVA: 0x37E2B0C Offset: 0x37DEB0C VA: 0x37E2B0C
	public static float SqrMagnitude(Vector3 vector) { }

	// RVA: 0x37E2B24 Offset: 0x37DEB24 VA: 0x37E2B24
	public float get_sqrMagnitude() { }

	// RVA: 0x37E2B44 Offset: 0x37DEB44 VA: 0x37E2B44
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x37E2B60 Offset: 0x37DEB60 VA: 0x37E2B60
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x37E2B7C Offset: 0x37DEB7C VA: 0x37E2B7C
	public static Vector3 get_zero() { }

	// RVA: 0x37E2BC8 Offset: 0x37DEBC8 VA: 0x37E2BC8
	public static Vector3 get_one() { }

	// RVA: 0x37E2C14 Offset: 0x37DEC14 VA: 0x37E2C14
	public static Vector3 get_forward() { }

	// RVA: 0x37E2C60 Offset: 0x37DEC60 VA: 0x37E2C60
	public static Vector3 get_back() { }

	// RVA: 0x37E2CAC Offset: 0x37DECAC VA: 0x37E2CAC
	public static Vector3 get_up() { }

	// RVA: 0x37E2CF8 Offset: 0x37DECF8 VA: 0x37E2CF8
	public static Vector3 get_down() { }

	// RVA: 0x37E2D44 Offset: 0x37DED44 VA: 0x37E2D44
	public static Vector3 get_left() { }

	// RVA: 0x37E2D90 Offset: 0x37DED90 VA: 0x37E2D90
	public static Vector3 get_right() { }

	// RVA: 0x37E2DDC Offset: 0x37DEDDC VA: 0x37E2DDC
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x37E2DEC Offset: 0x37DEDEC VA: 0x37E2DEC
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x37E2DFC Offset: 0x37DEDFC VA: 0x37E2DFC
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x37E2E0C Offset: 0x37DEE0C VA: 0x37E2E0C
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x37E2E1C Offset: 0x37DEE1C VA: 0x37E2E1C
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x37E2E30 Offset: 0x37DEE30 VA: 0x37E2E30
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x37E2E40 Offset: 0x37DEE40 VA: 0x37E2E40
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x37E2E74 Offset: 0x37DEE74 VA: 0x37E2E74
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x37E2EA8 Offset: 0x37DEEA8 VA: 0x37E2EA8 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E2EB8 Offset: 0x37DEEB8 VA: 0x37E2EB8 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E30A4 Offset: 0x37DF0A4 VA: 0x37E30A4
	private static void .cctor() { }

	// RVA: 0x37E1F94 Offset: 0x37DDF94 VA: 0x37E1F94
	private static void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret) { }
}
