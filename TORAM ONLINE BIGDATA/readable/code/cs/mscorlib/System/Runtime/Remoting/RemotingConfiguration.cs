// Assembly: mscorlib.dll
// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingConfiguration // TypeDefIndex: 10200
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static CustomErrorsModes _errorMode; // 0x1C
	private static Hashtable wellKnownClientEntries; // 0x20
	private static Hashtable activatedClientEntries; // 0x28
	private static Hashtable wellKnownServiceEntries; // 0x30
	private static Hashtable activatedServiceEntries; // 0x38
	private static Hashtable channelTemplates; // 0x40
	private static Hashtable clientProviderTemplates; // 0x48
	private static Hashtable serverProviderTemplates; // 0x50

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x2ECF2AC Offset: 0x2ECB2AC VA: 0x2ECF2AC
	public static string get_ApplicationName() { }

	// RVA: 0x2ECF304 Offset: 0x2ECB304 VA: 0x2ECF304
	public static void set_ApplicationName(string value) { }

	// RVA: 0x2ECF364 Offset: 0x2ECB364 VA: 0x2ECF364
	public static string get_ProcessId() { }

	// RVA: 0x2ECF410 Offset: 0x2ECB410 VA: 0x2ECF410
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x2ECF844 Offset: 0x2ECB844 VA: 0x2ECF844
	public static bool IsActivationAllowed(Type svrType) { }

	// RVA: 0x2ECF984 Offset: 0x2ECB984 VA: 0x2ECF984
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x2ECFB0C Offset: 0x2ECBB0C VA: 0x2ECFB0C
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x2ECFC94 Offset: 0x2ECBC94 VA: 0x2ECFC94
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x2ECFF14 Offset: 0x2ECBF14 VA: 0x2ECFF14
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x2ED0054 Offset: 0x2ECC054 VA: 0x2ED0054
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x2ED02CC Offset: 0x2ECC2CC VA: 0x2ED02CC
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x2ED0544 Offset: 0x2ECC544 VA: 0x2ED0544
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x2ED05C0 Offset: 0x2ECC5C0 VA: 0x2ED05C0
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x2ED063C Offset: 0x2ECC63C VA: 0x2ED063C
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x2ED06B8 Offset: 0x2ECC6B8 VA: 0x2ED06B8
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x2ED30F0 Offset: 0x2ECF0F0 VA: 0x2ED30F0
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x2ED360C Offset: 0x2ECF60C VA: 0x2ED360C
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x2ED36A0 Offset: 0x2ECF6A0 VA: 0x2ED36A0
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x2ED38F4 Offset: 0x2ECF8F4 VA: 0x2ED38F4
	private static void .cctor() { }
}
