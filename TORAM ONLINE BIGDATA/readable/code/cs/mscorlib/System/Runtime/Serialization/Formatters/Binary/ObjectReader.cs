// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectReader // TypeDefIndex: 10421
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x2F125BC Offset: 0x2F0E5BC VA: 0x2F125BC
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x2F12644 Offset: 0x2F0E644 VA: 0x2F12644
	internal object get_TopObject() { }

	// RVA: 0x2F1264C Offset: 0x2F0E64C VA: 0x2F1264C
	internal void set_TopObject(object value) { }

	// RVA: 0x2F0D1F4 Offset: 0x2F091F4 VA: 0x2F0D1F4
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x2F0D488 Offset: 0x2F09488 VA: 0x2F0D488
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x2F12C20 Offset: 0x2F0EC20 VA: 0x2F12C20
	private bool HasSurrogate(Type t) { }

	// RVA: 0x2F12CF4 Offset: 0x2F0ECF4 VA: 0x2F12CF4
	private void CheckSerializable(Type t) { }

	// RVA: 0x2F12E24 Offset: 0x2F0EE24 VA: 0x2F12E24
	private void InitFullDeserialization() { }

	// RVA: 0x2F12F50 Offset: 0x2F0EF50 VA: 0x2F12F50
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x2F0A318 Offset: 0x2F06318 VA: 0x2F0A318
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x2F0ABD4 Offset: 0x2F06BD4 VA: 0x2F0ABD4
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x2F12F80 Offset: 0x2F0EF80 VA: 0x2F12F80
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x2F13C28 Offset: 0x2F0FC28 VA: 0x2F13C28
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x2F130C4 Offset: 0x2F0F0C4 VA: 0x2F130C4
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x2F130E0 Offset: 0x2F0F0E0 VA: 0x2F130E0
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x2F130FC Offset: 0x2F0F0FC VA: 0x2F130FC
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x2F13450 Offset: 0x2F0F450 VA: 0x2F13450
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x2F13E74 Offset: 0x2F0FE74 VA: 0x2F13E74
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x2F145D8 Offset: 0x2F105D8 VA: 0x2F145D8
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x2F1469C Offset: 0x2F1069C VA: 0x2F1469C
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x2F14EA0 Offset: 0x2F10EA0 VA: 0x2F14EA0
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x2F13680 Offset: 0x2F0F680 VA: 0x2F13680
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x2F13B68 Offset: 0x2F0FB68 VA: 0x2F13B68
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x2F14E60 Offset: 0x2F10E60 VA: 0x2F14E60
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x2F145D0 Offset: 0x2F105D0 VA: 0x2F145D0
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x2F14EC8 Offset: 0x2F10EC8 VA: 0x2F14EC8
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x2F14FE8 Offset: 0x2F10FE8 VA: 0x2F14FE8
	internal long GetId(long objectId) { }

	// RVA: 0x2F150DC Offset: 0x2F110DC VA: 0x2F150DC
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x2F15134 Offset: 0x2F11134 VA: 0x2F15134
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x2F15430 Offset: 0x2F11430 VA: 0x2F15430
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x2F15490 Offset: 0x2F11490 VA: 0x2F15490
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x2F07174 Offset: 0x2F03174 VA: 0x2F07174
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x2F156F8 Offset: 0x2F116F8 VA: 0x2F156F8
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}
