// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPartyStatus : MonoBehaviour // TypeDefIndex: 6549
{
	// Fields
	private float secondPartyHp; // 0x20
	[SerializeField]
	private GameObject[] partyMemberStatusObject; // 0x28
	[SerializeField]
	private GameObject[] mercenaryInstruction; // 0x30
	[SerializeField]
	private GameObject secondPartyMemberStatusObject; // 0x38
	[SerializeField]
	private UIIruna2Anchor secondPartyMemberStateAnchor; // 0x40
	[SerializeField]
	private UILabel[] secondPartyMemberStateLabels; // 0x48
	[SerializeField]
	private UISprite secondPartyMemberStateIcon; // 0x50
	private List<UIPartyStatus.memberStatusUI> memberUI; // 0x58
	private UIIruna2AnchorSimple anchor; // 0x60
	private PlayerDataManager playerDataManager; // 0x68
	private SystemTextManager systemTextManager; // 0x70
	private FieldTextManager fieldTextManager; // 0x78
	private IList<PartyMemberData> partyMemberData; // 0x80
	private int playerLastFieldId; // 0x88
	private Coroutine[] scrollCroutine; // 0x90
	private UIPartyStatus.memberStatusUI secondPartyMemberStatusUI; // 0x98
	private MiniGameLobbyRoomData lobbyRoomData; // 0xA0
	[SerializeField]
	private NguiDynamicFont dynamicFont; // 0xA8
	private float dynamicFontCheckTimer; // 0xB0
	private int fontLayerId; // 0xB4
	private int selectMercenaryParam; // 0xB8
	private bool mercenaryInstractionDisplay; // 0xBC
	private bool isMercenaryInstractionActive; // 0xBD
	private MobaDataManager mobaDataManager; // 0xC0

	// Properties
	public float SecondPartyHp { get; }

	// Methods

	// RVA: 0x19760B4 Offset: 0x19720B4 VA: 0x19760B4
	public float get_SecondPartyHp() { }

	// RVA: 0x19760BC Offset: 0x19720BC VA: 0x19760BC
	private void Awake() { }

	// RVA: 0x19767B0 Offset: 0x19727B0 VA: 0x19767B0
	private void Start() { }

	// RVA: 0x19769DC Offset: 0x19729DC VA: 0x19769DC
	private void Update() { }

	// RVA: 0x1977B84 Offset: 0x1973B84 VA: 0x1977B84
	public void UpdateUI(IList<PartyMemberData> data) { }

	// RVA: 0x1977C40 Offset: 0x1973C40 VA: 0x1977C40
	public void UpdateUI(IList<PartyMemberData> data, float secondPartyHp) { }

	// RVA: 0x19767BC Offset: 0x19727BC VA: 0x19767BC
	public void SetShow(bool isPartyGroupShow, bool isMercenaryCheck) { }

	// RVA: 0x1979708 Offset: 0x1975708 VA: 0x1979708
	private void OnClick(int param) { }

	// RVA: 0x197A338 Offset: 0x1976338 VA: 0x197A338
	private void OnInstructionButton(int value) { }

	// RVA: 0x197A484 Offset: 0x1976484 VA: 0x197A484
	private void SetMemberFieldName(PartyMemberData data, int index, bool isSet) { }

	[IteratorStateMachine(typeof(UIPartyStatus.<ScrollFieldName>d__36))]
	// RVA: 0x197A924 Offset: 0x1976924 VA: 0x197A924
	private IEnumerator ScrollFieldName(PartyMemberData data, string fieldName, int index) { }

	// RVA: 0x197A9DC Offset: 0x19769DC VA: 0x197A9DC
	private bool IsFieldNameScroll(UIPartyStatus.memberStatusUI member, UserStateType state, int lastFieldId) { }

	// RVA: 0x197AA70 Offset: 0x1976A70 VA: 0x197AA70
	private bool IsChangeFieldName(PartyMemberData data, int lastFieldId) { }

	// RVA: 0x1977A50 Offset: 0x1973A50 VA: 0x1977A50
	private void FieldNameUpdate(PartyMemberData data, int memberNo) { }

	// RVA: 0x19777C8 Offset: 0x19737C8 VA: 0x19777C8
	private void UpdateMobaLobby(int memCount, int archetypeId) { }

	// RVA: 0x197AAF4 Offset: 0x1976AF4 VA: 0x197AAF4
	public void .ctor() { }
}
