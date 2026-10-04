// Assembly: mscorlib.dll
// Namespace: 
[IsReadOnly]
[Serializable]
public struct TimeZoneInfo.TransitionTime : IEquatable<TimeZoneInfo.TransitionTime>, ISerializable, IDeserializationCallback // TypeDefIndex: 9514
{
	// Fields
	private readonly DateTime _timeOfDay; // 0x0
	private readonly byte _month; // 0x8
	private readonly byte _week; // 0x9
	private readonly byte _day; // 0xA
	private readonly DayOfWeek _dayOfWeek; // 0xC
	private readonly bool _isFixedDateRule; // 0x10

	// Properties
	public DateTime TimeOfDay { get; }
	public int Month { get; }
	public int Week { get; }
	public int Day { get; }
	public DayOfWeek DayOfWeek { get; }
	public bool IsFixedDateRule { get; }

	// Methods

	// RVA: 0x2F6FD68 Offset: 0x2F6BD68 VA: 0x2F6FD68
	public DateTime get_TimeOfDay() { }

	// RVA: 0x2F6FD70 Offset: 0x2F6BD70 VA: 0x2F6FD70
	public int get_Month() { }

	// RVA: 0x2F6FD78 Offset: 0x2F6BD78 VA: 0x2F6FD78
	public int get_Week() { }

	// RVA: 0x2F6FD80 Offset: 0x2F6BD80 VA: 0x2F6FD80
	public int get_Day() { }

	// RVA: 0x2F6FD88 Offset: 0x2F6BD88 VA: 0x2F6FD88
	public DayOfWeek get_DayOfWeek() { }

	// RVA: 0x2F6FD90 Offset: 0x2F6BD90 VA: 0x2F6FD90
	public bool get_IsFixedDateRule() { }

	// RVA: 0x2F6FD98 Offset: 0x2F6BD98 VA: 0x2F6FD98 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F6EE50 Offset: 0x2F6AE50 VA: 0x2F6EE50
	public static bool op_Inequality(TimeZoneInfo.TransitionTime t1, TimeZoneInfo.TransitionTime t2) { }

	// RVA: 0x2F6EE84 Offset: 0x2F6AE84 VA: 0x2F6EE84 Slot: 4
	public bool Equals(TimeZoneInfo.TransitionTime other) { }

	// RVA: 0x2F6FE28 Offset: 0x2F6BE28 VA: 0x2F6FE28 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F6FE30 Offset: 0x2F6BE30 VA: 0x2F6FE30
	private void .ctor(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek, bool isFixedDateRule) { }

	// RVA: 0x2F67E18 Offset: 0x2F63E18 VA: 0x2F67E18
	public static TimeZoneInfo.TransitionTime CreateFixedDateRule(DateTime timeOfDay, int month, int day) { }

	// RVA: 0x2F68D9C Offset: 0x2F64D9C VA: 0x2F68D9C
	public static TimeZoneInfo.TransitionTime CreateFloatingDateRule(DateTime timeOfDay, int month, int week, DayOfWeek dayOfWeek) { }

	// RVA: 0x2F6FEA0 Offset: 0x2F6BEA0 VA: 0x2F6FEA0
	private static void ValidateTransitionTime(DateTime timeOfDay, int month, int week, int day, DayOfWeek dayOfWeek) { }

	// RVA: 0x2F7014C Offset: 0x2F6C14C VA: 0x2F7014C Slot: 6
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x2F70238 Offset: 0x2F6C238 VA: 0x2F70238 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x2F703E0 Offset: 0x2F6C3E0 VA: 0x2F703E0
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}
