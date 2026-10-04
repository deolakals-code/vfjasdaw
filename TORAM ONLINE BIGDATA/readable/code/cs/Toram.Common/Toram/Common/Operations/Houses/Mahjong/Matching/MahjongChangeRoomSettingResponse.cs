// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongChangeRoomSettingResponse : OperationResponseBase // TypeDefIndex: 12346
{
	// Fields
	[CompilerGenerated]
	private MahjongRoomSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public MahjongRoomSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F8310 Offset: 0x35F4310 VA: 0x35F8310
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F8318 Offset: 0x35F4318 VA: 0x35F8318
	public MahjongRoomSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35F8320 Offset: 0x35F4320 VA: 0x35F8320
	public void set_Setting(MahjongRoomSettingData value) { }

	// RVA: 0x35F8328 Offset: 0x35F4328 VA: 0x35F8328 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F8330 Offset: 0x35F4330 VA: 0x35F8330 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F8338 Offset: 0x35F4338 VA: 0x35F8338 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F83C0 Offset: 0x35F43C0 VA: 0x35F83C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
