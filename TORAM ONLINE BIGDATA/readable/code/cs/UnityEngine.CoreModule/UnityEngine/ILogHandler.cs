// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public interface ILogHandler // TypeDefIndex: 16292
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(Exception exception, Object context);
}
