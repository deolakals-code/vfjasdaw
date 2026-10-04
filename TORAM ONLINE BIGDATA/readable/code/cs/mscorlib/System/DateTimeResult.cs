// Assembly: mscorlib.dll
// Namespace: System
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct DateTimeResult // TypeDefIndex: 9598
{
	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58
	internal ReadOnlySpan<char> originalDateTimeString; // 0x60
	internal ReadOnlySpan<char> failedFormatSpecifier; // 0x70

	// Methods

	// RVA: 0x2FDE424 Offset: 0x2FDA424 VA: 0x2FDE424
	internal void Init(ReadOnlySpan<char> originalDateTimeString) { }

	// RVA: 0x2FDE448 Offset: 0x2FDA448 VA: 0x2FDE448
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x2FDE454 Offset: 0x2FDA454 VA: 0x2FDE454
	internal void SetBadFormatSpecifierFailure() { }

	// RVA: 0x2FDE4E8 Offset: 0x2FDA4E8 VA: 0x2FDE4E8
	internal void SetBadFormatSpecifierFailure(ReadOnlySpan<char> failedFormatSpecifier) { }

	// RVA: 0x2FDE54C Offset: 0x2FDA54C VA: 0x2FDE54C
	internal void SetBadDateTimeFailure() { }

	// RVA: 0x2FDE59C Offset: 0x2FDA59C VA: 0x2FDE59C
	internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

	// RVA: 0x2FDE5A8 Offset: 0x2FDA5A8 VA: 0x2FDE5A8
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x2FDE5B4 Offset: 0x2FDA5B4 VA: 0x2FDE5B4
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }
}
