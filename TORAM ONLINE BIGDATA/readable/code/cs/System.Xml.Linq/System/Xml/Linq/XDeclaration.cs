// Assembly: System.Xml.Linq.dll
// Namespace: System.Xml.Linq
public class XDeclaration // TypeDefIndex: 17509
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Properties
	public string Encoding { get; }
	public string Standalone { get; }
	public string Version { get; }

	// Methods

	// RVA: 0x32BF858 Offset: 0x32BB858 VA: 0x32BF858
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x32BF8B8 Offset: 0x32BB8B8 VA: 0x32BF8B8
	public void .ctor(XDeclaration other) { }

	// RVA: 0x32BF954 Offset: 0x32BB954 VA: 0x32BF954
	public string get_Encoding() { }

	// RVA: 0x32BF95C Offset: 0x32BB95C VA: 0x32BF95C
	public string get_Standalone() { }

	// RVA: 0x32BF964 Offset: 0x32BB964 VA: 0x32BF964
	public string get_Version() { }

	// RVA: 0x32BF96C Offset: 0x32BB96C VA: 0x32BF96C Slot: 3
	public override string ToString() { }
}
