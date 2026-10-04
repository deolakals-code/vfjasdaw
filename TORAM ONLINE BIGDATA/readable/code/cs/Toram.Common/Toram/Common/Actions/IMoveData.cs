// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public interface IMoveData // TypeDefIndex: 13187
{
	// Properties
	public abstract short[] Position { get; }
	public abstract short Rotation { get; }
	public abstract short Speed { get; }
	public abstract bool IsSpeed { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract short[] get_Position();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract short get_Rotation();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract short get_Speed();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsSpeed();
}
