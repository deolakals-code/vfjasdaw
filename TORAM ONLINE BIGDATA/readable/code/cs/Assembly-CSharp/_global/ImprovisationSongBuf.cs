// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ImprovisationSongBuf : SkillBufferDataBase // TypeDefIndex: 3207
{
	// Fields
	private readonly byte skillLocalId; // 0x1D
	private byte damageCut; // 0x1E
	private bool isInvincibility; // 0x1F
	private bool damaged; // 0x20

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }
	public byte SkillLocalId { get; }

	// Methods

	// RVA: 0x2335CD8 Offset: 0x2331CD8 VA: 0x2335CD8
	public void .ctor(byte lv, byte skillLocalId) { }

	// RVA: 0x2335D38 Offset: 0x2331D38 VA: 0x2335D38 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2335D40 Offset: 0x2331D40 VA: 0x2335D40 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2335D4C Offset: 0x2331D4C VA: 0x2335D4C
	public byte get_SkillLocalId() { }

	// RVA: 0x2335D54 Offset: 0x2331D54 VA: 0x2335D54 Slot: 11
	public override void Updata() { }

	// RVA: 0x2335DA8 Offset: 0x2331DA8 VA: 0x2335DA8 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2335DC8 Offset: 0x2331DC8 VA: 0x2335DC8
	public void Damaged() { }

	// RVA: 0x2335DD4 Offset: 0x2331DD4 VA: 0x2335DD4
	public bool CheckDamaged() { }
}
