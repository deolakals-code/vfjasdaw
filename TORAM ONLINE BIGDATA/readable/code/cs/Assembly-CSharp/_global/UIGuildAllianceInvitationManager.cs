// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildAllianceInvitationManager : UIBasePanelConnection // TypeDefIndex: 6616
{
	// Fields
	[SerializeField]
	private GameObject listBaseButton; // 0x30
	[SerializeField]
	private GameObject popWindow; // 0x38
	[SerializeField]
	private UILabel titleLabel; // 0x40
	[SerializeField]
	private GameObject applyPanel; // 0x48
	[SerializeField]
	private UILabel targetLabel; // 0x50
	[SerializeField]
	private GameObject startPanel; // 0x58
	[SerializeField]
	private UILabel timerLabel; // 0x60
	[SerializeField]
	private UILabel nonTelopLabel; // 0x68
	private UIGuildAllianceInvitationManager.State activeState; // 0x70
	private PlayerDataManager playerDataManager; // 0x78
	private UIScrollWindow scrollListWindow; // 0x80
	private Dictionary<int, GuildManager.AllianceInvitationData> list; // 0x88
	private int selectedId; // 0x90

	// Methods

	// RVA: 0x199B264 Offset: 0x1997264 VA: 0x199B264
	private void Awake() { }

	// RVA: 0x199B580 Offset: 0x1997580 VA: 0x199B580
	public void Initialize(GuildManager.AllianceInvitationData[] invitations) { }

	// RVA: 0x199B674 Offset: 0x1997674 VA: 0x199B674
	private void CreateList() { }

	// RVA: 0x199BD54 Offset: 0x1997D54 VA: 0x199BD54
	private void RemoveList(int id, bool isRecreate = True) { }

	// RVA: 0x199BE40 Offset: 0x1997E40 VA: 0x199BE40
	private void PopResultWindow() { }

	// RVA: 0x199C038 Offset: 0x1998038 VA: 0x199C038
	private void PopErrResultWindow(string title, string localize, int key) { }

	// RVA: 0x199AC78 Offset: 0x1996C78 VA: 0x199AC78
	public void OnClick_CancelInvitation(int id) { }

	// RVA: 0x199AF9C Offset: 0x1996F9C VA: 0x199AF9C
	public void OnClick_ApplePop(int id) { }

	// RVA: 0x199C1C8 Offset: 0x19981C8 VA: 0x199C1C8
	public void OnClick_StartPop() { }

	// RVA: 0x199C46C Offset: 0x199846C VA: 0x199C46C
	public void OnClick_StartClose() { }

	// RVA: 0x199C51C Offset: 0x199851C VA: 0x199C51C Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x199C5EC Offset: 0x19985EC VA: 0x199C5EC Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x199C690 Offset: 0x1998690 VA: 0x199C690
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x199C718 Offset: 0x1998718 VA: 0x199C718
	private void <PopErrResultWindow>b__22_0() { }
}
