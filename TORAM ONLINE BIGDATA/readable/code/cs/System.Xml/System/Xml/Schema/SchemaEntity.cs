// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 13721
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0x3309BB8 Offset: 0x3305BB8 VA: 0x3309BB8
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x3309C54 Offset: 0x3305C54 VA: 0x3309C54 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x3309C70 Offset: 0x3305C70 VA: 0x3309C70 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x3309C78 Offset: 0x3305C78 VA: 0x3309C78 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x3309C80 Offset: 0x3305C80 VA: 0x3309C80 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x3309CA8 Offset: 0x3305CA8 VA: 0x3309CA8 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x3309CB0 Offset: 0x3305CB0 VA: 0x3309CB0 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x3309D58 Offset: 0x3305D58 VA: 0x3309D58 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x3309E00 Offset: 0x3305E00 VA: 0x3309E00 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x3309E08 Offset: 0x3305E08 VA: 0x3309E08 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x3309E10 Offset: 0x3305E10 VA: 0x3309E10 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x3309E18 Offset: 0x3305E18 VA: 0x3309E18 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x3309E20 Offset: 0x3305E20 VA: 0x3309E20 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x3309E28 Offset: 0x3305E28 VA: 0x3309E28
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x3309F24 Offset: 0x3305F24 VA: 0x3309F24
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x3309F2C Offset: 0x3305F2C VA: 0x3309F2C
	internal string get_Url() { }

	// RVA: 0x3309F34 Offset: 0x3305F34 VA: 0x3309F34
	internal void set_Url(string value) { }

	// RVA: 0x3309F58 Offset: 0x3305F58 VA: 0x3309F58
	internal string get_Pubid() { }

	// RVA: 0x3309F60 Offset: 0x3305F60 VA: 0x3309F60
	internal void set_Pubid(string value) { }

	// RVA: 0x3309F68 Offset: 0x3305F68 VA: 0x3309F68
	internal bool get_IsExternal() { }

	// RVA: 0x3309F70 Offset: 0x3305F70 VA: 0x3309F70
	internal void set_IsExternal(bool value) { }

	// RVA: 0x3309F7C Offset: 0x3305F7C VA: 0x3309F7C
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x3309F84 Offset: 0x3305F84 VA: 0x3309F84
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x3309F90 Offset: 0x3305F90 VA: 0x3309F90
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x3309F98 Offset: 0x3305F98 VA: 0x3309F98
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x3309FA0 Offset: 0x3305FA0 VA: 0x3309FA0
	internal string get_Text() { }

	// RVA: 0x3309FA8 Offset: 0x3305FA8 VA: 0x3309FA8
	internal void set_Text(string value) { }

	// RVA: 0x3309FC8 Offset: 0x3305FC8 VA: 0x3309FC8
	internal int get_Line() { }

	// RVA: 0x3309FD0 Offset: 0x3305FD0 VA: 0x3309FD0
	internal void set_Line(int value) { }

	// RVA: 0x3309FD8 Offset: 0x3305FD8 VA: 0x3309FD8
	internal int get_Pos() { }

	// RVA: 0x3309FE0 Offset: 0x3305FE0 VA: 0x3309FE0
	internal void set_Pos(int value) { }

	// RVA: 0x3309D04 Offset: 0x3305D04 VA: 0x3309D04
	internal string get_BaseURI() { }

	// RVA: 0x3309FE8 Offset: 0x3305FE8 VA: 0x3309FE8
	internal void set_BaseURI(string value) { }

	// RVA: 0x3309FF0 Offset: 0x3305FF0 VA: 0x3309FF0
	internal bool get_ParsingInProgress() { }

	// RVA: 0x3309FF8 Offset: 0x3305FF8 VA: 0x3309FF8
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x3309DAC Offset: 0x3305DAC VA: 0x3309DAC
	internal string get_DeclaredURI() { }

	// RVA: 0x330A004 Offset: 0x3306004 VA: 0x330A004
	internal void set_DeclaredURI(string value) { }
}
