// Assembly: Toram.Common.dll
// Namespace: Toram.Common.House.MyRoomEvent
public class MyRoomEventSendData : UnityHashBase // TypeDefIndex: 12533
{
	// Fields
	[CompilerGenerated]
	private MyRoomEventPetSendData[] <Pets>k__BackingField; // 0x20
	[CompilerGenerated]
	private RewardResponseDatav2 <RewardData>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	public MyRoomEventPetSendData[] Pets { get; set; }
	public RewardResponseDatav2 RewardData { get; set; }

	// Methods

	// RVA: 0x361A080 Offset: 0x3616080 VA: 0x361A080
	public void .ctor() { }

	// RVA: 0x361A088 Offset: 0x3616088 VA: 0x361A088
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x361A090 Offset: 0x3616090 VA: 0x361A090 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x361A098 Offset: 0x3616098 VA: 0x361A098
	public MyRoomEventPetSendData[] get_Pets() { }

	[CompilerGenerated]
	// RVA: 0x361A0A0 Offset: 0x36160A0 VA: 0x361A0A0
	public void set_Pets(MyRoomEventPetSendData[] value) { }

	[CompilerGenerated]
	// RVA: 0x361A0A8 Offset: 0x36160A8 VA: 0x361A0A8
	public RewardResponseDatav2 get_RewardData() { }

	[CompilerGenerated]
	// RVA: 0x361A0B0 Offset: 0x36160B0 VA: 0x361A0B0
	public void set_RewardData(RewardResponseDatav2 value) { }

	// RVA: 0x361A0B8 Offset: 0x36160B8 VA: 0x361A0B8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x361A380 Offset: 0x3616380 VA: 0x361A380 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
