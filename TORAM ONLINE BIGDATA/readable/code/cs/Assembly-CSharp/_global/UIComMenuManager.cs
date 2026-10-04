// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIComMenuManager : UIBaseMenuPanel // TypeDefIndex: 8146
{
	// Fields
	private Dictionary<int, CommunityURLManager.CommunityURLData> urlData; // 0x80
	private UIPopWindow popWindow; // 0x88
	[SerializeField]
	private UILabel tellHistoryTitleLabel; // 0x90
	[SerializeField]
	private UILabel tellHistoryLabel; // 0x98
	[SerializeField]
	private UILabel moodMessageLabel; // 0xA0

	// Methods

	// RVA: 0x1CD69D4 Offset: 0x1CD29D4 VA: 0x1CD69D4
	private void Awake() { }

	// RVA: 0x1CD6EB8 Offset: 0x1CD2EB8 VA: 0x1CD6EB8 Slot: 7
	protected override void Start() { }

	// RVA: 0x1CD726C Offset: 0x1CD326C VA: 0x1CD726C Slot: 13
	protected override PopUpMessageWindow AdviceMessageData() { }

	// RVA: 0x1CD75A0 Offset: 0x1CD35A0 VA: 0x1CD75A0 Slot: 14
	protected override void AdviceMessageButton() { }

	// RVA: 0x1CD760C Offset: 0x1CD360C VA: 0x1CD760C Slot: 11
	protected override void OnClickButton(int id) { }

	// RVA: 0x1CD7924 Offset: 0x1CD3924 VA: 0x1CD7924
	private void closePopWindow() { }

	// RVA: 0x1CD79E0 Offset: 0x1CD39E0 VA: 0x1CD79E0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1CD7A5C Offset: 0x1CD3A5C VA: 0x1CD7A5C
	private void OnTellHistory() { }

	// RVA: 0x1CD7AB8 Offset: 0x1CD3AB8 VA: 0x1CD7AB8
	private void OnMoodMessage() { }

	// RVA: 0x1CD7B14 Offset: 0x1CD3B14 VA: 0x1CD7B14
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UIComMenuManager.<SetMoodMessageLabel>d__16))]
	// RVA: 0x1CD7200 Offset: 0x1CD3200 VA: 0x1CD7200
	private IEnumerator SetMoodMessageLabel() { }

	// RVA: 0x1CD7BB8 Offset: 0x1CD3BB8 VA: 0x1CD7BB8
	public void .ctor() { }
}
