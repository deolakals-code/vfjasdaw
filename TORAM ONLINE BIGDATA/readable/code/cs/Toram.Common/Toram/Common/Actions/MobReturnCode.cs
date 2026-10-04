// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Actions
public enum MobReturnCode // TypeDefIndex: 13176
{
	// Fields
	public int value__; // 0x0
	public const MobReturnCode Ok = 0;
	public const MobReturnCode NotFound = 1;
	public const MobReturnCode InvalidId = 2;
	public const MobReturnCode AlreadyDisposed = 3;
	public const MobReturnCode AlreadyDead = 4;
	public const MobReturnCode UnmanagedMonster = 5;
	public const MobReturnCode UnknownError = 6;
	public const MobReturnCode AlreadyExist = 7;
	public const MobReturnCode ViolationDetection = 8;
	public const MobReturnCode AlreadyAttacked = 9;
	public const MobReturnCode InvalidDamage_Debug = 255;
}
