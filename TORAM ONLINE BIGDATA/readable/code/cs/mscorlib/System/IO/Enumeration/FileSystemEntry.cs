// Assembly: mscorlib.dll
// Namespace: System.IO.Enumeration
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
public struct FileSystemEntry // TypeDefIndex: 10752
{
	// Fields
	internal Interop.Sys.DirectoryEntry _directoryEntry; // 0x0
	private FileStatus _status; // 0x10
	private Span<char> _pathBuffer; // 0x88
	private ReadOnlySpan<char> _fullPath; // 0x98
	private ReadOnlySpan<char> _fileName; // 0xA8
	[FixedBuffer(typeof(char), 256)]
	private FileSystemEntry.<_fileNameBuffer>e__FixedBuffer _fileNameBuffer; // 0xB8
	private FileAttributes _initialAttributes; // 0x2B8
	[CompilerGenerated]
	private ReadOnlySpan<char> <Directory>k__BackingField; // 0x2C0
	[CompilerGenerated]
	private ReadOnlySpan<char> <RootDirectory>k__BackingField; // 0x2D0
	[CompilerGenerated]
	private ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField; // 0x2E0

	// Properties
	private ReadOnlySpan<char> FullPath { get; }
	public ReadOnlySpan<char> FileName { get; }
	public ReadOnlySpan<char> Directory { get; set; }
	public ReadOnlySpan<char> RootDirectory { get; set; }
	public ReadOnlySpan<char> OriginalRootDirectory { get; set; }
	public FileAttributes Attributes { get; }
	public bool IsDirectory { get; }

	// Methods

	// RVA: 0x2F5D568 Offset: 0x2F59568 VA: 0x2F5D568
	internal static FileAttributes Initialize(ref FileSystemEntry entry, Interop.Sys.DirectoryEntry directoryEntry, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory, Span<char> pathBuffer) { }

	// RVA: 0x2F5D7E4 Offset: 0x2F597E4 VA: 0x2F5D7E4
	private ReadOnlySpan<char> get_FullPath() { }

	// RVA: 0x2F5D914 Offset: 0x2F59914 VA: 0x2F5D914
	public ReadOnlySpan<char> get_FileName() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x2F5D984 Offset: 0x2F59984 VA: 0x2F5D984
	public ReadOnlySpan<char> get_Directory() { }

	[CompilerGenerated]
	// RVA: 0x2F5D994 Offset: 0x2F59994 VA: 0x2F5D994
	private void set_Directory(ReadOnlySpan<char> value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x2F5D9A0 Offset: 0x2F599A0 VA: 0x2F5D9A0
	public ReadOnlySpan<char> get_RootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x2F5D9B0 Offset: 0x2F599B0 VA: 0x2F5D9B0
	private void set_RootDirectory(ReadOnlySpan<char> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x2F5D9BC Offset: 0x2F599BC VA: 0x2F5D9BC
	public ReadOnlySpan<char> get_OriginalRootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x2F5D9CC Offset: 0x2F599CC VA: 0x2F5D9CC
	private void set_OriginalRootDirectory(ReadOnlySpan<char> value) { }

	// RVA: 0x2F5D9D8 Offset: 0x2F599D8 VA: 0x2F5D9D8
	public FileAttributes get_Attributes() { }

	// RVA: 0x2F5DA20 Offset: 0x2F59A20 VA: 0x2F5DA20
	public bool get_IsDirectory() { }

	// RVA: 0x2F5DA28 Offset: 0x2F59A28 VA: 0x2F5DA28
	public string ToSpecifiedFullPath() { }
}
