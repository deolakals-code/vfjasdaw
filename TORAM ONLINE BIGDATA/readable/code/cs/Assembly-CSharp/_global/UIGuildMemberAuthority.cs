// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildMemberAuthority : MonoBehaviour // TypeDefIndex: 7145
{
	// Fields
	[SerializeField]
	private LocalizeText userNameLocalize; // 0x20
	[SerializeField]
	private UISprite subMasterIcon; // 0x28
	[SerializeField]
	private UISprite invitationIcon; // 0x30
	[SerializeField]
	private UISprite announceIcon; // 0x38
	[SerializeField]
	private UISprite unknownIcon1; // 0x40
	[SerializeField]
	private UISprite unknownIcon2; // 0x48
	private int targetId; // 0x50
	private byte defaultAuthority; // 0x54
	private byte currentAuthority; // 0x55
	private bool isMaster; // 0x56
	private Action<byte> callback; // 0x58
	private PlayerDataManager playerDataManager; // 0x60

	// Methods

	// RVA: 0x1AA8154 Offset: 0x1AA4154 VA: 0x1AA8154
	private void Awake() { }

	// RVA: 0x1AA8178 Offset: 0x1AA4178 VA: 0x1AA8178
	public void Initialize(string userName, byte authority, Action<byte> callback, bool isMaster) { }

	// RVA: 0x1AA826C Offset: 0x1AA426C VA: 0x1AA826C
	private void checkAuthority() { }

	// RVA: 0x1AA82FC Offset: 0x1AA42FC VA: 0x1AA82FC
	private string getSpriteName(bool isEnable) { }

	// RVA: 0x1AA8364 Offset: 0x1AA4364 VA: 0x1AA8364
	private void onSubMaster() { }

	// RVA: 0x1AA8414 Offset: 0x1AA4414 VA: 0x1AA8414
	private void onInvitation() { }

	// RVA: 0x1AA84A4 Offset: 0x1AA44A4 VA: 0x1AA84A4
	private void onAnnounce() { }

	// RVA: 0x1AA8534 Offset: 0x1AA4534 VA: 0x1AA8534
	private void onDetermine() { }

	// RVA: 0x1AA8564 Offset: 0x1AA4564 VA: 0x1AA8564
	public void OnClose() { }

	// RVA: 0x1AA8404 Offset: 0x1AA4404 VA: 0x1AA8404
	private void removeSubMasterAuthority() { }

	// RVA: 0x1AA8588 Offset: 0x1AA4588 VA: 0x1AA8588
	public void .ctor() { }
}
