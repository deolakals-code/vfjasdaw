// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class GetRoomGmEventMobDataResponse : PacketBase // TypeDefIndex: 11938
{
	// Fields
	[CompilerGenerated]
	private GmEventData[] <GmEvents>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 199, IsOptional = True)]
	public GmEventData[] GmEvents { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376A748 Offset: 0x3766748 VA: 0x376A748
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x376A750 Offset: 0x3766750 VA: 0x376A750
	public GmEventData[] get_GmEvents() { }

	[CompilerGenerated]
	// RVA: 0x376A758 Offset: 0x3766758 VA: 0x376A758
	public void set_GmEvents(GmEventData[] value) { }

	// RVA: 0x376A760 Offset: 0x3766760 VA: 0x376A760
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376A860 Offset: 0x3766860 VA: 0x376A860
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x376A8EC Offset: 0x37668EC VA: 0x376A8EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376A8F4 Offset: 0x37668F4 VA: 0x376A8F4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376A98C Offset: 0x376698C VA: 0x376A98C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376AA0C Offset: 0x3766A0C VA: 0x376AA0C Slot: 3
	public override string ToString() { }
}
