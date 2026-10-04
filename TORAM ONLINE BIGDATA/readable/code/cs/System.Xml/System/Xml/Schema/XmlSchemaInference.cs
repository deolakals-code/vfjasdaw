// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public sealed class XmlSchemaInference // TypeDefIndex: 13703
{
	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x32D80F8 Offset: 0x32D40F8 VA: 0x32D80F8
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x32D8100 Offset: 0x32D4100 VA: 0x32D8100
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x32D8108 Offset: 0x32D4108 VA: 0x32D8108
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x32D8110 Offset: 0x32D4110 VA: 0x32D8110
	public void .ctor() { }

	// RVA: 0x32D824C Offset: 0x32D424C VA: 0x32D824C
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x32D82C0 Offset: 0x32D42C0 VA: 0x32D82C0
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x32DA7D0 Offset: 0x32D67D0 VA: 0x32DA7D0
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x32DD058 Offset: 0x32D9058 VA: 0x32DD058
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x32D8D38 Offset: 0x32D4D38 VA: 0x32D8D38
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x32D9354 Offset: 0x32D5354 VA: 0x32D9354
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x32DDD60 Offset: 0x32D9D60 VA: 0x32DDD60
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x32DD498 Offset: 0x32D9498 VA: 0x32DD498
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x32DE328 Offset: 0x32DA328 VA: 0x32DE328
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x32DD5D0 Offset: 0x32D95D0 VA: 0x32DD5D0
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x32DE28C Offset: 0x32DA28C VA: 0x32DE28C
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x32DDE98 Offset: 0x32D9E98 VA: 0x32DDE98
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x32DB3B4 Offset: 0x32D73B4 VA: 0x32DB3B4
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x32DD0F4 Offset: 0x32D90F4 VA: 0x32DD0F4
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x32DF4A4 Offset: 0x32DB4A4 VA: 0x32DF4A4
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x32DAFEC Offset: 0x32D6FEC VA: 0x32DAFEC
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x32DF5D4 Offset: 0x32DB5D4 VA: 0x32DF5D4
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x32DDCD0 Offset: 0x32D9CD0 VA: 0x32DDCD0
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x32DFA0C Offset: 0x32DBA0C VA: 0x32DFA0C
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x32DB738 Offset: 0x32D7738 VA: 0x32DB738
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x32DFB30 Offset: 0x32DBB30 VA: 0x32DFB30
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x32E10D8 Offset: 0x32DD0D8 VA: 0x32E10D8
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x32DF734 Offset: 0x32DB734 VA: 0x32DF734
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x32DC884 Offset: 0x32D8884 VA: 0x32DC884
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x32DF318 Offset: 0x32DB318 VA: 0x32DF318
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x32E11EC Offset: 0x32DD1EC VA: 0x32E11EC
	private static void .cctor() { }
}
