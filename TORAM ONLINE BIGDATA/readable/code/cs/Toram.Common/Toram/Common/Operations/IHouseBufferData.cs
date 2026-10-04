// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public interface IHouseBufferData // TypeDefIndex: 11359
{
	// Properties
	public abstract short[] CuisineBuffId { get; }
	public abstract short[] CuisineBuffVal { get; }
	public abstract int CuisineRemainingTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract short[] get_CuisineBuffId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract short[] get_CuisineBuffVal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_CuisineRemainingTime();
}
