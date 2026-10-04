// Assembly: mscorlib.dll
// Namespace: System.Text
internal sealed class InternalDecoderBestFitFallbackBuffer : DecoderFallbackBuffer // TypeDefIndex: 10016
{
	// Fields
	private char _cBestFit; // 0x20
	private int _iCount; // 0x24
	private int _iSize; // 0x28
	private InternalDecoderBestFitFallback _oFallback; // 0x30
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x3067B90 Offset: 0x3063B90 VA: 0x3067B90
	private static object get_InternalSyncObject() { }

	// RVA: 0x3067978 Offset: 0x3063978 VA: 0x3067978
	public void .ctor(InternalDecoderBestFitFallback fallback) { }

	// RVA: 0x3067C2C Offset: 0x3063C2C VA: 0x3067C2C Slot: 4
	public override bool Fallback(byte[] bytesUnknown, int index) { }

	// RVA: 0x3067DAC Offset: 0x3063DAC VA: 0x3067DAC Slot: 5
	public override char GetNextChar() { }

	// RVA: 0x3067DEC Offset: 0x3063DEC VA: 0x3067DEC Slot: 6
	public override int get_Remaining() { }

	// RVA: 0x3067DF8 Offset: 0x3063DF8 VA: 0x3067DF8 Slot: 7
	public override void Reset() { }

	// RVA: 0x3067E08 Offset: 0x3063E08 VA: 0x3067E08 Slot: 9
	internal override int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x3067C6C Offset: 0x3063C6C VA: 0x3067C6C
	private char TryBestFit(byte[] bytesCheck) { }
}
