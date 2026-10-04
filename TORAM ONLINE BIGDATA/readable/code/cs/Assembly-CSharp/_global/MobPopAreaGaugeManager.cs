// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobPopAreaGaugeManager : ISceneChangeManager // TypeDefIndex: 1067
{
	// Fields
	private static MobPopAreaGaugeManager instance; // 0x0
	private PopAreaBonusSender sender; // 0x10
	private IBonusGameEventObservable suprretion; // 0x18
	private IAreaGaugeEventObservable sutamina; // 0x20
	[CompilerGenerated]
	private bool <IsBonus>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsBonusActive>k__BackingField; // 0x29
	[CompilerGenerated]
	private bool <IsBonusTapWait>k__BackingField; // 0x2A
	[CompilerGenerated]
	private bool <IsPopStop>k__BackingField; // 0x2B
	[CompilerGenerated]
	private bool <IsRewardWait>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <IsCoolTime>k__BackingField; // 0x2D
	[CompilerGenerated]
	private bool <IsAreaeRadication>k__BackingField; // 0x2E
	[CompilerGenerated]
	private int <AreaGauge>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <AreaGaugeMax>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <BonusGauge>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <BonusGaugeMax>k__BackingField; // 0x3C

	// Properties
	public static MobPopAreaGaugeManager Instance { get; }
	public IBonusEventController BonusEventController { get; }
	public IBonusGameEventObservable BonusEventSender { get; }
	public IAreaGaugeEventObservable AreaEventSender { get; }
	public bool IsBonus { get; set; }
	public bool IsBonusActive { get; set; }
	public bool IsBonusTapWait { get; set; }
	public bool IsPopStop { get; set; }
	public bool IsRewardWait { get; set; }
	public bool IsCoolTime { get; set; }
	public bool IsAreaeRadication { get; set; }
	public int AreaGauge { get; set; }
	public int AreaGaugeMax { get; set; }
	public int BonusGauge { get; set; }
	public int BonusGaugeMax { get; set; }
	public bool IsEnabledBonusGame { get; }

	// Methods

	// RVA: 0x1F346E4 Offset: 0x1F306E4 VA: 0x1F346E4
	public static MobPopAreaGaugeManager get_Instance() { }

	// RVA: 0x1F40A34 Offset: 0x1F3CA34 VA: 0x1F40A34
	public static void Restart() { }

	// RVA: 0x1F406D4 Offset: 0x1F3C6D4 VA: 0x1F406D4
	private void .ctor() { }

	// RVA: 0x1F41120 Offset: 0x1F3D120 VA: 0x1F41120
	public IBonusEventController get_BonusEventController() { }

	// RVA: 0x1F41128 Offset: 0x1F3D128 VA: 0x1F41128
	public IBonusGameEventObservable get_BonusEventSender() { }

	// RVA: 0x1F41130 Offset: 0x1F3D130 VA: 0x1F41130
	public IAreaGaugeEventObservable get_AreaEventSender() { }

	[CompilerGenerated]
	// RVA: 0x1F41138 Offset: 0x1F3D138 VA: 0x1F41138
	public bool get_IsBonus() { }

	[CompilerGenerated]
	// RVA: 0x1F41140 Offset: 0x1F3D140 VA: 0x1F41140
	private void set_IsBonus(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F4114C Offset: 0x1F3D14C VA: 0x1F4114C
	public bool get_IsBonusActive() { }

	[CompilerGenerated]
	// RVA: 0x1F41154 Offset: 0x1F3D154 VA: 0x1F41154
	private void set_IsBonusActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F41160 Offset: 0x1F3D160 VA: 0x1F41160
	public bool get_IsBonusTapWait() { }

	[CompilerGenerated]
	// RVA: 0x1F41168 Offset: 0x1F3D168 VA: 0x1F41168
	private void set_IsBonusTapWait(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F41174 Offset: 0x1F3D174 VA: 0x1F41174
	public bool get_IsPopStop() { }

	[CompilerGenerated]
	// RVA: 0x1F4117C Offset: 0x1F3D17C VA: 0x1F4117C
	private void set_IsPopStop(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F41188 Offset: 0x1F3D188 VA: 0x1F41188
	public bool get_IsRewardWait() { }

	[CompilerGenerated]
	// RVA: 0x1F41190 Offset: 0x1F3D190 VA: 0x1F41190
	private void set_IsRewardWait(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F4119C Offset: 0x1F3D19C VA: 0x1F4119C
	public bool get_IsCoolTime() { }

	[CompilerGenerated]
	// RVA: 0x1F411A4 Offset: 0x1F3D1A4 VA: 0x1F411A4
	private void set_IsCoolTime(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F411B0 Offset: 0x1F3D1B0 VA: 0x1F411B0
	public bool get_IsAreaeRadication() { }

	[CompilerGenerated]
	// RVA: 0x1F411B8 Offset: 0x1F3D1B8 VA: 0x1F411B8
	private void set_IsAreaeRadication(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F411C4 Offset: 0x1F3D1C4 VA: 0x1F411C4
	public int get_AreaGauge() { }

	[CompilerGenerated]
	// RVA: 0x1F411CC Offset: 0x1F3D1CC VA: 0x1F411CC
	private void set_AreaGauge(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F411D4 Offset: 0x1F3D1D4 VA: 0x1F411D4
	public int get_AreaGaugeMax() { }

	[CompilerGenerated]
	// RVA: 0x1F411DC Offset: 0x1F3D1DC VA: 0x1F411DC
	private void set_AreaGaugeMax(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F411E4 Offset: 0x1F3D1E4 VA: 0x1F411E4
	public int get_BonusGauge() { }

	[CompilerGenerated]
	// RVA: 0x1F411EC Offset: 0x1F3D1EC VA: 0x1F411EC
	private void set_BonusGauge(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F411F4 Offset: 0x1F3D1F4 VA: 0x1F411F4
	public int get_BonusGaugeMax() { }

	[CompilerGenerated]
	// RVA: 0x1F411FC Offset: 0x1F3D1FC VA: 0x1F411FC
	private void set_BonusGaugeMax(int value) { }

	// RVA: 0x1F41204 Offset: 0x1F3D204 VA: 0x1F41204
	public bool get_IsEnabledBonusGame() { }

	// RVA: 0x1F41214 Offset: 0x1F3D214 VA: 0x1F41214
	public void ForcingStaminaGaugeEvent() { }

	// RVA: 0x1F41278 Offset: 0x1F3D278 VA: 0x1F41278
	public void BonusGameEnd(Dictionary<int, int> result, byte gameState) { }

	// RVA: 0x1F41330 Offset: 0x1F3D330 VA: 0x1F41330
	public void SetAreaPopData(AreaPopData areaPop) { }

	// RVA: 0x1F41378 Offset: 0x1F3D378 VA: 0x1F41378
	public void SetAreaGauge(int currentStaminaGauge) { }

	// RVA: 0x1F413B4 Offset: 0x1F3D3B4 VA: 0x1F413B4
	public void SetAreaGauge(int currentAreaGauge, int maxAreaGauge) { }

	// RVA: 0x1F41540 Offset: 0x1F3D540 VA: 0x1F41540
	public void SetBonusGauge(int currentSuppressionGauge) { }

	// RVA: 0x1F41394 Offset: 0x1F3D394 VA: 0x1F41394
	public void SetBonusGauge(int currentSuppressionGauge, int maxSuppretionGauge) { }

	// RVA: 0x1F4187C Offset: 0x1F3D87C VA: 0x1F4187C
	public void BonusGameReward(AreaBonusRewardEvent reward) { }

	// RVA: 0x1F419D4 Offset: 0x1F3D9D4 VA: 0x1F419D4 Slot: 4
	public void OnEnter() { }

	// RVA: 0x1F419D8 Offset: 0x1F3D9D8 VA: 0x1F419D8 Slot: 5
	public void OnLeave() { }

	[CompilerGenerated]
	// RVA: 0x1F419E4 Offset: 0x1F3D9E4 VA: 0x1F419E4
	private void <.ctor>b__5_0(int x, int y) { }

	[CompilerGenerated]
	// RVA: 0x1F419F8 Offset: 0x1F3D9F8 VA: 0x1F419F8
	private void <.ctor>b__5_1(int x, int y) { }

	[CompilerGenerated]
	// RVA: 0x1F41A14 Offset: 0x1F3DA14 VA: 0x1F41A14
	private void <.ctor>b__5_2() { }

	[CompilerGenerated]
	// RVA: 0x1F41A24 Offset: 0x1F3DA24 VA: 0x1F41A24
	private void <.ctor>b__5_3() { }

	[CompilerGenerated]
	// RVA: 0x1F41A30 Offset: 0x1F3DA30 VA: 0x1F41A30
	private void <.ctor>b__5_4() { }

	[CompilerGenerated]
	// RVA: 0x1F41A38 Offset: 0x1F3DA38 VA: 0x1F41A38
	private void <.ctor>b__5_5(RewardResponseDatav2 x) { }

	[CompilerGenerated]
	// RVA: 0x1F41A44 Offset: 0x1F3DA44 VA: 0x1F41A44
	private void <.ctor>b__5_6() { }

	[CompilerGenerated]
	// RVA: 0x1F41A50 Offset: 0x1F3DA50 VA: 0x1F41A50
	private void <.ctor>b__5_7() { }

	[CompilerGenerated]
	// RVA: 0x1F41A5C Offset: 0x1F3DA5C VA: 0x1F41A5C
	private void <.ctor>b__5_8() { }
}
