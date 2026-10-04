// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.HighRaid
public class CheckHighRaidRoom : OperationRequestBase // TypeDefIndex: 11790
{
	// Fields
	[CompilerGenerated]
	private byte <HighRaidNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Flag>k__BackingField; // 0x21

	// Properties
	public byte HighRaidNo { get; set; }
	public byte Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374C03C Offset: 0x374803C VA: 0x374C03C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x374C044 Offset: 0x3748044 VA: 0x374C044
	public byte get_HighRaidNo() { }

	[CompilerGenerated]
	// RVA: 0x374C04C Offset: 0x374804C VA: 0x374C04C
	public void set_HighRaidNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374C054 Offset: 0x3748054 VA: 0x374C054
	public byte get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x374C05C Offset: 0x374805C VA: 0x374C05C
	public void set_Flag(byte value) { }

	// RVA: 0x374C064 Offset: 0x3748064 VA: 0x374C064 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374C06C Offset: 0x374806C VA: 0x374C06C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374C074 Offset: 0x3748074 VA: 0x374C074 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374C13C Offset: 0x374813C VA: 0x374C13C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
