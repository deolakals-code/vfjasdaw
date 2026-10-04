// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventMenuButton : MonoBehaviour // TypeDefIndex: 6510
{
	// Fields
	[SerializeField]
	private GameObject menuObject; // 0x20
	[SerializeField]
	private UISprite backPanelObject; // 0x28
	[SerializeField]
	private UISprite selectPanelObject; // 0x30
	[SerializeField]
	private BoxCollider boxColliderObject; // 0x38
	[SerializeField]
	private UILabel mainLabel; // 0x40
	private int sendMessageId; // 0x48
	[SerializeField]
	private UILabel subRightLabel; // 0x50
	[SerializeField]
	private UILabel subRightEffecrLabel; // 0x58
	[SerializeField]
	private GameObject subRightAnchor; // 0x60
	[SerializeField]
	private UILabel subLeftLabel; // 0x68
	[SerializeField]
	private UILabel subLeftEffectLabel; // 0x70
	[SerializeField]
	private GameObject subLeftAnchor; // 0x78
	private bool IsWarpList; // 0x80

	// Methods

	// RVA: 0x1964E3C Offset: 0x1960E3C VA: 0x1964E3C
	public void SetButtonSize(int num) { }

	// RVA: 0x1964F80 Offset: 0x1960F80 VA: 0x1964F80
	public void AddMenuButton(string mes, int sendId) { }

	// RVA: 0x1965468 Offset: 0x1961468 VA: 0x1965468
	public void AddMenuButton(UIEventMenuButton.MessageButtonData mes, int sendId) { }

	// RVA: 0x196557C Offset: 0x196157C VA: 0x196557C
	public void AddWarpListButton(string mainMes, string tagMes, string newMes, int iconId, int sendId) { }

	// RVA: 0x19652B0 Offset: 0x19612B0 VA: 0x19652B0
	private void SetSubLabel(UILabel sub, UILabel subEffect, GameObject labelAnchor, string text, byte effectType) { }

	// RVA: 0x19659D4 Offset: 0x19619D4 VA: 0x19659D4
	public void OnClick() { }

	// RVA: 0x19650C0 Offset: 0x19610C0 VA: 0x19650C0
	private string GetAddSpaceText(string mes) { }

	// RVA: 0x196521C Offset: 0x196121C VA: 0x196521C
	private void ChangeMainTextPivot(UIWidget.Pivot pivot) { }

	// RVA: 0x1965ACC Offset: 0x1961ACC VA: 0x1965ACC
	public void .ctor() { }
}
