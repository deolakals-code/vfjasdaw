// Assembly: System.Xml.dll
// Namespace: 
private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 13343
{
	// Fields
	private static XmlTextReaderImpl.NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Properties
	internal static XmlTextReaderImpl.NodeData None { get; }
	internal int LineNo { get; }
	internal int LinePos { get; }
	internal bool IsEmptyElement { get; set; }
	internal bool IsDefaultAttribute { get; set; }
	internal bool ValueBuffered { get; }
	internal string StringValue { get; }

	// Methods

	// RVA: 0x3396A70 Offset: 0x3392A70 VA: 0x3396A70
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x3396B18 Offset: 0x3392B18 VA: 0x3396B18
	internal void .ctor() { }

	// RVA: 0x3396BEC Offset: 0x3392BEC VA: 0x3396BEC
	internal int get_LineNo() { }

	// RVA: 0x3396BF4 Offset: 0x3392BF4 VA: 0x3396BF4
	internal int get_LinePos() { }

	// RVA: 0x3396BFC Offset: 0x3392BFC VA: 0x3396BFC
	internal bool get_IsEmptyElement() { }

	// RVA: 0x3396C20 Offset: 0x3392C20 VA: 0x3396C20
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x3396C2C Offset: 0x3392C2C VA: 0x3396C2C
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x3396C50 Offset: 0x3392C50 VA: 0x3396C50
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x3396C5C Offset: 0x3392C5C VA: 0x3396C5C
	internal bool get_ValueBuffered() { }

	// RVA: 0x3396C6C Offset: 0x3392C6C VA: 0x3396C6C
	internal string get_StringValue() { }

	// RVA: 0x3396CB4 Offset: 0x3392CB4 VA: 0x3396CB4
	internal void TrimSpacesInValue() { }

	// RVA: 0x3396B40 Offset: 0x3392B40 VA: 0x3396B40
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x3396D00 Offset: 0x3392D00 VA: 0x3396D00
	internal void ClearName() { }

	// RVA: 0x3396D9C Offset: 0x3392D9C VA: 0x3396D9C
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x3396DA8 Offset: 0x3392DA8 VA: 0x3396DA8
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x3396DB4 Offset: 0x3392DB4 VA: 0x3396DB4
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x3396DF0 Offset: 0x3392DF0 VA: 0x3396DF0
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x3396E48 Offset: 0x3392E48 VA: 0x3396E48
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x3396EB4 Offset: 0x3392EB4 VA: 0x3396EB4
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x3396F80 Offset: 0x3392F80 VA: 0x3396F80
	internal void SetValue(string value) { }

	// RVA: 0x3396F90 Offset: 0x3392F90 VA: 0x3396F90
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x3396FDC Offset: 0x3392FDC VA: 0x3396FDC
	internal void OnBufferInvalidated() { }

	// RVA: 0x339702C Offset: 0x339302C VA: 0x339702C
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x33970AC Offset: 0x33930AC VA: 0x33970AC
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x339710C Offset: 0x339310C VA: 0x339710C
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x3397120 Offset: 0x3393120 VA: 0x3397120
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x33971B8 Offset: 0x33931B8 VA: 0x33971B8 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }
}
