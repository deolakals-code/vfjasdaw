// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaPlayerStatus : PlayerStatusBase // TypeDefIndex: 1428
{
	// Fields
	[CompilerGenerated]
	private short <OwnerLevel>k__BackingField; // 0x12
	[CompilerGenerated]
	private byte <StartPopAreaNo>k__BackingField; // 0x14
	[SerializeField]
	private PlayerGameStatus gameStatus; // 0x18
	[SerializeField]
	private PlayerPrimaryStatus primaryStatus; // 0x20
	private IPlayerStatusCalculator secondaryStatus; // 0x28
	private IPlayerStatusCalculator battleStatus; // 0x30
	private IPlayerStatusCalculator temporaryStatus; // 0x38
	private BonusManager bonusManager; // 0x40
	private SkillManager skillManager; // 0x48
	private SkillBufferManager skillBufferManager; // 0x50
	private AbnormalStateManager abnormalStatusManager; // 0x58
	private EquipItemData equipData; // 0x60
	private EquipBuffManager equipBuffManager; // 0x68
	private GemCartBufferManager gemCartBuffManager; // 0x70
	private ItemRandomPropertyManager itemRandomPropertyManager; // 0x78
	private MobBuffManager mobBuffManager; // 0x80
	private MobaTreasureBonusManager treasureBonusManager; // 0x88
	private MobaDuelAbilityManager duelAbilityManager; // 0x90

	// Properties
	public override PlayerGameStatus GameStatus { get; }
	public override PlayerPrimaryStatus PrimaryStatus { get; }
	public override IPlayerStatusCalculator SecondaryStatus { get; }
	public override IPlayerStatusCalculator BattleStatus { get; }
	public override SkillManager SkillManager { get; }
	public override SkillBufferManager SkillBufferManager { get; }
	public override BonusManager BonusManager { get; }
	public override AbnormalStateManager AbnormalStatusManager { get; }
	public override EquipItemData EquipItemData { get; }
	public override EquipBuffManager EquipBuffManager { get; }
	public override GemCartBufferManager GemCartBuffManager { get; }
	public override ItemRandomPropertyManager ItemRandomProperty { get; }
	public override bool IsLocalDead { get; }
	public override bool IsDead { get; }
	public override bool IsActDead { get; }
	public override bool IsInvincibility { get; }
	public short OwnerLevel { get; set; }
	public byte StartPopAreaNo { get; set; }
	public MobBuffManager MobBuffManager { get; }
	public MobaTreasureBonusManager TreasureBonusManager { get; }
	public MobaDuelAbilityManager DuelAbilityManager { get; }

	// Methods

	// RVA: 0x203D968 Offset: 0x2039968 VA: 0x203D968 Slot: 4
	public override PlayerGameStatus get_GameStatus() { }

	// RVA: 0x203D970 Offset: 0x2039970 VA: 0x203D970 Slot: 5
	public override PlayerPrimaryStatus get_PrimaryStatus() { }

	// RVA: 0x203D978 Offset: 0x2039978 VA: 0x203D978 Slot: 6
	public override IPlayerStatusCalculator get_SecondaryStatus() { }

	// RVA: 0x203D980 Offset: 0x2039980 VA: 0x203D980 Slot: 7
	public override IPlayerStatusCalculator get_BattleStatus() { }

	// RVA: 0x203D988 Offset: 0x2039988 VA: 0x203D988 Slot: 8
	public override SkillManager get_SkillManager() { }

	// RVA: 0x203D990 Offset: 0x2039990 VA: 0x203D990 Slot: 9
	public override SkillBufferManager get_SkillBufferManager() { }

	// RVA: 0x203D998 Offset: 0x2039998 VA: 0x203D998 Slot: 10
	public override BonusManager get_BonusManager() { }

	// RVA: 0x203D9A0 Offset: 0x20399A0 VA: 0x203D9A0 Slot: 11
	public override AbnormalStateManager get_AbnormalStatusManager() { }

	// RVA: 0x203D9A8 Offset: 0x20399A8 VA: 0x203D9A8 Slot: 12
	public override EquipItemData get_EquipItemData() { }

	// RVA: 0x203D9B0 Offset: 0x20399B0 VA: 0x203D9B0 Slot: 13
	public override EquipBuffManager get_EquipBuffManager() { }

	// RVA: 0x203D9B8 Offset: 0x20399B8 VA: 0x203D9B8 Slot: 14
	public override GemCartBufferManager get_GemCartBuffManager() { }

	// RVA: 0x203D9C0 Offset: 0x20399C0 VA: 0x203D9C0 Slot: 15
	public override ItemRandomPropertyManager get_ItemRandomProperty() { }

	// RVA: 0x203D9C8 Offset: 0x20399C8 VA: 0x203D9C8 Slot: 16
	public override bool get_IsLocalDead() { }

	// RVA: 0x203D9E8 Offset: 0x20399E8 VA: 0x203D9E8 Slot: 17
	public override bool get_IsDead() { }

	// RVA: 0x203DA28 Offset: 0x2039A28 VA: 0x203DA28 Slot: 18
	public override bool get_IsActDead() { }

	// RVA: 0x203DA4C Offset: 0x2039A4C VA: 0x203DA4C Slot: 19
	public override bool get_IsInvincibility() { }

	[CompilerGenerated]
	// RVA: 0x203DA8C Offset: 0x2039A8C VA: 0x203DA8C
	public short get_OwnerLevel() { }

	[CompilerGenerated]
	// RVA: 0x203DA94 Offset: 0x2039A94 VA: 0x203DA94
	private void set_OwnerLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x203DA9C Offset: 0x2039A9C VA: 0x203DA9C
	public byte get_StartPopAreaNo() { }

	[CompilerGenerated]
	// RVA: 0x203DAA4 Offset: 0x2039AA4 VA: 0x203DAA4
	private void set_StartPopAreaNo(byte value) { }

	// RVA: 0x203DAAC Offset: 0x2039AAC VA: 0x203DAAC
	public MobBuffManager get_MobBuffManager() { }

	// RVA: 0x203DAB4 Offset: 0x2039AB4 VA: 0x203DAB4
	public MobaTreasureBonusManager get_TreasureBonusManager() { }

	// RVA: 0x203DABC Offset: 0x2039ABC VA: 0x203DABC
	public MobaDuelAbilityManager get_DuelAbilityManager() { }

	// RVA: 0x203DAC4 Offset: 0x2039AC4 VA: 0x203DAC4
	public void .ctor(BonusManager bonusManager, SkillManager skillManager, SkillBufferManager skillBufManager, AbnormalStateManager abnormalManager, EquipBuffManager equipBuffManager, GemCartBufferManager gemCartBuffManager, ItemRandomPropertyManager itemRandomPropertyManager, MobBuffManager mobBuffManager, MobaTreasureBonusManager treasureBonusManager, MobaDuelAbilityManager duelAbilityManager) { }

	// RVA: 0x203DCF8 Offset: 0x2039CF8 VA: 0x203DCF8 Slot: 20
	public override void Initialize(PrimaryStatusData primaryStatus, GameStatusData gameStatus, AvatarGameStatusData avatarGameStatus) { }

	// RVA: 0x203E50C Offset: 0x203A50C VA: 0x203E50C
	public void SetOwnerLevel(short ownerLevel) { }

	// RVA: 0x203E514 Offset: 0x203A514 VA: 0x203E514
	public void SetStartPopAreaNo(byte popAreaNo) { }

	// RVA: 0x203E51C Offset: 0x203A51C VA: 0x203E51C Slot: 26
	public override void LevelUp(PrimaryStatusData primaryStatus, int hp, int exHp, int mp, int exMp, long exp) { }

	// RVA: 0x203E5DC Offset: 0x203A5DC VA: 0x203E5DC Slot: 25
	public override void RestorePlayerStatus() { }

	// RVA: 0x203E5F0 Offset: 0x203A5F0 VA: 0x203E5F0 Slot: 24
	public override void TemporaryPlayerStatus() { }

	// RVA: 0x203E66C Offset: 0x203A66C VA: 0x203E66C Slot: 23
	public override void UpdateGameStatus(GameStatusData gameStatus) { }

	// RVA: 0x203E764 Offset: 0x203A764 VA: 0x203E764 Slot: 21
	public override void UpdatePrimaryStatus(IPrimaryStatus primaryStatus) { }

	// RVA: 0x203EC04 Offset: 0x203AC04 VA: 0x203EC04 Slot: 22
	public override void UpdatePrimaryStatus(PrimaryStatusData primaryStatus) { }

	// RVA: 0x203EC28 Offset: 0x203AC28 VA: 0x203EC28 Slot: 27
	public override long GetNextExp() { }
}
