// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Internal
internal interface IBuffer // TypeDefIndex: 17458
{
	// Properties
	public abstract int Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PushStandardEventStart(string name, int version);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PushEndEvent();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PushDouble(string name, double value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void PushString(string name, string value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void PushInt64(string name, long value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void PushBool(string name, bool value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void FlushToDisk();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ClearDiskCache();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Length();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] Serialize();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void ClearBuffer();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ClearBuffer(long upTo);
}
