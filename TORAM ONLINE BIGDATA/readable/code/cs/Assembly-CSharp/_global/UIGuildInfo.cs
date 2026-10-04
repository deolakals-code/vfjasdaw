// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildInfo : MonoBehaviour // TypeDefIndex: 7106
{
	// Fields
	[SerializeField]
	private GameObject infoParentObject; // 0x20
	[SerializeField]
	private GameObject noInfoParentObject; // 0x28
	[SerializeField]
	private ItemIcon noInfoItemIcon; // 0x30
	[SerializeField]
	private UILabel nameLabel; // 0x38
	[SerializeField]
	private LocalizeText lvLocalize; // 0x40
	[SerializeField]
	private LocalizeText peopleLocalize; // 0x48
	[SerializeField]
	private LocalizeText policyLocalize; // 0x50
	[SerializeField]
	private LocalizeText factionLocalize; // 0x58
	[SerializeField]
	private LocalizeText contributionLocalize; // 0x60
	[SerializeField]
	private LocalizeText labyrinthLocalize; // 0x68
	[SerializeField]
	private LocalizeText magicGaugeLocalize; // 0x70
	[SerializeField]
	private UISprite expSprite; // 0x78
	[SerializeField]
	private UISprite magicSprite; // 0x80
	[SerializeField]
	private GameObject labyrinthObj; // 0x88
	[SerializeField]
	private GameObject boosterObj; // 0x90
	[SerializeField]
	private GameObject boosterAnnounceObj; // 0x98
	[SerializeField]
	private LocalizeText guildPointLocalize; // 0xA0
	private float expSpriteWidthMax; // 0xA8
	private float magicSpriteWidthMax; // 0xAC
	private float guildNameLabelDefaultScale; // 0xB0
	private float guildNameLabelDefaultWidth; // 0xB4
	[CompilerGenerated]
	private GuildManager <guildManager>k__BackingField; // 0xB8
	[CompilerGenerated]
	private PlayerDataManager <playerDataManager>k__BackingField; // 0xC0
	[CompilerGenerated]
	private SystemTextManager <systemTextManager>k__BackingField; // 0xC8

	// Properties
	public bool IsVisible { get; set; }
	public GuildManager guildManager { get; set; }
	public PlayerDataManager playerDataManager { get; set; }
	public SystemTextManager systemTextManager { get; set; }

	// Methods

	// RVA: 0x1A96870 Offset: 0x1A92870 VA: 0x1A96870
	public bool get_IsVisible() { }

	// RVA: 0x1A9688C Offset: 0x1A9288C VA: 0x1A9688C
	public void set_IsVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1A96914 Offset: 0x1A92914 VA: 0x1A96914
	public GuildManager get_guildManager() { }

	[CompilerGenerated]
	// RVA: 0x1A9691C Offset: 0x1A9291C VA: 0x1A9691C
	public void set_guildManager(GuildManager value) { }

	[CompilerGenerated]
	// RVA: 0x1A96924 Offset: 0x1A92924 VA: 0x1A96924
	public PlayerDataManager get_playerDataManager() { }

	[CompilerGenerated]
	// RVA: 0x1A9692C Offset: 0x1A9292C VA: 0x1A9692C
	public void set_playerDataManager(PlayerDataManager value) { }

	[CompilerGenerated]
	// RVA: 0x1A96934 Offset: 0x1A92934 VA: 0x1A96934
	public SystemTextManager get_systemTextManager() { }

	[CompilerGenerated]
	// RVA: 0x1A9693C Offset: 0x1A9293C VA: 0x1A9693C
	public void set_systemTextManager(SystemTextManager value) { }

	[IteratorStateMachine(typeof(UIGuildInfo.<Initialize>d__36))]
	// RVA: 0x1A96944 Offset: 0x1A92944 VA: 0x1A96944
	public IEnumerator Initialize() { }

	// RVA: 0x1A969D8 Offset: 0x1A929D8 VA: 0x1A969D8
	public void .ctor() { }
}
