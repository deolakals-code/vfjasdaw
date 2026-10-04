// Assembly: UnityEngine.InputLegacyModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Input/GetInput.h")]
public class Gyroscope // TypeDefIndex: 17766
{
	// Fields
	private int m_GyroIndex; // 0x10

	// Properties
	public Vector3 gravity { get; }
	public bool enabled { set; }

	// Methods

	// RVA: 0x38165DC Offset: 0x38125DC VA: 0x38165DC
	internal void .ctor(int index) { }

	[FreeFunction("GetGravity")]
	// RVA: 0x3816604 Offset: 0x3812604 VA: 0x3816604
	private static Vector3 gravity_Internal(int idx) { }

	[FreeFunction("SetGyroEnabled")]
	// RVA: 0x38166A4 Offset: 0x38126A4 VA: 0x38166A4
	private static void setEnabled_Internal(int idx, bool enabled) { }

	// RVA: 0x38166E8 Offset: 0x38126E8 VA: 0x38166E8
	public Vector3 get_gravity() { }

	// RVA: 0x38166F0 Offset: 0x38126F0 VA: 0x38166F0
	public void set_enabled(bool value) { }

	// RVA: 0x3816660 Offset: 0x3812660 VA: 0x3816660
	private static void gravity_Internal_Injected(int idx, out Vector3 ret) { }
}
