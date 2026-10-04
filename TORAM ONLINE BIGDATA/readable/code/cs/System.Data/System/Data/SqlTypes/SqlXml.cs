// Assembly: System.Data.dll
// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 14822
{
	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0x325F7BC Offset: 0x325B7BC VA: 0x325F7BC
	public void .ctor() { }

	// RVA: 0x325F81C Offset: 0x325B81C VA: 0x325F81C
	public XmlReader CreateReader() { }

	// RVA: 0x325FB38 Offset: 0x325BB38 VA: 0x325FB38
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0x325FEF8 Offset: 0x325BEF8 VA: 0x325FEF8
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x325FA14 Offset: 0x325BA14 VA: 0x325FA14
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x325F984 Offset: 0x325B984 VA: 0x325F984 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x325F7F0 Offset: 0x325B7F0 VA: 0x325F7F0
	private void SetNull() { }

	// RVA: 0x325FFF0 Offset: 0x325BFF0 VA: 0x325FFF0 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x325FFF8 Offset: 0x325BFF8 VA: 0x325FFF8 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x32601E4 Offset: 0x325C1E4 VA: 0x32601E4 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x3260334 Offset: 0x325C334 VA: 0x3260334
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x32603C0 Offset: 0x325C3C0 VA: 0x32603C0
	private static void .cctor() { }
}
