// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.EventField
public class HalloweenStartResponse : OperationResponseBase // TypeDefIndex: 11673
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, byte> <MyBag>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <SearchedList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <BlueKeyNo>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <RedKeyNo>k__BackingField; // 0x31

	// Properties
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

	// RVA: 0x372F9CC Offset: 0x372B9CC VA: 0x372F9CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x372F9D4 Offset: 0x372B9D4 VA: 0x372F9D4
	public Dictionary<byte, byte> get_MyBag() { }

	[CompilerGenerated]
	// RVA: 0x372F9DC Offset: 0x372B9DC VA: 0x372F9DC
	public void set_MyBag(Dictionary<byte, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x372F9E4 Offset: 0x372B9E4 VA: 0x372F9E4
	public byte[] get_SearchedList() { }

	[CompilerGenerated]
	// RVA: 0x372F9EC Offset: 0x372B9EC VA: 0x372F9EC
	public void set_SearchedList(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x372F9F4 Offset: 0x372B9F4 VA: 0x372F9F4
	public byte get_BlueKeyNo() { }

	[CompilerGenerated]
	// RVA: 0x372F9FC Offset: 0x372B9FC VA: 0x372F9FC
	public void set_BlueKeyNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x372FA04 Offset: 0x372BA04 VA: 0x372FA04
	public byte get_RedKeyNo() { }

	[CompilerGenerated]
	// RVA: 0x372FA0C Offset: 0x372BA0C VA: 0x372FA0C
	public void set_RedKeyNo(byte value) { }

	// RVA: 0x372FA14 Offset: 0x372BA14 VA: 0x372FA14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372FA1C Offset: 0x372BA1C VA: 0x372FA1C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372FA24 Offset: 0x372BA24 VA: 0x372FA24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x372FCB4 Offset: 0x372BCB4 VA: 0x372FCB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
