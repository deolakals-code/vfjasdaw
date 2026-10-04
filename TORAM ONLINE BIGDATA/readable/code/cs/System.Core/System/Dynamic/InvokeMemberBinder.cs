// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class InvokeMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15788
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <IgnoreCase>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public bool IgnoreCase { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3188F50 Offset: 0x3184F50 VA: 0x3188F50
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3188F58 Offset: 0x3184F58 VA: 0x3188F58
	public bool get_IgnoreCase() { }

	// RVA: 0x3188F60 Offset: 0x3184F60 VA: 0x3188F60 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x318799C Offset: 0x318399C VA: 0x318799C
	public DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackInvokeMember(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DynamicMetaObject FallbackInvoke(DynamicMetaObject target, DynamicMetaObject[] args, DynamicMetaObject errorSuggestion);
}
