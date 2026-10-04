// Assembly: System.Xml.dll
// Namespace: System.Xml
[DefaultMember("Item")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XmlReader : IDisposable // TypeDefIndex: 13327
{
	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x3391B68 Offset: 0x338DB68 VA: 0x3391B68 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x3391B70 Offset: 0x338DB70 VA: 0x3391B70 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsEmptyElement();

	// RVA: 0x3391C54 Offset: 0x338DC54 VA: 0x3391C54 Slot: 15
	public virtual bool get_IsDefault() { }

	// RVA: 0x3391C5C Offset: 0x338DC5C VA: 0x3391C5C Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x3391C64 Offset: 0x338DC64 VA: 0x3391C64 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x3391C6C Offset: 0x338DC6C VA: 0x3391C6C Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0x3391CB4 Offset: 0x338DCB4 VA: 0x3391CB4 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x3391CFC Offset: 0x338DCFC VA: 0x3391CFC Slot: 20
	public virtual Type get_ValueType() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool MoveToAttribute(string name);

	// RVA: 0x3391D68 Offset: 0x338DD68 VA: 0x3391D68 Slot: 26
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool get_EOF();

	// RVA: 0x3391E34 Offset: 0x338DE34 VA: 0x3391E34 Slot: 33
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract ReadState get_ReadState();

	// RVA: 0x3391E38 Offset: 0x338DE38 VA: 0x3391E38 Slot: 35
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x3391F40 Offset: 0x338DF40 VA: 0x3391F40 Slot: 38
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void ResolveEntity();

	// RVA: 0x3391F48 Offset: 0x338DF48 VA: 0x3391F48 Slot: 40
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x3391F50 Offset: 0x338DF50 VA: 0x3391F50 Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsable(1)]
	// RVA: 0x3391FA8 Offset: 0x338DFA8 VA: 0x3391FA8 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0x33921E0 Offset: 0x338E1E0 VA: 0x33921E0 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x3392264 Offset: 0x338E264 VA: 0x3392264 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsable(1)]
	// RVA: 0x3392358 Offset: 0x338E358 VA: 0x3392358 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0x33925D4 Offset: 0x338E5D4 VA: 0x33925D4 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0x33926C8 Offset: 0x338E6C8 VA: 0x33926C8 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x339274C Offset: 0x338E74C VA: 0x339274C Slot: 48
	public virtual string ReadInnerXml() { }

	// RVA: 0x3392B4C Offset: 0x338EB4C VA: 0x3392B4C
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x3392A78 Offset: 0x338EA78 VA: 0x3392A78
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x3392A04 Offset: 0x338EA04 VA: 0x3392A04
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x3392F94 Offset: 0x338EF94 VA: 0x3392F94
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x339309C Offset: 0x338F09C VA: 0x339309C Slot: 49
	public virtual bool get_HasAttributes() { }

	// RVA: 0x338A84C Offset: 0x338684C VA: 0x338A84C Slot: 4
	public void Dispose() { }

	// RVA: 0x33930C0 Offset: 0x338F0C0 VA: 0x33930C0 Slot: 50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3393104 Offset: 0x338F104 VA: 0x3393104 Slot: 51
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x339217C Offset: 0x338E17C VA: 0x339217C
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x339310C Offset: 0x338F10C VA: 0x339310C
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x3391E6C Offset: 0x338DE6C VA: 0x3391E6C
	private bool SkipSubtree() { }

	// RVA: 0x3393170 Offset: 0x338F170 VA: 0x3393170
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x3393250 Offset: 0x338F250 VA: 0x3393250 Slot: 52
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x3393258 Offset: 0x338F258 VA: 0x3393258
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x3393490 Offset: 0x338F490 VA: 0x3393490
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x339363C Offset: 0x338F63C VA: 0x339363C
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x3393954 Offset: 0x338F954 VA: 0x3393954
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x3389DF0 Offset: 0x3385DF0 VA: 0x3389DF0
	protected void .ctor() { }

	// RVA: 0x3393AD4 Offset: 0x338FAD4 VA: 0x3393AD4
	private static void .cctor() { }
}
