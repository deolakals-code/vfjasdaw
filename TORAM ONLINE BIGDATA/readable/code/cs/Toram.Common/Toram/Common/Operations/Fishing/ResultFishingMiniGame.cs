// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Fishing
public class ResultFishingMiniGame : OperationRequestBase // TypeDefIndex: 11655
{
	// Fields
	[CompilerGenerated]
	private bool <IsSuccess>k__BackingField; // 0x20
	[CompilerGenerated]
	private int[] <HitLogs>k__BackingField; // 0x28

	// Properties
	public bool IsSuccess { get; set; }
	public int[] HitLogs { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x372C2BC Offset: 0x37282BC VA: 0x372C2BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x372C2C4 Offset: 0x37282C4 VA: 0x372C2C4
	public bool get_IsSuccess() { }

	[CompilerGenerated]
	// RVA: 0x372C2CC Offset: 0x37282CC VA: 0x372C2CC
	public void set_IsSuccess(bool value) { }

	[CompilerGenerated]
	// RVA: 0x372C2D8 Offset: 0x37282D8 VA: 0x372C2D8
	public int[] get_HitLogs() { }

	[CompilerGenerated]
	// RVA: 0x372C2E0 Offset: 0x37282E0 VA: 0x372C2E0
	public void set_HitLogs(int[] value) { }

	// RVA: 0x372C2E8 Offset: 0x37282E8 VA: 0x372C2E8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x372C2F0 Offset: 0x37282F0 VA: 0x372C2F0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x372C2F8 Offset: 0x37282F8 VA: 0x372C2F8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x372C3AC Offset: 0x37283AC VA: 0x372C3AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
