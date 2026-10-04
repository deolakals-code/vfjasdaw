// Assembly: mscorlib.dll
// Namespace: System.IO
internal struct FileStatus // TypeDefIndex: 10715
{
	// Fields
	private Interop.Sys.FileStatus _fileStatus; // 0x0
	private int _fileStatusInitialized; // 0x70
	[CompilerGenerated]
	private bool <InitiallyDirectory>k__BackingField; // 0x74
	internal bool _isDirectory; // 0x75
	private bool _exists; // 0x76

	// Properties
	internal bool InitiallyDirectory { get; set; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x2F4B59C Offset: 0x2F4759C VA: 0x2F4B59C
	internal bool get_InitiallyDirectory() { }

	[CompilerGenerated]
	// RVA: 0x2F4B5A4 Offset: 0x2F475A4 VA: 0x2F4B5A4
	private void set_InitiallyDirectory(bool value) { }

	// RVA: 0x2F4B5B0 Offset: 0x2F475B0 VA: 0x2F4B5B0
	internal static void Initialize(ref FileStatus status, bool isDirectory) { }

	// RVA: 0x2F4B5C4 Offset: 0x2F475C4 VA: 0x2F4B5C4
	internal bool IsReadOnly(ReadOnlySpan<char> path, bool continueOnError = False) { }

	// RVA: 0x2F4B774 Offset: 0x2F47774 VA: 0x2F4B774
	internal bool GetExists(ReadOnlySpan<char> path) { }

	// RVA: 0x2F4B7B8 Offset: 0x2F477B8 VA: 0x2F4B7B8
	public void Refresh(ReadOnlySpan<char> path) { }

	// RVA: 0x2F4B6B4 Offset: 0x2F476B4 VA: 0x2F4B6B4
	internal void EnsureStatInitialized(ReadOnlySpan<char> path, bool continueOnError = False) { }
}
