// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 14778
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0x3214ED4 Offset: 0x3210ED4 VA: 0x3214ED4
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0x3214F80 Offset: 0x3210F80 VA: 0x3214F80
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0x3215420 Offset: 0x3211420 VA: 0x3215420
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0x321574C Offset: 0x321174C VA: 0x321574C
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0x321591C Offset: 0x321191C VA: 0x321591C
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0x3215260 Offset: 0x3211260 VA: 0x3215260
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0x3216378 Offset: 0x3212378 VA: 0x3216378
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0x321644C Offset: 0x321244C VA: 0x321644C
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0x3216588 Offset: 0x3212588 VA: 0x3216588
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0x3216700 Offset: 0x3212700 VA: 0x3216700
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0x3215A70 Offset: 0x3211A70 VA: 0x3215A70
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x32170C0 Offset: 0x32130C0 VA: 0x32170C0
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x3217844 Offset: 0x3213844 VA: 0x3217844
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0x3215CA8 Offset: 0x3211CA8 VA: 0x3215CA8
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0x3215A80 Offset: 0x3211A80 VA: 0x3215A80
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0x3217A2C Offset: 0x3213A2C VA: 0x3217A2C
	private static void .cctor() { }
}
