// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.EventField
public class HalloweenSearchResponse : OperationResponseBase // TypeDefIndex: 11672
{
	// Fields
	[CompilerGenerated]
	private byte <NowReward>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, byte> <MyBag>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <SearchedList>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <BlueKeyNo>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <RedKeyNo>k__BackingField; // 0x39

	// Properties
	[PacketParameter(Code = 78)]
	public byte NowReward { get; set; }
	[PacketParameter(Code = 15)]
	public Dictionary<byte, byte> MyBag { get; set; }
	[PacketParameter(Code = 16)]
	public byte[] SearchedList { get; set; }
	[PacketParameter(Code = 10)]
	public byte BlueKeyNo { get; set; }
	[PacketParameter(Code = 11)]
	public byte RedKeyNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372F568 Offset: 0x372B568 VA: 0x372F568
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372F570 Offset: 0x372B570 VA: 0x372F570
	public byte get_NowReward() { }

	[CompilerGenerated]
	// RVA: 0x372F578 Offset: 0x372B578 VA: 0x372F578
	public void set_NowReward(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372F580 Offset: 0x372B580 VA: 0x372F580
	public Dictionary<byte, byte> get_MyBag() { }

	[CompilerGenerated]
	// RVA: 0x372F588 Offset: 0x372B588 VA: 0x372F588
	public void set_MyBag(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x372F590 Offset: 0x372B590 VA: 0x372F590
	public byte[] get_SearchedList() { }

	[CompilerGenerated]
	// RVA: 0x372F598 Offset: 0x372B598 VA: 0x372F598
	public void set_SearchedList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x372F5A0 Offset: 0x372B5A0 VA: 0x372F5A0
	public byte get_BlueKeyNo() { }

	[CompilerGenerated]
	// RVA: 0x372F5A8 Offset: 0x372B5A8 VA: 0x372F5A8
	public void set_BlueKeyNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372F5B0 Offset: 0x372B5B0 VA: 0x372F5B0
	public byte get_RedKeyNo() { }

	[CompilerGenerated]
	// RVA: 0x372F5B8 Offset: 0x372B5B8 VA: 0x372F5B8
	public void set_RedKeyNo(byte value) { }

	// RVA: 0x372F5C0 Offset: 0x372B5C0 VA: 0x372F5C0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372F5C8 Offset: 0x372B5C8 VA: 0x372F5C8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372F5D0 Offset: 0x372B5D0 VA: 0x372F5D0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372F8A4 Offset: 0x372B8A4 VA: 0x372F8A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
