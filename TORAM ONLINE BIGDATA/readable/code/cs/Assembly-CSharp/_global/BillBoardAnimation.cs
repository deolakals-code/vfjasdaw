// Assembly: Assembly-CSharp.dll
// Namespace: 
public class BillBoardAnimation : MonoBehaviour, IMotionLateUpdate, IBillBoardTarget // TypeDefIndex: 227
{
	// Fields
	private Transform[] boneTrans; // 0x20
	private byte[] boneFlag; // 0x28
	private Transform viewCamera; // 0x30

	// Methods

	// RVA: 0x21C8760 Offset: 0x21C4760 VA: 0x21C8760
	public void Initialize(Transform[] boneTrans, byte[] boneFlag) { }

	// RVA: 0x21C8838 Offset: 0x21C4838 VA: 0x21C8838
	public void CopyStatus(BillBoardAnimation cpoyData) { }

	// RVA: 0x21C8A08 Offset: 0x21C4A08 VA: 0x21C8A08 Slot: 5
	public void SetViewCamera(Transform view) { }

	// RVA: 0x21C8A10 Offset: 0x21C4A10 VA: 0x21C8A10 Slot: 4
	public void MotionLateUpdate() { }

	// RVA: 0x21C8FD4 Offset: 0x21C4FD4 VA: 0x21C8FD4
	public void .ctor() { }
}
