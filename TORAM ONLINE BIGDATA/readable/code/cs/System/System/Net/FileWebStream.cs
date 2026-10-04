// Assembly: System.dll
// Namespace: System.Net
internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 14453
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x3502B04 Offset: 0x34FEB04 VA: 0x3502B04
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x350378C Offset: 0x34FF78C VA: 0x350378C
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x3503848 Offset: 0x34FF848 VA: 0x3503848 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x35038F8 Offset: 0x34FF8F8 VA: 0x35038F8 Slot: 39
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x3503934 Offset: 0x34FF934 VA: 0x3503934 Slot: 31
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x3503A7C Offset: 0x34FFA7C VA: 0x3503A7C Slot: 34
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x3503B44 Offset: 0x34FFB44 VA: 0x3503B44 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x3503C24 Offset: 0x34FFC24 VA: 0x3503C24 Slot: 22
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x3503CC4 Offset: 0x34FFCC4 VA: 0x3503CC4 Slot: 25
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x3503DA4 Offset: 0x34FFDA4 VA: 0x3503DA4 Slot: 26
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x35039FC Offset: 0x34FF9FC VA: 0x35039FC
	private void CheckError() { }
}
