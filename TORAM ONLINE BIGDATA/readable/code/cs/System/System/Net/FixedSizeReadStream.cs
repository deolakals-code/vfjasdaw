// Assembly: System.dll
// Namespace: System.Net
internal class FixedSizeReadStream : WebReadStream // TypeDefIndex: 14480
{
	// Fields
	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; // 0x40
	private long position; // 0x48

	// Properties
	public long ContentLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x350BE64 Offset: 0x3507E64 VA: 0x350BE64
	public long get_ContentLength() { }

	// RVA: 0x350BE6C Offset: 0x3507E6C VA: 0x350BE6C
	public void .ctor(WebOperation operation, Stream innerStream, long contentLength) { }

	[AsyncStateMachine(typeof(FixedSizeReadStream.<ProcessReadAsync>d__5))]
	// RVA: 0x350BE94 Offset: 0x3507E94 VA: 0x350BE94 Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }
}
