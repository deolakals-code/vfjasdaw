// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class LoginResponse : PacketBase // TypeDefIndex: 11380
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AsobimoId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Address>k__BackingField; // 0x30
	[CompilerGenerated]
	private AppVerData <AppVerData>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <PrevWorldId>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <WorldId>k__BackingField; // 0x44
	[CompilerGenerated]
	private WorldLoginData[] <WorldList>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <ServerType>k__BackingField; // 0x50

	// Properties
	public int AvatarUuid { get; set; }
	public string AsobimoId { get; set; }
	public string Address { get; set; }
	public AppVerData AppVerData { get; set; }
	public int PrevWorldId { get; set; }
	public int WorldId { get; set; }
	public WorldLoginData[] WorldList { get; set; }
	public byte ServerType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FE260 Offset: 0x36FA260 VA: 0x36FE260
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FE268 Offset: 0x36FA268 VA: 0x36FE268
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36FE270 Offset: 0x36FA270 VA: 0x36FE270
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FE278 Offset: 0x36FA278 VA: 0x36FE278
	public string get_AsobimoId() { }

	[CompilerGenerated]
	// RVA: 0x36FE280 Offset: 0x36FA280 VA: 0x36FE280
	public void set_AsobimoId(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FE288 Offset: 0x36FA288 VA: 0x36FE288
	public string get_Address() { }

	[CompilerGenerated]
	// RVA: 0x36FE290 Offset: 0x36FA290 VA: 0x36FE290
	public void set_Address(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FE298 Offset: 0x36FA298 VA: 0x36FE298
	public AppVerData get_AppVerData() { }

	[CompilerGenerated]
	// RVA: 0x36FE2A0 Offset: 0x36FA2A0 VA: 0x36FE2A0
	public void set_AppVerData(AppVerData value) { }

	[CompilerGenerated]
	// RVA: 0x36FE2A8 Offset: 0x36FA2A8 VA: 0x36FE2A8
	public int get_PrevWorldId() { }

	[CompilerGenerated]
	// RVA: 0x36FE2B0 Offset: 0x36FA2B0 VA: 0x36FE2B0
	public void set_PrevWorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FE2B8 Offset: 0x36FA2B8 VA: 0x36FE2B8
	public int get_WorldId() { }

	[CompilerGenerated]
	// RVA: 0x36FE2C0 Offset: 0x36FA2C0 VA: 0x36FE2C0
	public void set_WorldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FE2C8 Offset: 0x36FA2C8 VA: 0x36FE2C8
	public WorldLoginData[] get_WorldList() { }

	[CompilerGenerated]
	// RVA: 0x36FE2D0 Offset: 0x36FA2D0 VA: 0x36FE2D0
	public void set_WorldList(WorldLoginData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36FE2D8 Offset: 0x36FA2D8 VA: 0x36FE2D8
	public byte get_ServerType() { }

	[CompilerGenerated]
	// RVA: 0x36FE2E0 Offset: 0x36FA2E0 VA: 0x36FE2E0
	public void set_ServerType(byte value) { }

	// RVA: 0x36FE2E8 Offset: 0x36FA2E8 VA: 0x36FE2E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FE2F0 Offset: 0x36FA2F0 VA: 0x36FE2F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FE754 Offset: 0x36FA754 VA: 0x36FE754 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
