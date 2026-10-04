// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 13507
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x33EDCE0 Offset: 0x33E9CE0 VA: 0x33EDCE0
	public void .ctor() { }

	// RVA: 0x33EDCF0 Offset: 0x33E9CF0 VA: 0x33EDCF0
	public string get_Name() { }

	// RVA: 0x33EDD44 Offset: 0x33E9D44 VA: 0x33EDD44
	public string get_Namespace() { }

	// RVA: 0x33EDD4C Offset: 0x33E9D4C VA: 0x33EDD4C
	public int get_Order() { }

	// RVA: 0x33EDD54 Offset: 0x33E9D54 VA: 0x33EDD54
	internal void AddKeyHash(StringBuilder sb) { }
}
