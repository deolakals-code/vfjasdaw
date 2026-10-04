// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class NormalRespawnResponse : PacketBase // TypeDefIndex: 12083
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameStatusData <PetGameStatus>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 25)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }
	[PacketParameter(Code = 181, IsOptional = True)]
	public GameStatusData PetGameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3783B04 Offset: 0x377FB04 VA: 0x3783B04
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3783B0C Offset: 0x377FB0C VA: 0x3783B0C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3783B14 Offset: 0x377FB14 VA: 0x3783B14
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3783B1C Offset: 0x377FB1C VA: 0x3783B1C
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3783B24 Offset: 0x377FB24 VA: 0x3783B24
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3783B2C Offset: 0x377FB2C VA: 0x3783B2C
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3783B34 Offset: 0x377FB34 VA: 0x3783B34
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3783B3C Offset: 0x377FB3C VA: 0x3783B3C
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3783B44 Offset: 0x377FB44 VA: 0x3783B44
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x3783B4C Offset: 0x377FB4C VA: 0x3783B4C
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3783B54 Offset: 0x377FB54 VA: 0x3783B54
	public short get_ExMp() { }

	[CompilerGenerated]
	// RVA: 0x3783B5C Offset: 0x377FB5C VA: 0x3783B5C
	public GameStatusData get_PetGameStatus() { }

	[CompilerGenerated]
	// RVA: 0x3783B64 Offset: 0x377FB64 VA: 0x3783B64
	public void set_PetGameStatus(GameStatusData value) { }

	// RVA: 0x3783B6C Offset: 0x377FB6C VA: 0x3783B6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3783B74 Offset: 0x377FB74 VA: 0x3783B74 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3783ECC Offset: 0x377FECC VA: 0x3783ECC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
