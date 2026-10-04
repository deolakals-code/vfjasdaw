// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIStampReceive : UIStamp // TypeDefIndex: 7996
{
	// Fields
	[SerializeField]
	protected UIStampIcon[] nextIcon; // 0xE0
	[SerializeField]
	private GameObject addObject; // 0xE8
	[SerializeField]
	private UIIcon itemIcon; // 0xF0
	[SerializeField]
	private UILabel itemNameLabel; // 0xF8
	[SerializeField]
	private UILabel subLabel; // 0x100
	[SerializeField]
	private GameObject rewardPopUp; // 0x108
	private GameObject addedObject; // 0x110
	private ItemTextManager itemTextManager; // 0x118
	private UIPopWindow popWindow; // 0x120
	private StampId rewardStampId; // 0x128

	// Methods

	// RVA: 0x1C8F6AC Offset: 0x1C8B6AC VA: 0x1C8F6AC Slot: 14
	protected override void Awake() { }

	// RVA: 0x1C8F878 Offset: 0x1C8B878 VA: 0x1C8F878 Slot: 15
	protected override void Start() { }

	// RVA: 0x1C8F87C Offset: 0x1C8B87C VA: 0x1C8F87C
	public void Initialize() { }

	[IteratorStateMachine(typeof(UIStampReceive.<InitializeStamp>d__13))]
	// RVA: 0x1C8FA20 Offset: 0x1C8BA20 VA: 0x1C8FA20 Slot: 16
	public override IEnumerator InitializeStamp() { }

	// RVA: 0x1C8F97C Offset: 0x1C8B97C VA: 0x1C8F97C
	private void initializeNext() { }

	// RVA: 0x1C8FAB4 Offset: 0x1C8BAB4 VA: 0x1C8FAB4
	private void onClickReceive(int index) { }

	// RVA: 0x1C8FD80 Offset: 0x1C8BD80 VA: 0x1C8FD80
	private bool isReceivedReward(int index) { }

	[IteratorStateMachine(typeof(UIStampReceive.<getReward>d__17))]
	// RVA: 0x1C8FDBC Offset: 0x1C8BDBC VA: 0x1C8FDBC
	private IEnumerator getReward(byte stampIndex) { }

	// RVA: 0x1C8FE60 Offset: 0x1C8BE60 VA: 0x1C8FE60
	private string getRewardIconName(RewardType type, int rewardValue) { }

	// RVA: 0x1C900D4 Offset: 0x1C8C0D4 VA: 0x1C900D4
	private string getRewardName(RewardType type, int rewardValue, int num) { }

	// RVA: 0x1C905DC Offset: 0x1C8C5DC VA: 0x1C905DC
	private void onPopWindowOpened() { }

	// RVA: 0x1C90664 Offset: 0x1C8C664 VA: 0x1C90664
	private void onPopWindowClose() { }

	// RVA: 0x1C9072C Offset: 0x1C8C72C VA: 0x1C9072C
	public void .ctor() { }
}
