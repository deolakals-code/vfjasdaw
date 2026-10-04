// Assembly: mscorlib.dll
// Namespace: 
private struct Enum.EnumResult // TypeDefIndex: 9751
{
	// Fields
	internal object parsedEnum; // 0x0
	internal bool canThrow; // 0x8
	internal Enum.ParseFailureKind m_failure; // 0xC
	internal string m_failureMessageID; // 0x10
	internal string m_failureParameter; // 0x18
	internal object m_failureMessageFormatArgument; // 0x20
	internal Exception m_innerException; // 0x28

	// Methods

	// RVA: 0x3018C34 Offset: 0x3014C34 VA: 0x3018C34
	internal void Init(bool canMethodThrow) { }

	// RVA: 0x3019B2C Offset: 0x3015B2C VA: 0x3019B2C
	internal void SetFailure(Exception unhandledException) { }

	// RVA: 0x30194A4 Offset: 0x30154A4 VA: 0x30194A4
	internal void SetFailure(Enum.ParseFailureKind failure, string failureParameter) { }

	// RVA: 0x3019500 Offset: 0x3015500 VA: 0x3019500
	internal void SetFailure(Enum.ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x301932C Offset: 0x301532C VA: 0x301932C
	internal Exception GetEnumParseException() { }
}
