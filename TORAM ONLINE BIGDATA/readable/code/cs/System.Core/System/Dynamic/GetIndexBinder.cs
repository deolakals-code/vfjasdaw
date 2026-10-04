// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class GetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15784
{
	// Methods

	// RVA: 0x3188BE0 Offset: 0x3184BE0 VA: 0x3188BE0 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3188C98 Offset: 0x3184C98 VA: 0x3188C98
	public DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject errorSuggestion);
}
