// Assembly: mscorlib.dll
// Namespace: 
[Serializable]
public sealed class TimeZoneInfo.AdjustmentRule : IEquatable<TimeZoneInfo.AdjustmentRule>, ISerializable, IDeserializationCallback // TypeDefIndex: 9513
{
	// Fields
	private readonly DateTime _dateStart; // 0x10
	private readonly DateTime _dateEnd; // 0x18
	private readonly TimeSpan _daylightDelta; // 0x20
	private readonly TimeZoneInfo.TransitionTime _daylightTransitionStart; // 0x28
	private readonly TimeZoneInfo.TransitionTime _daylightTransitionEnd; // 0x40
	private readonly TimeSpan _baseUtcOffsetDelta; // 0x58
	private readonly bool _noDaylightTransitions; // 0x60

	// Properties
	public DateTime DateStart { get; }
	public DateTime DateEnd { get; }
	public TimeSpan DaylightDelta { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionStart { get; }
	public TimeZoneInfo.TransitionTime DaylightTransitionEnd { get; }
	internal TimeSpan BaseUtcOffsetDelta { get; }
	internal bool NoDaylightTransitions { get; }
	internal bool HasDaylightSaving { get; }

	// Methods

	// RVA: 0x2F6EE00 Offset: 0x2F6AE00 VA: 0x2F6EE00
	public DateTime get_DateStart() { }

	// RVA: 0x2F6EE08 Offset: 0x2F6AE08 VA: 0x2F6EE08
	public DateTime get_DateEnd() { }

	// RVA: 0x2F6EE10 Offset: 0x2F6AE10 VA: 0x2F6EE10
	public TimeSpan get_DaylightDelta() { }

	// RVA: 0x2F6EE18 Offset: 0x2F6AE18 VA: 0x2F6EE18
	public TimeZoneInfo.TransitionTime get_DaylightTransitionStart() { }

	// RVA: 0x2F6EE2C Offset: 0x2F6AE2C VA: 0x2F6EE2C
	public TimeZoneInfo.TransitionTime get_DaylightTransitionEnd() { }

	// RVA: 0x2F6EE40 Offset: 0x2F6AE40 VA: 0x2F6EE40
	internal TimeSpan get_BaseUtcOffsetDelta() { }

	// RVA: 0x2F6EE48 Offset: 0x2F6AE48 VA: 0x2F6EE48
	internal bool get_NoDaylightTransitions() { }

	// RVA: 0x2F6A9A0 Offset: 0x2F669A0 VA: 0x2F6A9A0
	internal bool get_HasDaylightSaving() { }

	// RVA: 0x2F6B9A4 Offset: 0x2F679A4 VA: 0x2F6B9A4 Slot: 4
	public bool Equals(TimeZoneInfo.AdjustmentRule other) { }

	// RVA: 0x2F6EF5C Offset: 0x2F6AF5C VA: 0x2F6EF5C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F6EFB4 Offset: 0x2F6AFB4 VA: 0x2F6EFB4
	private void .ctor(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

	// RVA: 0x2F6EB34 Offset: 0x2F6AB34 VA: 0x2F6EB34
	public static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd) { }

	// RVA: 0x2F67A90 Offset: 0x2F63A90 VA: 0x2F67A90
	internal static TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions) { }

	// RVA: 0x2F6CEFC Offset: 0x2F68EFC VA: 0x2F6CEFC
	internal bool IsStartDateMarkerForBeginningOfYear() { }

	// RVA: 0x2F6D014 Offset: 0x2F69014 VA: 0x2F6D014
	internal bool IsEndDateMarkerForEndOfYear() { }

	// RVA: 0x2F6F07C Offset: 0x2F6B07C VA: 0x2F6F07C
	private static void ValidateAdjustmentRule(DateTime dateStart, DateTime dateEnd, TimeSpan daylightDelta, TimeZoneInfo.TransitionTime daylightTransitionStart, TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions) { }

	// RVA: 0x2F6F5C8 Offset: 0x2F6B5C8 VA: 0x2F6F5C8 Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2F6F6DC Offset: 0x2F6B6DC VA: 0x2F6F6DC Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F6F91C Offset: 0x2F6B91C VA: 0x2F6F91C
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F6FD30 Offset: 0x2F6BD30 VA: 0x2F6FD30
	internal void .ctor() { }
}
