// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class ExSkillDataBase // TypeDefIndex: 1818
{
	// Properties
	public abstract SkillId SkillId { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract SkillId get_SkillId();

	// RVA: 0x20E4308 Offset: 0x20E0308 VA: 0x20E4308
	public void .ctor() { }

	// RVA: 0x20E4344 Offset: 0x20E0344 VA: 0x20E4344
	public void .ctor(byte[] binary) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] ToBinary();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetValue(byte[] binary);
}
