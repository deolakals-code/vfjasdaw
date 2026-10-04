// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OBB // TypeDefIndex: 5294
{
	// Fields
	private Vector3[] normDir; // 0x10
	[CompilerGenerated]
	private Vector3 <Center>k__BackingField; // 0x18
	[CompilerGenerated]
	private Vector3 <Length>k__BackingField; // 0x24
	[CompilerGenerated]
	private Quaternion <Rotation>k__BackingField; // 0x30

	// Properties
	public Vector3 Center { get; set; }
	public Vector3 Length { get; set; }
	public Quaternion Rotation { get; set; }
	public Vector3 NormDirectX { get; set; }
	public Vector3 NormDirectY { get; set; }
	public Vector3 NormDirectZ { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2625AF4 Offset: 0x2621AF4 VA: 0x2625AF4
	public Vector3 get_Center() { }

	[CompilerGenerated]
	// RVA: 0x2625B00 Offset: 0x2621B00 VA: 0x2625B00
	public void set_Center(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2625B0C Offset: 0x2621B0C VA: 0x2625B0C
	public Vector3 get_Length() { }

	[CompilerGenerated]
	// RVA: 0x2625B18 Offset: 0x2621B18 VA: 0x2625B18
	public void set_Length(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x2625B24 Offset: 0x2621B24 VA: 0x2625B24
	public Quaternion get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x2625B30 Offset: 0x2621B30 VA: 0x2625B30
	private void set_Rotation(Quaternion value) { }

	// RVA: 0x2625B3C Offset: 0x2621B3C VA: 0x2625B3C
	public Vector3 get_NormDirectX() { }

	// RVA: 0x2625B68 Offset: 0x2621B68 VA: 0x2625B68
	public void set_NormDirectX(Vector3 value) { }

	// RVA: 0x2625B94 Offset: 0x2621B94 VA: 0x2625B94
	public Vector3 get_NormDirectY() { }

	// RVA: 0x2625BC4 Offset: 0x2621BC4 VA: 0x2625BC4
	public void set_NormDirectY(Vector3 value) { }

	// RVA: 0x2625BF4 Offset: 0x2621BF4 VA: 0x2625BF4
	public Vector3 get_NormDirectZ() { }

	// RVA: 0x2625C24 Offset: 0x2621C24 VA: 0x2625C24
	public void set_NormDirectZ(Vector3 value) { }

	// RVA: 0x2625C54 Offset: 0x2621C54 VA: 0x2625C54
	public void .ctor() { }

	// RVA: 0x2625D04 Offset: 0x2621D04 VA: 0x2625D04
	public void .ctor(Vector3 center, Vector3 len, Matrix4x4 mat) { }

	// RVA: 0x2625FDC Offset: 0x2621FDC VA: 0x2625FDC
	public void .ctor(Vector3 center, Vector3 len, Quaternion q) { }

	// RVA: 0x26260A8 Offset: 0x26220A8 VA: 0x26260A8
	public void Set(Vector3 center, Vector3 len, Quaternion q) { }

	// RVA: 0x2626360 Offset: 0x2622360 VA: 0x2626360
	public bool IsHitPoint(Vector3 pos) { }

	// RVA: 0x262650C Offset: 0x262250C VA: 0x262650C
	public bool IsHitSphere(Vector3 pos, float rad) { }

	// RVA: 0x2626378 Offset: 0x2622378 VA: 0x2626378
	public float GetOBBAndPointDist2(Vector3 pos) { }
}
