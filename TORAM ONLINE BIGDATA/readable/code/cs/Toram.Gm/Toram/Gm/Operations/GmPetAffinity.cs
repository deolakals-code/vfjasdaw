// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetAffinity : OperationRequestBase // TypeDefIndex: 17617
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Affinity>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public short Affinity { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3798BEC Offset: 0x3794BEC VA: 0x3798BEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3798BF4 Offset: 0x3794BF4 VA: 0x3798BF4
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3798BFC Offset: 0x3794BFC VA: 0x3798BFC
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3798C04 Offset: 0x3794C04 VA: 0x3798C04
	public short get_Affinity() { }

	[CompilerGenerated]
	// RVA: 0x3798C0C Offset: 0x3794C0C VA: 0x3798C0C
	public void set_Affinity(short value) { }

	// RVA: 0x3798C14 Offset: 0x3794C14 VA: 0x3798C14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3798C1C Offset: 0x3794C1C VA: 0x3798C1C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3798C24 Offset: 0x3794C24 VA: 0x3798C24 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3798D9C Offset: 0x3794D9C VA: 0x3798D9C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
