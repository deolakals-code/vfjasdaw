// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PlayerStatus : PlayerStatusBase // TypeDefIndex: 1471
{
	// Fields
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

	// Methods

	// RVA: 0x2056ED4 Offset: 0x2052ED4 VA: 0x2056ED4 Slot: 4
	public override PlayerGameStatus get_GameStatus() { }

	// RVA: 0x2056EDC Offset: 0x2052EDC VA: 0x2056EDC Slot: 5
	public override PlayerPrimaryStatus get_PrimaryStatus() { }

	// RVA: 0x2056EE4 Offset: 0x2052EE4 VA: 0x2056EE4 Slot: 6
	public override IPlayerStatusCalculator get_SecondaryStatus() { }

	// RVA: 0x2056EEC Offset: 0x2052EEC VA: 0x2056EEC Slot: 7
	public override IPlayerStatusCalculator get_BattleStatus() { }

	// RVA: 0x2056EF4 Offset: 0x2052EF4 VA: 0x2056EF4 Slot: 8
	public override SkillManager get_SkillManager() { }

	// RVA: 0x2056EFC Offset: 0x2052EFC VA: 0x2056EFC Slot: 9
	public override SkillBufferManager get_SkillBufferManager() { }

	// RVA: 0x2056F04 Offset: 0x2052F04 VA: 0x2056F04 Slot: 10
	public override BonusManager get_BonusManager() { }

	// RVA: 0x2056F0C Offset: 0x2052F0C VA: 0x2056F0C Slot: 11
	public override AbnormalStateManager get_AbnormalStatusManager() { }

	// RVA: 0x2056F14 Offset: 0x2052F14 VA: 0x2056F14 Slot: 12
	public override EquipItemData get_EquipItemData() { }

	// RVA: 0x2056F1C Offset: 0x2052F1C VA: 0x2056F1C Slot: 13
	public override EquipBuffManager get_EquipBuffManager() { }

	// RVA: 0x2056F24 Offset: 0x2052F24 VA: 0x2056F24 Slot: 14
	public override GemCartBufferManager get_GemCartBuffManager() { }

	// RVA: 0x2056F2C Offset: 0x2052F2C VA: 0x2056F2C Slot: 15
	public override ItemRandomPropertyManager get_ItemRandomProperty() { }

	// RVA: 0x2056F34 Offset: 0x2052F34 VA: 0x2056F34 Slot: 16
	public override bool get_IsLocalDead() { }

	// RVA: 0x2056F54 Offset: 0x2052F54 VA: 0x2056F54 Slot: 17
	public override bool get_IsDead() { }

	// RVA: 0x2056F94 Offset: 0x2052F94 VA: 0x2056F94 Slot: 18
	public override bool get_IsActDead() { }

	// RVA: 0x2056FB8 Offset: 0x2052FB8 VA: 0x2056FB8 Slot: 19
	public override bool get_IsInvincibility() { }

	// RVA: 0x2056FF8 Offset: 0x2052FF8 VA: 0x2056FF8
	public void .ctor(BonusManager bonusManager, SkillManager skillManager, SkillBufferManager skillBufManager, AbnormalStateManager abnormalManager, EquipBuffManager equipBuffManager, GemCartBufferManager gemCartBuffManager, ItemRandomPropertyManager itemRandomPropertyManager) { }

	// RVA: 0x20571B4 Offset: 0x20531B4 VA: 0x20571B4
	public void .ctor(BonusManager bonusManager, SkillManager skillManager, SkillBufferManager skillBufManager, AbnormalStateManager abnormalManager, IPlayerStatusCalculator secondry, IPlayerStatusCalculator battle, EquipBuffManager equipBuffManager, GemCartBufferManager gemCartBuffManager) { }

	// RVA: 0x2057304 Offset: 0x2053304 VA: 0x2057304 Slot: 20
	public override void Initialize(PrimaryStatusData primaryStatus, GameStatusData gameStatus, AvatarGameStatusData avatarGameStatus) { }

	// RVA: 0x2057364 Offset: 0x2053364 VA: 0x2057364
	public void Initialize(IPrimaryStatus primaryStatus, GameStatusData gameStatus) { }

	// RVA: 0x20573C4 Offset: 0x20533C4 VA: 0x20573C4 Slot: 21
	public override void UpdatePrimaryStatus(IPrimaryStatus primaryStatus) { }

	// RVA: 0x20573EC Offset: 0x20533EC VA: 0x20573EC Slot: 22
	public override void UpdatePrimaryStatus(PrimaryStatusData primaryStatus) { }

	// RVA: 0x2057414 Offset: 0x2053414 VA: 0x2057414 Slot: 23
	public override void UpdateGameStatus(GameStatusData gameStatus) { }

	// RVA: 0x205743C Offset: 0x205343C VA: 0x205743C Slot: 24
	public override void TemporaryPlayerStatus() { }

	// RVA: 0x20574B8 Offset: 0x20534B8 VA: 0x20574B8 Slot: 25
	public override void RestorePlayerStatus() { }

	// RVA: 0x20574CC Offset: 0x20534CC VA: 0x20574CC Slot: 26
	public override void LevelUp(PrimaryStatusData primaryStatus, int hp, int exHp, int mp, int exMp, long exp) { }
}
