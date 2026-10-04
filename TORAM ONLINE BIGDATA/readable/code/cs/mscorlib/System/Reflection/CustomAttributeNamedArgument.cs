// Assembly: mscorlib.dll
// Namespace: System.Reflection
public struct CustomAttributeNamedArgument // TypeDefIndex: 10631
{
	// Fields
	[CompilerGenerated]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <IsField>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x18
	private readonly Type _attributeType; // 0x20
	private MemberInfo _lazyMemberInfo; // 0x28

	// Properties
	public CustomAttributeTypedArgument TypedValue { get; }
	public bool IsField { get; }
	public string MemberName { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x2F304D4 Offset: 0x2F2C4D4 VA: 0x2F304D4
	internal void .ctor(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	// RVA: 0x2F30544 Offset: 0x2F2C544 VA: 0x2F30544
	public void .ctor(MemberInfo memberInfo, object value) { }

	// RVA: 0x2F30790 Offset: 0x2F2C790 VA: 0x2F30790
	public void .ctor(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2F308DC Offset: 0x2F2C8DC VA: 0x2F308DC
	public CustomAttributeTypedArgument get_TypedValue() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x2F308E8 Offset: 0x2F2C8E8 VA: 0x2F308E8
	public bool get_IsField() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2F308F0 Offset: 0x2F2C8F0 VA: 0x2F308F0
	public string get_MemberName() { }

	// RVA: 0x2F308F8 Offset: 0x2F2C8F8 VA: 0x2F308F8
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x2F309E0 Offset: 0x2F2C9E0 VA: 0x2F309E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F30A58 Offset: 0x2F2CA58 VA: 0x2F30A58 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F30AC4 Offset: 0x2F2CAC4 VA: 0x2F30AC4
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x2F30B44 Offset: 0x2F2CB44 VA: 0x2F30B44
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x2F30BC8 Offset: 0x2F2CBC8 VA: 0x2F30BC8 Slot: 3
	public override string ToString() { }
}
