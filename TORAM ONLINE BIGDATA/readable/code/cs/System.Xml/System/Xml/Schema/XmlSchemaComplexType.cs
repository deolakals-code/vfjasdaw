// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 13767
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x94
	private XmlSchemaContentModel contentModel; // 0x98
	private XmlSchemaParticle particle; // 0xA0
	private XmlSchemaObjectCollection attributes; // 0xA8
	private XmlSchemaAnyAttribute anyAttribute; // 0xB0
	private XmlSchemaParticle contentTypeParticle; // 0xB8
	private XmlSchemaDerivationMethod blockResolved; // 0xC0
	private XmlSchemaObjectTable localElements; // 0xC8
	private XmlSchemaObjectTable attributeUses; // 0xD0
	private XmlSchemaAnyAttribute attributeWildcard; // 0xD8
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE0

	// Properties
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[Xml("block")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("mixed")]
	[DefaultValue(False)]
	public override bool IsMixed { get; set; }
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x3334CF4 Offset: 0x3330CF4 VA: 0x3334CF4
	private static void .cctor() { }

	// RVA: 0x3334F18 Offset: 0x3330F18 VA: 0x3334F18
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x333525C Offset: 0x333125C VA: 0x333525C
	public void .ctor() { }

	// RVA: 0x3335344 Offset: 0x3331344 VA: 0x3335344
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x333539C Offset: 0x333139C VA: 0x333539C
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x33352D4 Offset: 0x33312D4 VA: 0x33352D4
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x33353F4 Offset: 0x33313F4 VA: 0x33353F4
	public bool get_IsAbstract() { }

	// RVA: 0x3335400 Offset: 0x3331400 VA: 0x3335400
	public void set_IsAbstract(bool value) { }

	// RVA: 0x3335420 Offset: 0x3331420 VA: 0x3335420
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x3335428 Offset: 0x3331428 VA: 0x3335428
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3335430 Offset: 0x3331430 VA: 0x3335430 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x333543C Offset: 0x333143C VA: 0x333543C Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x333545C Offset: 0x333145C VA: 0x333545C
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x3335464 Offset: 0x3331464 VA: 0x3335464
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x333546C Offset: 0x333146C VA: 0x333546C
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x3335474 Offset: 0x3331474 VA: 0x3335474
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x333547C Offset: 0x333147C VA: 0x333547C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x33354EC Offset: 0x33314EC VA: 0x33354EC
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x33354F4 Offset: 0x33314F4 VA: 0x33354F4
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x33354FC Offset: 0x33314FC VA: 0x33354FC
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x3335504 Offset: 0x3331504 VA: 0x3335504
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x333550C Offset: 0x333150C VA: 0x333550C
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x3335514 Offset: 0x3331514 VA: 0x3335514
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x3335584 Offset: 0x3331584 VA: 0x3335584
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x333558C Offset: 0x333158C VA: 0x333558C
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x33355FC Offset: 0x33315FC VA: 0x33355FC
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x3335604 Offset: 0x3331604 VA: 0x3335604
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x333560C Offset: 0x333160C VA: 0x333560C
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x3335614 Offset: 0x3331614 VA: 0x3335614
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x3335624 Offset: 0x3331624 VA: 0x3335624
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x333562C Offset: 0x333162C VA: 0x333562C
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x33359C8 Offset: 0x33319C8 VA: 0x33359C8 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x33316E0 Offset: 0x332D6E0 VA: 0x33316E0
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x3335EF4 Offset: 0x3331EF4 VA: 0x3335EF4
	private void ClearCompiledState() { }

	// RVA: 0x3333970 Offset: 0x332F970 VA: 0x3333970
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x3336014 Offset: 0x3332014 VA: 0x3336014
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x3335C4C Offset: 0x3331C4C VA: 0x3335C4C
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x33361F4 Offset: 0x33321F4 VA: 0x33361F4
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x33359D0 Offset: 0x33319D0 VA: 0x33359D0
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x3333814 Offset: 0x332F814 VA: 0x3333814
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }
}
