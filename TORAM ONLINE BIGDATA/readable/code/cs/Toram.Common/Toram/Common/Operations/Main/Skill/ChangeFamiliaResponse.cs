// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class ChangeFamiliaResponse : OperationResponseBase // TypeDefIndex: 12102
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <Model>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x30

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public long Model { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378789C Offset: 0x378389C VA: 0x378789C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37878A4 Offset: 0x37838A4 VA: 0x37878A4
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x37878AC Offset: 0x37838AC VA: 0x37878AC
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37878B4 Offset: 0x37838B4 VA: 0x37878B4
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x37878BC Offset: 0x37838BC VA: 0x37878BC
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x37878C4 Offset: 0x37838C4 VA: 0x37878C4
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x37878CC Offset: 0x37838CC VA: 0x37878CC
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x37878D4 Offset: 0x37838D4 VA: 0x37878D4
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x37878DC Offset: 0x37838DC VA: 0x37878DC
	public void set_Flag(int value) { }

	// RVA: 0x37878E4 Offset: 0x37838E4 VA: 0x37878E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37878EC Offset: 0x37838EC VA: 0x37878EC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37878F4 Offset: 0x37838F4 VA: 0x37878F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3787B3C Offset: 0x3783B3C VA: 0x3787B3C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
