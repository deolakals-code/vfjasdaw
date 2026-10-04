// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Converters
[Nullable(0)]
[NullableContext(1)]
public class XmlNodeConverter : JsonConverter // TypeDefIndex: 16100
{
	// Fields
	internal static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = "#text";
	private const string CommentName = "#comment";
	private const string CDataName = "#cdata-section";
	private const string WhitespaceName = "#whitespace";
	private const string SignificantWhitespaceName = "#significant-whitespace";
	private const string DeclarationName = "?xml";
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	[Nullable(2)]
	[CompilerGenerated]
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Properties
	[Nullable(2)]
	public string DeserializeRootElementName { get; set; }
	public bool WriteArrayAttribute { get; set; }
	public bool OmitRootObject { get; set; }
	public bool EncodeSpecialCharacters { get; set; }

	// Methods

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x30E4364 Offset: 0x30E0364 VA: 0x30E4364
	public string get_DeserializeRootElementName() { }

	[CompilerGenerated]
	[NullableContext(2)]
	// RVA: 0x30E436C Offset: 0x30E036C VA: 0x30E436C
	public void set_DeserializeRootElementName(string value) { }

	[CompilerGenerated]
	// RVA: 0x30E4374 Offset: 0x30E0374 VA: 0x30E4374
	public bool get_WriteArrayAttribute() { }

	[CompilerGenerated]
	// RVA: 0x30E437C Offset: 0x30E037C VA: 0x30E437C
	public void set_WriteArrayAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30E4388 Offset: 0x30E0388 VA: 0x30E4388
	public bool get_OmitRootObject() { }

	[CompilerGenerated]
	// RVA: 0x30E4390 Offset: 0x30E0390 VA: 0x30E4390
	public void set_OmitRootObject(bool value) { }

	[CompilerGenerated]
	// RVA: 0x30E439C Offset: 0x30E039C VA: 0x30E439C
	public bool get_EncodeSpecialCharacters() { }

	[CompilerGenerated]
	// RVA: 0x30E43A4 Offset: 0x30E03A4 VA: 0x30E43A4
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0x30E43B0 Offset: 0x30E03B0 VA: 0x30E43B0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x30E44F0 Offset: 0x30E04F0 VA: 0x30E44F0
	private IXmlNode WrapXml(object value) { }

	// RVA: 0x30E4608 Offset: 0x30E0608 VA: 0x30E4608
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x30E63E8 Offset: 0x30E23E8 VA: 0x30E63E8
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x30E6704 Offset: 0x30E2704 VA: 0x30E6704
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x30E6B44 Offset: 0x30E2B44 VA: 0x30E6B44
	private bool IsArray(IXmlNode node) { }

	// RVA: 0x30E6EDC Offset: 0x30E2EDC VA: 0x30E6EDC
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x30E788C Offset: 0x30E388C VA: 0x30E788C
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0x30E79F8 Offset: 0x30E39F8 VA: 0x30E79F8
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0x30E4C70 Offset: 0x30E0C70 VA: 0x30E4C70
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x30E7AC8 Offset: 0x30E3AC8 VA: 0x30E7AC8
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0x30E808C Offset: 0x30E408C VA: 0x30E808C Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x30E93C4 Offset: 0x30E53C4 VA: 0x30E93C4
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0x30E88EC Offset: 0x30E48EC VA: 0x30E88EC
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0x30EB620 Offset: 0x30E7620 VA: 0x30EB620
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0x30EB2A4 Offset: 0x30E72A4 VA: 0x30EB2A4
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0x30E9970 Offset: 0x30E5970 VA: 0x30E9970
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0x30EA8A8 Offset: 0x30E68A8 VA: 0x30EA8A8
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0x30EBE28 Offset: 0x30E7E28 VA: 0x30EBE28
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0x30EAC48 Offset: 0x30E6C48 VA: 0x30EAC48
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0x30EAC90 Offset: 0x30E6C90 VA: 0x30EAC90
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0x30E9FFC Offset: 0x30E5FFC VA: 0x30E9FFC
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0x30EA4B0 Offset: 0x30E64B0 VA: 0x30EA4B0
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0x30EBC6C Offset: 0x30E7C6C VA: 0x30EBC6C
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0x30E8C34 Offset: 0x30E4C34 VA: 0x30E8C34
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0x30EC168 Offset: 0x30E8168 VA: 0x30EC168
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0x30E7D74 Offset: 0x30E3D74 VA: 0x30E7D74
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0x30EC260 Offset: 0x30E8260 VA: 0x30EC260 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x30EC308 Offset: 0x30E8308 VA: 0x30EC308
	private bool IsXObject(Type valueType) { }

	// RVA: 0x30EC39C Offset: 0x30E839C VA: 0x30EC39C
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0x30EC430 Offset: 0x30E8430 VA: 0x30EC430
	public void .ctor() { }

	// RVA: 0x30EC438 Offset: 0x30E8438 VA: 0x30EC438
	private static void .cctor() { }
}
