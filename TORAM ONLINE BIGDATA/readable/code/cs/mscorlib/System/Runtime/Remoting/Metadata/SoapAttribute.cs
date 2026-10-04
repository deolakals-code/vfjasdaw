// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Metadata
[ComVisible(True)]
public class SoapAttribute : Attribute // TypeDefIndex: 10274
{
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x2EEB45C Offset: 0x2EE745C VA: 0x2EEB45C
	public void .ctor() { }

	// RVA: 0x2EEB464 Offset: 0x2EE7464 VA: 0x2EEB464 Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x2EEB46C Offset: 0x2EE746C VA: 0x2EEB46C Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x2EEB474 Offset: 0x2EE7474 VA: 0x2EEB474 Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }
}
