// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class DailyDartsGameThrowDarts : OperationRequestBase // TypeDefIndex: 12010
{
	// Fields
	[CompilerGenerated]
	private byte <DartsNum>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <HitId>k__BackingField; // 0x22

	// Properties
	[PacketClass(Code = 21)]
	public byte DartsNum { get; set; }
	[PacketClass(Code = 122, IsOptional = True)]
	public short HitId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37768B4 Offset: 0x37728B4 VA: 0x37768B4
	public void .ctor() { }

	// RVA: 0x37768BC Offset: 0x37728BC VA: 0x37768BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37768C4 Offset: 0x37728C4 VA: 0x37768C4
	public byte get_DartsNum() { }

	[CompilerGenerated]
	// RVA: 0x37768CC Offset: 0x37728CC VA: 0x37768CC
	public void set_DartsNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37768D4 Offset: 0x37728D4 VA: 0x37768D4
	public short get_HitId() { }

	[CompilerGenerated]
	// RVA: 0x37768DC Offset: 0x37728DC VA: 0x37768DC
	public void set_HitId(short value) { }

	// RVA: 0x37768E4 Offset: 0x37728E4 VA: 0x37768E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37768EC Offset: 0x37728EC VA: 0x37768EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37768F4 Offset: 0x37728F4 VA: 0x37768F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3776A98 Offset: 0x3772A98 VA: 0x3776A98 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
