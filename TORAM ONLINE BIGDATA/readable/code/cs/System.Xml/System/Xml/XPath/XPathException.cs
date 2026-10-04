// Assembly: System.Xml.dll
// Namespace: System.Xml.XPath
[Serializable]
public class XPathException : SystemException // TypeDefIndex: 13478
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x33E3658 Offset: 0x33DF658 VA: 0x33E3658
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33E3A40 Offset: 0x33DFA40 VA: 0x33E3A40 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x33E3B28 Offset: 0x33DFB28 VA: 0x33E3B28
	public void .ctor() { }

	// RVA: 0x33E3B7C Offset: 0x33DFB7C VA: 0x33E3B7C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x33E3C98 Offset: 0x33DFC98 VA: 0x33E3C98
	internal static XPathException Create(string res) { }

	// RVA: 0x33E3D00 Offset: 0x33DFD00 VA: 0x33E3D00
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x33E3DB4 Offset: 0x33DFDB4 VA: 0x33E3DB4
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x33E3CF8 Offset: 0x33DFCF8 VA: 0x33E3CF8
	private void .ctor(string res, string[] args) { }

	// RVA: 0x33E3C24 Offset: 0x33DFC24 VA: 0x33E3C24
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x33E3904 Offset: 0x33DF904 VA: 0x33E3904
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x33E3E8C Offset: 0x33DFE8C VA: 0x33E3E8C Slot: 5
	public override string get_Message() { }
}
