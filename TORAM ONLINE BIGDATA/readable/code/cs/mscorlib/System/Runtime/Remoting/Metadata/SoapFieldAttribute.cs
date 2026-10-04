// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Metadata
[Usage(256)]
[ComVisible(True)]
public sealed class SoapFieldAttribute : SoapAttribute // TypeDefIndex: 10275
{
	// Fields
	private string _elementName; // 0x28
	private bool _isElement; // 0x30

	// Properties
	public string XmlElementName { get; }

	// Methods

	// RVA: 0x2EEB47C Offset: 0x2EE747C VA: 0x2EEB47C
	public void .ctor() { }

	// RVA: 0x2EEB484 Offset: 0x2EE7484 VA: 0x2EEB484
	public string get_XmlElementName() { }

	// RVA: 0x2EEB48C Offset: 0x2EE748C VA: 0x2EEB48C
	public bool IsInteropXmlElement() { }

	// RVA: 0x2EEB494 Offset: 0x2EE7494 VA: 0x2EEB494 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}
