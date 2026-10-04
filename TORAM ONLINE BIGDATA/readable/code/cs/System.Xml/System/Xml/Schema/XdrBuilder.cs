// Assembly: System.Xml.dll
// Namespace: System.Xml.Schema
internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 13744
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x3325004 Offset: 0x3321004 VA: 0x3325004
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x33252C8 Offset: 0x33212C8 VA: 0x33252C8 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x3325948 Offset: 0x3321948 VA: 0x3325948 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x3326378 Offset: 0x3322378 VA: 0x3326378
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x3325D84 Offset: 0x3321D84 VA: 0x3325D84
	private bool LoadSchema(string uri) { }

	// RVA: 0x3325CCC Offset: 0x3321CCC VA: 0x3325CCC
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x3326480 Offset: 0x3322480 VA: 0x3326480 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x3326488 Offset: 0x3322488 VA: 0x3326488 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x33264E0 Offset: 0x33224E0 VA: 0x33264E0 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x332655C Offset: 0x332255C VA: 0x332655C Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x3326594 Offset: 0x3322594 VA: 0x3326594 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x3325758 Offset: 0x3321758 VA: 0x3325758
	private void Push() { }

	// RVA: 0x33265D0 Offset: 0x33225D0 VA: 0x33265D0
	private void Pop() { }

	// RVA: 0x3326660 Offset: 0x3322660 VA: 0x3326660
	private void PushGroupInfo() { }

	// RVA: 0x3326714 Offset: 0x3322714 VA: 0x3326714
	private void PopGroupInfo() { }

	// RVA: 0x33267A4 Offset: 0x33227A4 VA: 0x33267A4
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x3326804 Offset: 0x3322804 VA: 0x3326804
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33268A8 Offset: 0x33228A8 VA: 0x33268A8
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33268AC Offset: 0x33228AC VA: 0x33268AC
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x3326994 Offset: 0x3322994 VA: 0x3326994
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x3326F34 Offset: 0x3322F34 VA: 0x3326F34
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x3327060 Offset: 0x3323060 VA: 0x3327060
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332722C Offset: 0x332322C VA: 0x332722C
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3327450 Offset: 0x3323450 VA: 0x3327450
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33275CC Offset: 0x33235CC VA: 0x33275CC
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332779C Offset: 0x332379C VA: 0x332779C
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3327958 Offset: 0x3323958 VA: 0x3327958
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3327A3C Offset: 0x3323A3C VA: 0x3327A3C
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3327BE4 Offset: 0x3323BE4 VA: 0x3327BE4
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3327D8C Offset: 0x3323D8C VA: 0x3327D8C
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x3328090 Offset: 0x3324090 VA: 0x3328090
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x33284D8 Offset: 0x33244D8 VA: 0x33284D8
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x33285E4 Offset: 0x33245E4 VA: 0x33285E4
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332883C Offset: 0x332483C VA: 0x332883C
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33289B4 Offset: 0x33249B4 VA: 0x33289B4
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33289D4 Offset: 0x33249D4 VA: 0x33289D4
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3328BD0 Offset: 0x3324BD0 VA: 0x3328BD0
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3328CB4 Offset: 0x3324CB4 VA: 0x3328CB4
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3328D24 Offset: 0x3324D24 VA: 0x3328D24
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3328D94 Offset: 0x3324D94 VA: 0x3328D94
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x3328E0C Offset: 0x3324E0C VA: 0x3328E0C
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x3329198 Offset: 0x3325198 VA: 0x3329198
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x3329224 Offset: 0x3325224 VA: 0x3329224
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3329464 Offset: 0x3325464 VA: 0x3329464
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33295D0 Offset: 0x33255D0 VA: 0x33295D0
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332976C Offset: 0x332576C VA: 0x332976C
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x3329840 Offset: 0x3325840 VA: 0x3329840
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x33298E4 Offset: 0x33258E4 VA: 0x33298E4
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x33299BC Offset: 0x33259BC VA: 0x33299BC
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3329A40 Offset: 0x3325A40 VA: 0x3329A40
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x3329A60 Offset: 0x3325A60 VA: 0x3329A60
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x3329D60 Offset: 0x3325D60 VA: 0x3329D60
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x3329E74 Offset: 0x3325E74 VA: 0x3329E74
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x3329F2C Offset: 0x3325F2C VA: 0x3329F2C
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332A018 Offset: 0x3326018 VA: 0x332A018
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332A09C Offset: 0x332609C VA: 0x332A09C
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x332A120 Offset: 0x3326120 VA: 0x332A120
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x332A250 Offset: 0x3326250 VA: 0x332A250
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x332A2EC Offset: 0x33262EC VA: 0x332A2EC
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x332A3BC Offset: 0x33263BC VA: 0x332A3BC
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x332A428 Offset: 0x3326428 VA: 0x332A428
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x33255B4 Offset: 0x33215B4 VA: 0x33255B4
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x33257A4 Offset: 0x33217A4 VA: 0x33257A4
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x3326240 Offset: 0x3322240 VA: 0x3326240
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x3327678 Offset: 0x3323678 VA: 0x3327678
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x33293A8 Offset: 0x33253A8 VA: 0x33293A8
	private void AddOrder() { }

	// RVA: 0x33288B4 Offset: 0x33248B4 VA: 0x33288B4
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x33294D8 Offset: 0x33254D8 VA: 0x33294D8
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x3329644 Offset: 0x3325644 VA: 0x3329644
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x3329810 Offset: 0x3325810 VA: 0x3329810
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0x3327AAC Offset: 0x3323AAC VA: 0x3327AAC
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x3327C54 Offset: 0x3323C54 VA: 0x3327C54
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x3328458 Offset: 0x3324458 VA: 0x3328458
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0x332A508 Offset: 0x3326508 VA: 0x332A508
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0x3326E74 Offset: 0x3322E74 VA: 0x3326E74
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x3329148 Offset: 0x3325148 VA: 0x3329148
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x33272C8 Offset: 0x33232C8 VA: 0x33272C8
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x33274F0 Offset: 0x33234F0 VA: 0x33274F0
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x3328A8C Offset: 0x3324A8C VA: 0x3328A8C
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x3329058 Offset: 0x3325058 VA: 0x3329058
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x3325CC0 Offset: 0x3321CC0 VA: 0x3325CC0
	private bool IsGlobal(int flags) { }

	// RVA: 0x3326380 Offset: 0x3322380 VA: 0x3326380
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x33278A0 Offset: 0x33238A0 VA: 0x33278A0
	private void SendValidationEvent(string code) { }

	// RVA: 0x3325864 Offset: 0x3321864 VA: 0x3325864
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x332A9D8 Offset: 0x33269D8 VA: 0x332A9D8
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x332AB6C Offset: 0x3326B6C VA: 0x332AB6C
	private static void .cctor() { }
}
