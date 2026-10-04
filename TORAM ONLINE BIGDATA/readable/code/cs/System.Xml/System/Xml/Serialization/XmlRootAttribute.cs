// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(9244)]
public class XmlRootAttribute : Attribute // TypeDefIndex: 13531
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x33FA108 Offset: 0x33F6108 VA: 0x33FA108
	public void .ctor() { }

	// RVA: 0x33FA118 Offset: 0x33F6118 VA: 0x33FA118
	public void .ctor(string elementName) { }

	// RVA: 0x33FA150 Offset: 0x33F6150 VA: 0x33FA150
	public string get_DataType() { }

	// RVA: 0x33FA1A4 Offset: 0x33F61A4 VA: 0x33FA1A4
	public void set_DataType(string value) { }

	// RVA: 0x33F601C Offset: 0x33F201C VA: 0x33F601C
	public string get_ElementName() { }

	// RVA: 0x33FA1AC Offset: 0x33F61AC VA: 0x33FA1AC
	public void set_ElementName(string value) { }

	// RVA: 0x33FA1B4 Offset: 0x33F61B4 VA: 0x33FA1B4
	public bool get_IsNullable() { }

	// RVA: 0x33FA1BC Offset: 0x33F61BC VA: 0x33FA1BC
	public void set_IsNullable(bool value) { }

	// RVA: 0x33FA1C8 Offset: 0x33F61C8 VA: 0x33FA1C8
	public string get_Namespace() { }

	// RVA: 0x33FA1D0 Offset: 0x33F61D0 VA: 0x33FA1D0
	public void set_Namespace(string value) { }

	// RVA: 0x33F0EAC Offset: 0x33ECEAC VA: 0x33F0EAC
	internal void AddKeyHash(StringBuilder sb) { }
}
