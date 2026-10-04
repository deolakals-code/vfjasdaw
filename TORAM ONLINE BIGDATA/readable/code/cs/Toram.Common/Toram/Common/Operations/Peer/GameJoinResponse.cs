// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class GameJoinResponse : PacketBase // TypeDefIndex: 11376
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <GameScene>k__BackingField; // 0x24
	[CompilerGenerated]
	private AppVerData <AppVerData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 6)]
	public byte GameScene { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public AppVerData AppVerData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FC7D4 Offset: 0x36F87D4 VA: 0x36FC7D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FC7DC Offset: 0x36F87DC VA: 0x36FC7DC
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x36FC7E4 Offset: 0x36F87E4 VA: 0x36FC7E4
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x36FC7EC Offset: 0x36F87EC VA: 0x36FC7EC
	public byte get_GameScene() { }

	[CompilerGenerated]
	// RVA: 0x36FC7F4 Offset: 0x36F87F4 VA: 0x36FC7F4
	public void set_GameScene(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FC7FC Offset: 0x36F87FC VA: 0x36FC7FC
	public AppVerData get_AppVerData() { }

	[CompilerGenerated]
	// RVA: 0x36FC804 Offset: 0x36F8804 VA: 0x36FC804
	public void set_AppVerData(AppVerData value) { }

	// RVA: 0x36FC80C Offset: 0x36F880C VA: 0x36FC80C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FC92C Offset: 0x36F892C VA: 0x36FC92C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FC9A8 Offset: 0x36F89A8 VA: 0x36FC9A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FC9B0 Offset: 0x36F89B0 VA: 0x36FC9B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FCB38 Offset: 0x36F8B38 VA: 0x36FCB38 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
