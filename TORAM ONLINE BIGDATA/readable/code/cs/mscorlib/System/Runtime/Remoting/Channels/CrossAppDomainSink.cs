// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 10254
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x2EE8F24 Offset: 0x2EE4F24 VA: 0x2EE8F24
	internal void .ctor(int domainID) { }

	// RVA: 0x2EE8C18 Offset: 0x2EE4C18 VA: 0x2EE8C18
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x2EE8F4C Offset: 0x2EE4F4C VA: 0x2EE8F4C
	internal int get_TargetDomainId() { }

	// RVA: 0x2EE8F54 Offset: 0x2EE4F54 VA: 0x2EE8F54
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x2EE918C Offset: 0x2EE518C VA: 0x2EE918C Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x2EE9610 Offset: 0x2EE5610 VA: 0x2EE9610 Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x2EE971C Offset: 0x2EE571C VA: 0x2EE971C
	public void SendAsyncMessage(object data) { }

	// RVA: 0x2EE9828 Offset: 0x2EE5828 VA: 0x2EE9828
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2EE9938 Offset: 0x2EE5938 VA: 0x2EE9938
	private void <AsyncProcessMessage>b__10_0(object data) { }
}
