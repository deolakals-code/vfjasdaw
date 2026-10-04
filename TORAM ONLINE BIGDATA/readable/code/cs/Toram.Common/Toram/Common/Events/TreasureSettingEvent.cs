// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class TreasureSettingEvent : PacketBase // TypeDefIndex: 12634
{
	// Fields
	[CompilerGenerated]
	private TreasureSettingData[] <TreasureList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Seed>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <PtFlag>k__BackingField; // 0x2C

	// Properties
	[PacketClass(Code = 213)]
	public TreasureSettingData[] TreasureList { get; set; }
	[PacketClass(Code = 233)]
	public int Seed { get; set; }
	[PacketClass(Code = 43)]
	public bool PtFlag { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36362EC Offset: 0x36322EC VA: 0x36362EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36362F4 Offset: 0x36322F4 VA: 0x36362F4
	public TreasureSettingData[] get_TreasureList() { }

	[CompilerGenerated]
	// RVA: 0x36362FC Offset: 0x36322FC VA: 0x36362FC
	public void set_TreasureList(TreasureSettingData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3636304 Offset: 0x3632304 VA: 0x3636304
	public int get_Seed() { }

	[CompilerGenerated]
	// RVA: 0x363630C Offset: 0x363230C VA: 0x363630C
	public void set_Seed(int value) { }

	[CompilerGenerated]
	// RVA: 0x3636314 Offset: 0x3632314 VA: 0x3636314
	public bool get_PtFlag() { }

	[CompilerGenerated]
	// RVA: 0x363631C Offset: 0x363231C VA: 0x363631C
	public void set_PtFlag(bool value) { }

	// RVA: 0x3636328 Offset: 0x3632328 VA: 0x3636328
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36364DC Offset: 0x36324DC VA: 0x36364DC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36365E8 Offset: 0x36325E8 VA: 0x36365E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36365F0 Offset: 0x36325F0 VA: 0x36365F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3636688 Offset: 0x3632688 VA: 0x3636688 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
