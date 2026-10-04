// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildHomeRaidManager : UIBasePanelConnection, IUIGuildStaffRaidPanelController // TypeDefIndex: 6647
{
	// Fields
	[SerializeField]
	private UISprite[] titleIcon; // 0x30
	[SerializeField]
	private UILabel titleLabel; // 0x38
	[SerializeField]
	private UIIruna2Anchor orbPanelAnchor; // 0x40
	[SerializeField]
	private UILabel orbNumLabel; // 0x48
	private UIGuildStaffRaidPanel panel; // 0x50
	private PlayerDataManager playerDataManager; // 0x58

	// Methods

	// RVA: 0x19A68BC Offset: 0x19A28BC VA: 0x19A68BC
	private void Start() { }

	// RVA: 0x19A6FBC Offset: 0x19A2FBC VA: 0x19A6FBC
	public void ChangeTitleLabel(string icon, string title) { }

	// RVA: 0x19A6E20 Offset: 0x19A2E20 VA: 0x19A6E20
	public void ChangeTitleLabel(bool isSystem, string icon, string title) { }

	// RVA: 0x19A6FCC Offset: 0x19A2FCC VA: 0x19A6FCC Slot: 8
	public void ChangeOrbPanelEnable(bool isEnable) { }

	[IteratorStateMachine(typeof(UIGuildHomeRaidManager.<ConnectWait>d__10))]
	// RVA: 0x19A70FC Offset: 0x19A30FC VA: 0x19A70FC Slot: 9
	public IEnumerator ConnectWait(Func<bool> connectCheck, Action callback) { }

	// RVA: 0x19A6BF0 Offset: 0x19A2BF0 VA: 0x19A6BF0
	private UIGuildStaffRaidPanel LoadPanel(string path) { }

	[IteratorStateMachine(typeof(UIGuildHomeRaidManager.<ConnectionGuildRaidData>d__12))]
	// RVA: 0x19A6F50 Offset: 0x19A2F50 VA: 0x19A6F50
	private IEnumerator ConnectionGuildRaidData() { }

	// RVA: 0x19A71E8 Offset: 0x19A31E8 VA: 0x19A71E8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x19A72D4 Offset: 0x19A32D4 VA: 0x19A72D4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19A738C Offset: 0x19A338C VA: 0x19A738C
	public void .ctor() { }
}
