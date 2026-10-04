// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Button Keys")]
[RequireComponent(typeof(Collider))]
public class UIButtonKeys : MonoBehaviour // TypeDefIndex: 15
{
	// Fields
	public bool startsSelected; // 0x20
	public UIButtonKeys selectOnClick; // 0x28
	public UIButtonKeys selectOnUp; // 0x30
	public UIButtonKeys selectOnDown; // 0x38
	public UIButtonKeys selectOnLeft; // 0x40
	public UIButtonKeys selectOnRight; // 0x48

	// Methods

	// RVA: 0x1716650 Offset: 0x1712650 VA: 0x1716650
	private void OnEnable() { }

	// RVA: 0x171684C Offset: 0x171284C VA: 0x171684C
	private void OnKey(KeyCode key) { }

	// RVA: 0x1716B74 Offset: 0x1712B74 VA: 0x1716B74
	private void OnClick() { }

	// RVA: 0x1716C40 Offset: 0x1712C40 VA: 0x1716C40
	public void .ctor() { }
}
