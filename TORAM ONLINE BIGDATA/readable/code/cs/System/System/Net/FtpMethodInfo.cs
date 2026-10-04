// Assembly: System.dll
// Namespace: System.Net
internal class FtpMethodInfo // TypeDefIndex: 14375
{
	// Fields
	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Properties
	internal bool IsCommandOnly { get; }
	internal bool IsUpload { get; }
	internal bool IsDownload { get; }
	internal bool ShouldParseForResponseUri { get; }

	// Methods

	// RVA: 0x34E6C5C Offset: 0x34E2C5C VA: 0x34E6C5C
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x34E469C Offset: 0x34E069C VA: 0x34E469C
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x34E489C Offset: 0x34E089C VA: 0x34E489C
	internal bool get_IsCommandOnly() { }

	// RVA: 0x34E5754 Offset: 0x34E1754 VA: 0x34E5754
	internal bool get_IsUpload() { }

	// RVA: 0x34E5760 Offset: 0x34E1760 VA: 0x34E5760
	internal bool get_IsDownload() { }

	// RVA: 0x34E2D60 Offset: 0x34DED60 VA: 0x34E2D60
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x34E6CB4 Offset: 0x34E2CB4 VA: 0x34E6CB4
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x34E6E14 Offset: 0x34E2E14 VA: 0x34E6E14
	private static void .cctor() { }
}
