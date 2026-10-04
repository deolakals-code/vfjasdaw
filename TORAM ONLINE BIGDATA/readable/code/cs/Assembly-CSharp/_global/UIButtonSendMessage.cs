// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button SendMessage")]
public class UIButtonSendMessage : MonoBehaviour // TypeDefIndex: 25
{
	// Fields
	public int SendParam; // 0x20
	public GameObject target; // 0x28
	public string functionName; // 0x30
	public UIButtonSendMessage.Trigger trigger; // 0x38
	public bool includeChildren; // 0x3C

	// Methods

	// RVA: 0x1718340 Offset: 0x1714340 VA: 0x1718340
	private void OnHover(bool isOver) { }

	// RVA: 0x1718368 Offset: 0x1714368 VA: 0x1718368
	private void OnPress(bool isPressed) { }

	// RVA: 0x1718390 Offset: 0x1714390 VA: 0x1718390
	private void OnClick() { }

	// RVA: 0x171841C Offset: 0x171441C VA: 0x171841C Slot: 4
	protected virtual void Send() { }

	// RVA: 0x17185F8 Offset: 0x17145F8 VA: 0x17185F8
	public void .ctor() { }
}
