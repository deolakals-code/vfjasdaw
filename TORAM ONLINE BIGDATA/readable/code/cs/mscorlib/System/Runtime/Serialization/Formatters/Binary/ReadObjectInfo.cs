// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ReadObjectInfo // TypeDefIndex: 10415
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x2F114D4 Offset: 0x2F0D4D4 VA: 0x2F114D4
	internal void .ctor() { }

	// RVA: 0x2F114DC Offset: 0x2F0D4DC VA: 0x2F114DC
	internal void ObjectEnd() { }

	// RVA: 0x2F0AD40 Offset: 0x2F06D40 VA: 0x2F0AD40
	internal void PrepareForReuse() { }

	// RVA: 0x2F114E0 Offset: 0x2F0D4E0 VA: 0x2F114E0
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x2F115E0 Offset: 0x2F0D5E0 VA: 0x2F115E0
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x2F11838 Offset: 0x2F0D838 VA: 0x2F11838
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x2F118D4 Offset: 0x2F0D8D4 VA: 0x2F118D4
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x2F11698 Offset: 0x2F0D698 VA: 0x2F11698
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x2F11A58 Offset: 0x2F0DA58 VA: 0x2F11A58
	private void InitSiRead() { }

	// RVA: 0x2F119F4 Offset: 0x2F0D9F4 VA: 0x2F119F4
	private void InitNoMembers() { }

	// RVA: 0x2F11AE4 Offset: 0x2F0DAE4 VA: 0x2F11AE4
	private void InitMemberInfo() { }

	// RVA: 0x2F11E98 Offset: 0x2F0DE98 VA: 0x2F11E98
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x2F1215C Offset: 0x2F0E15C VA: 0x2F1215C
	internal Type GetType(string name) { }

	// RVA: 0x2F122F0 Offset: 0x2F0E2F0 VA: 0x2F122F0
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x2F0AC54 Offset: 0x2F06C54 VA: 0x2F0AC54
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x2F12398 Offset: 0x2F0E398 VA: 0x2F12398
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x2F1243C Offset: 0x2F0E43C VA: 0x2F1243C
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x2F12028 Offset: 0x2F0E028 VA: 0x2F12028
	private int Position(string name) { }

	// RVA: 0x2F0A348 Offset: 0x2F06348 VA: 0x2F0A348
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x2F11D30 Offset: 0x2F0DD30 VA: 0x2F11D30
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x2F11570 Offset: 0x2F0D570 VA: 0x2F11570
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}
