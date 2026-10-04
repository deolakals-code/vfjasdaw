// Assembly: System.Core.dll
// Namespace: System.Dynamic
public abstract class ConvertBinder : DynamicMetaObjectBinder // TypeDefIndex: 15765
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3182C8C Offset: 0x317EC8C VA: 0x3182C8C
	public Type get_Type() { }

	// RVA: 0x3182C94 Offset: 0x317EC94 VA: 0x3182C94
	public DynamicMetaObject FallbackConvert(DynamicMetaObject target) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion);

	// RVA: 0x3182CA4 Offset: 0x317ECA4 VA: 0x3182CA4 Slot: 7
	public sealed override DynamicMetaObject Bind(DynamicMetaObject target, DynamicMetaObject[] args) { }
}
