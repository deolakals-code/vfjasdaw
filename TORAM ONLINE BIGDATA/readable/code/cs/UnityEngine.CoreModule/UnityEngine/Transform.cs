// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
[RequiredByNativeCode]
[NativeHeader("Runtime/Transform/Transform.h")]
public class Transform : Component, IEnumerable // TypeDefIndex: 16403
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 eulerAngles { get; set; }
	public Vector3 localEulerAngles { get; set; }
	public Vector3 right { get; }
	public Vector3 up { get; }
	public Vector3 forward { get; set; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged { get; set; }

	// Methods

	// RVA: 0x37F2524 Offset: 0x37EE524 VA: 0x37F2524
	protected void .ctor() { }

	// RVA: 0x37F2528 Offset: 0x37EE528 VA: 0x37F2528
	public Vector3 get_position() { }

	// RVA: 0x37F25C8 Offset: 0x37EE5C8 VA: 0x37F25C8
	public void set_position(Vector3 value) { }

	// RVA: 0x37F2660 Offset: 0x37EE660 VA: 0x37F2660
	public Vector3 get_localPosition() { }

	// RVA: 0x37F2700 Offset: 0x37EE700 VA: 0x37F2700
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x37F2798 Offset: 0x37EE798 VA: 0x37F2798
	public Vector3 get_eulerAngles() { }

	// RVA: 0x37F2820 Offset: 0x37EE820 VA: 0x37F2820
	public void set_eulerAngles(Vector3 value) { }

	// RVA: 0x37F28A4 Offset: 0x37EE8A4 VA: 0x37F28A4
	public Vector3 get_localEulerAngles() { }

	// RVA: 0x37F292C Offset: 0x37EE92C VA: 0x37F292C
	public void set_localEulerAngles(Vector3 value) { }

	// RVA: 0x37F29B0 Offset: 0x37EE9B0 VA: 0x37F29B0
	public Vector3 get_right() { }

	// RVA: 0x37F2A2C Offset: 0x37EEA2C VA: 0x37F2A2C
	public Vector3 get_up() { }

	// RVA: 0x37F2AA8 Offset: 0x37EEAA8 VA: 0x37F2AA8
	public Vector3 get_forward() { }

	// RVA: 0x37F2B24 Offset: 0x37EEB24 VA: 0x37F2B24
	public void set_forward(Vector3 value) { }

	// RVA: 0x37F27C8 Offset: 0x37EE7C8 VA: 0x37F27C8
	public Quaternion get_rotation() { }

	// RVA: 0x37F2850 Offset: 0x37EE850 VA: 0x37F2850
	public void set_rotation(Quaternion value) { }

	// RVA: 0x37F28D4 Offset: 0x37EE8D4 VA: 0x37F28D4
	public Quaternion get_localRotation() { }

	// RVA: 0x37F295C Offset: 0x37EE95C VA: 0x37F295C
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x37F2C50 Offset: 0x37EEC50 VA: 0x37F2C50
	public Vector3 get_localScale() { }

	// RVA: 0x37F2CF0 Offset: 0x37EECF0 VA: 0x37F2CF0
	public void set_localScale(Vector3 value) { }

	// RVA: 0x37F2D88 Offset: 0x37EED88 VA: 0x37F2D88
	public Transform get_parent() { }

	// RVA: 0x37F2E00 Offset: 0x37EEE00 VA: 0x37F2E00
	public void set_parent(Transform value) { }

	// RVA: 0x37F2DC4 Offset: 0x37EEDC4 VA: 0x37F2DC4
	internal Transform get_parentInternal() { }

	// RVA: 0x37F2ECC Offset: 0x37EEECC VA: 0x37F2ECC
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x37F2F14 Offset: 0x37EEF14 VA: 0x37F2F14
	private Transform GetParent() { }

	// RVA: 0x37F2F50 Offset: 0x37EEF50 VA: 0x37F2F50
	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	// RVA: 0x37F2F98 Offset: 0x37EEF98 VA: 0x37F2F98
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x37F2FEC Offset: 0x37EEFEC VA: 0x37F2FEC
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x37F309C Offset: 0x37EF09C VA: 0x37F309C
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x37F314C Offset: 0x37EF14C VA: 0x37F314C
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x37F33D4 Offset: 0x37EF3D4 VA: 0x37F33D4
	public void Rotate(Vector3 eulers) { }

	// RVA: 0x37F33DC Offset: 0x37EF3DC VA: 0x37F33DC
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	[NativeMethod("RotateAround")]
	// RVA: 0x37F33E4 Offset: 0x37EF3E4 VA: 0x37F33E4
	internal void RotateAroundInternal(Vector3 axis, float angle) { }

	// RVA: 0x37F349C Offset: 0x37EF49C VA: 0x37F349C
	public void Rotate(Vector3 axis, float angle, Space relativeTo) { }

	// RVA: 0x37F35B4 Offset: 0x37EF5B4 VA: 0x37F35B4
	public void Rotate(Vector3 axis, float angle) { }

	// RVA: 0x37F35BC Offset: 0x37EF5BC VA: 0x37F35BC
	public void RotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x37F3680 Offset: 0x37EF680 VA: 0x37F3680
	public void LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x37F36E4 Offset: 0x37EF6E4 VA: 0x37F36E4
	public void LookAt(Vector3 worldPosition) { }

	[FreeFunction("Internal_LookAt", HasExplicitThis = True)]
	// RVA: 0x37F3684 Offset: 0x37EF684 VA: 0x37F3684
	private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp) { }

	// RVA: 0x37F354C Offset: 0x37EF54C VA: 0x37F354C
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x37F3808 Offset: 0x37EF808 VA: 0x37F3808
	public Vector3 InverseTransformDirection(Vector3 direction) { }

	// RVA: 0x37F38C4 Offset: 0x37EF8C4 VA: 0x37F38C4
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x37F3980 Offset: 0x37EF980 VA: 0x37F3980
	public Vector3 TransformPoint(float x, float y, float z) { }

	// RVA: 0x37F3984 Offset: 0x37EF984 VA: 0x37F3984
	public Vector3 InverseTransformPoint(Vector3 position) { }

	[NativeMethod("GetChildrenCount")]
	// RVA: 0x37F3A40 Offset: 0x37EFA40 VA: 0x37F3A40
	public int get_childCount() { }

	[FreeFunction]
	// RVA: 0x37F3A7C Offset: 0x37EFA7C VA: 0x37F3A7C
	private static Transform FindRelativeTransformWithPath(Transform transform, string path, bool isActiveOnly) { }

	// RVA: 0x37F3AD0 Offset: 0x37EFAD0 VA: 0x37F3AD0
	public Transform Find(string n) { }

	[NativeMethod("GetWorldScaleLossy")]
	// RVA: 0x37F3B64 Offset: 0x37EFB64 VA: 0x37F3B64
	public Vector3 get_lossyScale() { }

	// RVA: 0x37F3C04 Offset: 0x37EFC04 VA: 0x37F3C04
	public bool get_hasChanged() { }

	// RVA: 0x37F3C40 Offset: 0x37EFC40 VA: 0x37F3C40
	public void set_hasChanged(bool value) { }

	// RVA: 0x37F3C84 Offset: 0x37EFC84 VA: 0x37F3C84 Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	// RVA: 0x37F3D2C Offset: 0x37EFD2C VA: 0x37F3D2C
	public Transform GetChild(int index) { }

	// RVA: 0x37F2584 Offset: 0x37EE584 VA: 0x37F2584
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x37F261C Offset: 0x37EE61C VA: 0x37F261C
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x37F26BC Offset: 0x37EE6BC VA: 0x37F26BC
	private void get_localPosition_Injected(out Vector3 ret) { }

	// RVA: 0x37F2754 Offset: 0x37EE754 VA: 0x37F2754
	private void set_localPosition_Injected(ref Vector3 value) { }

	// RVA: 0x37F2B40 Offset: 0x37EEB40 VA: 0x37F2B40
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x37F2B84 Offset: 0x37EEB84 VA: 0x37F2B84
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x37F2BC8 Offset: 0x37EEBC8 VA: 0x37F2BC8
	private void get_localRotation_Injected(out Quaternion ret) { }

	// RVA: 0x37F2C0C Offset: 0x37EEC0C VA: 0x37F2C0C
	private void set_localRotation_Injected(ref Quaternion value) { }

	// RVA: 0x37F2CAC Offset: 0x37EECAC VA: 0x37F2CAC
	private void get_localScale_Injected(out Vector3 ret) { }

	// RVA: 0x37F2D44 Offset: 0x37EED44 VA: 0x37F2D44
	private void set_localScale_Injected(ref Vector3 value) { }

	// RVA: 0x37F3058 Offset: 0x37EF058 VA: 0x37F3058
	private void get_worldToLocalMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x37F3108 Offset: 0x37EF108 VA: 0x37F3108
	private void get_localToWorldMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x37F3448 Offset: 0x37EF448 VA: 0x37F3448
	private void RotateAroundInternal_Injected(ref Vector3 axis, float angle) { }

	// RVA: 0x37F3760 Offset: 0x37EF760 VA: 0x37F3760
	private void Internal_LookAt_Injected(ref Vector3 worldPosition, ref Vector3 worldUp) { }

	// RVA: 0x37F37B4 Offset: 0x37EF7B4 VA: 0x37F37B4
	private void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x37F3870 Offset: 0x37EF870 VA: 0x37F3870
	private void InverseTransformDirection_Injected(ref Vector3 direction, out Vector3 ret) { }

	// RVA: 0x37F392C Offset: 0x37EF92C VA: 0x37F392C
	private void TransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x37F39EC Offset: 0x37EF9EC VA: 0x37F39EC
	private void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	// RVA: 0x37F3BC0 Offset: 0x37EFBC0 VA: 0x37F3BC0
	private void get_lossyScale_Injected(out Vector3 ret) { }
}
