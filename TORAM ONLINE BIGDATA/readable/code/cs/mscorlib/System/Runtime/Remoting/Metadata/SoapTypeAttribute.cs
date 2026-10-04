// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Metadata
[ComVisible(True)]
[Usage(1052)]
public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 10278
{
	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x2EEB78C Offset: 0x2EE778C VA: 0x2EEB78C
	public void .ctor() { }

	// RVA: 0x2EEB794 Offset: 0x2EE7794 VA: 0x2EEB794 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x2EEB79C Offset: 0x2EE779C VA: 0x2EEB79C
	public string get_XmlElementName() { }

	// RVA: 0x2EEB7A4 Offset: 0x2EE77A4 VA: 0x2EEB7A4 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x2EEB7AC Offset: 0x2EE77AC VA: 0x2EEB7AC
	public string get_XmlTypeName() { }

	// RVA: 0x2EEB7B4 Offset: 0x2EE77B4 VA: 0x2EEB7B4
	public string get_XmlTypeNamespace() { }

	// RVA: 0x2EEB7BC Offset: 0x2EE77BC VA: 0x2EEB7BC
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x2EEB7C4 Offset: 0x2EE77C4 VA: 0x2EEB7C4
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x2EEB7CC Offset: 0x2EE77CC VA: 0x2EEB7CC Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}
