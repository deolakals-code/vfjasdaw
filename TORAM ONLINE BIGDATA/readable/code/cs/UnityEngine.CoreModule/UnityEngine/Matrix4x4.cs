// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Math/MathScripting.h")]
[Il2CppEagerStaticClassConstruction]
[DefaultMember("Item")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[NativeClass("Matrix4x4f")]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 16300
{
	// Fields
	[NativeName("m_Data[0]")]
	public float m00; // 0x0
	[NativeName("m_Data[1]")]
	public float m10; // 0x4
	[NativeName("m_Data[2]")]
	public float m20; // 0x8
	[NativeName("m_Data[3]")]
	public float m30; // 0xC
	[NativeName("m_Data[4]")]
	public float m01; // 0x10
	[NativeName("m_Data[5]")]
	public float m11; // 0x14
	[NativeName("m_Data[6]")]
	public float m21; // 0x18
	[NativeName("m_Data[7]")]
	public float m31; // 0x1C
	[NativeName("m_Data[8]")]
	public float m02; // 0x20
	[NativeName("m_Data[9]")]
	public float m12; // 0x24
	[NativeName("m_Data[10]")]
	public float m22; // 0x28
	[NativeName("m_Data[11]")]
	public float m32; // 0x2C
	[NativeName("m_Data[12]")]
	public float m03; // 0x30
	[NativeName("m_Data[13]")]
	public float m13; // 0x34
	[NativeName("m_Data[14]")]
	public float m23; // 0x38
	[NativeName("m_Data[15]")]
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Properties
	public Matrix4x4 inverse { get; }
	public static Matrix4x4 identity { get; }

	// Methods

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	// RVA: 0x37E0FB4 Offset: 0x37DCFB4 VA: 0x37E0FB4
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x37E10A0 Offset: 0x37DD0A0 VA: 0x37E10A0
	public void SetTRS(Vector3 pos, Quaternion q, Vector3 s) { }

	[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = True)]
	// RVA: 0x37E10E0 Offset: 0x37DD0E0 VA: 0x37E10E0
	public static Matrix4x4 Inverse(Matrix4x4 m) { }

	// RVA: 0x37E1190 Offset: 0x37DD190 VA: 0x37E1190
	public Matrix4x4 get_inverse() { }

	// RVA: 0x37E1210 Offset: 0x37DD210 VA: 0x37E1210
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x37E122C Offset: 0x37DD22C VA: 0x37E122C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E14A8 Offset: 0x37DD4A8 VA: 0x37E14A8 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E161C Offset: 0x37DD61C VA: 0x37E161C Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x37D1AB0 Offset: 0x37CDAB0 VA: 0x37D1AB0
	public static Matrix4x4 op_Multiply(Matrix4x4 lhs, Matrix4x4 rhs) { }

	// RVA: 0x37E13D4 Offset: 0x37DD3D4 VA: 0x37E13D4
	public Vector4 GetColumn(int index) { }

	// RVA: 0x37E1724 Offset: 0x37DD724 VA: 0x37E1724
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x37E17A4 Offset: 0x37DD7A4 VA: 0x37E17A4
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x37E17FC Offset: 0x37DD7FC VA: 0x37E17FC
	public Vector3 MultiplyVector(Vector3 vector) { }

	// RVA: 0x37E1844 Offset: 0x37DD844 VA: 0x37E1844
	public static Matrix4x4 Scale(Vector3 vector) { }

	// RVA: 0x37E1870 Offset: 0x37DD870 VA: 0x37E1870
	public static Matrix4x4 get_identity() { }

	// RVA: 0x37E18C8 Offset: 0x37DD8C8 VA: 0x37E18C8 Slot: 3
	public override string ToString() { }

	// RVA: 0x37E18D8 Offset: 0x37DD8D8 VA: 0x37E18D8 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E1EA0 Offset: 0x37DDEA0 VA: 0x37E1EA0
	private static void .cctor() { }

	// RVA: 0x37E1044 Offset: 0x37DD044 VA: 0x37E1044
	private static void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret) { }

	// RVA: 0x37E114C Offset: 0x37DD14C VA: 0x37E114C
	private static void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret) { }
}
