// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IBonusGameEventObservable // TypeDefIndex: 1065
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_BonusProgressEvent(Action<byte> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_BonusProgressEvent(Action<byte> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_BonusCompleteEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_BonusCompleteEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_BonusGameStartEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_BonusGameStartEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_BonusGameFirstTapEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_BonusGameFirstTapEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_BonusGameEndEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_BonusGameEndEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_BonusGameRewardEvent(Action<RewardResponseDatav2> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_BonusGameRewardEvent(Action<RewardResponseDatav2> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract void add_OtherBonusGameRewardEvent(Action<int, RewardResponseDatav2> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 13
	public abstract void remove_OtherBonusGameRewardEvent(Action<int, RewardResponseDatav2> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 14
	public abstract void add_BonusGameRewardEndEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 15
	public abstract void remove_BonusGameRewardEndEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 16
	public abstract void add_BonusAllEndEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 17
	public abstract void remove_BonusAllEndEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 18
	public abstract void add_BonusAbortEvent(Action value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	public abstract void remove_BonusAbortEvent(Action value);
}
