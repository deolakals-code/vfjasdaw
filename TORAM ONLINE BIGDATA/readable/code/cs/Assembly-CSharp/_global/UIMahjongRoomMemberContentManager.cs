// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMahjongRoomMemberContentManager : MonoBehaviour // TypeDefIndex: 5944
{
	// Fields
	[SerializeField]
	private GameObject leaderIcon; // 0x20
	[SerializeField]
	private UIButtonCallAction kickButton; // 0x28
	[SerializeField]
	private UISprite addCpuButton; // 0x30
	[SerializeField]
	private GameObject cpuLabel; // 0x38
	[SerializeField]
	private UILabel userNameLabel; // 0x40
	[SerializeField]
	private UILabel readyLabel; // 0x48
	[SerializeField]
	private GameObject psiObj; // 0x50
	[SerializeField]
	private UIImageButton psiSettingButton; // 0x58
	[SerializeField]
	private UILabel psiNameLabel; // 0x60
	private UIMahjongRoomMemberContentManager.MemberType memberType; // 0x68
	private SystemTextManager sys; // 0x70
	private Action kickOutAction; // 0x78
	private Action addCpuAction; // 0x80
	private bool isHost; // 0x88
	private bool isUseMatching; // 0x89
	private bool isReady; // 0x8A
	private Color grayColor; // 0x8C

	// Properties
	public Vector3 readyLabelPos { get; set; }
	public bool IsReady { get; }

	// Methods

	// RVA: 0x184DA9C Offset: 0x1849A9C VA: 0x184DA9C
	public Vector3 get_readyLabelPos() { }

	// RVA: 0x184DAC4 Offset: 0x1849AC4 VA: 0x184DAC4
	public void set_readyLabelPos(Vector3 value) { }

	// RVA: 0x184FF90 Offset: 0x184BF90 VA: 0x184FF90
	public bool get_IsReady() { }

	// RVA: 0x184E57C Offset: 0x184A57C VA: 0x184E57C
	public void Initialize(bool isHost, bool isUseMatching, Action kickOutAction, Action AddCpuAction) { }

	// RVA: 0x184E6CC Offset: 0x184A6CC VA: 0x184E6CC
	public void UpdateMember(UIMahjongRoomMemberContentManager.MemberType memberType, string memberName, bool isReady, bool isLeader, bool isPsiRule, MahjongPsiType psiType) { }

	// RVA: 0x18500D8 Offset: 0x184C0D8 VA: 0x18500D8
	public void UpdateReadyFlag(bool flag) { }

	// RVA: 0x18501AC Offset: 0x184C1AC VA: 0x18501AC
	public void UpdatePsiObjects(bool flag, MahjongPsiType psiType) { }

	// RVA: 0x1850394 Offset: 0x184C394 VA: 0x1850394
	public void UpdateAddCpuButton(UIMahjongRoomMemberContentManager.MemberType memberType) { }

	// RVA: 0x1850448 Offset: 0x184C448 VA: 0x1850448
	public void OnClickKickOut() { }

	// RVA: 0x1850514 Offset: 0x184C514 VA: 0x1850514
	public void OnClickAddCpuButton() { }

	// RVA: 0x184FF98 Offset: 0x184BF98 VA: 0x184FF98
	private void UpdateUserName(string userName) { }

	// RVA: 0x1850618 Offset: 0x184C618 VA: 0x1850618
	public void .ctor() { }
}
