// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal class FileSystemCalls : IFileSystemCalls // TypeDefIndex: 17465
{
	// Fields
	private readonly bool m_CanAccessFileSystem; // 0x10

	// Methods

	// RVA: 0x379C47C Offset: 0x379847C VA: 0x379C47C
	internal void .ctor() { }

	// RVA: 0x37A68A0 Offset: 0x37A28A0 VA: 0x37A68A0 Slot: 4
	public bool CanAccessFileSystem() { }

	// RVA: 0x37A68A8 Offset: 0x37A28A8 VA: 0x37A68A8 Slot: 5
	public bool FileExists(string path) { }

	// RVA: 0x37A68B4 Offset: 0x37A28B4 VA: 0x37A68B4 Slot: 6
	public void DeleteFile(string path) { }

	// RVA: 0x37A68C0 Offset: 0x37A28C0 VA: 0x37A68C0 Slot: 7
	public Stream OpenFileForWriting(string path) { }
}
