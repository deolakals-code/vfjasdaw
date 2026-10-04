// Assembly: System.Xml.dll
// Namespace: 
internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 13342
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private bool System.Xml.IDtdParserAdapter.IsEof { get; }
	private char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private int System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private int System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private int System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private int System.Xml.IDtdParserAdapter.LineNo { get; }
	private int System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private bool System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private bool System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0x33966F4 Offset: 0x33926F4 VA: 0x33966F4
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x3396724 Offset: 0x3392724 VA: 0x3396724 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x3396740 Offset: 0x3392740 VA: 0x3396740 Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x339675C Offset: 0x339275C VA: 0x339675C Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x3396778 Offset: 0x3392778 VA: 0x3396778 Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x3396794 Offset: 0x3392794 VA: 0x3396794 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x33967B0 Offset: 0x33927B0 VA: 0x33967B0 Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x33967CC Offset: 0x33927CC VA: 0x33967CC Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x33967E8 Offset: 0x33927E8 VA: 0x33967E8 Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x3396804 Offset: 0x3392804 VA: 0x3396804 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x3396820 Offset: 0x3392820 VA: 0x3396820 Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x339683C Offset: 0x339283C VA: 0x339683C Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x3396858 Offset: 0x3392858 VA: 0x3396858 Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x3396874 Offset: 0x3392874 VA: 0x3396874 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x3396890 Offset: 0x3392890 VA: 0x3396890 Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x33968AC Offset: 0x33928AC VA: 0x33968AC Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x33968C8 Offset: 0x33928C8 VA: 0x33968C8 Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x33968E8 Offset: 0x33928E8 VA: 0x33968E8 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x3396904 Offset: 0x3392904 VA: 0x3396904 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x3396920 Offset: 0x3392920 VA: 0x3396920 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x339693C Offset: 0x339293C VA: 0x339693C Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x3396958 Offset: 0x3392958 VA: 0x3396958 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x3396974 Offset: 0x3392974 VA: 0x3396974 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x3396990 Offset: 0x3392990 VA: 0x3396990 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x33969AC Offset: 0x33929AC VA: 0x33969AC Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x33969C8 Offset: 0x33929C8 VA: 0x33969C8 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x33969E4 Offset: 0x33929E4 VA: 0x33969E4 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x3396A00 Offset: 0x3392A00 VA: 0x3396A00 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x3396A1C Offset: 0x3392A1C VA: 0x3396A1C Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x3396A38 Offset: 0x3392A38 VA: 0x3396A38 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x3396A54 Offset: 0x3392A54 VA: 0x3396A54 Slot: 4
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }
}
