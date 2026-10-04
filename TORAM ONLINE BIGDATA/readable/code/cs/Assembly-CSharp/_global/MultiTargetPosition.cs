// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MultiTargetPosition : MonoBehaviour // TypeDefIndex: 4651
{
	// Fields
	[SerializeField]
	private GameObject[] target; // 0x20
	private GameObject[] mobTarget; // 0x28

	// Properties
	public int GetTargetNum { get; }
	public bool IsMultiTarget { get; }

	// Methods

	// RVA: 0x2584D7C Offset: 0x2580D7C VA: 0x2584D7C
	public int get_GetTargetNum() { }

	// RVA: 0x2584D94 Offset: 0x2580D94 VA: 0x2584D94
	public bool get_IsMultiTarget() { }

	// RVA: 0x2584E6C Offset: 0x2580E6C VA: 0x2584E6C
	public bool AddTargetMobObject(byte index, GameObject dummyMob) { }

	// RVA: 0x25850D8 Offset: 0x25810D8 VA: 0x25850D8
	public bool GetNearTargetDist(Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x2585240 Offset: 0x2581240 VA: 0x2585240
	public bool GetNearTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x2585434 Offset: 0x2581434 VA: 0x2585434
	public bool GetFarTargetInCameraDist(Plane[] planes, Vector3 pos, float rad, float height, float dist, out GameObject target, out float updateDist) { }

	// RVA: 0x2585628 Offset: 0x2581628 VA: 0x2585628
	public void .ctor() { }
}
