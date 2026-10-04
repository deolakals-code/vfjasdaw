// Assembly: UnityEngine.GameCenterModule.dll
// Namespace: UnityEngine.SocialPlatforms.Impl
public class LocalUser : UserProfile, ILocalUser, IUserProfile // TypeDefIndex: 17845
{
	// Fields
	private IUserProfile[] m_Friends; // 0x38
	private bool m_Authenticated; // 0x40
	private bool m_Underage; // 0x41

	// Properties
	public bool authenticated { get; }

	// Methods

	// RVA: 0x3800564 Offset: 0x37FC564 VA: 0x3800564
	public void .ctor() { }

	// RVA: 0x3800AD0 Offset: 0x37FCAD0 VA: 0x3800AD0 Slot: 8
	public bool get_authenticated() { }
}
