// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildRaidRandamPropertyLabel : MonoBehaviour // TypeDefIndex: 5761
{
	// Fields
	private static Dictionary<int, string> iconSprites; // 0x0
	[SerializeField]
	private UILabel propertyEffectLabel; // 0x20
	[SerializeField]
	private UILabel propertyUserNameLabel; // 0x28
	[SerializeField]
	private UISprite propertyIcon; // 0x30
	[SerializeField]
	private UISprite propertyIconSub; // 0x38
	[SerializeField]
	private GameObject badPropertyButton; // 0x40
	private byte index; // 0x48
	private bool isBadProperty; // 0x49
	private UIGuildRaidSymbolManager manager; // 0x50
	private bool isInvalid; // 0x58
	private bool isMyguild; // 0x59

	// Methods

	// RVA: 0x17E0228 Offset: 0x17DC228 VA: 0x17E0228
	public static void SetIcon(UISprite mainIcon, UISprite subIcon, int id) { }

	// RVA: 0x17E0484 Offset: 0x17DC484 VA: 0x17E0484
	public static bool IsBadProperty(int id) { }

	// RVA: 0x17E0494 Offset: 0x17DC494 VA: 0x17E0494
	public static string GetRandamPropertyText(GuildRaidRandomPropertyData data, int guildRaidLevel, SystemTextManager textManager) { }

	// RVA: 0x17E0738 Offset: 0x17DC738 VA: 0x17E0738
	public void SetRandamProperty(UIGuildRaidSymbolManager manager, GuildRaidRandomPropertyData data, int guildRaidLevel, bool isMyguild) { }

	// RVA: 0x17E0AA8 Offset: 0x17DCAA8 VA: 0x17E0AA8
	public void UpdateInvalid(GuildRaidRandomPropertyData data) { }

	// RVA: 0x17E0C2C Offset: 0x17DCC2C VA: 0x17E0C2C
	public void OnClick_RemoveProperty() { }

	// RVA: 0x17E1020 Offset: 0x17DD020 VA: 0x17E1020
	public void .ctor() { }

	// RVA: 0x17E1028 Offset: 0x17DD028 VA: 0x17E1028
	private static void .cctor() { }
}
