// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class DeleteIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15767
{
	// Methods

	// RVA: 0x3182E24 Offset: 0x317EE24 VA: 0x3182E24 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3182EE0 Offset: 0x317EEE0 VA: 0x3182EE0
	public DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}
