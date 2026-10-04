// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildMemberElement : UIFriendListElement // TypeDefIndex: 7146
{
	// Fields
	[SerializeField]
	private UILabel contributionLabel; // 0xA0
	[SerializeField]
	private UISprite[] authorityIcon; // 0xA8
	[SerializeField]
	private UISprite authorityHighIcon; // 0xB0
	[SerializeField]
	private GameObject settingIconObj; // 0xB8
	private bool menuFlag; // 0xC0

	// Methods

	// RVA: 0x1AA8598 Offset: 0x1AA4598 VA: 0x1AA8598
	public void SetLabel(string name, int lv, int contribution, byte authority) { }

	// RVA: 0x1AA8AD0 Offset: 0x1AA4AD0 VA: 0x1AA8AD0 Slot: 5
	public override void SetMenuState(bool isMenu) { }

	// RVA: 0x1AA8B70 Offset: 0x1AA4B70 VA: 0x1AA8B70 Slot: 4
	public override void SetSelected(bool isSelected) { }

	// RVA: 0x1AA8BC8 Offset: 0x1AA4BC8 VA: 0x1AA8BC8
	public void .ctor() { }
}
