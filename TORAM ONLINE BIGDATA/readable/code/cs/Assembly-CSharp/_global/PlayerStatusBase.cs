// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public abstract class PlayerStatusBase // TypeDefIndex: 1475
{
	// Fields
	[CompilerGenerated]
	private bool <IsInit>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IsEffectiveDeadItemDuration>k__BackingField; // 0x11

	// Properties
	public bool IsInit { get; set; }
	public abstract PlayerGameStatus GameStatus { get; }
	public abstract PlayerPrimaryStatus PrimaryStatus { get; }
	public abstract IPlayerStatusCalculator SecondaryStatus { get; }
	public abstract IPlayerStatusCalculator BattleStatus { get; }
	public abstract SkillManager SkillManager { get; }
	public abstract SkillBufferManager SkillBufferManager { get; }
	public abstract BonusManager BonusManager { get; }
	public abstract AbnormalStateManager AbnormalStatusManager { get; }
	public abstract EquipItemData EquipItemData { get; }
	public abstract EquipBuffManager EquipBuffManager { get; }
	public abstract GemCartBufferManager GemCartBuffManager { get; }
	public abstract ItemRandomPropertyManager ItemRandomProperty { get; }
	public abstract bool IsLocalDead { get; }
	public abstract bool IsDead { get; }
	public abstract bool IsActDead { get; }
	public abstract bool IsInvincibility { get; }
	public bool IsEffectiveDeadItemDuration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2057588 Offset: 0x2053588 VA: 0x2057588
	public bool get_IsInit() { }

	[CompilerGenerated]
	// RVA: 0x2057590 Offset: 0x2053590 VA: 0x2057590
	protected void set_IsInit(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract PlayerGameStatus get_GameStatus();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract PlayerPrimaryStatus get_PrimaryStatus();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IPlayerStatusCalculator get_SecondaryStatus();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IPlayerStatusCalculator get_BattleStatus();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract SkillManager get_SkillManager();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SkillBufferManager get_SkillBufferManager();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract BonusManager get_BonusManager();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract AbnormalStateManager get_AbnormalStatusManager();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract EquipItemData get_EquipItemData();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract EquipBuffManager get_EquipBuffManager();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract GemCartBufferManager get_GemCartBuffManager();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract ItemRandomPropertyManager get_ItemRandomProperty();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool get_IsLocalDead();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_IsDead();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_IsActDead();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_IsInvincibility();

	[CompilerGenerated]
	// RVA: 0x205759C Offset: 0x205359C VA: 0x205759C
	public bool get_IsEffectiveDeadItemDuration() { }

	[CompilerGenerated]
	// RVA: 0x20575A4 Offset: 0x20535A4 VA: 0x20575A4
	private void set_IsEffectiveDeadItemDuration(bool value) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Initialize(PrimaryStatusData primaryStatus, GameStatusData gameStatus, AvatarGameStatusData avatarGameStatus);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void UpdatePrimaryStatus(IPrimaryStatus primaryStatus);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void UpdatePrimaryStatus(PrimaryStatusData primaryStatus);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void UpdateGameStatus(GameStatusData gameStatus);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void TemporaryPlayerStatus();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void RestorePlayerStatus();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void LevelUp(PrimaryStatusData primaryStatus, int hp, int exHp, int mp, int exMp, long exp);

	// RVA: 0x20575B0 Offset: 0x20535B0 VA: 0x20575B0 Slot: 27
	public virtual long GetNextExp() { }

	// RVA: 0x2057618 Offset: 0x2053618 VA: 0x2057618
	public float GetHpPercent() { }

	// RVA: 0x2057700 Offset: 0x2053700 VA: 0x2057700
	public float GetMpPercent() { }

	// RVA: 0x20577E8 Offset: 0x20537E8 VA: 0x20577E8
	public void DamageHp(int damage, bool actDead) { }

	// RVA: 0x20578B8 Offset: 0x20538B8 VA: 0x20578B8
	public void AddLocalHp(int hp) { }

	// RVA: 0x2057A38 Offset: 0x2053A38 VA: 0x2057A38
	public void AddLocalMp(int mp) { }

	// RVA: 0x2057BB4 Offset: 0x2053BB4 VA: 0x2057BB4
	public bool EnoughMp(int mp) { }

	// RVA: 0x2057C10 Offset: 0x2053C10 VA: 0x2057C10
	public bool PaySkillMp(int mp) { }

	// RVA: 0x2057D24 Offset: 0x2053D24 VA: 0x2057D24
	public void SetExp(short level, long setExp) { }

	// RVA: 0x2057DA0 Offset: 0x2053DA0 VA: 0x2057DA0
	public void UpdateSkillPoint(int point) { }

	// RVA: 0x2057DCC Offset: 0x2053DCC VA: 0x2057DCC
	public void UpdateStatusPoint(int point) { }

	// RVA: 0x2057DF8 Offset: 0x2053DF8 VA: 0x2057DF8
	public void UpdateEffectiveDeadItemDuration(bool effective) { }

	// RVA: 0x2057E04 Offset: 0x2053E04 VA: 0x2057E04 Slot: 28
	public virtual void SetEquip(ItemDBData.EquipType type, ItemData item) { }

	// RVA: 0x2058B5C Offset: 0x2054B5C VA: 0x2058B5C
	public void SetCooking(List<BonusParameter> bonusParameterList) { }

	// RVA: 0x2058C84 Offset: 0x2054C84 VA: 0x2058C84
	public void SetGuildRaidBonus(List<BonusParameter> bonusParameterList) { }

	// RVA: 0x2058DAC Offset: 0x2054DAC VA: 0x2058DAC
	public void SetSelfDisclosureBonus(List<BonusParameter> bonusParameterList) { }

	// RVA: 0x2058810 Offset: 0x2054810 VA: 0x2058810
	protected void SetCristEquipBuff(BonusData bonus, BonusData cristBonus) { }

	// RVA: 0x2058F18 Offset: 0x2054F18 VA: 0x2058F18
	public ItemData GetEquip(ItemDBData.EquipType type) { }

	// RVA: 0x2058F48 Offset: 0x2054F48 VA: 0x2058F48
	public ElementType GetEquipElement() { }

	// RVA: 0x2059014 Offset: 0x2055014 VA: 0x2059014
	public ElementType GetEquipSubWeaponElement() { }

	// RVA: 0x20591B0 Offset: 0x20551B0 VA: 0x20591B0
	public SkillEqLimitFlag GetEquipSkill() { }

	// RVA: 0x2059360 Offset: 0x2055360 VA: 0x2059360
	public SkillEqLimitFlag GetMainEquipSkill() { }

	// RVA: 0x2059384 Offset: 0x2055384 VA: 0x2059384
	public SkillEqLimitFlag GetSubEquipSkill() { }

	// RVA: 0x20593A8 Offset: 0x20553A8 VA: 0x20593A8
	public SkillEqLimitFlag GetWeaponTypeToEquipLimit() { }

	// RVA: 0x20591EC Offset: 0x20551EC VA: 0x20591EC
	private SkillEqLimitFlag GetEquipSkillFlag(ItemData main, ItemData sub) { }

	// RVA: 0x20594F4 Offset: 0x20554F4 VA: 0x20594F4
	private SkillEqLimitFlag GetEquipSkillFlag(ItemDBData.ItemType type) { }

	// RVA: 0x205955C Offset: 0x205555C VA: 0x205955C
	public bool CheckBodyAbility(ItemDBData.ArmorAbility ability) { }

	// RVA: 0x20595E4 Offset: 0x20555E4 VA: 0x20595E4
	public void StartRandomProperty(byte equipType, short propertyId, short stack, out ItemRandomPropertyData item) { }

	// RVA: 0x205973C Offset: 0x205573C VA: 0x205973C
	public void EndItemRandomProperty(byte equipType, short propertyId) { }

	// RVA: 0x2059830 Offset: 0x2055830 VA: 0x2059830
	public void ResetItemRandomProperty() { }

	// RVA: 0x20598D4 Offset: 0x20558D4 VA: 0x20598D4 Slot: 29
	public virtual int GetFirstAttack() { }

	// RVA: 0x20598FC Offset: 0x20558FC VA: 0x20598FC Slot: 30
	public virtual int GetFirstAttackRate() { }

	// RVA: 0x2059974 Offset: 0x2055974 VA: 0x2059974
	public int GetBonusValueWithBuf(BonusType type) { }

	// RVA: 0x2059AB0 Offset: 0x2055AB0 VA: 0x2059AB0
	private SkillBufferId GetReceiveElementDmgRateBufType(BonusType type) { }

	// RVA: 0x2059ACC Offset: 0x2055ACC VA: 0x2059ACC
	public SkillData[] GetAvatarSkill() { }

	// RVA: 0x2059F58 Offset: 0x2055F58 VA: 0x2059F58
	public SkillData[] GetNinjaSkill() { }

	// RVA: 0x20571AC Offset: 0x20531AC VA: 0x20571AC
	protected void .ctor() { }
}
