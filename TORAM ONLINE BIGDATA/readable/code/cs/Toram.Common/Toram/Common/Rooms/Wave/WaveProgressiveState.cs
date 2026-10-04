// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Wave
[Flags]
public enum WaveProgressiveState // TypeDefIndex: 11305
{
	// Fields
	public int value__; // 0x0
	public const WaveProgressiveState Nil = 0;
	public const WaveProgressiveState BeforeGameStart = 1;
	public const WaveProgressiveState WaveStart = 2;
	public const WaveProgressiveState WavePlay = 4;
	public const WaveProgressiveState NextWaveDelay = 8;
	public const WaveProgressiveState PopEnd = 16;
	public const WaveProgressiveState SubjugationSuccess = 32;
	public const WaveProgressiveState End = 128;
}
