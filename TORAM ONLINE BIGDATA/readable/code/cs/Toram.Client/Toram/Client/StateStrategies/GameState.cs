// Assembly: Toram.Client.dll
// Namespace: Toram.Client.StateStrategies
public enum GameState // TypeDefIndex: 14880
{
	// Fields
	public int value__; // 0x0
	public const GameState Disconnected = 0;
	public const GameState MasterWaitForConnecting = 1;
	public const GameState MasterConnected = 2;
	public const GameState MasterWaitForReconnecting = 3;
	public const GameState MasterAllowLogin = 4;
	public const GameState GameWaitForConnecting = 5;
	public const GameState GameConnected = 6;
	public const GameState GameWaitForReconnecting = 7;
	public const GameState GameConnectSwitching = 8;
	public const GameState GameAvatarCreate = 9;
	public const GameState GameLoadAvatar = 10;
	public const GameState GameLoader = 11;
	public const GameState GameMain = 12;
	public const GameState GameParameterCreate = 13;
	public const GameState GameRecreate = 14;
	public const GameState Obsolete_15 = 15;
	public const GameState GameRename = 16;
	public const GameState GameAvatarNaming = 17;
	public const GameState GameBlank = 18;
}
