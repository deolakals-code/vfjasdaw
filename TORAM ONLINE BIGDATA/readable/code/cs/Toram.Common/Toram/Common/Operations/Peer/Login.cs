// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class Login : PacketBase // TypeDefIndex: 11379
{
	// Fields
	[CompilerGenerated]
	private AccountData <Account>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <AppliId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <AllowEntry>k__BackingField; // 0x2C
	[CompilerGenerated]
	private string <Signature>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <XSignature>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <AppliFlag>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <SelectWorldId>k__BackingField; // 0x44
	[CompilerGenerated]
	private string <AppVersion>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte[] <USignature>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <Model>k__BackingField; // 0x58

	// Properties
	public AccountData Account { get; set; }
	public int AppliId { get; set; }
	public byte AllowEntry { get; set; }
	public string Signature { get; set; }
	public string XSignature { get; set; }
	public byte AppliFlag { get; set; }
	public int SelectWorldId { get; set; }
	public string AppVersion { get; set; }
	public byte[] USignature { get; set; }
	public string Model { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FD9FC Offset: 0x36F99FC VA: 0x36FD9FC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FDA04 Offset: 0x36F9A04 VA: 0x36FDA04
	public AccountData get_Account() { }

	[CompilerGenerated]
	// RVA: 0x36FDA0C Offset: 0x36F9A0C VA: 0x36FDA0C
	public void set_Account(AccountData value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA14 Offset: 0x36F9A14 VA: 0x36FDA14
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x36FDA1C Offset: 0x36F9A1C VA: 0x36FDA1C
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA24 Offset: 0x36F9A24 VA: 0x36FDA24
	public byte get_AllowEntry() { }

	[CompilerGenerated]
	// RVA: 0x36FDA2C Offset: 0x36F9A2C VA: 0x36FDA2C
	public void set_AllowEntry(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA34 Offset: 0x36F9A34 VA: 0x36FDA34
	public string get_Signature() { }

	[CompilerGenerated]
	// RVA: 0x36FDA3C Offset: 0x36F9A3C VA: 0x36FDA3C
	public void set_Signature(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA44 Offset: 0x36F9A44 VA: 0x36FDA44
	public string get_XSignature() { }

	[CompilerGenerated]
	// RVA: 0x36FDA4C Offset: 0x36F9A4C VA: 0x36FDA4C
	public void set_XSignature(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA54 Offset: 0x36F9A54 VA: 0x36FDA54
	public byte get_AppliFlag() { }

	[CompilerGenerated]
	// RVA: 0x36FDA5C Offset: 0x36F9A5C VA: 0x36FDA5C
	public void set_AppliFlag(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA64 Offset: 0x36F9A64 VA: 0x36FDA64
	public int get_SelectWorldId() { }

	[CompilerGenerated]
	// RVA: 0x36FDA6C Offset: 0x36F9A6C VA: 0x36FDA6C
	public void set_SelectWorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA74 Offset: 0x36F9A74 VA: 0x36FDA74
	public string get_AppVersion() { }

	[CompilerGenerated]
	// RVA: 0x36FDA7C Offset: 0x36F9A7C VA: 0x36FDA7C
	public void set_AppVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA84 Offset: 0x36F9A84 VA: 0x36FDA84
	public byte[] get_USignature() { }

	[CompilerGenerated]
	// RVA: 0x36FDA8C Offset: 0x36F9A8C VA: 0x36FDA8C
	public void set_USignature(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36FDA94 Offset: 0x36F9A94 VA: 0x36FDA94
	public string get_Model() { }

	[CompilerGenerated]
	// RVA: 0x36FDA9C Offset: 0x36F9A9C VA: 0x36FDA9C
	public void set_Model(string value) { }

	// RVA: 0x36FDAA4 Offset: 0x36F9AA4 VA: 0x36FDAA4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FDAAC Offset: 0x36F9AAC VA: 0x36FDAAC Slot: 3
	public override string ToString() { }

	// RVA: 0x36FDB04 Offset: 0x36F9B04 VA: 0x36FDB04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FE050 Offset: 0x36FA050 VA: 0x36FE050 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
