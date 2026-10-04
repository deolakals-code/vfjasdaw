// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIHouseItemTypeButton : MonoBehaviour // TypeDefIndex: 7261
{
	// Fields
	[SerializeField]
	private UILabel itemLabel; // 0x20
	[SerializeField]
	private UIIcon icon; // 0x28
	[SerializeField]
	private GameObject defaultIcon; // 0x30
	[SerializeField]
	private TweenPosition tweenPosition; // 0x38
	private UIToggle toggle; // 0x40
	private bool selected; // 0x48

	// Methods

	// RVA: 0x1AF65F4 Offset: 0x1AF25F4 VA: 0x1AF65F4
	public void SetItemButton(string iconSprite, string itemText, GameObject manager, string message, int param) { }

	// RVA: 0x1AF6610 Offset: 0x1AF2610 VA: 0x1AF6610
	public void SetItemButton(bool isSystemIcon, string iconSprite, string itemText, GameObject manager, string message, int param) { }

	// RVA: 0x1AF674C Offset: 0x1AF274C VA: 0x1AF674C
	public void SetItemButton(byte type, short category, string itemText, GameObject manager, string message, int param) { }

	// RVA: 0x1AF6894 Offset: 0x1AF2894 VA: 0x1AF6894
	public void DefaultIconButton() { }

	// RVA: 0x1AF6930 Offset: 0x1AF2930 VA: 0x1AF6930
	private void Update() { }

	// RVA: 0x1AF6984 Offset: 0x1AF2984 VA: 0x1AF6984
	private void OnClick() { }

	// RVA: 0x1AF6A24 Offset: 0x1AF2A24 VA: 0x1AF6A24
	public void .ctor() { }
}
