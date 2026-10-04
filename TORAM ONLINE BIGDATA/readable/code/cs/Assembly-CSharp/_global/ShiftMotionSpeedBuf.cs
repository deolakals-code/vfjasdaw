// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShiftMotionSpeedBuf : SkillBufferDataBase // TypeDefIndex: 3305
{
	// Fields
	private int motionSpeed; // 0x20

	// Properties
	public override SkillId SkillId { get; }
	public override SkillBufferFlag Flag { get; }

	// Methods

	// RVA: 0x2344FDC Offset: 0x2340FDC VA: 0x2344FDC Slot: 4
	public override SkillId get_SkillId() { }

	// RVA: 0x2344FE4 Offset: 0x2340FE4 VA: 0x2344FE4 Slot: 9
	public override SkillBufferFlag get_Flag() { }

	// RVA: 0x2344FEC Offset: 0x2340FEC VA: 0x2344FEC
	public void .ctor(byte lv, int count, PlayerStatusBase status, SkillBufferDataBase buf) { }

	// RVA: 0x23450EC Offset: 0x23410EC VA: 0x23450EC Slot: 12
	public override int GetParam(int id) { }

	// RVA: 0x2345100 Offset: 0x2341100 VA: 0x2345100 Slot: 11
	public override void Updata() { }
}
