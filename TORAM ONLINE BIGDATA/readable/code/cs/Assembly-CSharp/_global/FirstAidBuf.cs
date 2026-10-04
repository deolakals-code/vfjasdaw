// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FirstAidBuf : SkillBufferDataBase // TypeDefIndex: 3166
{
	// Fields
	private const float LevelDownTime = 60;
	private float levelDownTimer; // 0x20
	private SkillBufferFlag _flag; // 0x24

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x232E7E8 Offset: 0x232A7E8 VA: 0x232E7E8 Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x232E7F0 Offset: 0x232A7F0 VA: 0x232E7F0 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x232E7F8 Offset: 0x232A7F8 VA: 0x232E7F8
	public void .ctor(byte lv, float time) { }

	// RVA: 0x232E82C Offset: 0x232A82C VA: 0x232E82C Slot: 11
	public override void Updata() { }

	// RVA: 0x232E918 Offset: 0x232A918 VA: 0x232E918 Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x232E944 Offset: 0x232A944 VA: 0x232E944
	public void LevelUp() { }

	// RVA: 0x232E968 Offset: 0x232A968 VA: 0x232E968
	public void ValidInvincible(float time) { }

	// RVA: 0x232E900 Offset: 0x232A900 VA: 0x232E900
	public void InvalidInvincible() { }
}
