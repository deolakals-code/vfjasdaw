// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.BlackKnight
public class BlackKnightJoinResponse : OperationResponseBase // TypeDefIndex: 12236
{
	// Fields
	[CompilerGenerated]
	private MemberData[] <Members>k__BackingField; // 0x20
	[CompilerGenerated]
	private BlackKnightSaveData[] <Saves>k__BackingField; // 0x28

	// Properties
	public MemberData[] Members { get; set; }
	public BlackKnightSaveData[] Saves { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E5418 Offset: 0x35E1418 VA: 0x35E5418
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E5420 Offset: 0x35E1420 VA: 0x35E5420
	public MemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x35E5428 Offset: 0x35E1428 VA: 0x35E5428
	public void set_Members(MemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35E5430 Offset: 0x35E1430 VA: 0x35E5430
	public BlackKnightSaveData[] get_Saves() { }

	[CompilerGenerated]
	// RVA: 0x35E5438 Offset: 0x35E1438 VA: 0x35E5438
	public void set_Saves(BlackKnightSaveData[] value) { }

	// RVA: 0x35E5440 Offset: 0x35E1440 VA: 0x35E5440 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E5448 Offset: 0x35E1448 VA: 0x35E5448 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E5450 Offset: 0x35E1450 VA: 0x35E5450 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E5520 Offset: 0x35E1520 VA: 0x35E5520 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
