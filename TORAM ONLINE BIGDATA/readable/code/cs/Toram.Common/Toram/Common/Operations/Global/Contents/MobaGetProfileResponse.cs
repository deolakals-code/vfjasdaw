// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaGetProfileResponse : OperationResponseBase // TypeDefIndex: 11577
{
	// Fields
	[CompilerGenerated]
	private MobaProfileData <Profile>k__BackingField; // 0x20

	// Properties
	public MobaProfileData Profile { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371DDB8 Offset: 0x3719DB8 VA: 0x371DDB8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371DDC0 Offset: 0x3719DC0 VA: 0x371DDC0
	public MobaProfileData get_Profile() { }

	[CompilerGenerated]
	// RVA: 0x371DDC8 Offset: 0x3719DC8 VA: 0x371DDC8
	public void set_Profile(MobaProfileData value) { }

	// RVA: 0x371DDD0 Offset: 0x3719DD0 VA: 0x371DDD0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371DDD8 Offset: 0x3719DD8 VA: 0x371DDD8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371DDE0 Offset: 0x3719DE0 VA: 0x371DDE0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371DE68 Offset: 0x3719E68 VA: 0x371DE68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
