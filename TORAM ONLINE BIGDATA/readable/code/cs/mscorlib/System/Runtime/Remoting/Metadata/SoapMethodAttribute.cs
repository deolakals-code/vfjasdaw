// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Metadata
[Usage(64)]
[ComVisible(True)]
public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 10276
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x2EEB54C Offset: 0x2EE754C VA: 0x2EEB54C
	public void .ctor() { }

	// RVA: 0x2EEB554 Offset: 0x2EE7554 VA: 0x2EEB554 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x2EEB55C Offset: 0x2EE755C VA: 0x2EEB55C Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x2EEB564 Offset: 0x2EE7564 VA: 0x2EEB564 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}
