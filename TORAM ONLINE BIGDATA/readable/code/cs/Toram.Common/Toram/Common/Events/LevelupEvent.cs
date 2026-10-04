// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class LevelupEvent : PacketBase // TypeDefIndex: 12628
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <ExHp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ExMp>k__BackingField; // 0x34
	[CompilerGenerated]
	private int <ExpI>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <ExpL>k__BackingField; // 0x40
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <PartyFlag>k__BackingField; // 0x50

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 29)]
	public short Level { get; set; }
	[PacketParameter(Code = 25)]
	public int Hp { get; set; }
	[PacketParameter(Code = 26)]
	public short Mp { get; set; }
	[PacketParameter(Code = 202, IsOptional = True)]
	public int ExHp { get; set; }
	[PacketParameter(Code = 203, IsOptional = True)]
	public short ExMp { get; set; }
	[PacketParameter(Code = 27, IsOptional = True)]
	public int ExpI { get; set; }
	[PacketParameter(Code = 192, IsOptional = True)]
	public long ExpL { get; set; }
	public long Exp { get; }
	[PacketParameter(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }
	[PacketParameter(Code = 43)]
	public byte PartyFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3634920 Offset: 0x3630920 VA: 0x3634920
	public void .ctor() { }

	// RVA: 0x3634928 Offset: 0x3630928 VA: 0x3634928
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3634930 Offset: 0x3630930 VA: 0x3634930
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3634938 Offset: 0x3630938 VA: 0x3634938
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3634940 Offset: 0x3630940 VA: 0x3634940
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x3634948 Offset: 0x3630948 VA: 0x3634948
	public void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x3634950 Offset: 0x3630950 VA: 0x3634950
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3634958 Offset: 0x3630958 VA: 0x3634958
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3634960 Offset: 0x3630960 VA: 0x3634960
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3634968 Offset: 0x3630968 VA: 0x3634968
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3634970 Offset: 0x3630970 VA: 0x3634970
	public void set_ExHp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3634978 Offset: 0x3630978 VA: 0x3634978
	public int get_ExHp() { }

	[CompilerGenerated]
	// RVA: 0x3634980 Offset: 0x3630980 VA: 0x3634980
	public void set_ExMp(short value) { }

	[CompilerGenerated]
	// RVA: 0x3634988 Offset: 0x3630988 VA: 0x3634988
	public short get_ExMp() { }

	[CompilerGenerated]
	// RVA: 0x3634990 Offset: 0x3630990 VA: 0x3634990
	public int get_ExpI() { }

	[CompilerGenerated]
	// RVA: 0x3634998 Offset: 0x3630998 VA: 0x3634998
	public void set_ExpI(int value) { }

	[CompilerGenerated]
	// RVA: 0x36349A0 Offset: 0x36309A0 VA: 0x36349A0
	public long get_ExpL() { }

	[CompilerGenerated]
	// RVA: 0x36349A8 Offset: 0x36309A8 VA: 0x36349A8
	public void set_ExpL(long value) { }

	// RVA: 0x36349B0 Offset: 0x36309B0 VA: 0x36349B0
	public long get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x36349B8 Offset: 0x36309B8 VA: 0x36349B8
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x36349C0 Offset: 0x36309C0 VA: 0x36349C0
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x36349C8 Offset: 0x36309C8 VA: 0x36349C8
	public byte get_PartyFlag() { }

	[CompilerGenerated]
	// RVA: 0x36349D0 Offset: 0x36309D0 VA: 0x36349D0
	public void set_PartyFlag(byte value) { }

	// RVA: 0x36349D8 Offset: 0x36309D8 VA: 0x36349D8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36349E0 Offset: 0x36309E0 VA: 0x36349E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3634EA0 Offset: 0x3630EA0 VA: 0x3634EA0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
