// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectWriter // TypeDefIndex: 10422
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x2F0DA08 Offset: 0x2F09A08 VA: 0x2F0DA08
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x2F0DC1C Offset: 0x2F09C1C VA: 0x2F0DC1C
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x2F16130 Offset: 0x2F12130 VA: 0x2F16130
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x2F15C38 Offset: 0x2F11C38 VA: 0x2F15C38
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x2F16884 Offset: 0x2F12884 VA: 0x2F16884
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x2F16AFC Offset: 0x2F12AFC VA: 0x2F16AFC
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x2F16C3C Offset: 0x2F12C3C VA: 0x2F16C3C
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x2F16138 Offset: 0x2F12138 VA: 0x2F16138
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x2F1721C Offset: 0x2F1321C VA: 0x2F1721C
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x2F174BC Offset: 0x2F134BC VA: 0x2F174BC
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x2F15FC0 Offset: 0x2F11FC0 VA: 0x2F15FC0
	private object GetNext(out long objID) { }

	// RVA: 0x2F158F8 Offset: 0x2F118F8 VA: 0x2F158F8
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x2F176F8 Offset: 0x2F136F8 VA: 0x2F176F8
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x2F17094 Offset: 0x2F13094 VA: 0x2F17094
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x2F17138 Offset: 0x2F13138 VA: 0x2F17138
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x2F17120 Offset: 0x2F13120 VA: 0x2F17120
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x2F17704 Offset: 0x2F13704 VA: 0x2F17704
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x2F16F68 Offset: 0x2F12F68 VA: 0x2F16F68
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x2F158D8 Offset: 0x2F118D8 VA: 0x2F158D8
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x2F177F8 Offset: 0x2F137F8 VA: 0x2F177F8
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x2F16C08 Offset: 0x2F12C08 VA: 0x2F16C08
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x2F15BF4 Offset: 0x2F11BF4 VA: 0x2F15BF4
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x2F17044 Offset: 0x2F13044 VA: 0x2F17044
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x2F1700C Offset: 0x2F1300C VA: 0x2F1700C
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x2F16AC4 Offset: 0x2F12AC4 VA: 0x2F16AC4
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x2F062D4 Offset: 0x2F022D4 VA: 0x2F062D4
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x2F159D8 Offset: 0x2F119D8 VA: 0x2F159D8
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x2F1686C Offset: 0x2F1286C VA: 0x2F1686C
	private Type GetType(object obj) { }

	// RVA: 0x2F178A0 Offset: 0x2F138A0 VA: 0x2F178A0
	private NameInfo GetNameInfo() { }

	// RVA: 0x2F16860 Offset: 0x2F12860 VA: 0x2F16860
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x2F15FA4 Offset: 0x2F11FA4 VA: 0x2F15FA4
	private void PutNameInfo(NameInfo nameInfo) { }
}
