// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CraneGame
public class CraneGameResult : OperationRequestBase // TypeDefIndex: 12264
{
	// Fields
	[CompilerGenerated]
	private bool <IsGet>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Score>k__BackingField; // 0x24

	// Properties
	public bool IsGet { get; set; }
	public int Score { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E9324 Offset: 0x35E5324 VA: 0x35E9324
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E932C Offset: 0x35E532C VA: 0x35E932C
	public bool get_IsGet() { }

	[CompilerGenerated]
	// RVA: 0x35E9334 Offset: 0x35E5334 VA: 0x35E9334
	public void set_IsGet(bool value) { }

	[CompilerGenerated]
	// RVA: 0x35E9340 Offset: 0x35E5340 VA: 0x35E9340
	public int get_Score() { }

	[CompilerGenerated]
	// RVA: 0x35E9348 Offset: 0x35E5348 VA: 0x35E9348
	public void set_Score(int value) { }

	// RVA: 0x35E9350 Offset: 0x35E5350 VA: 0x35E9350 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E9358 Offset: 0x35E5358 VA: 0x35E9358 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E9360 Offset: 0x35E5360 VA: 0x35E9360 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E943C Offset: 0x35E543C VA: 0x35E943C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
