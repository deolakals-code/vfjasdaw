// Assembly: System.dll
// Namespace: System.Net
public static class Dns // TypeDefIndex: 14478
{
	// Methods

	// RVA: 0x350B018 Offset: 0x3507018 VA: 0x350B018
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x350B270 Offset: 0x3507270 VA: 0x350B270
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x350B384 Offset: 0x3507384 VA: 0x350B384
	private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x350B388 Offset: 0x3507388 VA: 0x350B388
	private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x350B38C Offset: 0x350738C VA: 0x350B38C
	private static bool GetHostName_icall(out string h_name) { }

	// RVA: 0x350B390 Offset: 0x3507390 VA: 0x350B390
	private static void Error_11001(string hostName) { }

	// RVA: 0x350B3F4 Offset: 0x35073F4 VA: 0x350B3F4
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x350B740 Offset: 0x3507740 VA: 0x350B740
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x350B86C Offset: 0x350786C VA: 0x350B86C
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x350B9D8 Offset: 0x35079D8 VA: 0x350B9D8
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x350BB28 Offset: 0x3507B28 VA: 0x350BB28
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x350BA40 Offset: 0x3507A40 VA: 0x350BA40
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x350BD08 Offset: 0x3507D08 VA: 0x350BD08
	public static string GetHostName() { }

	// RVA: 0x350BD34 Offset: 0x3507D34 VA: 0x350BD34
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }
}
