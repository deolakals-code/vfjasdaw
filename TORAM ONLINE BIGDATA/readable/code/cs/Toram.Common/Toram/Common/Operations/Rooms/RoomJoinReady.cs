// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomJoinReady : PacketBase // TypeDefIndex: 11749
{
	// Fields
	[CompilerGenerated]
	private int[] <SupportItemList>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <SupportOrbItemList>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 148, IsOptional = True)]
	public int[] SupportItemList { get; set; }
	[PacketParameter(Code = 207, IsOptional = True)]
	public int[] SupportOrbItemList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3741AEC Offset: 0x373DAEC VA: 0x3741AEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3741AF4 Offset: 0x373DAF4 VA: 0x3741AF4
	public int[] get_SupportItemList() { }

	[CompilerGenerated]
	// RVA: 0x3741AFC Offset: 0x373DAFC VA: 0x3741AFC
	public void set_SupportItemList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3741B04 Offset: 0x373DB04 VA: 0x3741B04
	public int[] get_SupportOrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3741B0C Offset: 0x373DB0C VA: 0x3741B0C
	public void set_SupportOrbItemList(int[] value) { }

	// RVA: 0x3741B14 Offset: 0x373DB14 VA: 0x3741B14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3741B1C Offset: 0x373DB1C VA: 0x3741B1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3741CF4 Offset: 0x373DCF4 VA: 0x3741CF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
