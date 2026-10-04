// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 16413
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("objectArgument")]
	private Object m_ObjectArgument; // 0x10
	[SerializeField]
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[SerializeField]
	[FormerlySerializedAs("intArgument")]
	private int m_IntArgument; // 0x20
	[SerializeField]
	[FormerlySerializedAs("floatArgument")]
	private float m_FloatArgument; // 0x24
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	private string m_StringArgument; // 0x28
	[SerializeField]
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x37F47F4 Offset: 0x37F07F4 VA: 0x37F47F4
	public Object get_unityObjectArgument() { }

	// RVA: 0x37F47FC Offset: 0x37F07FC VA: 0x37F47FC
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x37F4804 Offset: 0x37F0804 VA: 0x37F4804
	public int get_intArgument() { }

	// RVA: 0x37F480C Offset: 0x37F080C VA: 0x37F480C
	public float get_floatArgument() { }

	// RVA: 0x37F4814 Offset: 0x37F0814 VA: 0x37F4814
	public string get_stringArgument() { }

	// RVA: 0x37F481C Offset: 0x37F081C VA: 0x37F481C
	public bool get_boolArgument() { }

	// RVA: 0x37F4824 Offset: 0x37F0824 VA: 0x37F4824 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x37F4848 Offset: 0x37F0848 VA: 0x37F4848 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x37F486C Offset: 0x37F086C VA: 0x37F486C
	public void .ctor() { }
}
