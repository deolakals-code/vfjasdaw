// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaException : SystemException // TypeDefIndex: 13776
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string sourceUri; // 0xA0
	private int lineNumber; // 0xA8
	private int linePosition; // 0xAC
	private XmlSchemaObject sourceSchemaObject; // 0xB0
	private string message; // 0xB8

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x3337644 Offset: 0x3333644 VA: 0x3337644
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3337B08 Offset: 0x3333B08 VA: 0x3337B08 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3337C78 Offset: 0x3333C78 VA: 0x3337C78
	public void .ctor() { }

	// RVA: 0x3337C8C Offset: 0x3333C8C VA: 0x3337C8C
	public void .ctor(string message) { }

	// RVA: 0x3337D9C Offset: 0x3333D9C VA: 0x3337D9C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x3337C9C Offset: 0x3333C9C VA: 0x3337C9C
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x3337E60 Offset: 0x3333E60 VA: 0x3337E60
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x332F3D4 Offset: 0x332B3D4 VA: 0x332F3D4
	internal void .ctor(string res, string arg) { }

	// RVA: 0x332AAA0 Offset: 0x3326AA0 VA: 0x332AAA0
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x3337E8C Offset: 0x3333E8C VA: 0x3337E8C
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x332A9AC Offset: 0x33269AC VA: 0x332A9AC
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x3337EBC Offset: 0x3333EBC VA: 0x3337EBC
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x3337EF8 Offset: 0x3333EF8 VA: 0x3337EF8
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x3337EC8 Offset: 0x3333EC8 VA: 0x3337EC8
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x3337DA8 Offset: 0x3333DA8 VA: 0x3337DA8
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x3337A44 Offset: 0x3333A44 VA: 0x3337A44
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x3337F98 Offset: 0x3333F98 VA: 0x3337F98
	internal string get_GetRes() { }

	// RVA: 0x3337FA0 Offset: 0x3333FA0 VA: 0x3337FA0
	internal string[] get_Args() { }

	// RVA: 0x3337FA8 Offset: 0x3333FA8 VA: 0x3337FA8
	public string get_SourceUri() { }

	// RVA: 0x3337FB0 Offset: 0x3333FB0 VA: 0x3337FB0
	public int get_LineNumber() { }

	// RVA: 0x3337FB8 Offset: 0x3333FB8 VA: 0x3337FB8
	public int get_LinePosition() { }

	// RVA: 0x3337FC0 Offset: 0x3333FC0 VA: 0x3337FC0
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x332E824 Offset: 0x332A824 VA: 0x332E824
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x3337FC8 Offset: 0x3333FC8 VA: 0x3337FC8
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x3337FD0 Offset: 0x3333FD0 VA: 0x3337FD0
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x3338014 Offset: 0x3334014 VA: 0x3338014 Slot: 5
	public override string get_Message() { }
}
