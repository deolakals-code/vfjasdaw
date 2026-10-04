// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations
public interface IParamData // TypeDefIndex: 11355
{
	// Properties
	public abstract byte ParamId { get; }
	public abstract string ParamName { get; }
	public abstract byte ParameterSlot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte get_ParamId();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ParamName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte get_ParameterSlot();
}
