// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlElement : IXmlNode // TypeDefIndex: 16088
{
	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAttributeNode(IXmlNode attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPrefixOfNamespace(string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();
}
