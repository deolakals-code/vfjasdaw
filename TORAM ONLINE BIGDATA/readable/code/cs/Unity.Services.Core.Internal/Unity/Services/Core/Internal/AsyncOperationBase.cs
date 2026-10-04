// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal abstract class AsyncOperationBase : CustomYieldInstruction // TypeDefIndex: 17551
{
	// Properties
	public override bool keepWaiting { get; }
	public abstract bool IsCompleted { get; }

	// Methods

	// RVA: 0x37AAC94 Offset: 0x37A6C94 VA: 0x37AAC94 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsCompleted();
}
