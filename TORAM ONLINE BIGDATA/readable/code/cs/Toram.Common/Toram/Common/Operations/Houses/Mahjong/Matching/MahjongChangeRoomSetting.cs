// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Mahjong.Matching
public class MahjongChangeRoomSetting : OperationRequestBase // TypeDefIndex: 12345
{
	// Fields
	[CompilerGenerated]
	private MahjongRoomSettingData <Setting>k__BackingField; // 0x20

	// Properties
	public MahjongRoomSettingData Setting { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F80F8 Offset: 0x35F40F8 VA: 0x35F80F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F8100 Offset: 0x35F4100 VA: 0x35F8100
	public MahjongRoomSettingData get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x35F8108 Offset: 0x35F4108 VA: 0x35F8108
	public void set_Setting(MahjongRoomSettingData value) { }

	// RVA: 0x35F8110 Offset: 0x35F4110 VA: 0x35F8110 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F8118 Offset: 0x35F4118 VA: 0x35F8118 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F8120 Offset: 0x35F4120 VA: 0x35F8120 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35F81A8 Offset: 0x35F41A8 VA: 0x35F81A8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
