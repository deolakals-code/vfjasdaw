// Assembly: Assembly-CSharp.dll
// Namespace: 
public class WallCollision : MonoBehaviour // TypeDefIndex: 4008
{
	// Fields
	private string hitLabelText; // 0x20
	private Transform player; // 0x28
	private bool hitWall; // 0x30
	private OBB labelObb; // 0x38

	// Methods

	// RVA: 0x246F75C Offset: 0x246B75C VA: 0x246F75C
	public void Initialize(float x1, float z1, float x2, float z2, string localizeText) { }

	// RVA: 0x246F77C Offset: 0x246B77C VA: 0x246F77C
	public void Initialize(float x1, float z1, float x2, float z2, string localizeText, int flag) { }

	// RVA: 0x246F798 Offset: 0x246B798 VA: 0x246F798
	public void Initialize(float x1, float y1, float z1, float x2, float y2, float z2, string localizeText, int flag) { }

	// RVA: 0x246FCDC Offset: 0x246BCDC VA: 0x246FCDC
	private void OnDestroy() { }

	// RVA: 0x246FD44 Offset: 0x246BD44 VA: 0x246FD44
	private void LateUpdate() { }

	// RVA: 0x246FDD0 Offset: 0x246BDD0 VA: 0x246FDD0
	public bool HitCollLabel(Vector3 pos) { }

	// RVA: 0x246FEB0 Offset: 0x246BEB0 VA: 0x246FEB0
	public void .ctor() { }
}
