// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentListViewContentManager : MonoBehaviour // TypeDefIndex: 7709
{
	// Fields
	[SerializeField]
	private UIPartyFieldLabel mapNameLabel; // 0x20
	[SerializeField]
	private UILabel partyNameLabel; // 0x28
	[SerializeField]
	private UILabel partyRecruitmentTypeLabel; // 0x30
	[SerializeField]
	private UILabel memberCountLabel; // 0x38
	private PartyRecruitmentData recruitmentData; // 0x40
	private Action<PartyRecruitmentData> buttonCallBack; // 0x48
	private Coroutine scrollFieldName; // 0x50

	// Methods

	// RVA: 0x1BEC434 Offset: 0x1BE8434 VA: 0x1BEC434
	private void OnDestroy() { }

	// RVA: 0x1BEAD44 Offset: 0x1BE6D44 VA: 0x1BEAD44
	public void Initialize(PartyRecruitmentData recruitmentData, Action<PartyRecruitmentData> buttonCallBack) { }

	// RVA: 0x1BEC4B4 Offset: 0x1BE84B4 VA: 0x1BEC4B4
	public void OnClickOpenDetails() { }

	[IteratorStateMachine(typeof(UIPartyRecruitmentListViewContentManager.<ScrollFieldName>d__10))]
	// RVA: 0x1BEC448 Offset: 0x1BE8448 VA: 0x1BEC448
	private IEnumerator ScrollFieldName() { }

	// RVA: 0x1BEC560 Offset: 0x1BE8560 VA: 0x1BEC560
	public void .ctor() { }
}
