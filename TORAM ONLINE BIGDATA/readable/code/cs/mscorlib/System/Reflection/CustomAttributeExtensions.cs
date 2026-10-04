// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Extension]
public static class CustomAttributeExtensions // TypeDefIndex: 10634
{
	// Methods

	[Extension]
	// RVA: 0x2F31B70 Offset: 0x2F2DB70 VA: 0x2F31B70
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x2F31B78 Offset: 0x2F2DB78 VA: 0x2F31B78
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E4664 Offset: 0x27E0664 VA: 0x27E4664
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E4724 Offset: 0x27E0724 VA: 0x27E4724
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x2F31B80 Offset: 0x2F2DB80 VA: 0x2F31B80
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Extension]
	// RVA: 0x2F31B88 Offset: 0x2F2DB88 VA: 0x2F31B88
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E47E4 Offset: 0x27E07E4 VA: 0x27E47E4
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x2F31B90 Offset: 0x2F2DB90 VA: 0x2F31B90
	public static bool IsDefined(MemberInfo element, Type attributeType) { }
}
