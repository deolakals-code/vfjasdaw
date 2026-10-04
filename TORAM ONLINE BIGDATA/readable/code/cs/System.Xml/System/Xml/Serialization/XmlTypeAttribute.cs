// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
[Usage(1052)]
public class XmlTypeAttribute : Attribute // TypeDefIndex: 13555
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x340F9DC Offset: 0x340B9DC VA: 0x340F9DC
	public bool get_IncludeInSchema() { }

	// RVA: 0x340F9E4 Offset: 0x340B9E4 VA: 0x340F9E4
	public string get_Namespace() { }

	// RVA: 0x340F9EC Offset: 0x340B9EC VA: 0x340F9EC
	public string get_TypeName() { }

	// RVA: 0x340FA40 Offset: 0x340BA40 VA: 0x340FA40
	internal void AddKeyHash(StringBuilder sb) { }
}
