// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PolygonRay : IObjectCollder // TypeDefIndex: 5295
{
	// Fields
	private Transform[] point; // 0x10
	private int[] triangle; // 0x18
	private int[] square; // 0x20
	private Vector3[] position; // 0x28

	// Methods

	// RVA: 0x2626534 Offset: 0x2622534 VA: 0x2626534
	public void .ctor(Transform[] point, int[] triangle) { }

	// RVA: 0x262653C Offset: 0x262253C VA: 0x262653C
	public void .ctor(Transform[] point, int[] triangle, int[] square) { }

	// RVA: 0x262659C Offset: 0x262259C VA: 0x262659C Slot: 4
	public bool IsHit(Vector3 p1, Vector3 pVec, float d) { }
}
