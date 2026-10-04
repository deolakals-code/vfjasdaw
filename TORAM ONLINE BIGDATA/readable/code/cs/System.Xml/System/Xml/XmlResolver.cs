// Assembly: System.Xml.dll
// Namespace: System.Xml
public abstract class XmlResolver // TypeDefIndex: 13472
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0x33E29E8 Offset: 0x33DE9E8 VA: 0x33E29E8 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x33E2BB4 Offset: 0x33DEBB4 VA: 0x33E2BB4 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x33E2CF8 Offset: 0x33DECF8 VA: 0x33E2CF8 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x33E2D30 Offset: 0x33DED30 VA: 0x33E2D30
	protected void .ctor() { }
}
