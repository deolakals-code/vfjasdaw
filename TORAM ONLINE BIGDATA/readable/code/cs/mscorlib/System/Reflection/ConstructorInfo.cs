// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
public abstract class ConstructorInfo : MethodBase // TypeDefIndex: 10586
{
	// Fields
	public static readonly string ConstructorName; // 0x0
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x2F297D4 Offset: 0x2F257D4 VA: 0x2F297D4
	protected void .ctor() { }

	// RVA: 0x2F297E4 Offset: 0x2F257E4 VA: 0x2F297E4 Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x2F297EC Offset: 0x2F257EC VA: 0x2F297EC
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x2F2980C Offset: 0x2F2580C VA: 0x2F2980C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F2981C Offset: 0x2F2581C VA: 0x2F2981C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F2982C Offset: 0x2F2582C VA: 0x2F2982C
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x2F29858 Offset: 0x2F25858 VA: 0x2F29858
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x2F298EC Offset: 0x2F258EC VA: 0x2F298EC
	private static void .cctor() { }
}
