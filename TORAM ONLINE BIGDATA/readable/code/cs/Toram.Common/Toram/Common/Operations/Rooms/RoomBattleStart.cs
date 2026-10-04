// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms
public class RoomBattleStart : PacketBase // TypeDefIndex: 11745
{
	// Fields
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x28
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPositionData>k__BackingField; // 0x30
	[CompilerGenerated]
	private int[] <SupportItemList>k__BackingField; // 0x38
	[CompilerGenerated]
	private int[] <SupportOrbItemList>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 54, IsOptional = True)]
	public short[] Position { get; set; }
	[PacketParameter(Code = 65, IsOptional = True)]
	public short Rotation { get; set; }
	[PacketClass(Code = 107, IsOptional = True)]
	public EmergencyPositionData EmergencyPositionData { get; set; }
	[PacketParameter(Code = 148, IsOptional = True)]
	public int[] SupportItemList { get; set; }
	[PacketParameter(Code = 207, IsOptional = True)]
	public int[] SupportOrbItemList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3740EB4 Offset: 0x373CEB4 VA: 0x3740EB4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3740EBC Offset: 0x373CEBC VA: 0x3740EBC
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3740EC4 Offset: 0x373CEC4 VA: 0x3740EC4
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3740ECC Offset: 0x373CECC VA: 0x3740ECC
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x3740ED4 Offset: 0x373CED4 VA: 0x3740ED4
	public void set_Rotation(short value) { }

	[CompilerGenerated]
	// RVA: 0x3740EDC Offset: 0x373CEDC VA: 0x3740EDC
	public EmergencyPositionData get_EmergencyPositionData() { }

	[CompilerGenerated]
	// RVA: 0x3740EE4 Offset: 0x373CEE4 VA: 0x3740EE4
	public void set_EmergencyPositionData(EmergencyPositionData value) { }

	[CompilerGenerated]
	// RVA: 0x3740EEC Offset: 0x373CEEC VA: 0x3740EEC
	public int[] get_SupportItemList() { }

	[CompilerGenerated]
	// RVA: 0x3740EF4 Offset: 0x373CEF4 VA: 0x3740EF4
	public void set_SupportItemList(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x3740EFC Offset: 0x373CEFC VA: 0x3740EFC
	public int[] get_SupportOrbItemList() { }

	[CompilerGenerated]
	// RVA: 0x3740F04 Offset: 0x373CF04 VA: 0x3740F04
	public void set_SupportOrbItemList(int[] value) { }

	// RVA: 0x3740F0C Offset: 0x373CF0C VA: 0x3740F0C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374102C Offset: 0x373D02C VA: 0x374102C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37410A8 Offset: 0x373D0A8 VA: 0x37410A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37410B0 Offset: 0x373D0B0 VA: 0x37410B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3741394 Offset: 0x373D394 VA: 0x3741394 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
