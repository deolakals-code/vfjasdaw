// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cultivation
public class CultivationGardenLeaveResponse : OperationResponseBase // TypeDefIndex: 12198
{
	// Fields
	[CompilerGenerated]
	private HouseReadOnlyData <HouseData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 73)]
	public HouseReadOnlyData HouseData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35DF3DC Offset: 0x35DB3DC VA: 0x35DF3DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35DF3E4 Offset: 0x35DB3E4 VA: 0x35DF3E4
	public HouseReadOnlyData get_HouseData() { }

	[CompilerGenerated]
	// RVA: 0x35DF3EC Offset: 0x35DB3EC VA: 0x35DF3EC
	public void set_HouseData(HouseReadOnlyData value) { }

	// RVA: 0x35DF3F4 Offset: 0x35DB3F4 VA: 0x35DF3F4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF514 Offset: 0x35DB514 VA: 0x35DF514
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF590 Offset: 0x35DB590 VA: 0x35DF590 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DF598 Offset: 0x35DB598 VA: 0x35DF598 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35DF5A0 Offset: 0x35DB5A0 VA: 0x35DF5A0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DF638 Offset: 0x35DB638 VA: 0x35DF638 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
