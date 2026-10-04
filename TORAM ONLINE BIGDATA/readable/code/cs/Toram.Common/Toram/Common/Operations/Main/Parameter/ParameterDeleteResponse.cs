// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterDeleteResponse : PacketBase // TypeDefIndex: 11988
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <ParamName>k__BackingField; // 0x28
	[CompilerGenerated]
	private StarGemData[] <StarGems>k__BackingField; // 0x30
	[CompilerGenerated]
	private PlayerStatusData <PlayerStatus>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <AccountLevel>k__BackingField; // 0x40

	// Properties
	[PacketParameter(Code = 108)]
	public byte ParamId { get; set; }
	[PacketParameter(Code = 109)]
	public string ParamName { get; set; }
	public StarGemData[] StarGems { get; set; }
	public PlayerStatusData PlayerStatus { get; set; }
	public short AccountLevel { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3772B44 Offset: 0x376EB44 VA: 0x3772B44
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3772B4C Offset: 0x376EB4C VA: 0x3772B4C
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3772B54 Offset: 0x376EB54 VA: 0x3772B54
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3772B5C Offset: 0x376EB5C VA: 0x3772B5C
	public string get_ParamName() { }

	[CompilerGenerated]
	// RVA: 0x3772B64 Offset: 0x376EB64 VA: 0x3772B64
	public void set_ParamName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3772B6C Offset: 0x376EB6C VA: 0x3772B6C
	public StarGemData[] get_StarGems() { }

	[CompilerGenerated]
	// RVA: 0x3772B74 Offset: 0x376EB74 VA: 0x3772B74
	public void set_StarGems(StarGemData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3772B7C Offset: 0x376EB7C VA: 0x3772B7C
	public PlayerStatusData get_PlayerStatus() { }

	[CompilerGenerated]
	// RVA: 0x3772B84 Offset: 0x376EB84 VA: 0x3772B84
	public void set_PlayerStatus(PlayerStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3772B8C Offset: 0x376EB8C VA: 0x3772B8C
	public short get_AccountLevel() { }

	[CompilerGenerated]
	// RVA: 0x3772B94 Offset: 0x376EB94 VA: 0x3772B94
	public void set_AccountLevel(short value) { }

	// RVA: 0x3772B9C Offset: 0x376EB9C VA: 0x3772B9C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3772BA4 Offset: 0x376EBA4 VA: 0x3772BA4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3772EF4 Offset: 0x376EEF4 VA: 0x3772EF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
