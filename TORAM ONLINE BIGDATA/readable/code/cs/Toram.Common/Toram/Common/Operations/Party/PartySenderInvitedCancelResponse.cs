// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartySenderInvitedCancelResponse : PacketBase // TypeDefIndex: 11475
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370FD9C Offset: 0x370BD9C VA: 0x370FD9C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x370FDA4 Offset: 0x370BDA4 VA: 0x370FDA4
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x370FDAC Offset: 0x370BDAC VA: 0x370FDAC
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370FDB4 Offset: 0x370BDB4 VA: 0x370FDB4
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x370FDBC Offset: 0x370BDBC VA: 0x370FDBC
	public void set_TargetName(string value) { }

	// RVA: 0x370FDC4 Offset: 0x370BDC4 VA: 0x370FDC4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370FDCC Offset: 0x370BDCC VA: 0x370FDCC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370FF44 Offset: 0x370BF44 VA: 0x370FF44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
