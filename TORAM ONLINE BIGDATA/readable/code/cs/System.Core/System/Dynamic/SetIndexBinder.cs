// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class SetIndexBinder : DynamicMetaObjectBinder // TypeDefIndex: 15789
{
	// Methods

	// RVA: 0x3189018 Offset: 0x3185018 VA: 0x3189018 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3189144 Offset: 0x3185144 VA: 0x3189144
	public DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetIndex(DynamicMetaObject target, DynamicMetaObject[] indexes, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}
