// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyRecruitmentRegistrationRoleBoardContentManager : MonoBehaviour // TypeDefIndex: 7718
{
	// Fields
	[SerializeField]
	private UISprite attackerButton; // 0x20
	[SerializeField]
	private UISprite tankerButton; // 0x28
	[SerializeField]
	private UISprite supporterButton; // 0x30
	[SerializeField]
	private UILabel descriptionLabel; // 0x38
	private PartyMemberFrameData partyMemberData; // 0x40
	private const string enableButtonSpriteName = "sys_07";
	private const string disableButtonSpriteName = "sys_08";
	private SystemTextManager systemTextManager; // 0x48
	private Action changeRoleCallBack; // 0x50

	// Properties
	public PartyMemberFrameData PartyMemberFrameData { get; }

	// Methods

	// RVA: 0x1BF01AC Offset: 0x1BEC1AC VA: 0x1BF01AC
	public PartyMemberFrameData get_PartyMemberFrameData() { }

	// RVA: 0x1BEDC5C Offset: 0x1BE9C5C VA: 0x1BEDC5C
	public void Initialize(int index, Action changeRoleCallBack) { }

	// RVA: 0x1BEDEB8 Offset: 0x1BE9EB8 VA: 0x1BEDEB8
	public void ChangeFrameNo(byte frameNo) { }

	// RVA: 0x1BEDED4 Offset: 0x1BE9ED4 VA: 0x1BEDED4
	public void ChangeAllToggles(PartyMemberFrameData memberData) { }

	// RVA: 0x1BF0258 Offset: 0x1BEC258 VA: 0x1BF0258
	public void OnClickAttackerToggle() { }

	// RVA: 0x1BF0394 Offset: 0x1BEC394 VA: 0x1BF0394
	public void OnClickTankerToggle() { }

	// RVA: 0x1BF041C Offset: 0x1BEC41C VA: 0x1BF041C
	public void OnClickSupporterToggle() { }

	// RVA: 0x1BF02E0 Offset: 0x1BEC2E0 VA: 0x1BF02E0
	private bool ApplyRoleState(PartyMemberRole memberRole) { }

	// RVA: 0x1BF0234 Offset: 0x1BEC234 VA: 0x1BF0234
	private bool CheckIsContainRole(PartyMemberRole role) { }

	// RVA: 0x1BF01B4 Offset: 0x1BEC1B4 VA: 0x1BF01B4
	private void ChangeRegistrationEnableDisplay() { }

	// RVA: 0x1BF032C Offset: 0x1BEC32C VA: 0x1BF032C
	private void PlaySE(bool isActive) { }

	// RVA: 0x1BF04A4 Offset: 0x1BEC4A4 VA: 0x1BF04A4
	public void .ctor() { }
}
