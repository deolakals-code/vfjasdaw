// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents
public class MobaSaveProfile : OperationRequestBase // TypeDefIndex: 11583
{
	// Fields
	[CompilerGenerated]
	private MobaProfileData <Profile>k__BackingField; // 0x20

	// Properties
	public MobaProfileData Profile { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x371EC30 Offset: 0x371AC30 VA: 0x371EC30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x371EC38 Offset: 0x371AC38 VA: 0x371EC38
	public MobaProfileData get_Profile() { }

	[CompilerGenerated]
	// RVA: 0x371EC40 Offset: 0x371AC40 VA: 0x371EC40
	public void set_Profile(MobaProfileData value) { }

	// RVA: 0x371EC48 Offset: 0x371AC48 VA: 0x371EC48 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x371EC50 Offset: 0x371AC50 VA: 0x371EC50 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x371EC58 Offset: 0x371AC58 VA: 0x371EC58 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x371ECE0 Offset: 0x371ACE0 VA: 0x371ECE0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
