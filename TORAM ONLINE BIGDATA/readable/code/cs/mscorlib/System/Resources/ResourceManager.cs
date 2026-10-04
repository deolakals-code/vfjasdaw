// Assembly: mscorlib.dll
// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceManager // TypeDefIndex: 10562
{
	// Fields
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; // 0x10
	private Dictionary<string, ResourceSet> _resourceSets; // 0x18
	protected Assembly MainAssembly; // 0x20
	private CultureInfo _neutralResourcesCulture; // 0x28
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x30
	private bool UseManifest; // 0x38
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; // 0x39
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x3C
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; // 0x40
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; // 0x48
	private IResourceGroveler resourceGroveler; // 0x50
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Methods

	// RVA: 0x2F24E00 Offset: 0x2F20E00 VA: 0x2F24E00
	private void Init() { }

	// RVA: 0x2F24F34 Offset: 0x2F20F34 VA: 0x2F24F34
	protected void .ctor() { }

	[OnDeserializing]
	// RVA: 0x2F250A4 Offset: 0x2F210A4 VA: 0x2F250A4
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x2F250DC Offset: 0x2F210DC VA: 0x2F250DC
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x2F25308 Offset: 0x2F21308 VA: 0x2F25308
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x2F25380 Offset: 0x2F21380 VA: 0x2F25380
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x2F255E8 Offset: 0x2F215E8 VA: 0x2F255E8
	private static void .cctor() { }
}
