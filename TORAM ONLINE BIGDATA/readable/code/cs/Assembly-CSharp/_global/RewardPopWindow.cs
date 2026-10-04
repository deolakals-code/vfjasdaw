// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RewardPopWindow : PopBaseWindow // TypeDefIndex: 8827
{
	// Fields
	private List<RewardData> rewardDataList; // 0x20
	private string titleText; // 0x28
	private string okText; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private float scrollCameraSetPosX; // 0x40
	private int messageAction; // 0x44
	private GameObject rewardObject; // 0x48
	private float y; // 0x50
	private float delayTimer; // 0x54
	private int rewardIndex; // 0x58
	private UIScrollWindow window; // 0x60
	private int rewardNum; // 0x68

	// Properties
	private PlayerDataManager PlayerData { get; }

	// Methods

	// RVA: 0x1E28470 Offset: 0x1E24470 VA: 0x1E28470
	private PlayerDataManager get_PlayerData() { }

	// RVA: 0x1E284F4 Offset: 0x1E244F4 VA: 0x1E284F4
	public void .ctor(string titleText, RewardData[] rewardData) { }

	// RVA: 0x1E28638 Offset: 0x1E24638 VA: 0x1E28638
	public void .ctor(string titleText, float posX, RewardData[] rewardData) { }

	// RVA: 0x1E28788 Offset: 0x1E24788 VA: 0x1E28788
	public void .ctor(string titleText, string okText, float posX, RewardData[] rewardData) { }

	// RVA: 0x1E288F0 Offset: 0x1E248F0 VA: 0x1E288F0 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E28BD8 Offset: 0x1E24BD8 VA: 0x1E28BD8
	private void AddOkButton() { }

	// RVA: 0x1E28E54 Offset: 0x1E24E54 VA: 0x1E28E54
	private void AddButton(RewardData rewardData) { }

	// RVA: 0x1E29724 Offset: 0x1E25724 VA: 0x1E29724 Slot: 5
	public override void Update() { }

	// RVA: 0x1E29834 Offset: 0x1E25834 VA: 0x1E29834 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E29840 Offset: 0x1E25840 VA: 0x1E29840 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E29848 Offset: 0x1E25848 VA: 0x1E29848 Slot: 8
	public override void Close() { }
}
