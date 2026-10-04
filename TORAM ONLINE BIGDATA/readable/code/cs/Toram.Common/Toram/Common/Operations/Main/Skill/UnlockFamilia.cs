// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class UnlockFamilia : OperationRequestBase // TypeDefIndex: 12110
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

	// RVA: 0x3788F28 Offset: 0x3784F28 VA: 0x3788F28
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3788F30 Offset: 0x3784F30 VA: 0x3788F30
	public byte get_UnlockNo() { }

	[CompilerGenerated]
	// RVA: 0x3788F38 Offset: 0x3784F38 VA: 0x3788F38
	public void set_UnlockNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3788F40 Offset: 0x3784F40 VA: 0x3788F40
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x3788F48 Offset: 0x3784F48 VA: 0x3788F48
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x3788F50 Offset: 0x3784F50 VA: 0x3788F50
	public int get_OrbNum() { }

	[CompilerGenerated]
	// RVA: 0x3788F58 Offset: 0x3784F58 VA: 0x3788F58
	public void set_OrbNum(int value) { }

	// RVA: 0x3788F60 Offset: 0x3784F60 VA: 0x3788F60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3788F68 Offset: 0x3784F68 VA: 0x3788F68 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3788F70 Offset: 0x3784F70 VA: 0x3788F70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3789134 Offset: 0x3785134 VA: 0x3789134 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
