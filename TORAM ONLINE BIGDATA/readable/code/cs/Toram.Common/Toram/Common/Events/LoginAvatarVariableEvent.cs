// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class LoginAvatarVariableEvent : PacketBase // TypeDefIndex: 12629
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private Dictionary<byte, int> <VariablesI>k__BackingField; // 0x28

	// Properties
	public int AvatarUuid { get; set; }
	public Dictionary<byte, int> VariablesI { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3635128 Offset: 0x3631128 VA: 0x3635128
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3635130 Offset: 0x3631130 VA: 0x3635130
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3635138 Offset: 0x3631138 VA: 0x3635138
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3635140 Offset: 0x3631140 VA: 0x3635140
	public Dictionary<byte, int> get_VariablesI() { }

	[CompilerGenerated]
	// RVA: 0x3635148 Offset: 0x3631148 VA: 0x3635148
	public void set_VariablesI(Dictionary<byte, int> value) { }

	// RVA: 0x3635150 Offset: 0x3631150 VA: 0x3635150 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3635158 Offset: 0x3631158 VA: 0x3635158 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3635318 Offset: 0x3631318 VA: 0x3635318 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
