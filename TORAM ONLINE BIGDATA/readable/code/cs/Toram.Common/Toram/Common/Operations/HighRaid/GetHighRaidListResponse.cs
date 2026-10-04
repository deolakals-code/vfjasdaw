// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.HighRaid
public class GetHighRaidListResponse : OperationResponseBase // TypeDefIndex: 11558
{
	// Fields
	[CompilerGenerated]
	private byte <HeldType>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <HighRaidList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 43)]
	public byte HeldType { get; set; }
	[PacketParameter(Code = 148)]
	public byte[] HighRaidList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371A074 Offset: 0x3716074 VA: 0x371A074
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371A07C Offset: 0x371607C VA: 0x371A07C
	public byte get_HeldType() { }

	[CompilerGenerated]
	// RVA: 0x371A084 Offset: 0x3716084 VA: 0x371A084
	public void set_HeldType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x371A08C Offset: 0x371608C VA: 0x371A08C
	public byte[] get_HighRaidList() { }

	[CompilerGenerated]
	// RVA: 0x371A094 Offset: 0x3716094 VA: 0x371A094
	public void set_HighRaidList(byte[] value) { }

	// RVA: 0x371A09C Offset: 0x371609C VA: 0x371A09C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371A174 Offset: 0x3716174 VA: 0x371A174
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x371A1E0 Offset: 0x37161E0 VA: 0x371A1E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371A1E8 Offset: 0x37161E8 VA: 0x371A1E8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371A1F0 Offset: 0x37161F0 VA: 0x371A1F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371A29C Offset: 0x371629C VA: 0x371A29C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
