// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Peer
public class GameReJoinResponse : PacketBase // TypeDefIndex: 11378
{
	// Fields
	[CompilerGenerated]
	private byte <GameScene>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ResultCode>k__BackingField; // 0x21
	[CompilerGenerated]
	private EnterAvatarData <AvatarData>k__BackingField; // 0x28
	[CompilerGenerated]
	private AppVerData <AppVerData>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte[] <AvatarBinary>k__BackingField; // 0x38
	[CompilerGenerated]
	private EnterAvatarData2 <AvatarData2>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 6)]
	public byte GameScene { get; set; }
	[PacketParameter(Code = 78)]
	public byte ResultCode { get; set; }
	[PacketClass(Code = 225, IsOptional = True)]
	[Obsolete("Old Version")]
	public EnterAvatarData AvatarData { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public AppVerData AppVerData { get; set; }
	public byte[] AvatarBinary { get; set; }
	public EnterAvatarData2 AvatarData2 { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36FD3C8 Offset: 0x36F93C8 VA: 0x36FD3C8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36FD3D0 Offset: 0x36F93D0 VA: 0x36FD3D0
	public byte get_GameScene() { }

	[CompilerGenerated]
	// RVA: 0x36FD3D8 Offset: 0x36F93D8 VA: 0x36FD3D8
	public void set_GameScene(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FD3E0 Offset: 0x36F93E0 VA: 0x36FD3E0
	public byte get_ResultCode() { }

	[CompilerGenerated]
	// RVA: 0x36FD3E8 Offset: 0x36F93E8 VA: 0x36FD3E8
	public void set_ResultCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36FD3F0 Offset: 0x36F93F0 VA: 0x36FD3F0
	public EnterAvatarData get_AvatarData() { }

	[CompilerGenerated]
	// RVA: 0x36FD3F8 Offset: 0x36F93F8 VA: 0x36FD3F8
	public void set_AvatarData(EnterAvatarData value) { }

	[CompilerGenerated]
	// RVA: 0x36FD400 Offset: 0x36F9400 VA: 0x36FD400
	public AppVerData get_AppVerData() { }

	[CompilerGenerated]
	// RVA: 0x36FD408 Offset: 0x36F9408 VA: 0x36FD408
	public void set_AppVerData(AppVerData value) { }

	[CompilerGenerated]
	// RVA: 0x36FD410 Offset: 0x36F9410 VA: 0x36FD410
	public byte[] get_AvatarBinary() { }

	[CompilerGenerated]
	// RVA: 0x36FD418 Offset: 0x36F9418 VA: 0x36FD418
	public void set_AvatarBinary(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36FD420 Offset: 0x36F9420 VA: 0x36FD420
	public EnterAvatarData2 get_AvatarData2() { }

	[CompilerGenerated]
	// RVA: 0x36FD428 Offset: 0x36F9428 VA: 0x36FD428
	public void set_AvatarData2(EnterAvatarData2 value) { }

	// RVA: 0x36FD430 Offset: 0x36F9430 VA: 0x36FD430 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36FD438 Offset: 0x36F9438 VA: 0x36FD438 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36FD870 Offset: 0x36F9870 VA: 0x36FD870 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
