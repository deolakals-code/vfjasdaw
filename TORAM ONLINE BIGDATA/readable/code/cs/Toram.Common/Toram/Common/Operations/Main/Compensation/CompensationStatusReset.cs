// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationStatusReset : OperationRequestBase // TypeDefIndex: 12031
{
	// Fields
	[CompilerGenerated]
	private byte <CompensationNum>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 253)]
	public byte CompensationNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377A3BC Offset: 0x37763BC VA: 0x377A3BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377A3C4 Offset: 0x37763C4 VA: 0x377A3C4
	public byte get_CompensationNum() { }

	[CompilerGenerated]
	// RVA: 0x377A3CC Offset: 0x37763CC VA: 0x377A3CC
	public void set_CompensationNum(byte value) { }

	// RVA: 0x377A3D4 Offset: 0x37763D4 VA: 0x377A3D4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377A3DC Offset: 0x37763DC VA: 0x377A3DC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377A3E4 Offset: 0x37763E4 VA: 0x377A3E4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377A504 Offset: 0x3776504 VA: 0x377A504 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
