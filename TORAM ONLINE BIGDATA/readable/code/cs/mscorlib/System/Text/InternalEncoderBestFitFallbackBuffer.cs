// Assembly: mscorlib.dll
// Namespace: System.Text
internal sealed class InternalEncoderBestFitFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 10027
{
	// Fields
	private char _cBestFit; // 0x30
	private InternalEncoderBestFitFallback _oFallback; // 0x38
	private int _iCount; // 0x40
	private int _iSize; // 0x44
	private static object s_InternalSyncObject; // 0x0

	// Properties
	private static object InternalSyncObject { get; }
	public override int Remaining { get; }

	// Methods

	// RVA: 0x306A3F0 Offset: 0x30663F0 VA: 0x306A3F0
	private static object get_InternalSyncObject() { }

	// RVA: 0x306A1BC Offset: 0x30661BC VA: 0x306A1BC
	public void .ctor(InternalEncoderBestFitFallback fallback) { }

	// RVA: 0x306A48C Offset: 0x306648C VA: 0x306A48C Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x306A590 Offset: 0x3066590 VA: 0x306A590 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x306A768 Offset: 0x3066768 VA: 0x306A768 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x306A7A8 Offset: 0x30667A8 VA: 0x306A7A8 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x306A7D4 Offset: 0x30667D4 VA: 0x306A7D4 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x306A7E0 Offset: 0x30667E0 VA: 0x306A7E0 Slot: 9
	public override void Reset() { }

	// RVA: 0x306A4BC Offset: 0x30664BC VA: 0x306A4BC
	private char TryBestFit(char cUnknown) { }
}
