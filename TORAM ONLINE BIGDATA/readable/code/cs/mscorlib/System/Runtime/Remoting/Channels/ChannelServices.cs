// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public sealed class ChannelServices // TypeDefIndex: 10250
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x2EE74CC Offset: 0x2EE34CC VA: 0x2EE74CC
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x2EDB808 Offset: 0x2ED7808 VA: 0x2EDB808
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x2EE7524 Offset: 0x2EE3524 VA: 0x2EE7524
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	// RVA: 0x2EE7740 Offset: 0x2EE3740 VA: 0x2EE7740
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x2EE7798 Offset: 0x2EE3798 VA: 0x2EE7798
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x2ED2474 Offset: 0x2ECE474 VA: 0x2ED2474
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x2EE7FF4 Offset: 0x2EE3FF4 VA: 0x2EE7FF4
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x2EE8304 Offset: 0x2EE4304 VA: 0x2EE8304
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x2EE83A8 Offset: 0x2EE43A8 VA: 0x2EE83A8
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x2EE8644 Offset: 0x2EE4644 VA: 0x2EE8644
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x2EE8808 Offset: 0x2EE4808 VA: 0x2EE8808
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x2ECC3CC Offset: 0x2EC83CC VA: 0x2ECC3CC
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x2EE8810 Offset: 0x2EE4810 VA: 0x2EE8810
	private static void .cctor() { }
}
