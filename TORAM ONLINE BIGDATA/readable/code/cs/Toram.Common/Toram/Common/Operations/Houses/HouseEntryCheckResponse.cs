// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses
public class HouseEntryCheckResponse : OperationResponseBase // TypeDefIndex: 12175
{
	// Fields
	[CompilerGenerated]
	private byte <EditState>k__BackingField; // 0x20

	// Properties
	public byte EditState { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3795898 Offset: 0x3791898 VA: 0x3795898
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37958A0 Offset: 0x37918A0 VA: 0x37958A0
	public byte get_EditState() { }

	[CompilerGenerated]
	// RVA: 0x37958A8 Offset: 0x37918A8 VA: 0x37958A8
	public void set_EditState(byte value) { }

	// RVA: 0x37958B0 Offset: 0x37918B0 VA: 0x37958B0
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37958B4 Offset: 0x37918B4 VA: 0x37958B4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37958B8 Offset: 0x37918B8 VA: 0x37958B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37958C0 Offset: 0x37918C0 VA: 0x37958C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37958C8 Offset: 0x37918C8 VA: 0x37958C8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37959E8 Offset: 0x37919E8 VA: 0x37959E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
