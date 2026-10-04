// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class DeleteMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15768
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
	// RVA: 0x3182EF0 Offset: 0x317EEF0 VA: 0x3182EF0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3182EF8 Offset: 0x317EEF8 VA: 0x3182EF8
	public bool get_IgnoreCase() { }

	// RVA: 0x3182F00 Offset: 0x317EF00 VA: 0x3182F00
	public DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackDeleteMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x3182F10 Offset: 0x317EF10 VA: 0x3182F10 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
