// Assembly: Assembly-CSharp.dll
// Namespace: 
[Flags]
public enum SkillBufferFlag // TypeDefIndex: 3311
{
	// Fields
	public int value__; // 0x0
	public const SkillBufferFlag None = 0;
	public const SkillBufferFlag Circle = 1;
	public const SkillBufferFlag Count = 2;
	public const SkillBufferFlag Minstrel = 4;
	public const SkillBufferFlag Dancer = 8;
	public const SkillBufferFlag DamageEnd = 16;
	public const SkillBufferFlag AbnormalEnd = 32;
	public const SkillBufferFlag UnableEquipChange = 64;
	public const SkillBufferFlag UpdateBufIconText = 512;
	public const SkillBufferFlag ChangeEquipRemove = 1024;
	public const SkillBufferFlag HideBufferIcon = 2048;
	public const SkillBufferFlag Invincible = 4096;
	public const SkillBufferFlag RemovedUpdateUIText = 8192;
	public const SkillBufferFlag Special = 16384;
	public const SkillBufferFlag MotionSwitchTemporary = 32768;
	public const SkillBufferFlag MotionSwitchContinuation = 65536;
	public const SkillBufferFlag SendSelfBufferRemove = 131072;
}
