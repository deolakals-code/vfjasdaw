// Assembly: System.Xml.dll
// Namespace: System.Xml
[Serializable]
public class XmlException : SystemException // TypeDefIndex: 13464
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	[OptionalField]
	private string sourceUri; // 0xA8
	private string message; // 0xB0

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x33E0004 Offset: 0x33DC004 VA: 0x33E0004
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33E06A0 Offset: 0x33DC6A0 VA: 0x33E06A0 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33E0810 Offset: 0x33DC810 VA: 0x33E0810
	public void .ctor() { }

	// RVA: 0x33E0828 Offset: 0x33DC828 VA: 0x33E0828
	public void .ctor(string message) { }

	// RVA: 0x33E0844 Offset: 0x33DC844 VA: 0x33E0844
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x33E083C Offset: 0x33DC83C VA: 0x33E083C
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x33E0854 Offset: 0x33DC854 VA: 0x33E0854
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x33D4CAC Offset: 0x33D0CAC VA: 0x33D4CAC
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x33D4AD0 Offset: 0x33D0AD0 VA: 0x33D4AD0
	internal void .ctor(string res, string arg) { }

	// RVA: 0x33E0B1C Offset: 0x33DCB1C VA: 0x33E0B1C
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x33E0BC8 Offset: 0x33DCBC8 VA: 0x33E0BC8
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x33E0DF0 Offset: 0x33DCDF0 VA: 0x33E0DF0
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x33E0C6C Offset: 0x33DCC6C VA: 0x33E0C6C
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x33DC61C Offset: 0x33D861C VA: 0x33DC61C
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x33E0DF8 Offset: 0x33DCDF8 VA: 0x33E0DF8
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x33DC87C Offset: 0x33D887C VA: 0x33DC87C
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x33E0EB4 Offset: 0x33DCEB4 VA: 0x33E0EB4
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x33E0EC8 Offset: 0x33DCEC8 VA: 0x33E0EC8
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x33E0A74 Offset: 0x33DCA74 VA: 0x33E0A74
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x33E0990 Offset: 0x33DC990 VA: 0x33E0990
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x33E0444 Offset: 0x33DC444 VA: 0x33E0444
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x33D4C50 Offset: 0x33D0C50 VA: 0x33D4C50
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x33E0ED0 Offset: 0x33DCED0 VA: 0x33E0ED0
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x33D4FFC Offset: 0x33D0FFC VA: 0x33D4FFC
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0x33E0F24 Offset: 0x33DCF24 VA: 0x33E0F24
	public int get_LineNumber() { }

	// RVA: 0x33E0F2C Offset: 0x33DCF2C VA: 0x33E0F2C
	public int get_LinePosition() { }

	// RVA: 0x33E0F34 Offset: 0x33DCF34 VA: 0x33E0F34 Slot: 5
	public override string get_Message() { }

	// RVA: 0x33E0F4C Offset: 0x33DCF4C VA: 0x33E0F4C
	internal string get_ResString() { }
}
