// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
internal class UnitySerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 9768
{
	// Fields
	private Type[] m_instantiation; // 0x10
	private int[] m_elementTypes; // 0x18
	private int m_genericParameterPosition; // 0x20
	private Type m_declaringType; // 0x28
	private MethodBase m_declaringMethod; // 0x30
	private string m_data; // 0x38
	private string m_assemblyName; // 0x40
	private int m_unityType; // 0x48

	// Methods

	// RVA: 0x3028C84 Offset: 0x3024C84 VA: 0x3028C84
	internal static RuntimeType AddElementTypes(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x3029058 Offset: 0x3025058 VA: 0x3029058
	internal Type MakeElementTypes(Type type) { }

	// RVA: 0x302914C Offset: 0x302514C VA: 0x302914C
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType) { }

	// RVA: 0x30292A0 Offset: 0x30252A0 VA: 0x30292A0
	internal static void GetUnitySerializationInfo(SerializationInfo info, RuntimeType type) { }

	// RVA: 0x3029624 Offset: 0x3025624 VA: 0x3029624
	internal static void GetUnitySerializationInfo(SerializationInfo info, int unityType, string data, RuntimeAssembly assembly) { }

	// RVA: 0x30297B0 Offset: 0x30257B0 VA: 0x30297B0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3029C6C Offset: 0x3025C6C VA: 0x3029C6C
	private void ThrowInsufficientInformation(string field) { }

	// RVA: 0x3029D70 Offset: 0x3025D70 VA: 0x3029D70 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3029DC0 Offset: 0x3025DC0 VA: 0x3029DC0 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}
