// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldMapSearchButton : MonoBehaviour // TypeDefIndex: 7409
{
	// Fields
	[SerializeField]
	private UILabel fieldSelectButtonLabel; // 0x20
	[SerializeField]
	private UILabel fieldSelectText; // 0x28
	[SerializeField]
	private GameObject fieldSelectFavoriteObject; // 0x30
	[SerializeField]
	private UISprite fieldSelectFavoriteFlagIcon; // 0x38
	[SerializeField]
	private GameObject fieldSelectFavoriteUpButton; // 0x40
	[SerializeField]
	private GameObject partyMemberIconObject; // 0x48
	[SerializeField]
	private UILabel eventText; // 0x50
	[SerializeField]
	private GameObject dropIconObject; // 0x58
	[SerializeField]
	private GameObject expIconObject; // 0x60
	[SerializeField]
	private UIImageButton selectImageButton; // 0x68
	private UIWorldMapPanel manager; // 0x70
	private int selectId; // 0x78
	private bool isFavorite; // 0x7C
	private List<GmEventData> eventDataList; // 0x80
	private int currentIndex; // 0x88
	private float timer; // 0x8C

	// Methods

	// RVA: 0x1B424F0 Offset: 0x1B3E4F0 VA: 0x1B424F0
	public void Initialize(UIWorldMapPanel manager, string name, string text, int selectId) { }

	// RVA: 0x1B42570 Offset: 0x1B3E570 VA: 0x1B42570
	public void SetRoomGmMobEvent(List<GmEventData> list) { }

	// RVA: 0x1B428CC Offset: 0x1B3E8CC VA: 0x1B428CC
	public void SetPartyMemberField(bool isPartyMember) { }

	// RVA: 0x1B42694 Offset: 0x1B3E694 VA: 0x1B42694
	private void SetGmEventData(GmEventData data) { }

	// RVA: 0x1B428EC Offset: 0x1B3E8EC VA: 0x1B428EC
	private void Update() { }

	// RVA: 0x1B429B0 Offset: 0x1B3E9B0 VA: 0x1B429B0
	public void SetFavoriteCheck(bool isFlag) { }

	// RVA: 0x1B429E8 Offset: 0x1B3E9E8 VA: 0x1B429E8
	public void SetFavoriteChangeButton(bool isEnabled, bool isSort_0) { }

	// RVA: 0x1B42A38 Offset: 0x1B3EA38 VA: 0x1B42A38
	public void SetNonGrayButtou() { }

	// RVA: 0x1B42AA8 Offset: 0x1B3EAA8 VA: 0x1B42AA8
	public void OnClick_UpButton() { }

	// RVA: 0x1B42ACC Offset: 0x1B3EACC VA: 0x1B42ACC
	public void OnClick_SelectButton() { }

	// RVA: 0x1B42AF0 Offset: 0x1B3EAF0 VA: 0x1B42AF0
	public void OnClick_ChangeFavorite() { }

	// RVA: 0x1B42B90 Offset: 0x1B3EB90 VA: 0x1B42B90
	public void .ctor() { }
}
