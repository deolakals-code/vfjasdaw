// Assembly: Assembly-CSharp.dll
// Namespace: 
public class TreasureRewardPopup : MonoBehaviour // TypeDefIndex: 8218
{
	// Fields
	[SerializeField]
	private GameObject rewardObject; // 0x20
	[SerializeField]
	private GameObject buttonObject; // 0x28
	[SerializeField]
	private UIScrollWindow scroll; // 0x30
	[SerializeField]
	private BoxCollider scrollCollider; // 0x38
	[SerializeField]
	private UILabel titleLabel; // 0x40
	private static readonly int WindowWidth; // 0x0
	private static readonly float labelInterval; // 0x4
	private static readonly float buttonPositionY; // 0x8
	private static readonly int scrollActivateNum; // 0xC
	private PlayerDataManager playerDataManager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private RewardData[] rewardData; // 0x58
	private bool isClose; // 0x60

	// Properties
	public bool IsClose { get; }

	// Methods

	// RVA: 0x1CFA7EC Offset: 0x1CF67EC VA: 0x1CFA7EC
	public bool get_IsClose() { }

	// RVA: 0x1CFA7F4 Offset: 0x1CF67F4 VA: 0x1CFA7F4
	private void Awake() { }

	// RVA: 0x1CFA8EC Offset: 0x1CF68EC VA: 0x1CFA8EC
	public void Initialize(RewardData[] rewardData, string titleKey) { }

	// RVA: 0x1CFAC54 Offset: 0x1CF6C54 VA: 0x1CFAC54
	public void HideReward() { }

	[IteratorStateMachine(typeof(TreasureRewardPopup.<RewardDataRegister>d__18))]
	// RVA: 0x1CFABE8 Offset: 0x1CF6BE8 VA: 0x1CFABE8
	private IEnumerator RewardDataRegister() { }

	// RVA: 0x1CFAD84 Offset: 0x1CF6D84 VA: 0x1CFAD84
	private void AddRewardDataLabel(Vector3 position, int index) { }

	// RVA: 0x1CFB2FC Offset: 0x1CF72FC VA: 0x1CFB2FC
	private void SetRewardLabel(UIQuestRewardList label, string title, int num, string type, string iconName) { }

	// RVA: 0x1CFB520 Offset: 0x1CF7520 VA: 0x1CFB520
	private void OnClickButton() { }

	// RVA: 0x1CFB52C Offset: 0x1CF752C VA: 0x1CFB52C
	public void Close() { }

	// RVA: 0x1CFB598 Offset: 0x1CF7598 VA: 0x1CFB598
	public void .ctor() { }

	// RVA: 0x1CFB5A0 Offset: 0x1CF75A0 VA: 0x1CFB5A0
	private static void .cctor() { }
}
