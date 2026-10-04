// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class GameReJoin : PacketBase // TypeDefIndex: 11377
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
	private string <XSignature>k__BackingField; // 0x48
	[CompilerGenerated]
	private string <AppVersion>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte[] <USignature>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <Model>k__BackingField; // 0x60

	// Properties
	public int AvatarUuid { get; set; }
	public string AsobimoId { get; set; }
	public string Guid { get; set; }
	public int AppliId { get; set; }
	public byte GameScene { get; set; }
	public int AssembleyVersion { get; set; }
	public string XSignature { get; set; }
	public string AppVersion { get; set; }
	public byte[] USignature { get; set; }
	public string Model { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FCC54 Offset: 0x36F8C54 VA: 0x36FCC54
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36FCC5C Offset: 0x36F8C5C VA: 0x36FCC5C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36FCC64 Offset: 0x36F8C64 VA: 0x36FCC64
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FCC6C Offset: 0x36F8C6C VA: 0x36FCC6C
	public string get_AsobimoId() { }

	[CompilerGenerated]
	// RVA: 0x36FCC74 Offset: 0x36F8C74 VA: 0x36FCC74
	public void set_AsobimoId(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FCC7C Offset: 0x36F8C7C VA: 0x36FCC7C
	public string get_Guid() { }

	[CompilerGenerated]
	// RVA: 0x36FCC84 Offset: 0x36F8C84 VA: 0x36FCC84
	public void set_Guid(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FCC8C Offset: 0x36F8C8C VA: 0x36FCC8C
	public int get_AppliId() { }

	[CompilerGenerated]
	// RVA: 0x36FCC94 Offset: 0x36F8C94 VA: 0x36FCC94
	public void set_AppliId(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FCC9C Offset: 0x36F8C9C VA: 0x36FCC9C
	public byte get_GameScene() { }

	[CompilerGenerated]
	// RVA: 0x36FCCA4 Offset: 0x36F8CA4 VA: 0x36FCCA4
	public void set_GameScene(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FCCAC Offset: 0x36F8CAC VA: 0x36FCCAC
	public int get_AssembleyVersion() { }

	[CompilerGenerated]
	// RVA: 0x36FCCB4 Offset: 0x36F8CB4 VA: 0x36FCCB4
	public void set_AssembleyVersion(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FCCBC Offset: 0x36F8CBC VA: 0x36FCCBC
	public string get_XSignature() { }

	[CompilerGenerated]
	// RVA: 0x36FCCC4 Offset: 0x36F8CC4 VA: 0x36FCCC4
	public void set_XSignature(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FCCCC Offset: 0x36F8CCC VA: 0x36FCCCC
	public string get_AppVersion() { }

	[CompilerGenerated]
	// RVA: 0x36FCCD4 Offset: 0x36F8CD4 VA: 0x36FCCD4
	public void set_AppVersion(string value) { }

	[CompilerGenerated]
	// RVA: 0x36FCCDC Offset: 0x36F8CDC VA: 0x36FCCDC
	public byte[] get_USignature() { }

	[CompilerGenerated]
	// RVA: 0x36FCCE4 Offset: 0x36F8CE4 VA: 0x36FCCE4
	public void set_USignature(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36FCCEC Offset: 0x36F8CEC VA: 0x36FCCEC
	public string get_Model() { }

	[CompilerGenerated]
	// RVA: 0x36FCCF4 Offset: 0x36F8CF4 VA: 0x36FCCF4
	public void set_Model(string value) { }

	// RVA: 0x36FCCFC Offset: 0x36F8CFC VA: 0x36FCCFC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FCD04 Offset: 0x36F8D04 VA: 0x36FCD04 Slot: 3
	public override string ToString() { }

	// RVA: 0x36FCD90 Offset: 0x36F8D90 VA: 0x36FCD90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FD1E0 Offset: 0x36F91E0 VA: 0x36FD1E0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
