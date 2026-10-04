// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class DynamicMetaObjectBinder : CallSiteBinder // TypeDefIndex: 15770
{
	// Properties
	public virtual Type ReturnType { get; }
	internal virtual bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x3183A54 Offset: 0x317FA54 VA: 0x3183A54
	protected void .ctor() { }

	// RVA: 0x3183AAC Offset: 0x317FAAC VA: 0x3183AAC Slot: 6
	public virtual Type get_ReturnType() { }

	// RVA: 0x3183B18 Offset: 0x317FB18 VA: 0x3183B18 Slot: 4
	public sealed override Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel) { }

	// RVA: 0x3184118 Offset: 0x3180118 VA: 0x3184118
	private static DynamicMetaObject[] CreateArgumentMetaObjects(object[] args, ReadOnlyCollection<ParameterExpression> parameters) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args);

	// RVA: 0x31842BC Offset: 0x31802BC VA: 0x31842BC
	public Expression GetUpdateExpression(Type type) { }

	// RVA: 0x318437C Offset: 0x318037C VA: 0x318437C Slot: 8
	internal virtual bool get_IsStandardBinder() { }
}
