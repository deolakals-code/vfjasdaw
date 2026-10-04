// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HouseFeedStray : OperationRequestBase // TypeDefIndex: 12308
{
	// Fields
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ModelId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <StraySeedTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <FoodId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <UseOrb>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <Orb>k__BackingField; // 0x34

	// Properties
	public int MonsterUuid { get; set; }
	public int ModelId { get; set; }
	public int StraySeedTime { get; set; }
	public int FoodId { get; set; }
	public int UseOrb { get; set; }
	public int Orb { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F0538 Offset: 0x35EC538 VA: 0x35F0538
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F0540 Offset: 0x35EC540 VA: 0x35F0540
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F0548 Offset: 0x35EC548 VA: 0x35F0548
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0550 Offset: 0x35EC550 VA: 0x35F0550
	public int get_ModelId() { }

	[CompilerGenerated]
	// RVA: 0x35F0558 Offset: 0x35EC558 VA: 0x35F0558
	public void set_ModelId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0560 Offset: 0x35EC560 VA: 0x35F0560
	public int get_StraySeedTime() { }

	[CompilerGenerated]
	// RVA: 0x35F0568 Offset: 0x35EC568 VA: 0x35F0568
	public void set_StraySeedTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0570 Offset: 0x35EC570 VA: 0x35F0570
	public int get_FoodId() { }

	[CompilerGenerated]
	// RVA: 0x35F0578 Offset: 0x35EC578 VA: 0x35F0578
	public void set_FoodId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0580 Offset: 0x35EC580 VA: 0x35F0580
	public int get_UseOrb() { }

	[CompilerGenerated]
	// RVA: 0x35F0588 Offset: 0x35EC588 VA: 0x35F0588
	public void set_UseOrb(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F0590 Offset: 0x35EC590 VA: 0x35F0590
	public int get_Orb() { }

	[CompilerGenerated]
	// RVA: 0x35F0598 Offset: 0x35EC598 VA: 0x35F0598
	public void set_Orb(int value) { }

	// RVA: 0x35F05A0 Offset: 0x35EC5A0 VA: 0x35F05A0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F05A8 Offset: 0x35EC5A8 VA: 0x35F05A8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F05B0 Offset: 0x35EC5B0 VA: 0x35F05B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F0870 Offset: 0x35EC870 VA: 0x35F0870 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
