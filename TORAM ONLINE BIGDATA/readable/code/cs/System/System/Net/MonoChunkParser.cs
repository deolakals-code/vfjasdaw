// Assembly: System.dll
// Namespace: System.Net
internal class MonoChunkParser // TypeDefIndex: 14494
{
	// Fields
	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkParser.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x3512E08 Offset: 0x350EE08 VA: 0x3512E08
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x3512ED8 Offset: 0x350EED8 VA: 0x3512ED8
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x3512EDC Offset: 0x350EEDC VA: 0x3512EDC
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x351325C Offset: 0x350F25C VA: 0x351325C
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x351327C Offset: 0x350F27C VA: 0x351327C
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x3513BA8 Offset: 0x350FBA8 VA: 0x3513BA8
	public bool get_WantMore() { }

	// RVA: 0x3513BCC Offset: 0x350FBCC VA: 0x3513BCC
	public bool get_DataAvailable() { }

	// RVA: 0x3513CCC Offset: 0x350FCCC VA: 0x3513CCC
	public int get_ChunkLeft() { }

	// RVA: 0x35136B0 Offset: 0x350F6B0 VA: 0x35136B0
	private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x35133B8 Offset: 0x350F3B8 VA: 0x35133B8
	private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x3513D58 Offset: 0x350FD58 VA: 0x3513D58
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x35137F0 Offset: 0x350F7F0 VA: 0x35137F0
	private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x35138F0 Offset: 0x350F8F0 VA: 0x35138F0
	private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x3513D08 Offset: 0x350FD08 VA: 0x3513D08
	private static void ThrowProtocolViolation(string message) { }
}
