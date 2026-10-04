// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemBreak : OperationRequestBase // TypeDefIndex: 11829
{
	// Fields
	[CompilerGenerated]
	private long <GemUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x28

	// Properties
	public long GemUuid { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x375297C Offset: 0x374E97C VA: 0x375297C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3752984 Offset: 0x374E984 VA: 0x3752984
	public long get_GemUuid() { }

	[CompilerGenerated]
	// RVA: 0x375298C Offset: 0x374E98C VA: 0x375298C
	public void set_GemUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3752994 Offset: 0x374E994 VA: 0x3752994
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x375299C Offset: 0x374E99C VA: 0x375299C
	public void set_Flag(byte value) { }

	// RVA: 0x37529A4 Offset: 0x374E9A4 VA: 0x37529A4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37529AC Offset: 0x374E9AC VA: 0x37529AC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37529B4 Offset: 0x374E9B4 VA: 0x37529B4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3752B58 Offset: 0x374EB58 VA: 0x3752B58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
