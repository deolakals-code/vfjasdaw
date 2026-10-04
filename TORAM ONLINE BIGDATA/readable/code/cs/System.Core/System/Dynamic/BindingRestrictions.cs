// Assembly: System.Core.dll
// Namespace: System.Dynamic
[DebuggerDisplay("{DebugView}")]
[DebuggerTypeProxy(typeof(BindingRestrictions.BindingRestrictionsProxy))]
public abstract class BindingRestrictions // TypeDefIndex: 15764
{
	// Fields
	public static readonly BindingRestrictions Empty; // 0x0

	// Methods

	// RVA: 0x3181A84 Offset: 0x317DA84 VA: 0x3181A84
	private void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Expression GetExpression();

	// RVA: 0x3181A8C Offset: 0x317DA8C VA: 0x3181A8C
	public BindingRestrictions Merge(BindingRestrictions restrictions) { }

	// RVA: 0x3181C04 Offset: 0x317DC04 VA: 0x3181C04
	public static BindingRestrictions GetTypeRestriction(Expression expression, Type type) { }

	// RVA: 0x3181D44 Offset: 0x317DD44 VA: 0x3181D44
	internal static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj) { }

	// RVA: 0x3181E8C Offset: 0x317DE8C VA: 0x3181E8C
	public static BindingRestrictions GetInstanceRestriction(Expression expression, object instance) { }

	// RVA: 0x3181FD4 Offset: 0x317DFD4 VA: 0x3181FD4
	public Expression ToExpression() { }

	// RVA: 0x3181FE0 Offset: 0x317DFE0 VA: 0x3181FE0
	private static void .cctor() { }
}
