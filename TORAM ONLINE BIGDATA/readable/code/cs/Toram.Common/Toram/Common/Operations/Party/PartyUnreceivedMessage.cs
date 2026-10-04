// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyUnreceivedMessage : OperationRequestBase // TypeDefIndex: 11460
{
	// Fields
	[CompilerGenerated]
	private DateTime <LatestPartyMsgTime>k__BackingField; // 0x20

	// Properties
	public DateTime LatestPartyMsgTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x370DBBC Offset: 0x3709BBC VA: 0x370DBBC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370DBC4 Offset: 0x3709BC4 VA: 0x370DBC4
	public DateTime get_LatestPartyMsgTime() { }

	[CompilerGenerated]
	// RVA: 0x370DBCC Offset: 0x3709BCC VA: 0x370DBCC
	public void set_LatestPartyMsgTime(DateTime value) { }

	// RVA: 0x370DBD4 Offset: 0x3709BD4 VA: 0x370DBD4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370DBDC Offset: 0x3709BDC VA: 0x370DBDC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x370DBE4 Offset: 0x3709BE4 VA: 0x370DBE4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370DD24 Offset: 0x3709D24 VA: 0x370DD24 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
