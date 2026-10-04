// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RoomManager.RoomMeberData // TypeDefIndex: 2452
{
	// Fields
	public readonly int ArchetypeId; // 0x10
	public readonly byte ArchetypeType; // 0x14
	public readonly string UserName; // 0x18
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x22
	[CompilerGenerated]
	private short <WeaponType>k__BackingField; // 0x24

	// Properties
	public short Level { get; set; }
	public byte State { get; set; }
	public short WeaponType { get; set; }

	// Methods

	// RVA: 0x21BA688 Offset: 0x21B6688 VA: 0x21BA688
	public void .ctor(IRoomMember roomMeber) { }

	[CompilerGenerated]
	// RVA: 0x21BA928 Offset: 0x21B6928 VA: 0x21BA928
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x21BA930 Offset: 0x21B6930 VA: 0x21BA930
	private void set_Level(short value) { }

	[CompilerGenerated]
	// RVA: 0x21BA938 Offset: 0x21B6938 VA: 0x21BA938
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x21BA940 Offset: 0x21B6940 VA: 0x21BA940
	private void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x21BA948 Offset: 0x21B6948 VA: 0x21BA948
	public short get_WeaponType() { }

	[CompilerGenerated]
	// RVA: 0x21BA950 Offset: 0x21B6950 VA: 0x21BA950
	private void set_WeaponType(short value) { }

	// RVA: 0x21BA958 Offset: 0x21B6958 VA: 0x21BA958
	public void UpdateStatus(byte state, short level, short weaponType) { }
}
