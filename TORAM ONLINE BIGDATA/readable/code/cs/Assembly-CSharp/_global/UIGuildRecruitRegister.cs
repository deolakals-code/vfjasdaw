// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRecruitRegister : UIBasePanelConnection // TypeDefIndex: 7165
{
	// Fields
	[SerializeField]
	private UISelectButton selectJoinType; // 0x30
	[SerializeField]
	private UISelectButton selectConditionType; // 0x38
	[SerializeField]
	private UISelectButton selectConditionValue; // 0x40
	[SerializeField]
	private UIInput inputComment; // 0x48
	[SerializeField]
	private GameObject registerWindow; // 0x50
	[SerializeField]
	private GameObject successPanel; // 0x58
	[SerializeField]
	private UILabel successPanelButton; // 0x60
	[SerializeField]
	private UIButtonMessage successButtonMessage; // 0x68
	[SerializeField]
	private UILabel successPanelLabel; // 0x70
	[SerializeField]
	private GameObject recruitDataPlate; // 0x78
	[SerializeField]
	private UIInput inputConditionValue; // 0x80
	[SerializeField]
	private TweenAlpha errorEffect; // 0x88
	private string[] missionList; // 0x90
	private const int MIN_MISSION_ID = 10;
	private string[] levelList; // 0x98
	private string[] playTimeList; // 0xA0
	private MissionTextManager missionTextManager; // 0xA8
	private bool isNgComment; // 0xB0
	private GuildBBSSendData currentServerData; // 0xB8

	// Properties
	private byte JoinType { get; }
	private byte ConditionType { get; }
	private int ConditionValue { get; }
	private string Comment { get; }

	// Methods

	// RVA: 0x1AAE6D0 Offset: 0x1AAA6D0 VA: 0x1AAE6D0
	private byte get_JoinType() { }

	// RVA: 0x1AAE6F0 Offset: 0x1AAA6F0 VA: 0x1AAE6F0
	private byte get_ConditionType() { }

	// RVA: 0x1AAE70C Offset: 0x1AAA70C VA: 0x1AAE70C
	private int get_ConditionValue() { }

	// RVA: 0x1AAE760 Offset: 0x1AAA760 VA: 0x1AAE760
	private string get_Comment() { }

	// RVA: 0x1AAE77C Offset: 0x1AAA77C VA: 0x1AAE77C
	private void Awake() { }

	[IteratorStateMachine(typeof(UIGuildRecruitRegister.<Start>d__31))]
	// RVA: 0x1AAE9A8 Offset: 0x1AAA9A8 VA: 0x1AAE9A8
	private IEnumerator Start() { }

	// RVA: 0x1AAEA3C Offset: 0x1AAAA3C VA: 0x1AAEA3C
	private void SetRegisterData(GuildBBSSendData registerData) { }

	// RVA: 0x1AAF044 Offset: 0x1AAB044 VA: 0x1AAF044
	private void OnConditionTypeChanged() { }

	// RVA: 0x1AAEEC0 Offset: 0x1AAAEC0 VA: 0x1AAEEC0
	private void SetConditionValue(int select = 0) { }

	// RVA: 0x1AAF04C Offset: 0x1AAB04C VA: 0x1AAF04C
	private void OnConditionValueChanged() { }

	// RVA: 0x1AAF07C Offset: 0x1AAB07C VA: 0x1AAF07C
	private void SetConnection(IReconnectionSubData data) { }

	// RVA: 0x1AAF2C4 Offset: 0x1AAB2C4 VA: 0x1AAF2C4
	public void OnConditionInput() { }

	// RVA: 0x1AAF620 Offset: 0x1AAB620 VA: 0x1AAF620
	public void OnCommentInput() { }

	// RVA: 0x1AAF930 Offset: 0x1AAB930 VA: 0x1AAF930
	private void PlayCommentError() { }

	// RVA: 0x1AAF9C0 Offset: 0x1AAB9C0 VA: 0x1AAF9C0
	public void OnPushRegisterButton() { }

	// RVA: 0x1AAFA78 Offset: 0x1AABA78 VA: 0x1AAFA78
	private bool IsChangeData() { }

	// RVA: 0x1AAFBFC Offset: 0x1AABBFC VA: 0x1AAFBFC
	public void OnPushRejectButton() { }

	// RVA: 0x1AAFC5C Offset: 0x1AABC5C VA: 0x1AAFC5C
	public void OnSuccessReject() { }

	// RVA: 0x1AAFC94 Offset: 0x1AABC94 VA: 0x1AAFC94
	private void OnSuccessRegister(GuildBBSSendData data) { }

	// RVA: 0x1AAEDB4 Offset: 0x1AAADB4 VA: 0x1AAEDB4
	private void SetRegisteredPanel(GuildBBSSendData data) { }

	// RVA: 0x1AAFDA0 Offset: 0x1AABDA0 VA: 0x1AAFDA0
	private void SetRegisterPlate(GuildBBSSendData data) { }

	// RVA: 0x1AB010C Offset: 0x1AAC10C VA: 0x1AB010C
	private void OnFailed(string messageKey, string[] list) { }

	// RVA: 0x1AB0244 Offset: 0x1AAC244 VA: 0x1AB0244 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1AB030C Offset: 0x1AAC30C VA: 0x1AB030C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1AB03BC Offset: 0x1AAC3BC VA: 0x1AB03BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1AB03C4 Offset: 0x1AAC3C4 VA: 0x1AB03C4
	private void <OnFailed>b__47_0() { }
}
