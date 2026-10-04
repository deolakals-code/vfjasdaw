// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class InvokeBinder : DynamicMetaObjectBinder // TypeDefIndex: 15787
{
	// Methods

	// RVA: 0x3188E88 Offset: 0x3184E88 VA: 0x3188E88
	public DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: 0x3188E98 Offset: 0x3184E98 VA: 0x3188E98 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
