// Assembly: Assembly-CSharp.dll
// Namespace: 
public class DamageStatus // TypeDefIndex: 329
{
	// Fields
	[CompilerGenerated]
	private byte <Parts>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <PrimaryStatusId>k__BackingField; // 0x14
	[CompilerGenerated]
	private byte[] <AbnormalCondition>k__BackingField; // 0x18

	// Properties
	public byte Parts { get; set; }
	public int PrimaryStatusId { get; set; }
	public byte[] AbnormalCondition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x2482274 Offset: 0x247E274 VA: 0x2482274
	public byte get_Parts() { }

	[CompilerGenerated]
	// RVA: 0x248227C Offset: 0x247E27C VA: 0x248227C
	private void set_Parts(byte value) { }

	[CompilerGenerated]
	// RVA: 0x2482284 Offset: 0x247E284 VA: 0x2482284
	public int get_PrimaryStatusId() { }

	[CompilerGenerated]
	// RVA: 0x248228C Offset: 0x247E28C VA: 0x248228C
	private void set_PrimaryStatusId(int value) { }

	[CompilerGenerated]
	// RVA: 0x2482294 Offset: 0x247E294 VA: 0x2482294
	public byte[] get_AbnormalCondition() { }

	[CompilerGenerated]
	// RVA: 0x248229C Offset: 0x247E29C VA: 0x248229C
	private void set_AbnormalCondition(byte[] value) { }

	// RVA: 0x24822A4 Offset: 0x247E2A4 VA: 0x24822A4
	public void .ctor(byte parts, int primaryStatus, byte[] condition) { }

	// RVA: 0x24822EC Offset: 0x247E2EC VA: 0x24822EC
	public static DamageStatus Create(MobActionManagerBase mobAction) { }
}
