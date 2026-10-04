// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateNewParameter : PacketBase // TypeDefIndex: 11398
{
	// Fields
	[CompilerGenerated]
	private NewStyleData <NewStyleData>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <Weapon>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <StartBeginning>k__BackingField; // 0x29

	// Properties
	public NewStyleData NewStyleData { get; set; }
	public byte Weapon { get; set; }
	public bool StartBeginning { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3700E24 Offset: 0x36FCE24 VA: 0x3700E24
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3700E2C Offset: 0x36FCE2C VA: 0x3700E2C
	public NewStyleData get_NewStyleData() { }

	[CompilerGenerated]
	// RVA: 0x3700E34 Offset: 0x36FCE34 VA: 0x3700E34
	public void set_NewStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x3700E3C Offset: 0x36FCE3C VA: 0x3700E3C
	public byte get_Weapon() { }

	[CompilerGenerated]
	// RVA: 0x3700E44 Offset: 0x36FCE44 VA: 0x3700E44
	public void set_Weapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3700E4C Offset: 0x36FCE4C VA: 0x3700E4C
	public bool get_StartBeginning() { }

	[CompilerGenerated]
	// RVA: 0x3700E54 Offset: 0x36FCE54 VA: 0x3700E54
	public void set_StartBeginning(bool value) { }

	// RVA: 0x3700E60 Offset: 0x36FCE60 VA: 0x3700E60 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3700E68 Offset: 0x36FCE68 VA: 0x3700E68 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x37010D4 Offset: 0x36FD0D4 VA: 0x37010D4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
