// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class GetBonusStatusResponse : PacketBase // TypeDefIndex: 12069
{
	// Fields
	[CompilerGenerated]
	private int <TrophyExpBonus>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <OrbExpBonus>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <TrophyDropBonus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <OrbDropBonus>k__BackingField; // 0x2C

	// Properties
	public int TrophyExpBonus { get; set; }
	public int OrbExpBonus { get; set; }
	public int TrophyDropBonus { get; set; }
	public int OrbDropBonus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3781584 Offset: 0x377D584 VA: 0x3781584
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x378158C Offset: 0x377D58C VA: 0x378158C
	public int get_TrophyExpBonus() { }

	[CompilerGenerated]
	// RVA: 0x3781594 Offset: 0x377D594 VA: 0x3781594
	public void set_TrophyExpBonus(int value) { }

	[CompilerGenerated]
	// RVA: 0x378159C Offset: 0x377D59C VA: 0x378159C
	public int get_OrbExpBonus() { }

	[CompilerGenerated]
	// RVA: 0x37815A4 Offset: 0x377D5A4 VA: 0x37815A4
	public void set_OrbExpBonus(int value) { }

	[CompilerGenerated]
	// RVA: 0x37815AC Offset: 0x377D5AC VA: 0x37815AC
	public int get_TrophyDropBonus() { }

	[CompilerGenerated]
	// RVA: 0x37815B4 Offset: 0x377D5B4 VA: 0x37815B4
	public void set_TrophyDropBonus(int value) { }

	[CompilerGenerated]
	// RVA: 0x37815BC Offset: 0x377D5BC VA: 0x37815BC
	public int get_OrbDropBonus() { }

	[CompilerGenerated]
	// RVA: 0x37815C4 Offset: 0x377D5C4 VA: 0x37815C4
	public void set_OrbDropBonus(int value) { }

	// RVA: 0x37815CC Offset: 0x377D5CC VA: 0x37815CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37815D4 Offset: 0x377D5D4 VA: 0x37815D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3781720 Offset: 0x377D720 VA: 0x3781720 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
