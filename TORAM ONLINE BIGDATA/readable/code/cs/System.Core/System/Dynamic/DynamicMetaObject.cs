// Assembly: System.Core.dll
// Namespace: System.Dynamic
public class DynamicMetaObject // TypeDefIndex: 15769
{
	// Fields
	public static readonly DynamicMetaObject[] EmptyMetaObjects; // 0x0
	private static readonly object s_noValueSentinel; // 0x8
	private readonly object _value; // 0x10
	[CompilerGenerated]
	private readonly Expression <Expression>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly BindingRestrictions <Restrictions>k__BackingField; // 0x20

	// Properties
	public Expression Expression { get; }
	public BindingRestrictions Restrictions { get; }
	public object Value { get; }
	public bool HasValue { get; }
	public Type RuntimeType { get; }
	public Type LimitType { get; }

	// Methods

	// RVA: 0x3182FC0 Offset: 0x317EFC0 VA: 0x3182FC0
	public void .ctor(Expression expression, BindingRestrictions restrictions) { }

	// RVA: 0x31830B0 Offset: 0x317F0B0 VA: 0x31830B0
	public void .ctor(Expression expression, BindingRestrictions restrictions, object value) { }

	[CompilerGenerated]
	// RVA: 0x31830DC Offset: 0x317F0DC VA: 0x31830DC
	public Expression get_Expression() { }

	[CompilerGenerated]
	// RVA: 0x31830E4 Offset: 0x317F0E4 VA: 0x31830E4
	public BindingRestrictions get_Restrictions() { }

	// RVA: 0x3181E00 Offset: 0x317DE00 VA: 0x3181E00
	public object get_Value() { }

	// RVA: 0x3181E24 Offset: 0x317DE24 VA: 0x3181E24
	public bool get_HasValue() { }

	// RVA: 0x31830EC Offset: 0x317F0EC VA: 0x31830EC
	public Type get_RuntimeType() { }

	// RVA: 0x3181F18 Offset: 0x317DF18 VA: 0x3181F18
	public Type get_LimitType() { }

	// RVA: 0x3183164 Offset: 0x317F164 VA: 0x3183164 Slot: 4
	public virtual DynamicMetaObject BindConvert(ConvertBinder binder) { }

	// RVA: 0x31831DC Offset: 0x317F1DC VA: 0x31831DC Slot: 5
	public virtual DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x318324C Offset: 0x317F24C VA: 0x318324C Slot: 6
	public virtual DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x31832C4 Offset: 0x317F2C4 VA: 0x31832C4 Slot: 7
	public virtual DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	// RVA: 0x318333C Offset: 0x317F33C VA: 0x318333C Slot: 8
	public virtual DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x31833B4 Offset: 0x317F3B4 VA: 0x31833B4 Slot: 9
	public virtual DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }

	// RVA: 0x318343C Offset: 0x317F43C VA: 0x318343C Slot: 10
	public virtual DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }

	// RVA: 0x31834BC Offset: 0x317F4BC VA: 0x31834BC Slot: 11
	public virtual DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x3183534 Offset: 0x317F534 VA: 0x3183534 Slot: 12
	public virtual DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x31835AC Offset: 0x317F5AC VA: 0x31835AC Slot: 13
	public virtual DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x318362C Offset: 0x317F62C VA: 0x318362C Slot: 14
	public virtual DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }

	// RVA: 0x318369C Offset: 0x317F69C VA: 0x318369C Slot: 15
	public virtual DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }

	// RVA: 0x318371C Offset: 0x317F71C VA: 0x318371C Slot: 16
	public virtual IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x31837A8 Offset: 0x317F7A8 VA: 0x31837A8
	public static DynamicMetaObject Create(object value, Expression expression) { }

	// RVA: 0x3183964 Offset: 0x317F964 VA: 0x3183964
	private static void .cctor() { }
}
