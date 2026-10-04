// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaSaveProfileResponse : OperationResponseBase // TypeDefIndex: 11584
{
	// Fields
	[CompilerGenerated]
	private MobaProfileData <Profile>k__BackingField; // 0x20

	// Properties
	public MobaProfileData Profile { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371EE7C Offset: 0x371AE7C VA: 0x371EE7C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x371EE84 Offset: 0x371AE84 VA: 0x371EE84
	public MobaProfileData get_Profile() { }

	[CompilerGenerated]
	// RVA: 0x371EE8C Offset: 0x371AE8C VA: 0x371EE8C
	public void set_Profile(MobaProfileData value) { }

	// RVA: 0x371EE94 Offset: 0x371AE94 VA: 0x371EE94 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371EE9C Offset: 0x371AE9C VA: 0x371EE9C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371EEA4 Offset: 0x371AEA4 VA: 0x371EEA4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371EF2C Offset: 0x371AF2C VA: 0x371EF2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
