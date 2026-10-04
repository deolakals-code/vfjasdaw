// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PolygonRayCollider : MonoBehaviour, IObjectCollder // TypeDefIndex: 5296
{
	// Fields
	[SerializeField]
	private Transform[] point; // 0x20
	[SerializeField]
	private int[] triangle; // 0x28
	[SerializeField]
	private int[] square; // 0x30
	private PolygonRay polygonRay; // 0x38

	// Methods

	// RVA: 0x2626964 Offset: 0x2622964 VA: 0x2626964
	private void Awake() { }

	// RVA: 0x26269DC Offset: 0x26229DC VA: 0x26269DC Slot: 4
	public bool IsHit(Vector3 p1, Vector3 pVec, float d) { }

	// RVA: 0x2626B0C Offset: 0x2622B0C VA: 0x2626B0C
	public void .ctor() { }
}
