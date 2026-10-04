// Assembly: System.dll
// Namespace: System.Net.NetworkInformation
internal abstract class CommonUnixIPGlobalProperties : IPGlobalProperties // TypeDefIndex: 14547
{
	// Properties
	public override string DomainName { get; }

	// Methods

	// RVA: 0x344C944 Offset: 0x3448944 VA: 0x344C944
	private static extern int getdomainname(byte[] name, int len) { }

	// RVA: 0x344C9D0 Offset: 0x34489D0 VA: 0x344C9D0 Slot: 4
	public override string get_DomainName() { }

	// RVA: 0x344CB5C Offset: 0x3448B5C VA: 0x344CB5C
	protected void .ctor() { }
}
