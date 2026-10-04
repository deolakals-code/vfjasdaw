// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class UpdateExSkillConfig : OperationRequestBase // TypeDefIndex: 12104
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

	// RVA: 0x3787EF4 Offset: 0x3783EF4 VA: 0x3787EF4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3787EFC Offset: 0x3783EFC VA: 0x3787EFC
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3787F04 Offset: 0x3783F04 VA: 0x3787F04
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3787F0C Offset: 0x3783F0C VA: 0x3787F0C
	public byte[] get_Binary() { }

	[CompilerGenerated]
	// RVA: 0x3787F14 Offset: 0x3783F14 VA: 0x3787F14
	public void set_Binary(byte[] value) { }

	// RVA: 0x3787F1C Offset: 0x3783F1C VA: 0x3787F1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3787F24 Offset: 0x3783F24 VA: 0x3787F24 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3787F2C Offset: 0x3783F2C VA: 0x3787F2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37880B0 Offset: 0x37840B0 VA: 0x37880B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
