// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class OptionsSystem // TypeDefIndex: 5389
{
	// Fields
	[CompilerGenerated]
	private bool <ShortcutClose>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <TargetNearDist>k__BackingField; // 0x11
	[CompilerGenerated]
	private byte <ActionPushingTime>k__BackingField; // 0x12
	[CompilerGenerated]
	private byte <AutoItemHp>k__BackingField; // 0x13
	[CompilerGenerated]
	private int <AutoItemId>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte <AutoSkillMp>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <AutoSkillId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <CameraLRReverse>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <CameraLRReaction>k__BackingField; // 0x21
	[CompilerGenerated]
	private bool <CameraUDReverse>k__BackingField; // 0x22
	[CompilerGenerated]
	private byte <CameraUDReaction>k__BackingField; // 0x23
	[CompilerGenerated]
	private bool <CameraZOReverse>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <CameraZOReaction>k__BackingField; // 0x25
	[CompilerGenerated]
	private OptionsSystem.CameraAutoFocusType <CameraAutoFocus>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <BattleCameraAutoFocus>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <ReverseTopButton>k__BackingField; // 0x2D
	[CompilerGenerated]
	private bool <ReturnScreenShot>k__BackingField; // 0x2E
	[CompilerGenerated]
	private byte <ScreenShotType>k__BackingField; // 0x2F
	[CompilerGenerated]
	private byte <QualityData>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <OtherCharacterTap>k__BackingField; // 0x31
	[CompilerGenerated]
	private bool <MarketLockExpend>k__BackingField; // 0x32
	[CompilerGenerated]
	private bool <MarketLockCollect>k__BackingField; // 0x33
	[CompilerGenerated]
	private bool <MarketLockEquip>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <MarketLockCrista>k__BackingField; // 0x35
	[CompilerGenerated]
	private bool <MarketLockOther>k__BackingField; // 0x36
	[CompilerGenerated]
	private OptionsSystem.CameraFollowType <CameraFollow>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <CameraLinkSkill>k__BackingField; // 0x3C
	[CompilerGenerated]
	private bool <WarpItemLockAction>k__BackingField; // 0x3D
	[CompilerGenerated]
	private bool <WarpItemLockBoss>k__BackingField; // 0x3E
	[CompilerGenerated]
	private bool <IsDashMove>k__BackingField; // 0x3F
	[CompilerGenerated]
	private bool <IsExtendedShortcutEnabled>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <ItemBagDisplay>k__BackingField; // 0x41
	[CompilerGenerated]
	private bool <FirstScenarioSkip>k__BackingField; // 0x42
	[CompilerGenerated]
	private bool <FishingVibration>k__BackingField; // 0x43
	[CompilerGenerated]
	private byte <AutoRejectApply>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <ConditionApply>k__BackingField; // 0x45
	[CompilerGenerated]
	private GuardType <Guard>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <GuardVolume>k__BackingField; // 0x4C
	[CompilerGenerated]
	private GuardManualType <GuardManualType>k__BackingField; // 0x50
	[CompilerGenerated]
	private AvoidType <Avoid>k__BackingField; // 0x54
	[CompilerGenerated]
	private AvoidManualType <AvoidManualType>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <WeaponMonsterTarget>k__BackingField; // 0x5C
	private const OptionsSystem.WeaponMonsterTargetType allMonsterTargetType = 1023;
	[CompilerGenerated]
	private int <BattleMonsterTarget>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <AutoDeleteEquipItem>k__BackingField; // 0x64
	[CompilerGenerated]
	private bool <AutoDeleteEquipItemBossDrop>k__BackingField; // 0x65
	[CompilerGenerated]
	private bool <AutoDeleteEquipItemEvent>k__BackingField; // 0x66
	[CompilerGenerated]
	private byte <AutoDeleteEquipItemSlot>k__BackingField; // 0x67
	[CompilerGenerated]
	private byte <AutoDeleteEquipItemStatus>k__BackingField; // 0x68
	[CompilerGenerated]
	private byte <AutoDeleteEquipItemDuplicate>k__BackingField; // 0x69
	[CompilerGenerated]
	private byte <AutoDeleteEquipItemProperty>k__BackingField; // 0x6A
	[CompilerGenerated]
	private ItemAutoDiscardOptionData <ItemAutoDiscardOptionData>k__BackingField; // 0x70
	private bool isGetFirstOptionData; // 0x78
	[CompilerGenerated]
	private Color <EquipBonusColor>k__BackingField; // 0x7C
	[CompilerGenerated]
	private Color <EquipLimitBonusColor>k__BackingField; // 0x8C
	public const int DefaultActionPushingTime = 0;
	public const int DefaultScreenShotType = 0;
	public const int DefaultCameraFollow = 1;
	public static readonly Color32 DefaultEquipBonusColor; // 0x0
	public static readonly Color32 DefaultEquipLimitBonusColor; // 0x4
	private PlayerDataManager playerDataManager; // 0xA0

	// Properties
	[SerializeField]
	public bool ShortcutClose { get; set; }
	[SerializeField]
	public bool TargetNearDist { get; set; }
	[SerializeField]
	public byte ActionPushingTime { get; set; }
	public float ActionHoldedTime { get; }
	[SerializeField]
	public byte AutoItemHp { get; set; }
	[SerializeField]
	public int AutoItemId { get; set; }
	[SerializeField]
	public byte AutoSkillMp { get; set; }
	[SerializeField]
	public int AutoSkillId { get; set; }
	[SerializeField]
	public bool CameraLRReverse { get; set; }
	[SerializeField]
	public byte CameraLRReaction { get; set; }
	public float CameraLRPower { get; }
	[SerializeField]
	public bool CameraUDReverse { get; set; }
	[SerializeField]
	public byte CameraUDReaction { get; set; }
	public float CameraUDPower { get; }
	[SerializeField]
	public bool CameraZOReverse { get; set; }
	[SerializeField]
	public byte CameraZOReaction { get; set; }
	public float CameraZOPower { get; }
	[SerializeField]
	public OptionsSystem.CameraAutoFocusType CameraAutoFocus { get; set; }
	[SerializeField]
	public bool BattleCameraAutoFocus { get; set; }
	[SerializeField]
	public bool ReverseTopButton { get; set; }
	[SerializeField]
	public bool ReturnScreenShot { get; set; }
	[SerializeField]
	public byte ScreenShotType { get; set; }
	[SerializeField]
	public byte QualityData { get; set; }
	[SerializeField]
	public byte OtherCharacterTap { get; set; }
	[SerializeField]
	public bool MarketLockExpend { get; set; }
	[SerializeField]
	public bool MarketLockCollect { get; set; }
	[SerializeField]
	public bool MarketLockEquip { get; set; }
	[SerializeField]
	public bool MarketLockCrista { get; set; }
	[SerializeField]
	public bool MarketLockOther { get; set; }
	[SerializeField]
	public OptionsSystem.CameraFollowType CameraFollow { get; set; }
	[SerializeField]
	public bool CameraLinkSkill { get; set; }
	public int QualityTargetFrame { get; }
	public byte MarketLockBitFlag { get; }
	[SerializeField]
	public bool WarpItemLockAction { get; set; }
	[SerializeField]
	public bool WarpItemLockBoss { get; set; }
	public byte WarpItemLockBitFlag { get; }
	[SerializeField]
	public bool IsDashMove { get; set; }
	public virtual bool IsExtendedShortcutEnabled { get; set; }
	[SerializeField]
	public bool ItemBagDisplay { get; set; }
	[SerializeField]
	public bool FirstScenarioSkip { get; set; }
	[SerializeField]
	public bool FishingVibration { get; set; }
	[SerializeField]
	public byte AutoRejectApply { get; set; }
	[SerializeField]
	public byte ConditionApply { get; set; }
	public GuardType Guard { get; set; }
	public byte GuardVolume { get; set; }
	public float GuardVolumeRate { get; }
	public GuardManualType GuardManualType { get; set; }
	[SerializeField]
	public AvoidType Avoid { get; set; }
	public AvoidManualType AvoidManualType { get; set; }
	[SerializeField]
	public int WeaponMonsterTarget { get; set; }
	[SerializeField]
	public int BattleMonsterTarget { get; set; }
	[SerializeField]
	public bool AutoDeleteEquipItem { get; set; }
	[SerializeField]
	public bool AutoDeleteEquipItemBossDrop { get; set; }
	[SerializeField]
	public bool AutoDeleteEquipItemEvent { get; set; }
	[SerializeField]
	public byte AutoDeleteEquipItemSlot { get; set; }
	[SerializeField]
	public byte AutoDeleteEquipItemStatus { get; set; }
	[SerializeField]
	public byte AutoDeleteEquipItemDuplicate { get; set; }
	[SerializeField]
	public byte AutoDeleteEquipItemProperty { get; set; }
	public ItemAutoDiscardOptionData ItemAutoDiscardOptionData { get; set; }
	[SerializeField]
	public Color EquipBonusColor { get; set; }
	[SerializeField]
	public Color EquipLimitBonusColor { get; set; }
	public string EquipBonusColorLabelFormat { get; }
	public string EquipLimitBonusColorLabelFormat { get; }
	protected virtual byte DefaultQualityData { get; }
	protected virtual byte DefaultCameraUDReaction { get; }
	protected virtual bool DefaultDashMove { get; }
	private PlayerDataManager playerManager { get; }

	// Methods

	// RVA: 0x264D400 Offset: 0x2649400 VA: 0x264D400
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x264FA10 Offset: 0x264BA10 VA: 0x264FA10
	private void set_ShortcutClose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FA1C Offset: 0x264BA1C VA: 0x264FA1C
	public bool get_ShortcutClose() { }

	[CompilerGenerated]
	// RVA: 0x264FA24 Offset: 0x264BA24 VA: 0x264FA24
	private void set_TargetNearDist(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FA30 Offset: 0x264BA30 VA: 0x264FA30
	public bool get_TargetNearDist() { }

	[CompilerGenerated]
	// RVA: 0x264FA38 Offset: 0x264BA38 VA: 0x264FA38
	private void set_ActionPushingTime(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FA40 Offset: 0x264BA40 VA: 0x264FA40
	public byte get_ActionPushingTime() { }

	// RVA: 0x264FA48 Offset: 0x264BA48 VA: 0x264FA48
	public float get_ActionHoldedTime() { }

	[CompilerGenerated]
	// RVA: 0x264FA60 Offset: 0x264BA60 VA: 0x264FA60
	private void set_AutoItemHp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FA68 Offset: 0x264BA68 VA: 0x264FA68
	public byte get_AutoItemHp() { }

	[CompilerGenerated]
	// RVA: 0x264FA70 Offset: 0x264BA70 VA: 0x264FA70
	private void set_AutoItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x264FA78 Offset: 0x264BA78 VA: 0x264FA78
	public int get_AutoItemId() { }

	[CompilerGenerated]
	// RVA: 0x264FA80 Offset: 0x264BA80 VA: 0x264FA80
	private void set_AutoSkillMp(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FA88 Offset: 0x264BA88 VA: 0x264FA88
	public byte get_AutoSkillMp() { }

	[CompilerGenerated]
	// RVA: 0x264FA90 Offset: 0x264BA90 VA: 0x264FA90
	private void set_AutoSkillId(int value) { }

	[CompilerGenerated]
	// RVA: 0x264FA98 Offset: 0x264BA98 VA: 0x264FA98
	public int get_AutoSkillId() { }

	[CompilerGenerated]
	// RVA: 0x264FAA0 Offset: 0x264BAA0 VA: 0x264FAA0
	private void set_CameraLRReverse(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FAAC Offset: 0x264BAAC VA: 0x264FAAC
	public bool get_CameraLRReverse() { }

	[CompilerGenerated]
	// RVA: 0x264FAB4 Offset: 0x264BAB4 VA: 0x264FAB4
	private void set_CameraLRReaction(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FABC Offset: 0x264BABC VA: 0x264FABC
	public byte get_CameraLRReaction() { }

	// RVA: 0x264FAC4 Offset: 0x264BAC4 VA: 0x264FAC4
	public float get_CameraLRPower() { }

	[CompilerGenerated]
	// RVA: 0x264FAE0 Offset: 0x264BAE0 VA: 0x264FAE0
	private void set_CameraUDReverse(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FAEC Offset: 0x264BAEC VA: 0x264FAEC
	public bool get_CameraUDReverse() { }

	[CompilerGenerated]
	// RVA: 0x264FAF4 Offset: 0x264BAF4 VA: 0x264FAF4
	private void set_CameraUDReaction(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FAFC Offset: 0x264BAFC VA: 0x264FAFC
	public byte get_CameraUDReaction() { }

	// RVA: 0x264FB04 Offset: 0x264BB04 VA: 0x264FB04
	public float get_CameraUDPower() { }

	[CompilerGenerated]
	// RVA: 0x264FB20 Offset: 0x264BB20 VA: 0x264FB20
	private void set_CameraZOReverse(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FB2C Offset: 0x264BB2C VA: 0x264FB2C
	public bool get_CameraZOReverse() { }

	[CompilerGenerated]
	// RVA: 0x264FB34 Offset: 0x264BB34 VA: 0x264FB34
	private void set_CameraZOReaction(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FB3C Offset: 0x264BB3C VA: 0x264FB3C
	public byte get_CameraZOReaction() { }

	// RVA: 0x264FB44 Offset: 0x264BB44 VA: 0x264FB44
	public float get_CameraZOPower() { }

	[CompilerGenerated]
	// RVA: 0x264FB60 Offset: 0x264BB60 VA: 0x264FB60
	private void set_CameraAutoFocus(OptionsSystem.CameraAutoFocusType value) { }

	[CompilerGenerated]
	// RVA: 0x264FB68 Offset: 0x264BB68 VA: 0x264FB68
	public OptionsSystem.CameraAutoFocusType get_CameraAutoFocus() { }

	[CompilerGenerated]
	// RVA: 0x264FB70 Offset: 0x264BB70 VA: 0x264FB70
	private void set_BattleCameraAutoFocus(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FB7C Offset: 0x264BB7C VA: 0x264FB7C
	public bool get_BattleCameraAutoFocus() { }

	[CompilerGenerated]
	// RVA: 0x264FB84 Offset: 0x264BB84 VA: 0x264FB84
	private void set_ReverseTopButton(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FB90 Offset: 0x264BB90 VA: 0x264FB90
	public bool get_ReverseTopButton() { }

	[CompilerGenerated]
	// RVA: 0x264FB98 Offset: 0x264BB98 VA: 0x264FB98
	private void set_ReturnScreenShot(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FBA4 Offset: 0x264BBA4 VA: 0x264FBA4
	public bool get_ReturnScreenShot() { }

	[CompilerGenerated]
	// RVA: 0x264FBAC Offset: 0x264BBAC VA: 0x264FBAC
	private void set_ScreenShotType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FBB4 Offset: 0x264BBB4 VA: 0x264FBB4
	public byte get_ScreenShotType() { }

	[CompilerGenerated]
	// RVA: 0x264FBBC Offset: 0x264BBBC VA: 0x264FBBC
	private void set_QualityData(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FBC4 Offset: 0x264BBC4 VA: 0x264FBC4
	public byte get_QualityData() { }

	[CompilerGenerated]
	// RVA: 0x264FBCC Offset: 0x264BBCC VA: 0x264FBCC
	private void set_OtherCharacterTap(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FBD4 Offset: 0x264BBD4 VA: 0x264FBD4
	public byte get_OtherCharacterTap() { }

	[CompilerGenerated]
	// RVA: 0x264FBDC Offset: 0x264BBDC VA: 0x264FBDC
	private void set_MarketLockExpend(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FBE8 Offset: 0x264BBE8 VA: 0x264FBE8
	public bool get_MarketLockExpend() { }

	[CompilerGenerated]
	// RVA: 0x264FBF0 Offset: 0x264BBF0 VA: 0x264FBF0
	private void set_MarketLockCollect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FBFC Offset: 0x264BBFC VA: 0x264FBFC
	public bool get_MarketLockCollect() { }

	[CompilerGenerated]
	// RVA: 0x264FC04 Offset: 0x264BC04 VA: 0x264FC04
	private void set_MarketLockEquip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FC10 Offset: 0x264BC10 VA: 0x264FC10
	public bool get_MarketLockEquip() { }

	[CompilerGenerated]
	// RVA: 0x264FC18 Offset: 0x264BC18 VA: 0x264FC18
	private void set_MarketLockCrista(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FC24 Offset: 0x264BC24 VA: 0x264FC24
	public bool get_MarketLockCrista() { }

	[CompilerGenerated]
	// RVA: 0x264FC2C Offset: 0x264BC2C VA: 0x264FC2C
	private void set_MarketLockOther(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FC38 Offset: 0x264BC38 VA: 0x264FC38
	public bool get_MarketLockOther() { }

	[CompilerGenerated]
	// RVA: 0x264FC40 Offset: 0x264BC40 VA: 0x264FC40
	private void set_CameraFollow(OptionsSystem.CameraFollowType value) { }

	[CompilerGenerated]
	// RVA: 0x264FC48 Offset: 0x264BC48 VA: 0x264FC48
	public OptionsSystem.CameraFollowType get_CameraFollow() { }

	[CompilerGenerated]
	// RVA: 0x264FC50 Offset: 0x264BC50 VA: 0x264FC50
	private void set_CameraLinkSkill(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FC5C Offset: 0x264BC5C VA: 0x264FC5C
	public bool get_CameraLinkSkill() { }

	// RVA: 0x264FC64 Offset: 0x264BC64 VA: 0x264FC64
	public int get_QualityTargetFrame() { }

	// RVA: 0x264FCFC Offset: 0x264BCFC VA: 0x264FCFC
	public byte get_MarketLockBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x264FD44 Offset: 0x264BD44 VA: 0x264FD44
	private void set_WarpItemLockAction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FD50 Offset: 0x264BD50 VA: 0x264FD50
	public bool get_WarpItemLockAction() { }

	[CompilerGenerated]
	// RVA: 0x264FD58 Offset: 0x264BD58 VA: 0x264FD58
	private void set_WarpItemLockBoss(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FD64 Offset: 0x264BD64 VA: 0x264FD64
	public bool get_WarpItemLockBoss() { }

	// RVA: 0x264FD6C Offset: 0x264BD6C VA: 0x264FD6C
	public byte get_WarpItemLockBitFlag() { }

	[CompilerGenerated]
	// RVA: 0x264FD84 Offset: 0x264BD84 VA: 0x264FD84
	private void set_IsDashMove(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FD90 Offset: 0x264BD90 VA: 0x264FD90
	public bool get_IsDashMove() { }

	[CompilerGenerated]
	// RVA: 0x264FD98 Offset: 0x264BD98 VA: 0x264FD98 Slot: 4
	public virtual bool get_IsExtendedShortcutEnabled() { }

	[CompilerGenerated]
	// RVA: 0x264FDA0 Offset: 0x264BDA0 VA: 0x264FDA0
	private void set_IsExtendedShortcutEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FDAC Offset: 0x264BDAC VA: 0x264FDAC
	private void set_ItemBagDisplay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FDB8 Offset: 0x264BDB8 VA: 0x264FDB8
	public bool get_ItemBagDisplay() { }

	[CompilerGenerated]
	// RVA: 0x264FDC0 Offset: 0x264BDC0 VA: 0x264FDC0
	private void set_FirstScenarioSkip(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FDCC Offset: 0x264BDCC VA: 0x264FDCC
	public bool get_FirstScenarioSkip() { }

	[CompilerGenerated]
	// RVA: 0x264FDD4 Offset: 0x264BDD4 VA: 0x264FDD4
	private void set_FishingVibration(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FDE0 Offset: 0x264BDE0 VA: 0x264FDE0
	public bool get_FishingVibration() { }

	[CompilerGenerated]
	// RVA: 0x264FDE8 Offset: 0x264BDE8 VA: 0x264FDE8
	private void set_AutoRejectApply(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FDF0 Offset: 0x264BDF0 VA: 0x264FDF0
	public byte get_AutoRejectApply() { }

	[CompilerGenerated]
	// RVA: 0x264FDF8 Offset: 0x264BDF8 VA: 0x264FDF8
	private void set_ConditionApply(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FE00 Offset: 0x264BE00 VA: 0x264FE00
	public byte get_ConditionApply() { }

	[CompilerGenerated]
	// RVA: 0x264FE08 Offset: 0x264BE08 VA: 0x264FE08
	private void set_Guard(GuardType value) { }

	[CompilerGenerated]
	// RVA: 0x264FE10 Offset: 0x264BE10 VA: 0x264FE10
	public GuardType get_Guard() { }

	[CompilerGenerated]
	// RVA: 0x264FE18 Offset: 0x264BE18 VA: 0x264FE18
	private void set_GuardVolume(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FE20 Offset: 0x264BE20 VA: 0x264FE20
	public byte get_GuardVolume() { }

	// RVA: 0x264FE28 Offset: 0x264BE28 VA: 0x264FE28
	public float get_GuardVolumeRate() { }

	[CompilerGenerated]
	// RVA: 0x264FE54 Offset: 0x264BE54 VA: 0x264FE54
	private void set_GuardManualType(GuardManualType value) { }

	[CompilerGenerated]
	// RVA: 0x264FE5C Offset: 0x264BE5C VA: 0x264FE5C
	public GuardManualType get_GuardManualType() { }

	[CompilerGenerated]
	// RVA: 0x264FE64 Offset: 0x264BE64 VA: 0x264FE64
	private void set_Avoid(AvoidType value) { }

	[CompilerGenerated]
	// RVA: 0x264FE6C Offset: 0x264BE6C VA: 0x264FE6C
	public AvoidType get_Avoid() { }

	[CompilerGenerated]
	// RVA: 0x264FE74 Offset: 0x264BE74 VA: 0x264FE74
	private void set_AvoidManualType(AvoidManualType value) { }

	[CompilerGenerated]
	// RVA: 0x264FE7C Offset: 0x264BE7C VA: 0x264FE7C
	public AvoidManualType get_AvoidManualType() { }

	[CompilerGenerated]
	// RVA: 0x264FE84 Offset: 0x264BE84 VA: 0x264FE84
	private void set_WeaponMonsterTarget(int value) { }

	[CompilerGenerated]
	// RVA: 0x264FE8C Offset: 0x264BE8C VA: 0x264FE8C
	public int get_WeaponMonsterTarget() { }

	// RVA: 0x264FE94 Offset: 0x264BE94 VA: 0x264FE94
	public bool CheckWeaponNearMonsterTarget(int itemType) { }

	// RVA: 0x264FE98 Offset: 0x264BE98 VA: 0x264FE98
	public bool CheckWeaponNearMonsterTarget(ItemDBData.ItemType weaponType) { }

	// RVA: 0x264FED4 Offset: 0x264BED4 VA: 0x264FED4
	public bool CheckWeaponNearMonsterTarget(OptionsSystem.WeaponMonsterTargetType type) { }

	[CompilerGenerated]
	// RVA: 0x264FEE4 Offset: 0x264BEE4 VA: 0x264FEE4
	private void set_BattleMonsterTarget(int value) { }

	[CompilerGenerated]
	// RVA: 0x264FEEC Offset: 0x264BEEC VA: 0x264FEEC
	public int get_BattleMonsterTarget() { }

	// RVA: 0x264FEF4 Offset: 0x264BEF4 VA: 0x264FEF4
	public bool CheckBattleMonsterTarget(OptionsSystem.BattleMonstarTargetType type) { }

	[CompilerGenerated]
	// RVA: 0x264FF04 Offset: 0x264BF04 VA: 0x264FF04
	private void set_AutoDeleteEquipItem(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FF10 Offset: 0x264BF10 VA: 0x264FF10
	public bool get_AutoDeleteEquipItem() { }

	[CompilerGenerated]
	// RVA: 0x264FF18 Offset: 0x264BF18 VA: 0x264FF18
	private void set_AutoDeleteEquipItemBossDrop(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FF24 Offset: 0x264BF24 VA: 0x264FF24
	public bool get_AutoDeleteEquipItemBossDrop() { }

	[CompilerGenerated]
	// RVA: 0x264FF2C Offset: 0x264BF2C VA: 0x264FF2C
	private void set_AutoDeleteEquipItemEvent(bool value) { }

	[CompilerGenerated]
	// RVA: 0x264FF38 Offset: 0x264BF38 VA: 0x264FF38
	public bool get_AutoDeleteEquipItemEvent() { }

	[CompilerGenerated]
	// RVA: 0x264FF40 Offset: 0x264BF40 VA: 0x264FF40
	private void set_AutoDeleteEquipItemSlot(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FF48 Offset: 0x264BF48 VA: 0x264FF48
	public byte get_AutoDeleteEquipItemSlot() { }

	[CompilerGenerated]
	// RVA: 0x264FF50 Offset: 0x264BF50 VA: 0x264FF50
	private void set_AutoDeleteEquipItemStatus(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FF58 Offset: 0x264BF58 VA: 0x264FF58
	public byte get_AutoDeleteEquipItemStatus() { }

	[CompilerGenerated]
	// RVA: 0x264FF60 Offset: 0x264BF60 VA: 0x264FF60
	private void set_AutoDeleteEquipItemDuplicate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FF68 Offset: 0x264BF68 VA: 0x264FF68
	public byte get_AutoDeleteEquipItemDuplicate() { }

	[CompilerGenerated]
	// RVA: 0x264FF70 Offset: 0x264BF70 VA: 0x264FF70
	private void set_AutoDeleteEquipItemProperty(byte value) { }

	[CompilerGenerated]
	// RVA: 0x264FF78 Offset: 0x264BF78 VA: 0x264FF78
	public byte get_AutoDeleteEquipItemProperty() { }

	[CompilerGenerated]
	// RVA: 0x264FF80 Offset: 0x264BF80 VA: 0x264FF80
	private void set_ItemAutoDiscardOptionData(ItemAutoDiscardOptionData value) { }

	[CompilerGenerated]
	// RVA: 0x264FF88 Offset: 0x264BF88 VA: 0x264FF88
	public ItemAutoDiscardOptionData get_ItemAutoDiscardOptionData() { }

	[CompilerGenerated]
	// RVA: 0x264FF90 Offset: 0x264BF90 VA: 0x264FF90
	private void set_EquipBonusColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264FF9C Offset: 0x264BF9C VA: 0x264FF9C
	public Color get_EquipBonusColor() { }

	[CompilerGenerated]
	// RVA: 0x264FFA8 Offset: 0x264BFA8 VA: 0x264FFA8
	private void set_EquipLimitBonusColor(Color value) { }

	[CompilerGenerated]
	// RVA: 0x264FFB4 Offset: 0x264BFB4 VA: 0x264FFB4
	public Color get_EquipLimitBonusColor() { }

	// RVA: 0x264FFC0 Offset: 0x264BFC0 VA: 0x264FFC0
	public string get_EquipBonusColorLabelFormat() { }

	// RVA: 0x264FFE4 Offset: 0x264BFE4 VA: 0x264FFE4
	public string get_EquipLimitBonusColorLabelFormat() { }

	// RVA: 0x2650008 Offset: 0x264C008 VA: 0x2650008 Slot: 5
	protected virtual byte get_DefaultQualityData() { }

	// RVA: 0x2650010 Offset: 0x264C010 VA: 0x2650010 Slot: 6
	protected virtual byte get_DefaultCameraUDReaction() { }

	// RVA: 0x2650018 Offset: 0x264C018 VA: 0x2650018 Slot: 7
	protected virtual bool get_DefaultDashMove() { }

	// RVA: 0x2650020 Offset: 0x264C020 VA: 0x2650020
	private PlayerDataManager get_playerManager() { }

	// RVA: 0x26500A4 Offset: 0x264C0A4 VA: 0x26500A4
	private int SaveFlag(int setting, bool flag, int bit) { }

	// RVA: 0x26500B4 Offset: 0x264C0B4 VA: 0x26500B4
	private int SaveFlag(int setting, bool flag, OptionsSystem.SystemOptionBitFlag bitFlag) { }

	// RVA: 0x26500CC Offset: 0x264C0CC VA: 0x26500CC
	private bool LoadFlag(int loadFlag, OptionsSystem.SystemOptionBitFlag bitFlag) { }

	// RVA: 0x26500D8 Offset: 0x264C0D8 VA: 0x26500D8 Slot: 8
	public virtual void SystemOptionSave() { }

	// RVA: 0x2650544 Offset: 0x264C544 VA: 0x2650544 Slot: 9
	public virtual void SystemOptionLoad() { }

	// RVA: 0x264DF48 Offset: 0x2649F48 VA: 0x264DF48
	public void NewAccountClear() { }

	// RVA: 0x2650B30 Offset: 0x264CB30 VA: 0x2650B30 Slot: 10
	public virtual bool SetFlag(OptionsSystem.SystemOptionType type, bool flag) { }

	// RVA: 0x2650D10 Offset: 0x264CD10 VA: 0x2650D10
	public bool SetParam(OptionsSystem.SystemOptionType type, int param) { }

	// RVA: 0x2650F04 Offset: 0x264CF04 VA: 0x2650F04
	public bool OtherCharacterTapOptionCheck() { }

	// RVA: 0x26510D8 Offset: 0x264D0D8 VA: 0x26510D8
	public bool CheckRejectApplyFlag(OptionsSystem.AutoRejectApplyFlag flag) { }

	// RVA: 0x26510E8 Offset: 0x264D0E8 VA: 0x26510E8
	public bool CheckConditionApplyFlag(OptionsSystem.ConditionApplyFlag flag) { }

	// RVA: 0x26510F8 Offset: 0x264D0F8 VA: 0x26510F8
	public bool CheckRejectApply(OptionsSystem.AutoRejectApplyFlag flag, int archetypeId) { }

	// RVA: 0x26511F4 Offset: 0x264D1F4 VA: 0x26511F4
	public bool SetColor(OptionsSystem.SystemOptionType type, Color setColor) { }

	// RVA: 0x2650A94 Offset: 0x264CA94 VA: 0x2650A94
	private Color IntToColor(string load, Color baseColor) { }

	// RVA: 0x265051C Offset: 0x264C51C VA: 0x265051C
	private void ColorToInt(string save, Color32 colorData) { }

	// RVA: 0x2651228 Offset: 0x264D228 VA: 0x2651228
	public ClientOptionsData GetSendClientOptionsData() { }

	// RVA: 0x2651298 Offset: 0x264D298 VA: 0x2651298
	public bool ChangeSystemAvatarOption() { }

	// RVA: 0x2651460 Offset: 0x264D460 VA: 0x2651460
	public void SetAvatarOptionData(AvatarOptionDataBase[] optionList) { }

	// RVA: 0x2651360 Offset: 0x264D360 VA: 0x2651360
	private void SendChangeAvatarOption(ItemAutoDiscardOptionData data) { }

	// RVA: 0x2651554 Offset: 0x264D554 VA: 0x2651554
	private void SetItemAutoDiscardOptionData(ItemAutoDiscardOptionData option) { }

	// RVA: 0x2651690 Offset: 0x264D690 VA: 0x2651690
	private static void .cctor() { }
}
