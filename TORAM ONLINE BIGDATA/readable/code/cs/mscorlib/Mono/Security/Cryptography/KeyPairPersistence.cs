// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal class KeyPairPersistence // TypeDefIndex: 9473
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x2E72178 Offset: 0x2E6E178 VA: 0x2E72178
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x2E72180 Offset: 0x2E6E180 VA: 0x2E72180
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x2E722B0 Offset: 0x2E6E2B0 VA: 0x2E722B0
	public string get_Filename() { }

	// RVA: 0x2E73028 Offset: 0x2E6F028 VA: 0x2E73028
	public string get_KeyValue() { }

	// RVA: 0x2E73030 Offset: 0x2E6F030 VA: 0x2E73030
	public void set_KeyValue(string value) { }

	// RVA: 0x2E73054 Offset: 0x2E6F054 VA: 0x2E73054
	public bool Load() { }

	// RVA: 0x2E7333C Offset: 0x2E6F33C VA: 0x2E7333C
	public void Save() { }

	// RVA: 0x2E738B4 Offset: 0x2E6F8B4 VA: 0x2E738B4
	public void Remove() { }

	// RVA: 0x2E72AE0 Offset: 0x2E6EAE0 VA: 0x2E72AE0
	private static string get_UserPath() { }

	// RVA: 0x2E72598 Offset: 0x2E6E598 VA: 0x2E72598
	private static string get_MachinePath() { }

	// RVA: 0x2E739E8 Offset: 0x2E6F9E8 VA: 0x2E739E8
	internal static bool _CanSecure(char* root) { }

	// RVA: 0x2E739EC Offset: 0x2E6F9EC VA: 0x2E739EC
	internal static bool _ProtectUser(char* path) { }

	// RVA: 0x2E739F0 Offset: 0x2E6F9F0 VA: 0x2E739F0
	internal static bool _ProtectMachine(char* path) { }

	// RVA: 0x2E739F4 Offset: 0x2E6F9F4 VA: 0x2E739F4
	internal static bool _IsUserProtected(char* path) { }

	// RVA: 0x2E739F8 Offset: 0x2E6F9F8 VA: 0x2E739F8
	internal static bool _IsMachineProtected(char* path) { }

	// RVA: 0x2E739FC Offset: 0x2E6F9FC VA: 0x2E739FC
	private static bool CanSecure(string path) { }

	// RVA: 0x2E73824 Offset: 0x2E6F824 VA: 0x2E73824
	private static bool ProtectUser(string path) { }

	// RVA: 0x2E73794 Offset: 0x2E6F794 VA: 0x2E73794
	private static bool ProtectMachine(string path) { }

	// RVA: 0x2E738C8 Offset: 0x2E6F8C8 VA: 0x2E738C8
	private static bool IsUserProtected(string path) { }

	// RVA: 0x2E73958 Offset: 0x2E6F958 VA: 0x2E73958
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x2E73044 Offset: 0x2E6F044 VA: 0x2E73044
	private bool get_CanChange() { }

	// RVA: 0x2E73A9C Offset: 0x2E6FA9C VA: 0x2E73A9C
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x2E72578 Offset: 0x2E6E578 VA: 0x2E72578
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x2E72460 Offset: 0x2E6E460 VA: 0x2E72460
	private string get_ContainerName() { }

	// RVA: 0x2E72218 Offset: 0x2E6E218 VA: 0x2E72218
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x2E73208 Offset: 0x2E6F208 VA: 0x2E73208
	private void FromXml(string xml) { }

	// RVA: 0x2E73580 Offset: 0x2E6F580 VA: 0x2E73580
	private string ToXml() { }

	// RVA: 0x2E73ABC Offset: 0x2E6FABC VA: 0x2E73ABC
	private static void .cctor() { }
}
