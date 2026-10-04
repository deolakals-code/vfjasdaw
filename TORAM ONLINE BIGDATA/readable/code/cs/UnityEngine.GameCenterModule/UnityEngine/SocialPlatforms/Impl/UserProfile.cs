// Assembly: UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class UserProfile : IUserProfile // TypeDefIndex: 17846
{
	// Fields
	protected string m_UserName; // 0x10
	protected string m_ID; // 0x18
	private string m_legacyID; // 0x20
	protected bool m_IsFriend; // 0x28
	protected UserState m_State; // 0x2C
	protected Texture2D m_Image; // 0x30

	// Properties
	public string userName { get; }
	public string id { get; }
	public bool isFriend { get; }
	public UserState state { get; }

	// Methods

	// RVA: 0x38009F0 Offset: 0x37FC9F0 VA: 0x38009F0
	public void .ctor() { }

	// RVA: 0x3800AD8 Offset: 0x37FCAD8 VA: 0x3800AD8 Slot: 3
	public override string ToString() { }

	// RVA: 0x3800CAC Offset: 0x37FCCAC VA: 0x3800CAC Slot: 4
	public string get_userName() { }

	// RVA: 0x3800CA4 Offset: 0x37FCCA4 VA: 0x3800CA4 Slot: 5
	public string get_id() { }

	// RVA: 0x3800CB4 Offset: 0x37FCCB4 VA: 0x3800CB4 Slot: 6
	public bool get_isFriend() { }

	// RVA: 0x3800CBC Offset: 0x37FCCBC VA: 0x3800CBC Slot: 7
	public UserState get_state() { }
}
