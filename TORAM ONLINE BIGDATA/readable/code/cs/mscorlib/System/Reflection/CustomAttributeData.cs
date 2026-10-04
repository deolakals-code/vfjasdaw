// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class CustomAttributeData // TypeDefIndex: 10642
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisible(True)]
	public virtual ConstructorInfo Constructor { get; }
	[ComVisible(True)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x2F34A50 Offset: 0x2F30A50 VA: 0x2F34A50
	protected void .ctor() { }

	// RVA: 0x2F34A58 Offset: 0x2F30A58 VA: 0x2F34A58
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x2F34B28 Offset: 0x2F30B28 VA: 0x2F34B28
	internal void .ctor(ConstructorInfo ctorInfo) { }

	// RVA: 0x2F34C34 Offset: 0x2F30C34 VA: 0x2F34C34
	internal void .ctor(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	// RVA: 0x2F34C94 Offset: 0x2F30C94 VA: 0x2F34C94
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x2F34C98 Offset: 0x2F30C98 VA: 0x2F34C98
	private void ResolveArguments() { }

	// RVA: 0x2F34E80 Offset: 0x2F30E80 VA: 0x2F34E80 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x2F34E88 Offset: 0x2F30E88 VA: 0x2F34E88 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x2F34EA0 Offset: 0x2F30EA0 VA: 0x2F34EA0 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x2F34EB8 Offset: 0x2F30EB8 VA: 0x2F34EB8
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x2F34F14 Offset: 0x2F30F14 VA: 0x2F34F14
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x2F34F70 Offset: 0x2F30F70 VA: 0x2F34F70
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x2F34FCC Offset: 0x2F30FCC VA: 0x2F34FCC
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x2F35028 Offset: 0x2F31028 VA: 0x2F35028
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x2F35084 Offset: 0x2F31084 VA: 0x2F35084
	public Type get_AttributeType() { }

	// RVA: 0x2F350A4 Offset: 0x2F310A4 VA: 0x2F350A4 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E42A0 Offset: 0x27E02A0 VA: 0x27E42A0
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x27E43C8 Offset: 0x27E03C8 VA: 0x27E43C8
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	|
	|-RVA: 0x27E44D4 Offset: 0x27E04D4 VA: 0x27E44D4
	|-CustomAttributeData.UnboxValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2F35628 Offset: 0x2F31628 VA: 0x2F35628 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F35CAC Offset: 0x2F31CAC VA: 0x2F35CAC Slot: 2
	public override int GetHashCode() { }
}
