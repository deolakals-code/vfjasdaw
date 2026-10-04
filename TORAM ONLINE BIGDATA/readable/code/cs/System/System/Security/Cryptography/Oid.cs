// Assembly: System.dll
// Namespace: System.Security.Cryptography
public sealed class Oid // TypeDefIndex: 14113
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x348B1E4 Offset: 0x34871E4 VA: 0x348B1E4
	public void .ctor() { }

	// RVA: 0x348B1EC Offset: 0x34871EC VA: 0x348B1EC
	public void .ctor(string oid) { }

	// RVA: 0x348B280 Offset: 0x3487280 VA: 0x348B280
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x348B2C4 Offset: 0x34872C4 VA: 0x348B2C4
	public void .ctor(Oid oid) { }

	// RVA: 0x348B35C Offset: 0x348735C VA: 0x348B35C
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x348B4E0 Offset: 0x34874E0 VA: 0x348B4E0
	public string get_Value() { }

	// RVA: 0x348B4E8 Offset: 0x34874E8 VA: 0x348B4E8
	public void set_Value(string value) { }

	// RVA: 0x348B4F0 Offset: 0x34874F0 VA: 0x348B4F0
	public string get_FriendlyName() { }

	// RVA: 0x348B488 Offset: 0x3487488 VA: 0x348B488
	private void .ctor(string value, string friendlyName, OidGroup group) { }
}
