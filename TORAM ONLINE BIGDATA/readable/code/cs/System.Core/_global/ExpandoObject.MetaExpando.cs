// Assembly: System.Core.dll
// Namespace: 
private class ExpandoObject.MetaExpando : DynamicMetaObject // TypeDefIndex: 15780
{
	// Properties
	public ExpandoObject Value { get; }

	// Methods

	// RVA: 0x3186CD4 Offset: 0x3182CD4 VA: 0x3186CD4
	public void .ctor(Expression expression, ExpandoObject value) { }

	// RVA: 0x3186D7C Offset: 0x3182D7C VA: 0x3186D7C
	private DynamicMetaObject BindGetOrInvokeMember(DynamicMetaObjectBinder binder, string name, bool ignoreCase, DynamicMetaObject fallback, Func<DynamicMetaObject, DynamicMetaObject> fallbackInvoke) { }

	// RVA: 0x31877A4 Offset: 0x31837A4 VA: 0x31877A4 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }

	// RVA: 0x318784C Offset: 0x318384C VA: 0x318784C Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }

	// RVA: 0x31879AC Offset: 0x31839AC VA: 0x31879AC Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }

	// RVA: 0x3187EA4 Offset: 0x3183EA4 VA: 0x3187EA4 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }

	[IteratorStateMachine(typeof(ExpandoObject.MetaExpando.<GetDynamicMemberNames>d__6))]
	// RVA: 0x3188158 Offset: 0x3184158 VA: 0x3188158 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }

	// RVA: 0x31874F0 Offset: 0x31834F0 VA: 0x31874F0
	private DynamicMetaObject AddDynamicTestAndDefer(DynamicMetaObjectBinder binder, ExpandoClass klass, ExpandoClass originalClass, DynamicMetaObject succeeds) { }

	// RVA: 0x3187DD4 Offset: 0x3183DD4 VA: 0x3187DD4
	private ExpandoClass GetClassEnsureIndex(string name, bool caseInsensitive, ExpandoObject obj, out ExpandoClass klass, out int index) { }

	// RVA: 0x3187408 Offset: 0x3183408 VA: 0x3187408
	private Expression GetLimitedSelf() { }

	// RVA: 0x3188208 Offset: 0x3184208 VA: 0x3188208
	private BindingRestrictions GetRestrictions() { }

	// RVA: 0x31873A4 Offset: 0x31833A4 VA: 0x31873A4
	public ExpandoObject get_Value() { }
}
