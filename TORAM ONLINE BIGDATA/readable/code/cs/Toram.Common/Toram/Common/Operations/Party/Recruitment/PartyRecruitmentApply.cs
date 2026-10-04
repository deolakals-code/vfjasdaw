// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Recruitment
public class PartyRecruitmentApply : OperationRequestBase // TypeDefIndex: 11486
{
	// Fields
	[CompilerGenerated]
	private int <RecruitmentId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <FrameNo>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsRecruitmentList>k__BackingField; // 0x25

	// Properties
	public int RecruitmentId { get; set; }
	public byte FrameNo { get; set; }
	public bool IsRecruitmentList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3711DAC Offset: 0x370DDAC VA: 0x3711DAC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3711DB4 Offset: 0x370DDB4 VA: 0x3711DB4
	public int get_RecruitmentId() { }

	[CompilerGenerated]
	// RVA: 0x3711DBC Offset: 0x370DDBC VA: 0x3711DBC
	public void set_RecruitmentId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3711DC4 Offset: 0x370DDC4 VA: 0x3711DC4
	public byte get_FrameNo() { }

	[CompilerGenerated]
	// RVA: 0x3711DCC Offset: 0x370DDCC VA: 0x3711DCC
	public void set_FrameNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3711DD4 Offset: 0x370DDD4 VA: 0x3711DD4
	public bool get_IsRecruitmentList() { }

	[CompilerGenerated]
	// RVA: 0x3711DDC Offset: 0x370DDDC VA: 0x3711DDC
	public void set_IsRecruitmentList(bool value) { }

	// RVA: 0x3711DE8 Offset: 0x370DDE8 VA: 0x3711DE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3711DF0 Offset: 0x370DDF0 VA: 0x3711DF0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3711DF8 Offset: 0x370DDF8 VA: 0x3711DF8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3711F18 Offset: 0x370DF18 VA: 0x3711F18 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
