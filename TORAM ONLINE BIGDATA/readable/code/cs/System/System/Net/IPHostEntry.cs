// Assembly: System.dll
// Namespace: System.Net
public class IPHostEntry // TypeDefIndex: 14394
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x34EE12C Offset: 0x34EA12C VA: 0x34EE12C
	public string get_HostName() { }

	// RVA: 0x34EE134 Offset: 0x34EA134 VA: 0x34EE134
	public void set_HostName(string value) { }

	// RVA: 0x34EE13C Offset: 0x34EA13C VA: 0x34EE13C
	public void set_Aliases(string[] value) { }

	// RVA: 0x34EE144 Offset: 0x34EA144 VA: 0x34EE144
	public IPAddress[] get_AddressList() { }

	// RVA: 0x34EE14C Offset: 0x34EA14C VA: 0x34EE14C
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x34EE154 Offset: 0x34EA154 VA: 0x34EE154
	public void .ctor() { }
}
