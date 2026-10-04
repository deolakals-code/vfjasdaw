// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Parameter
public class ParameterGetActionSettingResponse : OperationResponseBase // TypeDefIndex: 11983
{
	// Fields
	[CompilerGenerated]
	private byte <ParamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte[] <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private Dictionary<short, byte> <Skills>k__BackingField; // 0x30
	[CompilerGenerated]
	private Dictionary<short, byte> <GemSkills>k__BackingField; // 0x38

	// Properties
	public byte ParamId { get; set; }
	public byte[] Setting { get; set; }
	public Dictionary<short, byte> Skills { get; set; }
	public Dictionary<short, byte> GemSkills { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3771D28 Offset: 0x376DD28 VA: 0x3771D28
	public void .ctor() { }

	// RVA: 0x3771D30 Offset: 0x376DD30 VA: 0x3771D30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3771D38 Offset: 0x376DD38 VA: 0x3771D38
	public byte get_ParamId() { }

	[CompilerGenerated]
	// RVA: 0x3771D40 Offset: 0x376DD40 VA: 0x3771D40
	public void set_ParamId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3771D48 Offset: 0x376DD48 VA: 0x3771D48
	public byte[] get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3771D50 Offset: 0x376DD50 VA: 0x3771D50
	public void set_Setting(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3771D58 Offset: 0x376DD58 VA: 0x3771D58
	public Dictionary<short, byte> get_Skills() { }

	[CompilerGenerated]
	// RVA: 0x3771D60 Offset: 0x376DD60 VA: 0x3771D60
	public void set_Skills(Dictionary<short, byte> value) { }

	[CompilerGenerated]
	// RVA: 0x3771D68 Offset: 0x376DD68 VA: 0x3771D68
	public Dictionary<short, byte> get_GemSkills() { }

	[CompilerGenerated]
	// RVA: 0x3771D70 Offset: 0x376DD70 VA: 0x3771D70
	public void set_GemSkills(Dictionary<short, byte> value) { }

	// RVA: 0x3771D78 Offset: 0x376DD78 VA: 0x3771D78 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3771D80 Offset: 0x376DD80 VA: 0x3771D80 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3771D88 Offset: 0x376DD88 VA: 0x3771D88 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3771F18 Offset: 0x376DF18 VA: 0x3771F18 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
