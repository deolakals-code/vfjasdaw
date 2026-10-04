// Assembly: mscorlib.dll
// Namespace: System.Reflection
[ComVisible(True)]
[ComDefaultInterface(typeof(_AssemblyName))]
[ClassInterface(0)]
[Serializable]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 10640
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; }
	public CultureInfo CultureInfo { get; }
	public AssemblyNameFlags Flags { get; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x2F332FC Offset: 0x2F2F2FC VA: 0x2F332FC
	public void .ctor() { }

	// RVA: 0x2F3331C Offset: 0x2F2F31C VA: 0x2F3331C
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x2F33320 Offset: 0x2F2F320 VA: 0x2F33320
	public void .ctor(string assemblyName) { }

	// RVA: 0x2F338C8 Offset: 0x2F2F8C8 VA: 0x2F338C8
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x2F33E68 Offset: 0x2F2FE68 VA: 0x2F33E68
	public string get_Name() { }

	// RVA: 0x2F33E70 Offset: 0x2F2FE70 VA: 0x2F33E70
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x2F33E78 Offset: 0x2F2FE78 VA: 0x2F33E78
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x2F33E80 Offset: 0x2F2FE80 VA: 0x2F33E80
	public string get_FullName() { }

	// RVA: 0x2F342D4 Offset: 0x2F302D4 VA: 0x2F342D4
	public Version get_Version() { }

	// RVA: 0x2F342DC Offset: 0x2F302DC VA: 0x2F342DC
	public void set_Version(Version value) { }

	// RVA: 0x2F3432C Offset: 0x2F3032C VA: 0x2F3432C Slot: 3
	public override string ToString() { }

	// RVA: 0x2F34354 Offset: 0x2F30354 VA: 0x2F34354
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x2F3444C Offset: 0x2F3044C VA: 0x2F3444C
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x2F341F0 Offset: 0x2F301F0 VA: 0x2F341F0
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x2F3455C Offset: 0x2F3055C VA: 0x2F3455C
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x2F344D0 Offset: 0x2F304D0 VA: 0x2F344D0
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x2F34560 Offset: 0x2F30560 VA: 0x2F34560 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F3488C Offset: 0x2F3088C VA: 0x2F3488C Slot: 4
	public object Clone() { }

	// RVA: 0x2F3497C Offset: 0x2F3097C VA: 0x2F3497C Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x2F34984 Offset: 0x2F30984 VA: 0x2F34984
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x2F335D4 Offset: 0x2F2F5D4 VA: 0x2F335D4
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x2F34988 Offset: 0x2F30988 VA: 0x2F34988
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}
