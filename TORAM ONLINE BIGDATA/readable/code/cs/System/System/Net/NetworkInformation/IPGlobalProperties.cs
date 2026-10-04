// Assembly: System.dll
// Namespace: System.Net.NetworkInformation
public abstract class IPGlobalProperties // TypeDefIndex: 14543
{
	// Properties
	public abstract string DomainName { get; }

	// Methods

	// RVA: 0x344C7E0 Offset: 0x34487E0 VA: 0x344C7E0
	public static IPGlobalProperties GetIPGlobalProperties() { }

	// RVA: 0x344C82C Offset: 0x344882C VA: 0x344C82C
	internal static IPGlobalProperties InternalGetIPGlobalProperties() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_DomainName();

	// RVA: 0x344C830 Offset: 0x3448830 VA: 0x344C830
	protected void .ctor() { }
}
