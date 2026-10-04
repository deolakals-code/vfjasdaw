// Assembly: mscorlib.dll
// Namespace: System.Reflection
public struct CustomAttributeTypedArgument // TypeDefIndex: 10632
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ArgumentType>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x8

	// Properties
	public Type ArgumentType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x2F31838 Offset: 0x2F2D838 VA: 0x2F31838
	public void .ctor(object value) { }

	// RVA: 0x2F2AD24 Offset: 0x2F26D24 VA: 0x2F2AD24
	public void .ctor(Type argumentType, object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2F31988 Offset: 0x2F2D988 VA: 0x2F31988
	public Type get_ArgumentType() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2F31990 Offset: 0x2F2D990 VA: 0x2F31990
	public object get_Value() { }

	// RVA: 0x2F31998 Offset: 0x2F2D998 VA: 0x2F31998 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F31A08 Offset: 0x2F2DA08 VA: 0x2F31A08 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F31A6C Offset: 0x2F2DA6C VA: 0x2F31A6C
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x2F31AE4 Offset: 0x2F2DAE4 VA: 0x2F31AE4
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x2F31B60 Offset: 0x2F2DB60 VA: 0x2F31B60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2F30EF0 Offset: 0x2F2CEF0 VA: 0x2F30EF0
	internal string ToString(bool typed) { }

	// RVA: 0x2F318D0 Offset: 0x2F2D8D0 VA: 0x2F318D0
	private static object CanonicalizeValue(object value) { }
}
