// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[Serializable]
internal class EnvoyInfo : IEnvoyInfo // TypeDefIndex: 10192
{
	// Fields
	private IMessageSink envoySinks; // 0x10

	// Properties
	public IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: 0x2ECCC94 Offset: 0x2EC8C94 VA: 0x2ECCC94
	public void .ctor(IMessageSink sinks) { }

	// RVA: 0x2ECCCC4 Offset: 0x2EC8CC4 VA: 0x2ECCCC4 Slot: 4
	public IMessageSink get_EnvoySinks() { }
}
