// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XProcessingInstruction : XNode // TypeDefIndex: 17531
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x32BF310 Offset: 0x32BB310 VA: 0x32BF310
	public void .ctor(string target, string data) { }

	// RVA: 0x32C385C Offset: 0x32BF85C VA: 0x32C385C
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x32C38E8 Offset: 0x32BF8E8 VA: 0x32C38E8
	public string get_Data() { }

	// RVA: 0x32C38F0 Offset: 0x32BF8F0 VA: 0x32C38F0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32C38F8 Offset: 0x32BF8F8 VA: 0x32C38F8
	public string get_Target() { }

	// RVA: 0x32C3900 Offset: 0x32BF900 VA: 0x32C3900 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x32C3970 Offset: 0x32BF970 VA: 0x32C3970 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x32C3784 Offset: 0x32BF784 VA: 0x32C3784
	private static void ValidateName(string name) { }
}
