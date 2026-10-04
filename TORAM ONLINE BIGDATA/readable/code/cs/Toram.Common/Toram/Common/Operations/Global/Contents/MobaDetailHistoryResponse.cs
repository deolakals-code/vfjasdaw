// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaDetailHistoryResponse : OperationResponseBase // TypeDefIndex: 11575
{
	// Fields
	[CompilerGenerated]
	private byte[] <BinRecord>k__BackingField; // 0x20

	// Properties
	public byte[] BinRecord { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371D8B4 Offset: 0x37198B4 VA: 0x371D8B4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371D8BC Offset: 0x37198BC VA: 0x371D8BC
	public byte[] get_BinRecord() { }

	[CompilerGenerated]
	// RVA: 0x371D8C4 Offset: 0x37198C4 VA: 0x371D8C4
	public void set_BinRecord(byte[] value) { }

	// RVA: 0x371D8CC Offset: 0x37198CC VA: 0x371D8CC
	public MobaGameResultData GetGameResult() { }

	// RVA: 0x371D92C Offset: 0x371992C VA: 0x371D92C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371D934 Offset: 0x3719934 VA: 0x371D934 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371D93C Offset: 0x371993C VA: 0x371D93C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371D9B0 Offset: 0x37199B0 VA: 0x371D9B0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
