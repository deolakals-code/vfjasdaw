// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Compensation
public class CompensationSkillReset : OperationRequestBase // TypeDefIndex: 12033
{
	// Fields
	[CompilerGenerated]
	private short <ResetSkillID>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <CompensationNum>k__BackingField; // 0x22

	// Properties
	[PacketParameter(Code = 90)]
	public short ResetSkillID { get; set; }
	[PacketParameter(Code = 253)]
	public byte CompensationNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x377AA50 Offset: 0x3776A50 VA: 0x377AA50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x377AA58 Offset: 0x3776A58 VA: 0x377AA58
	public short get_ResetSkillID() { }

	[CompilerGenerated]
	// RVA: 0x377AA60 Offset: 0x3776A60 VA: 0x377AA60
	public void set_ResetSkillID(short value) { }

	[CompilerGenerated]
	// RVA: 0x377AA68 Offset: 0x3776A68 VA: 0x377AA68
	public byte get_CompensationNum() { }

	[CompilerGenerated]
	// RVA: 0x377AA70 Offset: 0x3776A70 VA: 0x377AA70
	public void set_CompensationNum(byte value) { }

	// RVA: 0x377AA78 Offset: 0x3776A78 VA: 0x377AA78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x377AA80 Offset: 0x3776A80 VA: 0x377AA80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x377AA88 Offset: 0x3776A88 VA: 0x377AA88 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x377AC00 Offset: 0x3776C00 VA: 0x377AC00 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
