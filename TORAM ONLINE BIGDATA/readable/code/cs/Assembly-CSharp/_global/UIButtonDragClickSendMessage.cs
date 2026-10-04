// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button DragClick SendMessage")]
public class UIButtonDragClickSendMessage : MonoBehaviour // TypeDefIndex: 13
{
	// Fields
	public int SendParam; // 0x20
	public GameObject target; // 0x28
	public string functionName; // 0x30
	public bool includeChildren; // 0x38
	private float moveDist; // 0x3C

	// Methods

	// RVA: 0x17162C4 Offset: 0x17122C4 VA: 0x17162C4
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x17162E0 Offset: 0x17122E0 VA: 0x17162E0
	private void OnScroll(float delta) { }

	// RVA: 0x17162F4 Offset: 0x17122F4 VA: 0x17162F4
	private void OnPress(bool isPressed) { }

	// RVA: 0x1716320 Offset: 0x1712320 VA: 0x1716320 Slot: 4
	protected virtual void Send() { }

	// RVA: 0x17164FC Offset: 0x17124FC VA: 0x17164FC
	public void .ctor() { }
}
