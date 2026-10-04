// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class StartComboBonusEvent : PacketBase // TypeDefIndex: 12609
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ComboBonus>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <Time>k__BackingField; // 0x26

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 195)]
	public short ComboBonus { get; set; }
	[PacketParameter(Code = 172)]
	public short Time { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x362FA14 Offset: 0x362BA14 VA: 0x362FA14
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x362FA1C Offset: 0x362BA1C VA: 0x362FA1C
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x362FA24 Offset: 0x362BA24 VA: 0x362FA24
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x362FA2C Offset: 0x362BA2C VA: 0x362FA2C
	public short get_ComboBonus() { }

	[CompilerGenerated]
	// RVA: 0x362FA34 Offset: 0x362BA34 VA: 0x362FA34
	public void set_ComboBonus(short value) { }

	[CompilerGenerated]
	// RVA: 0x362FA3C Offset: 0x362BA3C VA: 0x362FA3C
	public short get_Time() { }

	[CompilerGenerated]
	// RVA: 0x362FA44 Offset: 0x362BA44 VA: 0x362FA44
	public void set_Time(short value) { }

	// RVA: 0x362FA4C Offset: 0x362BA4C VA: 0x362FA4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x362FA54 Offset: 0x362BA54 VA: 0x362FA54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x362FB8C Offset: 0x362BB8C VA: 0x362FB8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
