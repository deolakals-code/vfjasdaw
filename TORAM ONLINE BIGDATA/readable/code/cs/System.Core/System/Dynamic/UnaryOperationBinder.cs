// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class UnaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 15791
{
	// Methods

	// RVA: 0x318933C Offset: 0x318533C VA: 0x318933C
	public DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackUnaryOperation(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x318934C Offset: 0x318534C VA: 0x318934C Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
