// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuestRewardPopWindow : PopBaseWindow // TypeDefIndex: 8825
{
	// Fields
	protected List<QuestManager.RewardData> rewardDataList; // 0x20
	private int messageAction; // 0x28
	protected GameObject rewardObject; // 0x30
	protected float y; // 0x38
	protected float delayTimer; // 0x3C
	protected int rewardIndex; // 0x40
	protected UIScrollWindow window; // 0x48
	protected int rewardNum; // 0x50
	[CompilerGenerated]
	private bool <IsEndAnimation>k__BackingField; // 0x54

	// Properties
	public bool IsEndAnimation { get; set; }

	// Methods

	// RVA: 0x1E06F60 Offset: 0x1E02F60 VA: 0x1E06F60
	public void .ctor() { }

	// RVA: 0x1E15EFC Offset: 0x1E11EFC VA: 0x1E15EFC
	public void .ctor(List<QuestManager.RewardData> rewardData) { }

	[CompilerGenerated]
	// RVA: 0x1E15F74 Offset: 0x1E11F74 VA: 0x1E15F74
	public bool get_IsEndAnimation() { }

	[CompilerGenerated]
	// RVA: 0x1E15F7C Offset: 0x1E11F7C VA: 0x1E15F7C
	protected void set_IsEndAnimation(bool value) { }

	// RVA: 0x1E15F88 Offset: 0x1E11F88 VA: 0x1E15F88 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E07B70 Offset: 0x1E03B70 VA: 0x1E07B70
	protected void AddOkButton() { }

	// RVA: 0x1E07444 Offset: 0x1E03444 VA: 0x1E07444
	protected void AddButton(QuestManager.RewardData rewardData) { }

	// RVA: 0x1E1623C Offset: 0x1E1223C VA: 0x1E1623C Slot: 5
	public override void Update() { }

	// RVA: 0x1E163DC Offset: 0x1E123DC VA: 0x1E163DC Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E163F0 Offset: 0x1E123F0 VA: 0x1E163F0 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E163F8 Offset: 0x1E123F8 VA: 0x1E163F8 Slot: 8
	public override void Close() { }
}
