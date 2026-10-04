// Assembly: mscorlib.dll
// Namespace: System.Reflection
[Serializable]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 10637
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x2F31B98 Offset: 0x2F2DB98 VA: 0x2F31B98
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x2F31BA8 Offset: 0x2F2DBA8 VA: 0x2F31BA8
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x2F31EB8 Offset: 0x2F2DEB8 VA: 0x2F31EB8
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F32258 Offset: 0x2F2E258 VA: 0x2F32258 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F322B0 Offset: 0x2F2E2B0 VA: 0x2F322B0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}
