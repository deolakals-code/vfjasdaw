// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Loader
public class ReturnEmergencyPosition : PacketBase // TypeDefIndex: 11552
{
	// Fields
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 107)]
	public EmergencyPositionData EmergencyPositionData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3719270 Offset: 0x3715270 VA: 0x3719270
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3719278 Offset: 0x3715278 VA: 0x3719278
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3719280 Offset: 0x3715280 VA: 0x3719280
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	// RVA: 0x3719288 Offset: 0x3715288 VA: 0x3719288
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719374 Offset: 0x3715374 VA: 0x3719374
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37193E4 Offset: 0x37153E4 VA: 0x37193E4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37193EC Offset: 0x37153EC VA: 0x37193EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3719484 Offset: 0x3715484 VA: 0x3719484 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
