// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb.StarGem
public class OrbStarGemReinforce : OperationRequestBase // TypeDefIndex: 11837
{
	// Fields
	[CompilerGenerated]
	private long <ReinforceGemUid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReinforceGemNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <MaterialGemUid>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <MaterialGemNo>k__BackingField; // 0x38

	// Properties
	[PacketParameter(Code = 91)]
	public long ReinforceGemUid { get; set; }
	[PacketParameter(Code = 148)]
	public short ReinforceGemNo { get; set; }
	[PacketParameter(Code = 236)]
	public long MaterialGemUid { get; set; }
	[PacketParameter(Code = 237)]
	public short MaterialGemNo { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3753F34 Offset: 0x374FF34 VA: 0x3753F34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3753F3C Offset: 0x374FF3C VA: 0x3753F3C
	public long get_ReinforceGemUid() { }

	[CompilerGenerated]
	// RVA: 0x3753F44 Offset: 0x374FF44 VA: 0x3753F44
	public void set_ReinforceGemUid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3753F4C Offset: 0x374FF4C VA: 0x3753F4C
	public short get_ReinforceGemNo() { }

	[CompilerGenerated]
	// RVA: 0x3753F54 Offset: 0x374FF54 VA: 0x3753F54
	public void set_ReinforceGemNo(short value) { }

	[CompilerGenerated]
	// RVA: 0x3753F5C Offset: 0x374FF5C VA: 0x3753F5C
	public long get_MaterialGemUid() { }

	[CompilerGenerated]
	// RVA: 0x3753F64 Offset: 0x374FF64 VA: 0x3753F64
	public void set_MaterialGemUid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3753F6C Offset: 0x374FF6C VA: 0x3753F6C
	public short get_MaterialGemNo() { }

	[CompilerGenerated]
	// RVA: 0x3753F74 Offset: 0x374FF74 VA: 0x3753F74
	public void set_MaterialGemNo(short value) { }

	// RVA: 0x3753F7C Offset: 0x374FF7C VA: 0x3753F7C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3753F84 Offset: 0x374FF84 VA: 0x3753F84 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3753F8C Offset: 0x374FF8C VA: 0x3753F8C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3754194 Offset: 0x3750194 VA: 0x3754194 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
