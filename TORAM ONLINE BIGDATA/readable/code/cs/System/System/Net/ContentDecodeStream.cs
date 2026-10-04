// Assembly: System.dll
// Namespace: System.Net
internal class ContentDecodeStream : WebReadStream // TypeDefIndex: 14471
{
	// Fields
	[CompilerGenerated]
	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Properties
	private Stream OriginalInnerStream { get; }

	// Methods

	// RVA: 0x3508A08 Offset: 0x3504A08 VA: 0x3508A08
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode) { }

	[CompilerGenerated]
	// RVA: 0x3508B20 Offset: 0x3504B20 VA: 0x3508B20
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x3508AF0 Offset: 0x3504AF0 VA: 0x3508AF0
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x3508B28 Offset: 0x3504B28 VA: 0x3508B28 Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x3508B4C Offset: 0x3504B4C VA: 0x3508B4C Slot: 38
	internal override Task FinishReading(CancellationToken cancellationToken) { }
}
