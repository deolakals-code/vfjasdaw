// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIComeBackManager : UIBasePanel // TypeDefIndex: 6486
{
	// Fields
	[SerializeField]
	private Transform mobParent; // 0x30
	private Transform shadow; // 0x38
	[SerializeField]
	private GameObject popWindow; // 0x40
	[SerializeField]
	private GameObject okButton; // 0x48
	private UIIruna2Anchor okButtonAnchor; // 0x50
	private bool clickResult; // 0x58
	private GameObject rewardPopUp; // 0x60
	private AvatarVariableUpdateResponse rewardData; // 0x68

	// Methods

	// RVA: 0x19570B4 Offset: 0x19530B4 VA: 0x19570B4
	private void Start() { }

	// RVA: 0x1957670 Offset: 0x1953670 VA: 0x1957670
	private void LateUpdate() { }

	// RVA: 0x1957730 Offset: 0x1953730 VA: 0x1957730
	private void OnClickButton() { }

	[IteratorStateMachine(typeof(UIComeBackManager.<ConnectWait>d__11))]
	// RVA: 0x19577C0 Offset: 0x19537C0 VA: 0x19577C0
	private IEnumerator ConnectWait() { }

	// RVA: 0x1957854 Offset: 0x1953854 VA: 0x1957854
	private void onFinishRewardEffect() { }

	// RVA: 0x1957B80 Offset: 0x1953B80 VA: 0x1957B80
	public void onFinishReward() { }

	// RVA: 0x1957C0C Offset: 0x1953C0C VA: 0x1957C0C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1957D20 Offset: 0x1953D20 VA: 0x1957D20 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1957E34 Offset: 0x1953E34 VA: 0x1957E34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1957E3C Offset: 0x1953E3C VA: 0x1957E3C
	private void <ConnectWait>b__11_0(AvatarVariableUpdateResponse res) { }
}
