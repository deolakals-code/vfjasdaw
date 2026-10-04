// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class BinaryOperationBinder : DynamicMetaObjectBinder // TypeDefIndex: 15756
{
	// Fields
	[CompilerGenerated]
	private readonly ExpressionType <Operation>k__BackingField; // 0x18

	// Properties
	public ExpressionType Operation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3181984 Offset: 0x317D984 VA: 0x3181984
	public ExpressionType get_Operation() { }

	// RVA: 0x318198C Offset: 0x317D98C VA: 0x318198C
	public DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackBinaryOperation(DynamicMetaObject target, DynamicMetaObject arg, DynamicMetaObject errorSuggestion);

	// RVA: 0x318199C Offset: 0x317D99C VA: 0x318199C Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
