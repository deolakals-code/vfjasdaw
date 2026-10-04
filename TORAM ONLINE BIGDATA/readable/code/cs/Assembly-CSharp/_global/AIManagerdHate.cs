// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AIManagerdHate : MonoBehaviour // TypeDefIndex: 606
{
	// Fields
	private const float IntervalTimer = 0.5;
	private IAITargetSortOrder mainOrder; // 0x20
	private IAITargetSortOrder nextOrder; // 0x28
	private IntervalTimer timer; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private EnemyMobActionManagerBase[] newTargetList; // 0x40
	private PartyMemberData[] partyMember; // 0x48
	[CompilerGenerated]
	private GameObject <MainTargt>k__BackingField; // 0x50

	// Properties
	public GameObject MainTargt { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19DF1D0 Offset: 0x19DB1D0 VA: 0x19DF1D0
	public GameObject get_MainTargt() { }

	[CompilerGenerated]
	// RVA: 0x19DF1D8 Offset: 0x19DB1D8 VA: 0x19DF1D8
	private void set_MainTargt(GameObject value) { }

	// RVA: 0x19DF1E0 Offset: 0x19DB1E0 VA: 0x19DF1E0
	private void Start() { }

	// RVA: 0x19DF4E8 Offset: 0x19DB4E8 VA: 0x19DF4E8
	private void Update() { }

	// RVA: 0x19DF3F0 Offset: 0x19DB3F0 VA: 0x19DF3F0
	public void SetOrder(TargetOrderType order) { }

	// RVA: 0x19DF574 Offset: 0x19DB574 VA: 0x19DF574
	private void ChangeSortOrderUpdate() { }

	// RVA: 0x19DF5C8 Offset: 0x19DB5C8 VA: 0x19DF5C8
	private void GettingTargetData() { }

	// RVA: 0x19DF644 Offset: 0x19DB644 VA: 0x19DF644
	private void SortTarget() { }

	// RVA: 0x19DF854 Offset: 0x19DB854 VA: 0x19DF854
	public void .ctor() { }
}
