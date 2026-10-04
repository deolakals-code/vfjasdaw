// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Systems
public class ClientOptions : PacketBase // TypeDefIndex: 11940
{
	// Fields
	[CompilerGenerated]
	private ClientOptionsData <OptionsData>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <EnterField>k__BackingField; // 0x28

	// Properties
	public ClientOptionsData OptionsData { get; set; }
	public bool EnterField { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x376ADDC Offset: 0x3766DDC VA: 0x376ADDC
	public ClientOptionsData get_OptionsData() { }

	[CompilerGenerated]
	// RVA: 0x376ADE4 Offset: 0x3766DE4 VA: 0x376ADE4
	public void set_OptionsData(ClientOptionsData value) { }

	[CompilerGenerated]
	// RVA: 0x376ADEC Offset: 0x3766DEC VA: 0x376ADEC
	public bool get_EnterField() { }

	[CompilerGenerated]
	// RVA: 0x376ADF4 Offset: 0x3766DF4 VA: 0x376ADF4
	public void set_EnterField(bool value) { }

	// RVA: 0x376AE00 Offset: 0x3766E00 VA: 0x376AE00 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x376AE08 Offset: 0x3766E08 VA: 0x376AE08
	public void .ctor() { }

	// RVA: 0x376AE10 Offset: 0x3766E10 VA: 0x376AE10 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x376AF04 Offset: 0x3766F04 VA: 0x376AF04 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
