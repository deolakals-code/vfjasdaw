// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions.PetAction
public class PetSendData : UnityHashBase // TypeDefIndex: 13220
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Rotation>k__BackingField; // 0x30

	// Properties
	public long PetUuid { get; set; }
	public short[] Position { get; set; }
	public short Rotation { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36E424C Offset: 0x36E024C VA: 0x36E424C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36E4254 Offset: 0x36E0254 VA: 0x36E4254
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x36E425C Offset: 0x36E025C VA: 0x36E425C
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x36E4264 Offset: 0x36E0264 VA: 0x36E4264
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x36E426C Offset: 0x36E026C VA: 0x36E426C
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36E4274 Offset: 0x36E0274 VA: 0x36E4274
	public short get_Rotation() { }

	[CompilerGenerated]
	// RVA: 0x36E427C Offset: 0x36E027C VA: 0x36E427C
	public void set_Rotation(short value) { }

	// RVA: 0x36E4284 Offset: 0x36E0284 VA: 0x36E4284 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36E428C Offset: 0x36E028C VA: 0x36E428C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36E451C Offset: 0x36E051C VA: 0x36E451C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
