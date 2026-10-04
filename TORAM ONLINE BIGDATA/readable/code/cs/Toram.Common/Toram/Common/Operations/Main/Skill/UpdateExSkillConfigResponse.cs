// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class UpdateExSkillConfigResponse : OperationResponseBase // TypeDefIndex: 12103
{
	// Fields
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <Binary>k__BackingField; // 0x28

	// Properties
	public short SkillId { get; set; }
	public byte[] Binary { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3787C84 Offset: 0x3783C84 VA: 0x3787C84
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3787C8C Offset: 0x3783C8C VA: 0x3787C8C
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3787C94 Offset: 0x3783C94 VA: 0x3787C94
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3787C9C Offset: 0x3783C9C VA: 0x3787C9C
	public byte[] get_Binary() { }

	[CompilerGenerated]
	// RVA: 0x3787CA4 Offset: 0x3783CA4 VA: 0x3787CA4
	public void set_Binary(byte[] value) { }

	// RVA: 0x3787CAC Offset: 0x3783CAC VA: 0x3787CAC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3787CB4 Offset: 0x3783CB4 VA: 0x3787CB4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3787CBC Offset: 0x3783CBC VA: 0x3787CBC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3787E40 Offset: 0x3783E40 VA: 0x3787E40 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
