// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CapsuleCollder : IObjectCollder // TypeDefIndex: 5288
{
	// Fields
	private Transform[] point; // 0x10
	private float radius; // 0x18

	// Methods

	// RVA: 0x2623530 Offset: 0x261F530 VA: 0x2623530
	public void .ctor(Transform p1, Transform p2, float radius) { }

	// RVA: 0x2623638 Offset: 0x261F638 VA: 0x2623638 Slot: 4
	public bool IsHit(Vector3 position, Vector3 vec, float d) { }

	// RVA: 0x262371C Offset: 0x261F71C VA: 0x262371C
	public static bool IsHit(Vector3 position, Vector3 p1, Vector3 p2, float d) { }

	// RVA: 0x2623758 Offset: 0x261F758 VA: 0x2623758
	public static bool IsHit(Vector3 position, Vector3 p1, Vector3 p2, float d, out float sqrMagnitude) { }
}
