// Assembly: System.dll
// Namespace: 
[Flags]
private enum ContextAwareResult.StateFlags // TypeDefIndex: 14347
{
	// Fields
	public byte value__; // 0x0
	public const ContextAwareResult.StateFlags None = 0;
	public const ContextAwareResult.StateFlags CaptureIdentity = 1;
	public const ContextAwareResult.StateFlags CaptureContext = 2;
	public const ContextAwareResult.StateFlags ThreadSafeContextCopy = 4;
	public const ContextAwareResult.StateFlags PostBlockStarted = 8;
	public const ContextAwareResult.StateFlags PostBlockFinished = 16;
}
