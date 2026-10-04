// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class GetMemberBinder : DynamicMetaObjectBinder // TypeDefIndex: 15785
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

	// RVA: 0x3188CA8 Offset: 0x3184CA8 VA: 0x3188CA8
	protected void .ctor(string name, bool ignoreCase) { }

	// RVA: 0x3188D28 Offset: 0x3184D28 VA: 0x3188D28 Slot: 6
	public sealed override Type get_ReturnType() { }

	[CompilerGenerated]
	// RVA: 0x3188D94 Offset: 0x3184D94 VA: 0x3188D94
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x3188D9C Offset: 0x3184D9C VA: 0x3188D9C
	public bool get_IgnoreCase() { }

	// RVA: 0x318783C Offset: 0x318383C VA: 0x318783C
	public DynamicMetaObject FallbackGetMember(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x3188DA4 Offset: 0x3184DA4 VA: 0x3188DA4 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }

	// RVA: 0x3188E80 Offset: 0x3184E80 VA: 0x3188E80 Slot: 8
	internal sealed override bool get_IsStandardBinder() { }
}
