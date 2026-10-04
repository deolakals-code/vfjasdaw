// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Wave
public class GetWaveRewardSaveDataResponse : OperationRequestBase // TypeDefIndex: 11793
{
	// Fields
	[CompilerGenerated]
	private Dictionary<ushort, byte> <SaveData>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public Dictionary<ushort, byte> SaveData { get; set; }

	// Methods

	// RVA: 0x374C8AC Offset: 0x37488AC VA: 0x374C8AC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374C8B4 Offset: 0x37488B4 VA: 0x374C8B4 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x374C8BC Offset: 0x37488BC VA: 0x374C8BC
	public Dictionary<ushort, byte> get_SaveData() { }

	[CompilerGenerated]
	// RVA: 0x374C8C4 Offset: 0x37488C4 VA: 0x374C8C4
	public void set_SaveData(Dictionary<ushort, byte> value) { }

	// RVA: 0x374C8CC Offset: 0x37488CC VA: 0x374C8CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x374C8D4 Offset: 0x37488D4 VA: 0x374C8D4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374CB7C Offset: 0x3748B7C VA: 0x374CB7C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374CD94 Offset: 0x3748D94 VA: 0x374CD94 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374CE2C Offset: 0x3748E2C VA: 0x374CE2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
