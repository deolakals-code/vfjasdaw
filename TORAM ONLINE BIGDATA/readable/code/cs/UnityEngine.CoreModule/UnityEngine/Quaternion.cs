// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[UsedByNativeCode]
public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 16302
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }
	public Vector3 eulerAngles { get; set; }

	// Methods

	[FreeFunction("FromToQuaternionSafe", IsThreadSafe = True)]
	// RVA: 0x37E31A0 Offset: 0x37DF1A0 VA: 0x37E31A0
	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37E3254 Offset: 0x37DF254 VA: 0x37E3254
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = True)]
	// RVA: 0x37E32EC Offset: 0x37DF2EC VA: 0x37E32EC
	public static Quaternion Slerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x37E33C0 Offset: 0x37DF3C0 VA: 0x37E33C0
	public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = True)]
	// RVA: 0x37E3494 Offset: 0x37DF494 VA: 0x37E3494
	public static Quaternion Lerp(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = True)]
	// RVA: 0x37E3568 Offset: 0x37DF568 VA: 0x37E3568
	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t) { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	// RVA: 0x37E363C Offset: 0x37DF63C VA: 0x37E363C
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = True)]
	// RVA: 0x37E36D4 Offset: 0x37DF6D4 VA: 0x37E36D4
	private static Vector3 Internal_ToEulerRad(Quaternion rotation) { }

	[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = True)]
	// RVA: 0x37E3770 Offset: 0x37DF770 VA: 0x37E3770
	public static Quaternion AngleAxis(float angle, Vector3 axis) { }

	[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = True)]
	// RVA: 0x37E3828 Offset: 0x37DF828 VA: 0x37E3828
	public static Quaternion LookRotation(Vector3 forward, Vector3 upwards) { }

	[ExcludeFromDocs]
	// RVA: 0x37E38DC Offset: 0x37DF8DC VA: 0x37E38DC
	public static Quaternion LookRotation(Vector3 forward) { }

	// RVA: 0x37E3948 Offset: 0x37DF948 VA: 0x37E3948
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x37E3954 Offset: 0x37DF954 VA: 0x37E3954
	public static Quaternion get_identity() { }

	// RVA: 0x37E39A0 Offset: 0x37DF9A0 VA: 0x37E39A0
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x37E3A14 Offset: 0x37DFA14 VA: 0x37E3A14
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x37E3AB8 Offset: 0x37DFAB8 VA: 0x37E3AB8
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x37E3ACC Offset: 0x37DFACC VA: 0x37E3ACC
	public static float Dot(Quaternion a, Quaternion b) { }

	[ExcludeFromDocs]
	// RVA: 0x37E3AEC Offset: 0x37DFAEC VA: 0x37E3AEC
	public void SetLookRotation(Vector3 view) { }

	// RVA: 0x37E3B70 Offset: 0x37DFB70 VA: 0x37E3B70
	public void SetLookRotation(Vector3 view, Vector3 up) { }

	// RVA: 0x37E3B8C Offset: 0x37DFB8C VA: 0x37E3B8C
	public static float Angle(Quaternion a, Quaternion b) { }

	// RVA: 0x37E3BEC Offset: 0x37DFBEC VA: 0x37E3BEC
	private static Vector3 Internal_MakePositive(Vector3 euler) { }

	// RVA: 0x37E3C74 Offset: 0x37DFC74 VA: 0x37E3C74
	public Vector3 get_eulerAngles() { }

	// RVA: 0x37E3CA0 Offset: 0x37DFCA0 VA: 0x37E3CA0
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x37E3CD0 Offset: 0x37DFCD0 VA: 0x37E3CD0
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x37E3CE8 Offset: 0x37DFCE8 VA: 0x37E3CE8
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x37E3D00 Offset: 0x37DFD00 VA: 0x37E3D00
	public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta) { }

	// RVA: 0x37E3E00 Offset: 0x37DFE00 VA: 0x37E3E00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E3E64 Offset: 0x37DFE64 VA: 0x37E3E64 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E3F38 Offset: 0x37DFF38 VA: 0x37E3F38 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x37E3FB8 Offset: 0x37DFFB8 VA: 0x37E3FB8 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E3FC8 Offset: 0x37DFFC8 VA: 0x37E3FC8 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E4200 Offset: 0x37E0200 VA: 0x37E4200
	private static void .cctor() { }

	// RVA: 0x37E3200 Offset: 0x37DF200 VA: 0x37E3200
	private static void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret) { }

	// RVA: 0x37E32A8 Offset: 0x37DF2A8 VA: 0x37E32A8
	private static void Inverse_Injected(ref Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x37E335C Offset: 0x37DF35C VA: 0x37E335C
	private static void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x37E3430 Offset: 0x37DF430 VA: 0x37E3430
	private static void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x37E3504 Offset: 0x37DF504 VA: 0x37E3504
	private static void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x37E35D8 Offset: 0x37DF5D8 VA: 0x37E35D8
	private static void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret) { }

	// RVA: 0x37E3690 Offset: 0x37DF690 VA: 0x37E3690
	private static void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret) { }

	// RVA: 0x37E372C Offset: 0x37DF72C VA: 0x37E372C
	private static void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret) { }

	// RVA: 0x37E37D4 Offset: 0x37DF7D4 VA: 0x37E37D4
	private static void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret) { }

	// RVA: 0x37E3888 Offset: 0x37DF888 VA: 0x37E3888
	private static void LookRotation_Injected(ref Vector3 forward, ref Vector3 upwards, out Quaternion ret) { }
}
