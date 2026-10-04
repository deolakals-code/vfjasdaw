// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class UpdateGenericFlag : PacketBase // TypeDefIndex: 11955
{
	// Fields
	[CompilerGenerated]
	private byte <FlagId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <FlagData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 200)]
	public byte FlagId { get; set; }
	[PacketParameter(Code = 199, IsOptional = True)]
	public string FlagData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x376D95C Offset: 0x376995C VA: 0x376D95C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x376D964 Offset: 0x3769964 VA: 0x376D964
	public byte get_FlagId() { }

	[CompilerGenerated]
	// RVA: 0x376D96C Offset: 0x376996C VA: 0x376D96C
	public void set_FlagId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x376D974 Offset: 0x3769974 VA: 0x376D974
	public string get_FlagData() { }

	[CompilerGenerated]
	// RVA: 0x376D97C Offset: 0x376997C VA: 0x376D97C
	public void set_FlagData(string value) { }

	// RVA: 0x376D984 Offset: 0x3769984 VA: 0x376D984 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376D98C Offset: 0x376998C VA: 0x376D98C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x376DB30 Offset: 0x3769B30 VA: 0x376DB30 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
