// Assembly: mscorlib.dll
// Namespace: System.Security
[Serializable]
internal sealed class SecurityDocument // TypeDefIndex: 10068
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x2EA1D18 Offset: 0x2E9DD18 VA: 0x2EA1D18
	public void .ctor(int numData) { }

	// RVA: 0x2EA1D88 Offset: 0x2E9DD88 VA: 0x2EA1D88
	public void GuaranteeSize(int size) { }

	// RVA: 0x2EA1E40 Offset: 0x2E9DE40 VA: 0x2EA1E40
	public void AddString(string str, ref int position) { }

	// RVA: 0x2EA1F8C Offset: 0x2E9DF8C VA: 0x2EA1F8C
	public void AppendString(string str, ref int position) { }

	// RVA: 0x2EA2018 Offset: 0x2E9E018 VA: 0x2EA2018
	public static int EncodedStringSize(string str) { }

	// RVA: 0x2EA2038 Offset: 0x2E9E038 VA: 0x2EA2038
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x2EA2590 Offset: 0x2E9E590 VA: 0x2EA2590
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x2EA25EC Offset: 0x2E9E5EC VA: 0x2EA25EC
	public SecurityElement GetRootElement() { }

	// RVA: 0x2EA2608 Offset: 0x2E9E608 VA: 0x2EA2608
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x2EA2624 Offset: 0x2E9E624 VA: 0x2EA2624
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}
