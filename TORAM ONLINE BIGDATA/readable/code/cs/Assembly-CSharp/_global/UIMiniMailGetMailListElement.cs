// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMiniMailGetMailListElement : MonoBehaviour // TypeDefIndex: 7445
{
	// Fields
	private PlayerDataManager playerData; // 0x20
	[SerializeField]
	private UILabel nameLabel; // 0x28
	[SerializeField]
	private UILabel getDateLabel; // 0x30
	[SerializeField]
	private UILabel checkMailLabel; // 0x38
	[SerializeField]
	private UIImageButton checkMailButton; // 0x40
	[SerializeField]
	private UILabel mailTitleLabel; // 0x48
	[SerializeField]
	private UILabel stateLabel; // 0x50
	[SerializeField]
	private UISprite stateIcon; // 0x58
	[SerializeField]
	private UISprite stateMailIcon; // 0x60
	[SerializeField]
	private UIImageButton[] imageButton; // 0x68
	[SerializeField]
	private UILabel textMessageLabel; // 0x70
	[SerializeField]
	private GameObject mailObjectParent; // 0x78
	private SystemTextManager systemTextManager; // 0x80

	// Properties
	private PlayerDataManager playerDataManager { get; }

	// Methods

	// RVA: 0x1B540A4 Offset: 0x1B500A4 VA: 0x1B540A4
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1B54128 Offset: 0x1B50128 VA: 0x1B54128
	private void Awake() { }

	// RVA: 0x1B54210 Offset: 0x1B50210 VA: 0x1B54210
	public void Initialize(MailHeaderData mailData, MailCountType mailCountType) { }

	// RVA: 0x1B5477C Offset: 0x1B5077C VA: 0x1B5477C
	public void Initialize(MailHistoryData data) { }

	// RVA: 0x1B54A6C Offset: 0x1B50A6C VA: 0x1B54A6C
	public void .ctor() { }
}
