// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 10252
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x2EDC7EC Offset: 0x2ED87EC VA: 0x2EDC7EC
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x2EE89E4 Offset: 0x2EE49E4 VA: 0x2EE89E4 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x2EE8A24 Offset: 0x2EE4A24 VA: 0x2EE8A24 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x2EE8A2C Offset: 0x2EE4A2C VA: 0x2EE8A2C Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x2EE8A90 Offset: 0x2EE4A90 VA: 0x2EE8A90 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x2EE8A94 Offset: 0x2EE4A94 VA: 0x2EE8A94 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x2EE89DC Offset: 0x2EE49DC VA: 0x2EE89DC
	public void .ctor() { }

	// RVA: 0x2EE8EA8 Offset: 0x2EE4EA8 VA: 0x2EE8EA8
	private static void .cctor() { }
}
