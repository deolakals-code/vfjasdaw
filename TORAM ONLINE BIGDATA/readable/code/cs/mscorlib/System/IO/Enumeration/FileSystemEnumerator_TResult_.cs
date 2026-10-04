// Assembly: mscorlib.dll
// Namespace: System.IO.Enumeration
public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 10762
{
	// Fields
	private readonly string _originalRootDirectory; // 0x0
	private readonly string _rootDirectory; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly object _lock; // 0x0
	private string _currentPath; // 0x0
	private IntPtr _directoryHandle; // 0x0
	private bool _lastEntryFound; // 0x0
	private Queue<string> _pending; // 0x0
	private Interop.Sys.DirectoryEntry _entry; // 0x0
	private TResult _current; // 0x0
	private char[] _pathBuffer; // 0x0
	private byte[] _entryBuffer; // 0x0

	// Properties
	public TResult Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string directory, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FC9F4 Offset: 0x29F89F4 VA: 0x29FC9F4
	|-FileSystemEnumerator<object>..ctor
	|
	|-RVA: 0x29FDD98 Offset: 0x29F9D98 VA: 0x29FDD98
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool InternalContinueOnError(Interop.ErrorInfo info, bool ignoreNotFound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FCE74 Offset: 0x29F8E74 VA: 0x29FCE74
	|-FileSystemEnumerator<object>.InternalContinueOnError
	|
	|-RVA: 0x29FE314 Offset: 0x29FA314 VA: 0x29FE314
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.InternalContinueOnError
	*/

	// RVA: -1 Offset: -1
	private static bool IsDirectoryNotFound(Interop.ErrorInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FCF28 Offset: 0x29F8F28 VA: 0x29FCF28
	|-FileSystemEnumerator<object>.IsDirectoryNotFound
	|
	|-RVA: 0x29FE3DC Offset: 0x29FA3DC VA: 0x29FE3DC
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.IsDirectoryNotFound
	*/

	// RVA: -1 Offset: -1
	private static bool IsAccessError(Interop.ErrorInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FCF4C Offset: 0x29F8F4C VA: 0x29FCF4C
	|-FileSystemEnumerator<object>.IsAccessError
	|
	|-RVA: 0x29FE400 Offset: 0x29FA400 VA: 0x29FE400
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.IsAccessError
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FCF8C Offset: 0x29F8F8C VA: 0x29FCF8C
	|-FileSystemEnumerator<object>.CreateDirectoryHandle
	|
	|-RVA: 0x29FE440 Offset: 0x29FA440 VA: 0x29FE440
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateDirectoryHandle
	*/

	// RVA: -1 Offset: -1
	private void CloseDirectoryHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FD078 Offset: 0x29F9078 VA: 0x29FD078
	|-FileSystemEnumerator<object>.CloseDirectoryHandle
	|
	|-RVA: 0x29FE530 Offset: 0x29FA530 VA: 0x29FE530
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CloseDirectoryHandle
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FD100 Offset: 0x29F9100 VA: 0x29FD100
	|-FileSystemEnumerator<object>.MoveNext
	|
	|-RVA: 0x29FE5D4 Offset: 0x29FA5D4 VA: 0x29FE5D4
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void FindNextEntry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FD630 Offset: 0x29F9630 VA: 0x29FD630
	|-FileSystemEnumerator<object>.FindNextEntry
	|
	|-RVA: 0x29FEED4 Offset: 0x29FAED4 VA: 0x29FEED4
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.FindNextEntry
	*/

	// RVA: -1 Offset: -1
	private void FindNextEntry(byte* entryBufferPtr, int bufferLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FD664 Offset: 0x29F9664 VA: 0x29FD664
	|-FileSystemEnumerator<object>.FindNextEntry
	|
	|-RVA: 0x29FEF9C Offset: 0x29FAF9C VA: 0x29FEF9C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.FindNextEntry
	*/

	// RVA: -1 Offset: -1
	private bool DequeueNextDirectory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FD79C Offset: 0x29F979C VA: 0x29FD79C
	|-FileSystemEnumerator<object>.DequeueNextDirectory
	|
	|-RVA: 0x29FF134 Offset: 0x29FB134 VA: 0x29FF134
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DequeueNextDirectory
	*/

	// RVA: -1 Offset: -1
	private void InternalDispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FD880 Offset: 0x29F9880 VA: 0x29FD880
	|-FileSystemEnumerator<object>.InternalDispose
	|
	|-RVA: 0x29FF320 Offset: 0x29FB320 VA: 0x29FF320
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.InternalDispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB48 Offset: 0x29F9B48 VA: 0x29FDB48
	|-FileSystemEnumerator<object>.ShouldIncludeEntry
	|
	|-RVA: 0x29FF6F8 Offset: 0x29FB6F8 VA: 0x29FF6F8
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB50 Offset: 0x29F9B50 VA: 0x29FDB50
	|-FileSystemEnumerator<object>.ShouldRecurseIntoEntry
	|
	|-RVA: 0x29FF700 Offset: 0x29FB700 VA: 0x29FF700
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract TResult TransformEntry(ref FileSystemEntry entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB58 Offset: 0x29F9B58 VA: 0x29FDB58
	|-FileSystemEnumerator<object>.OnDirectoryFinished
	|
	|-RVA: 0x29FF708 Offset: 0x29FB708 VA: 0x29FF708
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.OnDirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual bool ContinueOnError(int error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB5C Offset: 0x29F9B5C VA: 0x29FDB5C
	|-FileSystemEnumerator<object>.ContinueOnError
	|
	|-RVA: 0x29FF70C Offset: 0x29FB70C VA: 0x29FF70C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ContinueOnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TResult get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB64 Offset: 0x29F9B64 VA: 0x29FDB64
	|-FileSystemEnumerator<object>.get_Current
	|
	|-RVA: 0x29FF714 Offset: 0x29FB714 VA: 0x29FF714
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB6C Offset: 0x29F9B6C VA: 0x29FDB6C
	|-FileSystemEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x29FF7B4 Offset: 0x29FB7B4 VA: 0x29FF7B4
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	private void DirectoryFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDB74 Offset: 0x29F9B74 VA: 0x29FDB74
	|-FileSystemEnumerator<object>.DirectoryFinished
	|
	|-RVA: 0x29FF858 Offset: 0x29FB858 VA: 0x29FF858
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDC3C Offset: 0x29F9C3C VA: 0x29FDC3C
	|-FileSystemEnumerator<object>.Reset
	|
	|-RVA: 0x29FF97C Offset: 0x29FB97C VA: 0x29FF97C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDC70 Offset: 0x29F9C70 VA: 0x29FDC70
	|-FileSystemEnumerator<object>.Dispose
	|
	|-RVA: 0x29FF9B0 Offset: 0x29FB9B0 VA: 0x29FF9B0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDCEC Offset: 0x29F9CEC VA: 0x29FDCEC
	|-FileSystemEnumerator<object>.Dispose
	|
	|-RVA: 0x29FFA30 Offset: 0x29FBA30 VA: 0x29FFA30
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29FDCF0 Offset: 0x29F9CF0 VA: 0x29FDCF0
	|-FileSystemEnumerator<object>.Finalize
	|
	|-RVA: 0x29FFA34 Offset: 0x29FBA34 VA: 0x29FFA34
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Finalize
	*/
}
