using System;

namespace STW.TPC1.ShiftRoutines
{
    public interface IShiftSheldue
    {
        Shift GetShift(DateTime time);
    }
}