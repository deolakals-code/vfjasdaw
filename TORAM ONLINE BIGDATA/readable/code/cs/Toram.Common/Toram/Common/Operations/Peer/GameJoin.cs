// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class GameJoin : PacketBase // TypeDefIndex: 11375
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <AsobimoId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <Guid>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <AppliId>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <GameScene>k__BackingField; // 0x3C
	[CompilerGenerated]
	private int <AssembleyVersion>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <AsobimoAccount>k__BackingField; // 0x44
	[CompilerGenerated]
	private string <XSignature>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte[] <USignature>k__BackingField; // 0x50
	[CompilerGenerated]
	private string <AppVersion>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <Model>k__BackingField; // 0x60

	// Properties
	public int AvatarUuid { get; set; }
	public string AsobimoId { get; set; }
	public string Guid { get; set; }
	public int AppliId { get; set; }
	public byte GameScene { get; set; }
	public int AssembleyVersion { get; set; }
	public byte AsobimoAccount { get; set; }
	public string XSignature { get; set; }
	public byte[] USignature { get; set; }
	public string AppVersion { get; set; }
	public string Model { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FBFC8 Offset: 0x36F7FC8 VA: 0x36FBFC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FBFD0 Offset: 0x36F7FD0 VA: 0x36FBFD0
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36FBFD8 Offset: 0x36F7FD8 VA: 0x36FBFD8
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FBFE0 Offset: 0x36F7FE0 VA: 0x36FBFE0
	public string get_AsobimoId() { }

	[CompilerGenerated]
	// RVA: 0x36FBFE8 Offset: 0x36F7FE8 VA: 0x36FBFE8
	public void set_AsobimoId(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FBFF0 Offset: 0x36F7FF0 VA: 0x36FBFF0
	public string get_Guid() { }

	[CompilerGenerated]
	// RVA: 0x36FBFF8 Offset: 0x36F7FF8 VA: 0x36FBFF8
	public void set_Guid(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FC000 Offset: 0x36F8000 VA: 0x36FC000
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x36FC008 Offset: 0x36F8008 VA: 0x36FC008
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FC010 Offset: 0x36F8010 VA: 0x36FC010
	public byte get_GameScene() { }

	[CompilerGenerated]
	// RVA: 0x36FC018 Offset: 0x36F8018 VA: 0x36FC018
	public void set_GameScene(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FC020 Offset: 0x36F8020 VA: 0x36FC020
	public int get_AssembleyVersion() { }

	[CompilerGenerated]
	// RVA: 0x36FC028 Offset: 0x36F8028 VA: 0x36FC028
	public void set_AssembleyVersion(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FC030 Offset: 0x36F8030 VA: 0x36FC030
	public byte get_AsobimoAccount() { }

	[CompilerGenerated]
	// RVA: 0x36FC038 Offset: 0x36F8038 VA: 0x36FC038
	public void set_AsobimoAccount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FC040 Offset: 0x36F8040 VA: 0x36FC040
	public string get_XSignature() { }

	[CompilerGenerated]
	// RVA: 0x36FC048 Offset: 0x36F8048 VA: 0x36FC048
	public void set_XSignature(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FC050 Offset: 0x36F8050 VA: 0x36FC050
	public byte[] get_USignature() { }

	[CompilerGenerated]
	// RVA: 0x36FC058 Offset: 0x36F8058 VA: 0x36FC058
	public void set_USignature(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36FC060 Offset: 0x36F8060 VA: 0x36FC060
	public string get_AppVersion() { }

	[CompilerGenerated]
	// RVA: 0x36FC068 Offset: 0x36F8068 VA: 0x36FC068
	public void set_AppVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FC070 Offset: 0x36F8070 VA: 0x36FC070
	public string get_Model() { }

	[CompilerGenerated]
	// RVA: 0x36FC078 Offset: 0x36F8078 VA: 0x36FC078
	public void set_Model(string value) { }

	// RVA: 0x36FC080 Offset: 0x36F8080 VA: 0x36FC080 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FC088 Offset: 0x36F8088 VA: 0x36FC088 Slot: 3
	public override string ToString() { }

	// RVA: 0x36FC114 Offset: 0x36F8114 VA: 0x36FC114 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FC5C0 Offset: 0x36F85C0 VA: 0x36FC5C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
