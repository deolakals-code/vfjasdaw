// Assembly: System.dll
// Namespace: System.Net
internal class MonoChunkStream : WebReadStream // TypeDefIndex: 14497
{
	// Fields
	[CompilerGenerated]
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Properties
	protected MonoChunkParser Decoder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x3513DA0 Offset: 0x350FDA0 VA: 0x3513DA0
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x3513DA8 Offset: 0x350FDA8 VA: 0x3513DA8
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<ProcessReadAsync>d__7))]
	// RVA: 0x3513ECC Offset: 0x350FECC VA: 0x3513ECC Slot: 37
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<FinishReading>d__8))]
	// RVA: 0x3514034 Offset: 0x3510034 VA: 0x3514034 Slot: 38
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x3514134 Offset: 0x3510134 VA: 0x3514134
	private static void ThrowExpectingChunkTrailer() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x351418C Offset: 0x351018C VA: 0x351418C
	private Task <>n__0(CancellationToken cancellationToken) { }
}
