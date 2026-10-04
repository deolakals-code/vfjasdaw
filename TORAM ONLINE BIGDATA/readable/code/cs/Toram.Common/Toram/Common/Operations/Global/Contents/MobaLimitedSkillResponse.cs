// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaLimitedSkillResponse : OperationResponseBase // TypeDefIndex: 11578
{
	// Fields
	[CompilerGenerated]
	private byte[] <EnableSkills>k__BackingField; // 0x20

	// Properties
	public byte[] EnableSkills { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371E004 Offset: 0x371A004 VA: 0x371E004
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371E00C Offset: 0x371A00C VA: 0x371E00C
	public byte[] get_EnableSkills() { }

	[CompilerGenerated]
	// RVA: 0x371E014 Offset: 0x371A014 VA: 0x371E014
	public void set_EnableSkills(byte[] value) { }

	// RVA: 0x371E01C Offset: 0x371A01C VA: 0x371E01C
	public MobaSkillData[] GetSkills() { }

	// RVA: 0x371E064 Offset: 0x371A064 VA: 0x371E064 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371E06C Offset: 0x371A06C VA: 0x371E06C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371E074 Offset: 0x371A074 VA: 0x371E074 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371E0B0 Offset: 0x371A0B0 VA: 0x371E0B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
