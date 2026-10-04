// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class EnvoyTerminatorSink : IMessageSink // TypeDefIndex: 10299
{
	// Fields
	public static EnvoyTerminatorSink Instance; // 0x0

	// Methods

	// RVA: 0x2EF393C Offset: 0x2EEF93C VA: 0x2EF393C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x2EF39F4 Offset: 0x2EEF9F4 VA: 0x2EF39F4 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x2EF3AB8 Offset: 0x2EEFAB8 VA: 0x2EF3AB8
	public void .ctor() { }

	// RVA: 0x2EF3AC0 Offset: 0x2EEFAC0 VA: 0x2EF3AC0
	private static void .cctor() { }
}
