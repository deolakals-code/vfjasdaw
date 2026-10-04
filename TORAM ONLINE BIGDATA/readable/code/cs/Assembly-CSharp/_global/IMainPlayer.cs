// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IMainPlayer // TypeDefIndex: 595
{
	// Properties
	public abstract PlayerActionManagerBase ActionManager { get; }
	public abstract CharacterMove CharacterMove { get; }
	public abstract PlayerStatusBase PlayerStatus { get; }
	public abstract ItemManager ItemManager { get; }
	public abstract AutoItemManager AutoItemManager { get; }
	public abstract SkillManager SkillManager { get; }
	public abstract SkillBufferManager SkillBufferManager { get; }
	public abstract BonusManager BonusManager { get; }
	public abstract AbnormalStateManager AbnormalStateManager { get; }
	public abstract BufferEffectManager BufferEffectManager { get; }
	public abstract EquipBuffManager EquipBuffManager { get; }
	public abstract StarGemManager StarGemManager { get; }
	public abstract RegistletManager RegistletManager { get; }
	public abstract GemCartBufferManager GemCartBufManager { get; }
	public abstract ItemRandomPropertyManager ItemRandomPropertyManager { get; }
	public abstract ProficiencyManager ProficiencyManager { get; }
	public abstract SkillComboManager SkillComboManager { get; }
	public abstract EffectPlayer EffectPlayer { get; }
	public abstract EmotionPlayer EmotionPlayer { get; }
	public abstract NewArchetypeProperties Properties { get; }
	public abstract ExSkillManager ExSkillManager { get; }
	public abstract TradeManager TradeManager { get; }
	public abstract bool IsMerging { get; }
	public abstract float PlayerHeight { get; }
	public abstract bool IsMan { get; }
	public abstract bool IsManAnimation { get; }
	public abstract bool IsFieldAction { get; }
	public abstract GameObject gameObject { get; }
	public abstract Transform transform { get; }
	public abstract string UserName { get; }
	public abstract float ItemDelayTime { get; }
	public abstract float ItemDelayPercent { get; }
	public abstract bool IsGMEventPlayer { get; }
	public abstract bool IsUseSignBoard { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract PlayerActionManagerBase get_ActionManager();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract CharacterMove get_CharacterMove();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PlayerStatusBase get_PlayerStatus();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract ItemManager get_ItemManager();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AutoItemManager get_AutoItemManager();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SkillManager get_SkillManager();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract SkillBufferManager get_SkillBufferManager();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BonusManager get_BonusManager();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract AbnormalStateManager get_AbnormalStateManager();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract BufferEffectManager get_BufferEffectManager();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract EquipBuffManager get_EquipBuffManager();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract StarGemManager get_StarGemManager();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract RegistletManager get_RegistletManager();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract GemCartBufferManager get_GemCartBufManager();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract ItemRandomPropertyManager get_ItemRandomPropertyManager();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract ProficiencyManager get_ProficiencyManager();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract SkillComboManager get_SkillComboManager();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract EffectPlayer get_EffectPlayer();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract EmotionPlayer get_EmotionPlayer();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract NewArchetypeProperties get_Properties();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract ExSkillManager get_ExSkillManager();

	// RVA: -1 Offset: -1 Slot: 21
	public abstract TradeManager get_TradeManager();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool get_IsMerging();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract float get_PlayerHeight();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool get_IsMan();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool get_IsManAnimation();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool get_IsFieldAction();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool ConnectUpdate(PacketBase updatePacketBase);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract void ConnectUpdate(int serverFPS, Dictionary<byte, object> newProperties, IItemBagData itemBagData, IStatusData statusData, IGuildBufferData guildBufferData, IParamData paramData, IHouseBufferData houseData);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void OnEnter();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract void OnLeave();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void OnSetEquipProperties(bool isUpdate, NewArchetypeProperties properties);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract string get_UserName();

	// RVA: -1 Offset: -1 Slot: 35
	public abstract float get_ItemDelayTime();

	// RVA: -1 Offset: -1 Slot: 36
	public abstract float get_ItemDelayPercent();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract bool get_IsGMEventPlayer();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool get_IsUseSignBoard();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void CalcItemDelay(float time, bool bonus);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool ItemInvoke(int uuid);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract bool ItemReserveCancel(int uuid);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract void OnSetProperties(NewArchetypeProperties properties);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract bool ClientEquipItem(ItemDBData.EquipType type, int uuid);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract bool PushEquipItem();

	// RVA: -1 Offset: -1 Slot: 45
	public abstract GameObject CloneModelObject();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract void EquipAllPurge(bool deadUpdate);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract bool EquipItem(ItemDBData.EquipType type, int uuid);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract SignboardPropertyData GetUpdateSignboard();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract void OnChangeState(ArchetypeChangeState response);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract void PlayerRespawn(int hp, int mp, bool orbRespawn);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract bool UseItem(int uuid, bool isAutoUse);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract void UpdateStatusEquip();

	// RVA: -1 Offset: -1 Slot: 53
	public abstract void UpdateSkillList(Dictionary<short, byte> skill);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract void UpdateClientEquipModel();

	// RVA: -1 Offset: -1 Slot: 55
	public abstract void UpdateServerMp(int mp, int exMp);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract void UpdateServerHP(int hp, int exHp);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract void FieldDummyLeave();
}
