// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomSecondPartyJoin : OperationRequestBase // TypeDefIndex: 11738
{
	// Fields
	[CompilerGenerated]
	private NpcJoinPositionData[] <Npcs>k__BackingField; // 0x20

	// Properties
	public NpcJoinPositionData[] Npcs { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x373F1D8 Offset: 0x373B1D8 VA: 0x373F1D8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x373F1E0 Offset: 0x373B1E0 VA: 0x373F1E0
	public NpcJoinPositionData[] get_Npcs() { }

	[CompilerGenerated]
	// RVA: 0x373F1E8 Offset: 0x373B1E8 VA: 0x373F1E8
	public void set_Npcs(NpcJoinPositionData[] value) { }

	// RVA: 0x373F1F0 Offset: 0x373B1F0 VA: 0x373F1F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x373F1F8 Offset: 0x373B1F8 VA: 0x373F1F8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x373F200 Offset: 0x373B200 VA: 0x373F200 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x373F378 Offset: 0x373B378 VA: 0x373F378 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
