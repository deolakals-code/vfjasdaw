// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopAreaBonusSender : MonoBehaviour, IBonusGameEventObservable, IAreaGaugeEventObservable, IBonusEventController // TypeDefIndex: 1073
{
	// Fields
	private int recordAreaGauge; // 0x20
	private int maxAreaGauge; // 0x24
	private readonly int[] AreagaugeThreshold; // 0x28
	private int recordBonusGauge; // 0x30
	private int maxBonusGauge; // 0x34
	private readonly int[] BonusgaugeThreshold; // 0x38
	[CompilerGenerated]
	private Action<int, int> AreaGaugeChangeEvent; // 0x40
	[CompilerGenerated]
	private Action<byte> AreaProgressEvent; // 0x48
	[CompilerGenerated]
	private Action<int, int> BonusGaugeChangeEvent; // 0x50
	[CompilerGenerated]
	private Action BonusGameEndEvent; // 0x58
	[CompilerGenerated]
	private Action BonusCompleteEvent; // 0x60
	[CompilerGenerated]
	private Action<byte> BonusProgressEvent; // 0x68
	[CompilerGenerated]
	private Action BonusGameStartEvent; // 0x70
	[CompilerGenerated]
	private Action BonusGameFirstTapEvent; // 0x78
	[CompilerGenerated]
	private Action<RewardResponseDatav2> BonusGameRewardEvent; // 0x80
	[CompilerGenerated]
	private Action BonusAllEndEvent; // 0x88
	[CompilerGenerated]
	private Action BonusGameRewardEndEvent; // 0x90
	[CompilerGenerated]
	private Action<int, RewardResponseDatav2> OtherBonusGameRewardEvent; // 0x98
	[CompilerGenerated]
	private Action BonusAbortEvent; // 0xA0

	// Methods

	// RVA: 0x1F424CC Offset: 0x1F3E4CC VA: 0x1F424CC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1F40B68 Offset: 0x1F3CB68 VA: 0x1F40B68 Slot: 26
	public void add_AreaGaugeChangeEvent(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x1F425A4 Offset: 0x1F3E5A4 VA: 0x1F425A4 Slot: 27
	public void remove_AreaGaugeChangeEvent(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x1F42654 Offset: 0x1F3E654 VA: 0x1F42654 Slot: 24
	public void add_AreaProgressEvent(Action<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x1F42704 Offset: 0x1F3E704 VA: 0x1F42704 Slot: 25
	public void remove_AreaProgressEvent(Action<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x1F40C18 Offset: 0x1F3CC18 VA: 0x1F40C18 Slot: 28
	public void add_BonusGaugeChangeEvent(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x1F427B4 Offset: 0x1F3E7B4 VA: 0x1F427B4 Slot: 29
	public void remove_BonusGaugeChangeEvent(Action<int, int> value) { }

	[CompilerGenerated]
	// RVA: 0x1F40F4C Offset: 0x1F3CF4C VA: 0x1F40F4C Slot: 12
	public void add_BonusGameEndEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42864 Offset: 0x1F3E864 VA: 0x1F42864 Slot: 13
	public void remove_BonusGameEndEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F40CC8 Offset: 0x1F3CCC8 VA: 0x1F40CC8 Slot: 6
	public void add_BonusCompleteEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42900 Offset: 0x1F3E900 VA: 0x1F42900 Slot: 7
	public void remove_BonusCompleteEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F4299C Offset: 0x1F3E99C VA: 0x1F4299C Slot: 4
	public void add_BonusProgressEvent(Action<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x1F42A4C Offset: 0x1F3EA4C VA: 0x1F42A4C Slot: 5
	public void remove_BonusProgressEvent(Action<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x1F40D64 Offset: 0x1F3CD64 VA: 0x1F40D64 Slot: 8
	public void add_BonusGameStartEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42AFC Offset: 0x1F3EAFC VA: 0x1F42AFC Slot: 9
	public void remove_BonusGameStartEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F40E00 Offset: 0x1F3CE00 VA: 0x1F40E00 Slot: 10
	public void add_BonusGameFirstTapEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42B98 Offset: 0x1F3EB98 VA: 0x1F42B98 Slot: 11
	public void remove_BonusGameFirstTapEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F40E9C Offset: 0x1F3CE9C VA: 0x1F40E9C Slot: 14
	public void add_BonusGameRewardEvent(Action<RewardResponseDatav2> value) { }

	[CompilerGenerated]
	// RVA: 0x1F42C34 Offset: 0x1F3EC34 VA: 0x1F42C34 Slot: 15
	public void remove_BonusGameRewardEvent(Action<RewardResponseDatav2> value) { }

	[CompilerGenerated]
	// RVA: 0x1F41084 Offset: 0x1F3D084 VA: 0x1F41084 Slot: 20
	public void add_BonusAllEndEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42CE4 Offset: 0x1F3ECE4 VA: 0x1F42CE4 Slot: 21
	public void remove_BonusAllEndEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F40FE8 Offset: 0x1F3CFE8 VA: 0x1F40FE8 Slot: 18
	public void add_BonusGameRewardEndEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42D80 Offset: 0x1F3ED80 VA: 0x1F42D80 Slot: 19
	public void remove_BonusGameRewardEndEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F42E1C Offset: 0x1F3EE1C VA: 0x1F42E1C Slot: 16
	public void add_OtherBonusGameRewardEvent(Action<int, RewardResponseDatav2> value) { }

	[CompilerGenerated]
	// RVA: 0x1F42ECC Offset: 0x1F3EECC VA: 0x1F42ECC Slot: 17
	public void remove_OtherBonusGameRewardEvent(Action<int, RewardResponseDatav2> value) { }

	[CompilerGenerated]
	// RVA: 0x1F42F7C Offset: 0x1F3EF7C VA: 0x1F42F7C Slot: 22
	public void add_BonusAbortEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1F43018 Offset: 0x1F3F018 VA: 0x1F43018 Slot: 23
	public void remove_BonusAbortEvent(Action value) { }

	// RVA: 0x1F4122C Offset: 0x1F3D22C VA: 0x1F4122C
	public void ForcingCurrentStaminaEvent() { }

	// RVA: 0x1F430B4 Offset: 0x1F3F0B4 VA: 0x1F430B4 Slot: 30
	public void BonusGameEnd(Dictionary<int, int> result, byte gameState) { }

	// RVA: 0x1F413AC Offset: 0x1F3D3AC VA: 0x1F413AC
	public void SetAreaGauge(int currentAreaGauge) { }

	// RVA: 0x1F413CC Offset: 0x1F3D3CC VA: 0x1F413CC
	public void SetAreaGauge(int currentAreaGauge, int maxAreaGauge) { }

	// RVA: 0x1F4155C Offset: 0x1F3D55C VA: 0x1F4155C
	public void SetBonusGauge(int currentBonusGauge) { }

	// RVA: 0x1F41564 Offset: 0x1F3D564 VA: 0x1F41564
	public void SetBonusGauge(int currentBonusGauge, int maxBonusGauge) { }

	// RVA: 0x1F43428 Offset: 0x1F3F428 VA: 0x1F43428 Slot: 32
	public void BonusGameStart() { }

	// RVA: 0x1F41998 Offset: 0x1F3D998 VA: 0x1F41998
	public void BonusGameReward(RewardResponseDatav2 reward) { }

	// RVA: 0x1F419B8 Offset: 0x1F3D9B8 VA: 0x1F419B8
	public void OtherBonusGameReward(int id, RewardResponseDatav2 reward) { }

	// RVA: 0x1F434CC Offset: 0x1F3F4CC VA: 0x1F434CC Slot: 33
	public void BonusAllEnd() { }

	// RVA: 0x1F434E8 Offset: 0x1F3F4E8 VA: 0x1F434E8 Slot: 31
	public void BonusGameRewardEnd() { }

	// RVA: 0x1F43504 Offset: 0x1F3F504 VA: 0x1F43504 Slot: 34
	public void BonusAbort() { }

	// RVA: 0x1F43520 Offset: 0x1F3F520 VA: 0x1F43520 Slot: 35
	public void BonusFirstTap() { }

	[IteratorStateMachine(typeof(PopAreaBonusSender.<BonusGameRewardWait>d__59))]
	// RVA: 0x1F43444 Offset: 0x1F3F444 VA: 0x1F43444
	private IEnumerator BonusGameRewardWait(RewardResponseDatav2 reward) { }
}
