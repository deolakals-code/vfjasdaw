// Assembly: Assembly-CSharp.dll
// Namespace: 
public class AuraBladeBuf : SkillBufferDataBase // TypeDefIndex: 3072
{
	// Fields
	private int lastDamageRate; // 0x20
	private int percent; // 0x24
	private PlayerStatusBase status; // 0x28

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x231E610 Offset: 0x231A610 VA: 0x231E610 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x231E618 Offset: 0x231A618 VA: 0x231E618 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x231E620 Offset: 0x231A620 VA: 0x231E620
	public void .ctor(byte lv, PlayerStatusBase status) { }

	// RVA: 0x231E72C Offset: 0x231A72C VA: 0x231E72C Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x231E75C Offset: 0x231A75C VA: 0x231E75C Slot: 11
	public override void Updata() { }

	// RVA: 0x231E7B0 Offset: 0x231A7B0 VA: 0x231E7B0
	public void ExtensionTime() { }

	// RVA: 0x231E664 Offset: 0x231A664 VA: 0x231E664
	public void CalcBufferValue() { }

	// RVA: 0x231E7C4 Offset: 0x231A7C4 VA: 0x231E7C4
	public bool CheckPersistent() { }
}
