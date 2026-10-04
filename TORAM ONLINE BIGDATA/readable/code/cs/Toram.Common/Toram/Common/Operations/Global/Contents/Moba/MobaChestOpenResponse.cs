// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaChestOpenResponse : OperationResponseBase // TypeDefIndex: 11599
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ChestUniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <ElapsedTicks>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <OpenSec>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobaRewardData <Reward>k__BackingField; // 0x38

	// Properties
	public short ReturnCode { get; set; }
	public int ChestUniqueId { get; set; }
	public long ElapsedTicks { get; set; }
	public short OpenSec { get; set; }
	public MobaRewardData Reward { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3722044 Offset: 0x371E044 VA: 0x3722044
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372204C Offset: 0x371E04C VA: 0x372204C
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3722054 Offset: 0x371E054 VA: 0x3722054
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x372205C Offset: 0x371E05C VA: 0x372205C
	public int get_ChestUniqueId() { }

	[CompilerGenerated]
	// RVA: 0x3722064 Offset: 0x371E064 VA: 0x3722064
	public void set_ChestUniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x372206C Offset: 0x371E06C VA: 0x372206C
	public long get_ElapsedTicks() { }

	[CompilerGenerated]
	// RVA: 0x3722074 Offset: 0x371E074 VA: 0x3722074
	public void set_ElapsedTicks(long value) { }

	[CompilerGenerated]
	// RVA: 0x372207C Offset: 0x371E07C VA: 0x372207C
	public short get_OpenSec() { }

	[CompilerGenerated]
	// RVA: 0x3722084 Offset: 0x371E084 VA: 0x3722084
	public void set_OpenSec(short value) { }

	[CompilerGenerated]
	// RVA: 0x372208C Offset: 0x371E08C VA: 0x372208C
	public MobaRewardData get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3722094 Offset: 0x371E094 VA: 0x3722094
	public void set_Reward(MobaRewardData value) { }

	// RVA: 0x372209C Offset: 0x371E09C VA: 0x372209C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37220A4 Offset: 0x371E0A4 VA: 0x37220A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37220AC Offset: 0x371E0AC VA: 0x37220AC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3722224 Offset: 0x371E224 VA: 0x3722224 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
