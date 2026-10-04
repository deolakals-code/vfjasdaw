// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class CreateInstanceBinder : DynamicMetaObjectBinder // TypeDefIndex: 15766
{
	// Methods

	// RVA: 0x3182D54 Offset: 0x317ED54 VA: 0x3182D54
	public DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackCreateInstance(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x3182D64 Offset: 0x317ED64 VA: 0x3182D64 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
