// Assembly: mscorlib.dll
// Namespace: System.Globalization
internal static class EncodingTable // TypeDefIndex: 10821
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Dictionary<string, int> hashByName; // 0x18
	private static Dictionary<int, CodePageDataItem> hashByCodePage; // 0x20

	// Methods

	// RVA: 0x2F9EF68 Offset: 0x2F9AF68 VA: 0x2F9EF68
	private static int GetNumEncodingItems() { }

	// RVA: 0x2F9EFCC Offset: 0x2F9AFCC VA: 0x2F9EFCC
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x2F9EFFC Offset: 0x2F9AFFC VA: 0x2F9EFFC
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x2F9F030 Offset: 0x2F9B030 VA: 0x2F9F030
	private static void .cctor() { }

	// RVA: 0x2FA8F30 Offset: 0x2FA4F30 VA: 0x2FA8F30
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x2FA9184 Offset: 0x2FA5184 VA: 0x2FA9184
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x2FA9400 Offset: 0x2FA5400 VA: 0x2FA9400
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}
