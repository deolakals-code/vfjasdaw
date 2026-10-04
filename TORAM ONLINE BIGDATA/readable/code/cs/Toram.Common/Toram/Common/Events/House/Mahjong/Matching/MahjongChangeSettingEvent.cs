// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House.Mahjong.Matching
public class MahjongChangeSettingEvent : EventSubBase // TypeDefIndex: 12845
{
	// Fields
	[CompilerGenerated]
	private MahjongRoomSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public MahjongRoomSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3667DAC Offset: 0x3663DAC VA: 0x3667DAC
	public void .ctor() { }

	// RVA: 0x3667DB4 Offset: 0x3663DB4 VA: 0x3667DB4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3667DBC Offset: 0x3663DBC VA: 0x3667DBC
	public MahjongRoomSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3667DC4 Offset: 0x3663DC4 VA: 0x3667DC4
	public void set_Setting(MahjongRoomSettingData value) { }

	// RVA: 0x3667DCC Offset: 0x3663DCC VA: 0x3667DCC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3667DD4 Offset: 0x3663DD4 VA: 0x3667DD4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3667DDC Offset: 0x3663DDC VA: 0x3667DDC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3667E64 Offset: 0x3663E64 VA: 0x3667E64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
