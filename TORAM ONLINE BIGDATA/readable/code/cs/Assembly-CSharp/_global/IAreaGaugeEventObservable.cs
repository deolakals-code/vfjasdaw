// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IAreaGaugeEventObservable // TypeDefIndex: 1063
{
	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void add_AreaProgressEvent(Action<byte> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void remove_AreaProgressEvent(Action<byte> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_AreaGaugeChangeEvent(Action<int, int> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_AreaGaugeChangeEvent(Action<int, int> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void add_BonusGaugeChangeEvent(Action<int, int> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void remove_BonusGaugeChangeEvent(Action<int, int> value);
}
