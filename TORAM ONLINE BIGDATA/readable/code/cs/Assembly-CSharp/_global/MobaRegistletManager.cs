// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobaRegistletManager : RegistletManager // TypeDefIndex: 2294
{
	// Fields
	private readonly MobaDuelAbilityManager duelAbilityManager; // 0x38

	// Properties
	private byte MaxRegistletSlot { get; }

	// Methods

	// RVA: 0x217CD04 Offset: 0x2178D04 VA: 0x217CD04
	private byte get_MaxRegistletSlot() { }

	// RVA: 0x217CD1C Offset: 0x2178D1C VA: 0x217CD1C
	public void .ctor(GemCartBufferManager manager, MobaDuelAbilityManager duelAbilityManager) { }

	// RVA: 0x217CD98 Offset: 0x2178D98 VA: 0x217CD98
	public byte GetLevelSlot(short level) { }

	// RVA: 0x217CEA4 Offset: 0x2178EA4 VA: 0x217CEA4
	public void LevelUpChangeRegistlet(byte newSlotNum) { }
}
