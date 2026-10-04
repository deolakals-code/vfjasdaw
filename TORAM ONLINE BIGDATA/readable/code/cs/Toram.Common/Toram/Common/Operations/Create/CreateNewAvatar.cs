// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Create
public class CreateNewAvatar : PacketBase // TypeDefIndex: 11406
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

	// RVA: 0x3701ED8 Offset: 0x36FDED8 VA: 0x3701ED8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3701EE0 Offset: 0x36FDEE0 VA: 0x3701EE0
	public NewStyleData get_NewStyleData() { }

	[CompilerGenerated]
	// RVA: 0x3701EE8 Offset: 0x36FDEE8 VA: 0x3701EE8
	public void set_NewStyleData(NewStyleData value) { }

	[CompilerGenerated]
	// RVA: 0x3701EF0 Offset: 0x36FDEF0 VA: 0x3701EF0
	public byte get_Weapon() { }

	[CompilerGenerated]
	// RVA: 0x3701EF8 Offset: 0x36FDEF8 VA: 0x3701EF8
	public void set_Weapon(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3701F00 Offset: 0x36FDF00 VA: 0x3701F00
	public bool get_StartBeginning() { }

	[CompilerGenerated]
	// RVA: 0x3701F08 Offset: 0x36FDF08 VA: 0x3701F08
	public void set_StartBeginning(bool value) { }

	// RVA: 0x3701F14 Offset: 0x36FDF14 VA: 0x3701F14 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3701F1C Offset: 0x36FDF1C VA: 0x3701F1C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3702188 Offset: 0x36FE188 VA: 0x3702188 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
