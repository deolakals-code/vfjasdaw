// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
[Serializable]
public struct TimeStamp : IComparable, IComparable<TimeStamp>, IEquatable<TimeStamp> // TypeDefIndex: 11134
{
	// Fields
	public static readonly DateTime MaxDateTime; // 0x0
	public static readonly DateTime MinDateTime; // 0x8
	public static readonly TimeStamp MaxTimeStamp; // 0x10
	public static readonly TimeStamp MinTimeStamp; // 0x18
	public const int TicksSecond = 1;
	public const int TicksMinute = 60;
	public const int TicksHour = 3600;
	public const int TicksDay = 86400;
	private long timeStampData; // 0x0

	// Properties
	internal long InternalTicks { get; }
	[CLSCompliant(False)]
	public uint Ticks { get; }
	public DateTime DateTime { get; }

	// Methods

	// RVA: 0x35C6304 Offset: 0x35C2304 VA: 0x35C6304
	public void .ctor(DateTime dateTime) { }

	[CLSCompliant(False)]
	// RVA: 0x35C6494 Offset: 0x35C2494 VA: 0x35C6494
	public void .ctor(uint timestamp) { }

	// RVA: 0x35C65D0 Offset: 0x35C25D0 VA: 0x35C65D0
	public void .ctor(int year, int month, int day, int hour, int minute, int second) { }

	// RVA: 0x35C66B4 Offset: 0x35C26B4 VA: 0x35C66B4
	internal long get_InternalTicks() { }

	// RVA: 0x35C657C Offset: 0x35C257C VA: 0x35C657C
	public uint get_Ticks() { }

	// RVA: 0x35C66BC Offset: 0x35C26BC VA: 0x35C66BC
	public DateTime get_DateTime() { }

	// RVA: 0x35C675C Offset: 0x35C275C VA: 0x35C675C Slot: 3
	public override string ToString() { }

	// RVA: 0x35C685C Offset: 0x35C285C VA: 0x35C685C Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x35C6934 Offset: 0x35C2934 VA: 0x35C6934 Slot: 5
	public int CompareTo(TimeStamp value) { }

	// RVA: 0x35C69AC Offset: 0x35C29AC VA: 0x35C69AC Slot: 6
	public bool Equals(TimeStamp value) { }

	// RVA: 0x35C6A18 Offset: 0x35C2A18 VA: 0x35C6A18 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x35C6AC0 Offset: 0x35C2AC0 VA: 0x35C6AC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x35C636C Offset: 0x35C236C VA: 0x35C636C
	private static long SetTimeStampData(DateTime dateTime) { }

	// RVA: 0x35C6AC8 Offset: 0x35C2AC8 VA: 0x35C6AC8
	public static bool IsTimeStampRange(DateTime dateTime) { }

	// RVA: 0x35C6BB8 Offset: 0x35C2BB8 VA: 0x35C6BB8
	private static void .cctor() { }
}
