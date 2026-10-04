// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class MiniGameLobbyEnter : OperationRequestBase // TypeDefIndex: 12004
{
	// Fields
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x20
	[CompilerGenerated]
	private EmergencyPositionData <EmergencyPosition>k__BackingField; // 0x28

	// Properties
	public int FieldId { get; set; }
	public EmergencyPositionData EmergencyPosition { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3775488 Offset: 0x3771488 VA: 0x3775488
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3775490 Offset: 0x3771490 VA: 0x3775490
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x3775498 Offset: 0x3771498 VA: 0x3775498
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37754A0 Offset: 0x37714A0 VA: 0x37754A0
	public EmergencyPositionData get_EmergencyPosition() { }

	[CompilerGenerated]
	// RVA: 0x37754A8 Offset: 0x37714A8 VA: 0x37754A8
	public void set_EmergencyPosition(EmergencyPositionData value) { }

	// RVA: 0x37754B0 Offset: 0x37714B0 VA: 0x37754B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37754B8 Offset: 0x37714B8 VA: 0x37754B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37754C0 Offset: 0x37714C0 VA: 0x37754C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37756B4 Offset: 0x37716B4 VA: 0x37756B4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
