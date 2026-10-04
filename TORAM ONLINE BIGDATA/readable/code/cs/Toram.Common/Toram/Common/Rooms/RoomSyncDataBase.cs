// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms
public abstract class RoomSyncDataBase : UnityHashBase // TypeDefIndex: 11299
{
	// Fields
	[CompilerGenerated]
	private MobResponseData[] <MobDataList>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 76, IsOptional = True)]
	public MobResponseData[] MobDataList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36D6E40 Offset: 0x36D2E40 VA: 0x36D6E40
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36DAAB4 Offset: 0x36D6AB4 VA: 0x36DAAB4
	public MobResponseData[] get_MobDataList() { }

	[CompilerGenerated]
	// RVA: 0x36DAABC Offset: 0x36D6ABC VA: 0x36DAABC
	public void set_MobDataList(MobResponseData[] value) { }

	// RVA: 0x36DAAC4 Offset: 0x36D6AC4 VA: 0x36DAAC4
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DAC00 Offset: 0x36D6C00 VA: 0x36DAC00
	private void GetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DACC8 Offset: 0x36D6CC8 VA: 0x36DACC8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36DACD0 Offset: 0x36D6CD0 VA: 0x36DACD0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DAD68 Offset: 0x36D6D68 VA: 0x36DAD68 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
