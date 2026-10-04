// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
public class XmlReflectionMember // TypeDefIndex: 13530
{
	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x33F7D74 Offset: 0x33F3D74 VA: 0x33F7D74
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x33FA0E0 Offset: 0x33F60E0 VA: 0x33FA0E0
	public bool get_IsReturnValue() { }

	// RVA: 0x33FA0E8 Offset: 0x33F60E8 VA: 0x33FA0E8
	public string get_MemberName() { }

	// RVA: 0x33FA0F0 Offset: 0x33F60F0 VA: 0x33FA0F0
	public Type get_MemberType() { }

	// RVA: 0x33F6F90 Offset: 0x33F2F90 VA: 0x33F6F90
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x33FA0F8 Offset: 0x33F60F8 VA: 0x33FA0F8
	internal Type get_DeclaringType() { }

	// RVA: 0x33FA100 Offset: 0x33F6100 VA: 0x33FA100
	internal void set_DeclaringType(Type value) { }
}
