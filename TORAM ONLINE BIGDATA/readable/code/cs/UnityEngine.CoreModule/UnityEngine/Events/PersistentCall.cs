// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 16422
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("instance")]
	private Object m_Target; // 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; // 0x18
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName; // 0x20
	[SerializeField]
	[FormerlySerializedAs("mode")]
	private PersistentListenerMode m_Mode; // 0x28
	[FormerlySerializedAs("arguments")]
	[SerializeField]
	private ArgumentCache m_Arguments; // 0x30
	[SerializeField]
	[FormerlySerializedAs("m_Enabled")]
	[FormerlySerializedAs("enabled")]
	private UnityEventCallState m_CallState; // 0x38

	// Properties
	public Object target { get; }
	public string targetAssemblyTypeName { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x37F4D24 Offset: 0x37F0D24 VA: 0x37F4D24
	public Object get_target() { }

	// RVA: 0x37F4D2C Offset: 0x37F0D2C VA: 0x37F4D2C
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x37F4DE4 Offset: 0x37F0DE4 VA: 0x37F4DE4
	public string get_methodName() { }

	// RVA: 0x37F4DEC Offset: 0x37F0DEC VA: 0x37F4DEC
	public PersistentListenerMode get_mode() { }

	// RVA: 0x37F4DF4 Offset: 0x37F0DF4 VA: 0x37F4DF4
	public ArgumentCache get_arguments() { }

	// RVA: 0x37F4DFC Offset: 0x37F0DFC VA: 0x37F4DFC
	public bool IsValid() { }

	// RVA: 0x37F4E38 Offset: 0x37F0E38 VA: 0x37F4E38
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x37F52EC Offset: 0x37F12EC VA: 0x37F52EC
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x37F576C Offset: 0x37F176C VA: 0x37F576C Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x37F5790 Offset: 0x37F1790 VA: 0x37F5790 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x37F57B4 Offset: 0x37F17B4 VA: 0x37F57B4
	public void .ctor() { }
}
