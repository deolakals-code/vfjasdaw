// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class SetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15790
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public sealed override Type ReturnType { get; }
	public string Name { get; }
	public bool IgnoreCase { get; }
	internal sealed override bool IsStandardBinder { get; }

	// Methods

	// RVA: 0x3189154 Offset: 0x3185154 VA: 0x3189154
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x31891D4 Offset: 0x31851D4 VA: 0x31891D4 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x3189240 Offset: 0x3185240 VA: 0x3189240
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3189248 Offset: 0x3185248 VA: 0x3189248
	public bool get_IgnoreCase() { }

	// RVA: 0x3189250 Offset: 0x3185250 VA: 0x3189250 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3189324 Offset: 0x3185324 VA: 0x3189324 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }

	// RVA: 0x318932C Offset: 0x318532C VA: 0x318932C
	public DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion);
}
