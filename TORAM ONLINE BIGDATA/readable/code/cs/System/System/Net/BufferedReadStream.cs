// Assembly: System.dll
// Namespace: System.Net
internal class BufferedReadStream : WebReadStream // TypeDefIndex: 14469
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x350842C Offset: 0x350442C VA: 0x350842C
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[AsyncStateMachine(typeof(BufferedReadStream.<ProcessReadAsync>d__2))]
	// RVA: 0x350845C Offset: 0x350445C VA: 0x350845C Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x35085C4 Offset: 0x35045C4 VA: 0x35085C4
	internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result) { }
}
