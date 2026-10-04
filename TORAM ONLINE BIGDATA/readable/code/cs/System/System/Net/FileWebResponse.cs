// Assembly: System.dll
// Namespace: System.Net
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 14454
{
	// Fields
	private bool m_closed; // 0x19
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x3502EC4 Offset: 0x34FEEC4 VA: 0x3502EC4
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x3503E44 Offset: 0x34FFE44 VA: 0x3503E44
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x35040C0 Offset: 0x35000C0 VA: 0x35040C0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x35040CC Offset: 0x35000CC VA: 0x35040CC Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x3504284 Offset: 0x3500284 VA: 0x3504284 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x3504318 Offset: 0x3500318 VA: 0x3504318 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x350429C Offset: 0x350029C VA: 0x350429C
	private void CheckDisposed() { }

	// RVA: 0x3504330 Offset: 0x3500330 VA: 0x3504330 Slot: 9
	public override void Close() { }

	// RVA: 0x35043C8 Offset: 0x35003C8 VA: 0x35043C8 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x3504544 Offset: 0x3500544 VA: 0x3504544 Slot: 12
	public override Stream GetResponseStream() { }
}
