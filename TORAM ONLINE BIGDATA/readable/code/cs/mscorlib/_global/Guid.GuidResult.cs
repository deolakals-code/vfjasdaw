// Assembly: mscorlib.dll
// Namespace: 
private struct Guid.GuidResult // TypeDefIndex: 9604
{
	// Fields
	internal Guid _parsedGuid; // 0x0
	internal Guid.GuidParseThrowStyle _throwStyle; // 0x10
	private Guid.ParseFailureKind _failure; // 0x14
	private string _failureMessageID; // 0x18
	private object _failureMessageFormatArgument; // 0x20
	private string _failureArgumentName; // 0x28
	private Exception _innerException; // 0x30

	// Methods

	// RVA: 0x2FE10CC Offset: 0x2FDD0CC VA: 0x2FE10CC
	internal void Init(Guid.GuidParseThrowStyle canThrow) { }

	// RVA: 0x2FE03A4 Offset: 0x2FDC3A4 VA: 0x2FE03A4
	internal void SetFailure(Exception nativeException) { }

	// RVA: 0x2FDEFC8 Offset: 0x2FDAFC8 VA: 0x2FDEFC8
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x2FDFFA0 Offset: 0x2FDBFA0 VA: 0x2FDFFA0
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x2FDFC00 Offset: 0x2FDBC00 VA: 0x2FDFC00
	internal void SetFailure(Guid.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	// RVA: 0x2FDEB38 Offset: 0x2FDAB38 VA: 0x2FDEB38
	internal Exception GetGuidParseException() { }
}
