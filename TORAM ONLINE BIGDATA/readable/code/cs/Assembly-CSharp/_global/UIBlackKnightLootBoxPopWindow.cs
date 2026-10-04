// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIBlackKnightLootBoxPopWindow : MonoBehaviour // TypeDefIndex: 5841
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
	private PlayerDataManager playerDataManager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private BlackKnightCristaId cristaId; // 0x58
	private bool isClose; // 0x5C

	// Properties
	public bool IsClose { get; }

	// Methods

	// RVA: 0x1805F28 Offset: 0x1801F28 VA: 0x1805F28
	public bool get_IsClose() { }

	// RVA: 0x1805F30 Offset: 0x1801F30 VA: 0x1805F30
	private void Awake() { }

	// RVA: 0x1803814 Offset: 0x17FF814 VA: 0x1803814
	public void Initialize(BlackKnightCristaId cristaId, string titleKey) { }

	// RVA: 0x1806094 Offset: 0x1802094 VA: 0x1806094
	public void HideReward() { }

	[IteratorStateMachine(typeof(UIBlackKnightLootBoxPopWindow.<RewardDataRegister>d__16))]
	// RVA: 0x1806028 Offset: 0x1802028 VA: 0x1806028
	private IEnumerator RewardDataRegister() { }

	// RVA: 0x18061C4 Offset: 0x18021C4 VA: 0x18061C4
	private void AddRewardDataLabel(Vector3 position, int index) { }

	// RVA: 0x1806398 Offset: 0x1802398 VA: 0x1806398
	private void SetRewardLabel(UIQuestRewardList label, string title, int num, string type, string iconName) { }

	// RVA: 0x18065BC Offset: 0x18025BC VA: 0x18065BC
	private void OnClickButton() { }

	// RVA: 0x1806600 Offset: 0x1802600 VA: 0x1806600
	public void Close() { }

	// RVA: 0x180666C Offset: 0x180266C VA: 0x180666C
	public void .ctor() { }

	// RVA: 0x180667C Offset: 0x180267C VA: 0x180667C
	private static void .cctor() { }
}
