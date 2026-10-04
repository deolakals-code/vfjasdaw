// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.GuildStaff
public class RegistletEnhanceGemCartResponse : OperationResponseBase // TypeDefIndex: 12420
{
	// Fields
	[CompilerGenerated]
	private GemCartData <GemCart>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <Uuid>k__BackingField; // 0x28
	[CompilerGenerated]
	private long[] <UuidList>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <GemPowder>k__BackingField; // 0x38

	// Properties
	[PacketClass(Code = 2)]
	public GemCartData GemCart { get; set; }
	[Obsolete("rm21640:一括強化実装前のプロパティ。使用しない。実装後削除予定。")]
	[PacketParameter(Code = 56)]
	public long Uuid { get; set; }
	public long[] UuidList { get; set; }
	[PacketParameter(Code = 29)]
	public int GemPowder { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36048A8 Offset: 0x36008A8 VA: 0x36048A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36048B0 Offset: 0x36008B0 VA: 0x36048B0
	public GemCartData get_GemCart() { }

	[CompilerGenerated]
	// RVA: 0x36048B8 Offset: 0x36008B8 VA: 0x36048B8
	public void set_GemCart(GemCartData value) { }

	[CompilerGenerated]
	// RVA: 0x36048C0 Offset: 0x36008C0 VA: 0x36048C0
	public long get_Uuid() { }

	[CompilerGenerated]
	// RVA: 0x36048C8 Offset: 0x36008C8 VA: 0x36048C8
	public void set_Uuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x36048D0 Offset: 0x36008D0 VA: 0x36048D0
	public long[] get_UuidList() { }

	[CompilerGenerated]
	// RVA: 0x36048D8 Offset: 0x36008D8 VA: 0x36048D8
	public void set_UuidList(long[] value) { }

	[CompilerGenerated]
	// RVA: 0x36048E0 Offset: 0x36008E0 VA: 0x36048E0
	public int get_GemPowder() { }

	[CompilerGenerated]
	// RVA: 0x36048E8 Offset: 0x36008E8 VA: 0x36048E8
	public void set_GemPowder(int value) { }

	// RVA: 0x36048F0 Offset: 0x36008F0 VA: 0x36048F0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36048F8 Offset: 0x36008F8 VA: 0x36048F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3604900 Offset: 0x3600900 VA: 0x3604900 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3604A2C Offset: 0x3600A2C VA: 0x3604A2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
