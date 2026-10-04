// Assembly: Toram.Common.dll
// Namespace: 
public class EnterAvatarData2.HousePack : PacketBase, IHouseBufferData, IHouseData // TypeDefIndex: 11367
{
	// Fields
	[CompilerGenerated]
	private short[] <CuisineBuffId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <CuisineBuffVal>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <CuisineRemainingTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private MyRoomEventSendData <MyRoomEventData>k__BackingField; // 0x38

	// Properties
	public short[] CuisineBuffId { get; set; }
	public short[] CuisineBuffVal { get; set; }
	public int CuisineRemainingTime { get; set; }
	public MyRoomEventSendData MyRoomEventData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36F4440 Offset: 0x36F0440 VA: 0x36F4440
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36F5DFC Offset: 0x36F1DFC VA: 0x36F5DFC Slot: 7
	public short[] get_CuisineBuffId() { }

	[CompilerGenerated]
	// RVA: 0x36F5E04 Offset: 0x36F1E04 VA: 0x36F5E04
	public void set_CuisineBuffId(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F5E0C Offset: 0x36F1E0C VA: 0x36F5E0C Slot: 8
	public short[] get_CuisineBuffVal() { }

	[CompilerGenerated]
	// RVA: 0x36F5E14 Offset: 0x36F1E14 VA: 0x36F5E14
	public void set_CuisineBuffVal(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36F5E1C Offset: 0x36F1E1C VA: 0x36F5E1C Slot: 9
	public int get_CuisineRemainingTime() { }

	[CompilerGenerated]
	// RVA: 0x36F5E24 Offset: 0x36F1E24 VA: 0x36F5E24
	public void set_CuisineRemainingTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36F5E2C Offset: 0x36F1E2C VA: 0x36F5E2C Slot: 10
	public MyRoomEventSendData get_MyRoomEventData() { }

	[CompilerGenerated]
	// RVA: 0x36F5E34 Offset: 0x36F1E34 VA: 0x36F5E34
	public void set_MyRoomEventData(MyRoomEventSendData value) { }

	// RVA: 0x36F5E3C Offset: 0x36F1E3C VA: 0x36F5E3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36F5E44 Offset: 0x36F1E44 VA: 0x36F5E44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x36F5F70 Offset: 0x36F1F70 VA: 0x36F5F70 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
