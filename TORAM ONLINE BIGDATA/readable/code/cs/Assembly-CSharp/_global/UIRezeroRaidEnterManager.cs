// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRezeroRaidEnterManager : UIBasePanel // TypeDefIndex: 6182
{
	// Fields
	[SerializeField]
	private GameObject mainPanel; // 0x30
	private UIIruna2Anchor mainAnchor; // 0x38
	[SerializeField]
	private GameObject partyNamePanel; // 0x40
	private UIIruna2Anchor partyNameAnchor; // 0x48
	[SerializeField]
	private GameObject mainTextPanel; // 0x50
	[SerializeField]
	private UILabel timerTextLabel; // 0x58
	[SerializeField]
	private UILabel pointTextLabel; // 0x60
	[SerializeField]
	private UIImageButton enterButton; // 0x68
	[SerializeField]
	private UILabel enterLabel; // 0x70
	[SerializeField]
	private GameObject[] partyMemberObj; // 0x78
	protected UIPartyMember[] partyMemberData; // 0x80
	protected TweenPosition[] partyMemberEffect; // 0x88
	[SerializeField]
	private GameObject topObj; // 0x90
	[SerializeField]
	private GameObject bottomObj; // 0x98
	[SerializeField]
	private GameObject errLabel; // 0xA0
	[SerializeField]
	private GameObject matchingPanel; // 0xA8
	[SerializeField]
	private UILabel matchingTimerLabel; // 0xB0

	// Methods

	// RVA: 0x18B3DD8 Offset: 0x18AFDD8 VA: 0x18B3DD8 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18B3DDC Offset: 0x18AFDDC VA: 0x18B3DDC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18B3DE0 Offset: 0x18AFDE0 VA: 0x18B3DE0 Slot: 4
	public override void OnOpenShortcutPanel(GameObject shortcutManager) { }

	// RVA: 0x18B3DE4 Offset: 0x18AFDE4 VA: 0x18B3DE4
	public void .ctor() { }
}
