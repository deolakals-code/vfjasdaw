// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIIconBase : MonoBehaviour // TypeDefIndex: 8935
{
	// Fields
	private static Dictionary<SkillTreeType, int> iconSkillId; // 0x0
	protected UIIconBase.EnableCheck check; // 0x20
	private bool iconEnabled; // 0x24

	// Properties
	public bool IconEnabled { get; set; }

	// Methods

	// RVA: 0x1E5B41C Offset: 0x1E5741C VA: 0x1E5B41C
	public static string PetStaminaSpriteIcon(int stamina, bool isGroggy) { }

	// RVA: 0x1E5B504 Offset: 0x1E57504 VA: 0x1E5B504
	public bool get_IconEnabled() { }

	// RVA: 0x1E5B50C Offset: 0x1E5750C VA: 0x1E5B50C
	public void set_IconEnabled(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnEnable();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnDisable();

	// RVA: 0x1E5B52C Offset: 0x1E5752C VA: 0x1E5B52C
	public void SkillIcon(int skillId) { }

	// RVA: 0x1E5BB0C Offset: 0x1E57B0C VA: 0x1E5BB0C
	private int PetSkillIcon(int skillId) { }

	// RVA: 0x1E5BB30 Offset: 0x1E57B30 VA: 0x1E5BB30
	public void SkillComboIcon(SkillComboType type) { }

	// RVA: 0x1E5BBD0 Offset: 0x1E57BD0 VA: 0x1E5BBD0
	public void SkillTreeIcon(SkillTreeType skillTreeType) { }

	// RVA: 0x1E5BD14 Offset: 0x1E57D14 VA: 0x1E5BD14
	public void EmotionIcon(int emotionId) { }

	// RVA: 0x1E5BE90 Offset: 0x1E57E90 VA: 0x1E5BE90
	public void SwitchEmotionIcon(int id, EmotionPlayer.EmotionType state) { }

	// RVA: 0x1E5BF78 Offset: 0x1E57F78 VA: 0x1E5BF78
	public void MenuIcon(int menuId) { }

	// RVA: 0x1E5C2D4 Offset: 0x1E582D4 VA: 0x1E5C2D4
	public void RewardIcon(RewardType type, int rewardValue) { }

	// RVA: 0x1E54F54 Offset: 0x1E50F54 VA: 0x1E54F54
	public void ItemIcon(int itemId) { }

	// RVA: 0x1E5C500 Offset: 0x1E58500 VA: 0x1E5C500
	public void ItemIcon(int type, int elementType, int param) { }

	// RVA: 0x1E5C508 Offset: 0x1E58508 VA: 0x1E5C508
	public void ItemIcon(int type, int elementType, int param, int param2) { }

	// RVA: 0x1E5C920 Offset: 0x1E58920 VA: 0x1E5C920
	public void ItemRunnTypeIcon(BonusType type) { }

	// RVA: 0x1E5CA04 Offset: 0x1E58A04 VA: 0x1E5CA04
	public void GuildRaidItemIcon(int id, int level) { }

	// RVA: 0x1E5CAA8 Offset: 0x1E58AA8 VA: 0x1E5CAA8
	public void GuildRaidElementIcon(ElementType type, int level) { }

	// RVA: 0x1E5CBF0 Offset: 0x1E58BF0 VA: 0x1E5CBF0
	public void GuildFacilityIcon(GuildFacilityId id) { }

	// RVA: 0x1E5CDB0 Offset: 0x1E58DB0 VA: 0x1E5CDB0
	public void HouseItemIcon(byte type, short category) { }

	// RVA: 0x1E5CFC8 Offset: 0x1E58FC8 VA: 0x1E5CFC8
	public void BadStatusTypeIcon(AbnormalType type) { }

	// RVA: 0x1E5D0D8 Offset: 0x1E590D8 VA: 0x1E5D0D8
	public void EquipIcon(int uuid) { }

	// RVA: 0x1E5C7B4 Offset: 0x1E587B4 VA: 0x1E5C7B4
	public void EquipIcon(ItemType itemType, int ability, bool isHand = False) { }

	// RVA: 0x1E5D0DC Offset: 0x1E590DC VA: 0x1E5D0DC
	public static string GetAvatarEquipSpriteName(EquipType type) { }

	// RVA: 0x1E5D1D4 Offset: 0x1E591D4 VA: 0x1E5D1D4
	public void AvatarEquipIcon(EquipType type) { }

	// RVA: 0x1E5D26C Offset: 0x1E5926C VA: 0x1E5D26C
	public void ChatIcon(ChatChannelType chatType) { }

	// RVA: 0x1E5D370 Offset: 0x1E59370 VA: 0x1E5D370
	public void ComboBufferIcon(SkillComboType type) { }

	// RVA: 0x1E5D448 Offset: 0x1E59448 VA: 0x1E5D448
	public void OnEquipCristaIcon(int itemId) { }

	// RVA: 0x1E5D5A8 Offset: 0x1E595A8 VA: 0x1E5D5A8
	public void EquipBuffIcon(int equipBuffId) { }

	// RVA: 0x1E5D674 Offset: 0x1E59674 VA: 0x1E5D674
	public void SnowballItemIcon(int itemId) { }

	// RVA: 0x1E5D7C4 Offset: 0x1E597C4 VA: 0x1E5D7C4
	public static string GetItemSpriteNameFromId(int itemId) { }

	// RVA: 0x1E5C360 Offset: 0x1E58360 VA: 0x1E5C360
	public static string RewardIconSpriteName(RewardType type, int rewardValue) { }

	// RVA: 0x1E5DBE0 Offset: 0x1E59BE0 VA: 0x1E5DBE0
	public static string DeliveryIconSpriteName(RewardType type, int value) { }

	// RVA: 0x1E5DD68 Offset: 0x1E59D68 VA: 0x1E5DD68
	public static string GetOnEquipCristaSpriteName(int itemId) { }

	// RVA: 0x1E5DB30 Offset: 0x1E59B30 VA: 0x1E5DB30
	public static string MaterialIconSpriteName(int value) { }

	// RVA: 0x1E5DE90 Offset: 0x1E59E90 VA: 0x1E5DE90
	public static bool TryGetSkillTreeIcon(SkillTreeType type, out int id) { }

	// RVA: 0x1E5DF20 Offset: 0x1E59F20 VA: 0x1E5DF20
	public static string GetWeaponIconName(int itemType) { }

	// RVA: 0x1E5DFA0 Offset: 0x1E59FA0 VA: 0x1E5DFA0
	public static string GetItemSpriteName(int itemId) { }

	// RVA: 0x1E5E1A4 Offset: 0x1E5A1A4 VA: 0x1E5E1A4
	public static Color GetRandomPropertyIconColor(short propertyId) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool CheckSprite(string name);

	// RVA: 0x1E55068 Offset: 0x1E51068 VA: 0x1E55068
	public void SetIcon(string spriteName) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SetIcon(string spriteName, Color color);

	// RVA: 0x1E5C2B8 Offset: 0x1E582B8 VA: 0x1E5C2B8
	public void SetSystemIcon(string spriteName) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetSystemIcon(string spriteName, Color color);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void NonIcon();

	// RVA: 0x1E54EC4 Offset: 0x1E50EC4 VA: 0x1E54EC4
	protected void .ctor() { }

	// RVA: 0x1E5E2FC Offset: 0x1E5A2FC VA: 0x1E5E2FC
	private static void .cctor() { }
}
