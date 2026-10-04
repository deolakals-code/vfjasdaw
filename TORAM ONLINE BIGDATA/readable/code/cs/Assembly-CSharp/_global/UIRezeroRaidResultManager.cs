// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIRezeroRaidResultManager : UIBasePanel, IEventResultPanel // TypeDefIndex: 6187
{
	// Fields
	[SerializeField]
	private GameObject modelParent; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	[SerializeField]
	private UILabel battleTimeLabel; // 0x40
	[SerializeField]
	private UILabel bossResultItemLabel; // 0x48
	[SerializeField]
	private UILabel[] rankingLabel; // 0x50
	[SerializeField]
	private UILabel[] rankingNameLabel; // 0x58
	[SerializeField]
	private GameObject[] rankingPanel; // 0x60
	[SerializeField]
	private UILabel userLabel; // 0x68
	[SerializeField]
	private GameObject bonusPanel; // 0x70

	// Properties
	public bool IsClose { get; }

	// Methods

	// RVA: 0x18B4140 Offset: 0x18B0140 VA: 0x18B4140 Slot: 7
	public bool get_IsClose() { }

	// RVA: 0x18B4178 Offset: 0x18B0178 VA: 0x18B4178 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x18B417C Offset: 0x18B017C VA: 0x18B417C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x18B4180 Offset: 0x18B0180 VA: 0x18B4180
	public void .ctor() { }
}
