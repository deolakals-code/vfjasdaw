// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("Iruna2/Render/BillBoard")]
public class BillBoard : MonoBehaviour, IBillBoardTarget // TypeDefIndex: 226
{
	// Fields
	public Transform[] BillBoardBones; // 0x20
	private bool activeFlag; // 0x28
	public bool[] BillBoardY; // 0x30
	private Transform viewCamera; // 0x38

	// Methods

	// RVA: 0x21C7EC0 Offset: 0x21C3EC0 VA: 0x21C7EC0
	private void OnBecameVisible() { }

	// RVA: 0x21C7ECC Offset: 0x21C3ECC VA: 0x21C7ECC
	private void OnBecameInvisible() { }

	// RVA: 0x21C7ED4 Offset: 0x21C3ED4 VA: 0x21C7ED4 Slot: 4
	public void SetViewCamera(Transform view) { }

	// RVA: 0x21C7EDC Offset: 0x21C3EDC VA: 0x21C7EDC
	private void Update() { }

	// RVA: 0x21C7FE4 Offset: 0x21C3FE4 VA: 0x21C7FE4
	private void LateUpdate() { }

	// RVA: 0x21C8750 Offset: 0x21C4750 VA: 0x21C8750
	public void .ctor() { }
}
