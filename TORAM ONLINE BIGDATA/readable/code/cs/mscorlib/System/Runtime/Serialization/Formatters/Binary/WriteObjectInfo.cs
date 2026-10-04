// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class WriteObjectInfo // TypeDefIndex: 10414
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x2F0FD7C Offset: 0x2F0BD7C VA: 0x2F0FD7C
	internal void .ctor() { }

	// RVA: 0x2F0FD84 Offset: 0x2F0BD84 VA: 0x2F0FD84
	internal void ObjectEnd() { }

	// RVA: 0x2F0FDB0 Offset: 0x2F0BDB0 VA: 0x2F0FDB0
	private void InternalInit() { }

	// RVA: 0x2F0FE30 Offset: 0x2F0BE30 VA: 0x2F0FE30
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x2F0FF8C Offset: 0x2F0BF8C VA: 0x2F0FF8C
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x2F10DDC Offset: 0x2F0CDDC VA: 0x2F10DDC
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x2F10E64 Offset: 0x2F0CE64 VA: 0x2F10E64
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x2F10624 Offset: 0x2F0C624 VA: 0x2F10624
	private void InitSiWrite() { }

	// RVA: 0x2F10958 Offset: 0x2F0C958 VA: 0x2F10958
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x2F104E0 Offset: 0x2F0C4E0 VA: 0x2F104E0
	private void InitNoMembers() { }

	// RVA: 0x2F10AB0 Offset: 0x2F0CAB0 VA: 0x2F10AB0
	private void InitMemberInfo() { }

	// RVA: 0x2F06398 Offset: 0x2F02398 VA: 0x2F06398
	internal string GetTypeFullName() { }

	// RVA: 0x2F06370 Offset: 0x2F02370 VA: 0x2F06370
	internal string GetAssemblyString() { }

	// RVA: 0x2F105FC Offset: 0x2F0C5FC VA: 0x2F105FC
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x2F112A4 Offset: 0x2F0D2A4 VA: 0x2F112A4
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x2F1140C Offset: 0x2F0D40C VA: 0x2F1140C
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x2F0FEC0 Offset: 0x2F0BEC0 VA: 0x2F0FEC0
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x2F0FD90 Offset: 0x2F0BD90 VA: 0x2F0FD90
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}
