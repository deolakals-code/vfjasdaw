// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class UnlockHuntingOne : OperationRequestBase // TypeDefIndex: 12099
{
	// Fields
	[CompilerGenerated]
	private byte <UnlockNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <OrbNum>k__BackingField; // 0x28

	// Properties
	public byte UnlockNo { get; set; }
	public int UseOrb { get; set; }
	public int OrbNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3786F28 Offset: 0x3782F28 VA: 0x3786F28
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3786F30 Offset: 0x3782F30 VA: 0x3786F30
	public byte get_UnlockNo() { }

	[CompilerGenerated]
	// RVA: 0x3786F38 Offset: 0x3782F38 VA: 0x3786F38
	public void set_UnlockNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3786F40 Offset: 0x3782F40 VA: 0x3786F40
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x3786F48 Offset: 0x3782F48 VA: 0x3786F48
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3786F50 Offset: 0x3782F50 VA: 0x3786F50
	public int get_OrbNum() { }

	[CompilerGenerated]
	// RVA: 0x3786F58 Offset: 0x3782F58 VA: 0x3786F58
	public void set_OrbNum(int value) { }

	// RVA: 0x3786F60 Offset: 0x3782F60 VA: 0x3786F60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3786F68 Offset: 0x3782F68 VA: 0x3786F68 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3786F70 Offset: 0x3782F70 VA: 0x3786F70 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378707C Offset: 0x378307C VA: 0x378707C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
