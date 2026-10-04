// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseCreateObjItem : OperationRequestBase // TypeDefIndex: 12169
{
	// Fields
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsDirect>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <ObjId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <Num>k__BackingField; // 0x30
	[CompilerGenerated]
	private short[] <FishIndexList>k__BackingField; // 0x38

	// Properties
	public int Orb { get; set; }
	public int UseOrb { get; set; }
	public bool IsDirect { get; set; }
	public int ObjId { get; set; }
	public byte Num { get; set; }
	public short[] FishIndexList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37946BC Offset: 0x37906BC VA: 0x37946BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37946C4 Offset: 0x37906C4 VA: 0x37946C4
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x37946CC Offset: 0x37906CC VA: 0x37946CC
	public void set_Orb(int value) { }

	[CompilerGenerated]
	// RVA: 0x37946D4 Offset: 0x37906D4 VA: 0x37946D4
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x37946DC Offset: 0x37906DC VA: 0x37946DC
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x37946E4 Offset: 0x37906E4 VA: 0x37946E4
	public bool get_IsDirect() { }

	[CompilerGenerated]
	// RVA: 0x37946EC Offset: 0x37906EC VA: 0x37946EC
	public void set_IsDirect(bool value) { }

	[CompilerGenerated]
	// RVA: 0x37946F8 Offset: 0x37906F8 VA: 0x37946F8
	public int get_ObjId() { }

	[CompilerGenerated]
	// RVA: 0x3794700 Offset: 0x3790700 VA: 0x3794700
	public void set_ObjId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3794708 Offset: 0x3790708 VA: 0x3794708
	public byte get_Num() { }

	[CompilerGenerated]
	// RVA: 0x3794710 Offset: 0x3790710 VA: 0x3794710
	public void set_Num(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3794718 Offset: 0x3790718 VA: 0x3794718
	public short[] get_FishIndexList() { }

	[CompilerGenerated]
	// RVA: 0x3794720 Offset: 0x3790720 VA: 0x3794720
	public void set_FishIndexList(short[] value) { }

	// RVA: 0x3794728 Offset: 0x3790728 VA: 0x3794728 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3794730 Offset: 0x3790730 VA: 0x3794730 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3794738 Offset: 0x3790738 VA: 0x3794738 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x379496C Offset: 0x379096C VA: 0x379496C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
