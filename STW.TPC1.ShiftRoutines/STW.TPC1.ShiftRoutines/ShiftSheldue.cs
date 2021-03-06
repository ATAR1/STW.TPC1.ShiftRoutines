﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STW.TPC1.ShiftRoutines
{
    /// <summary>
    /// Расписание смен при двенадцатичасовом графике
    /// </summary>
    public class ShiftSheldue : IShiftSheldue
    {
        private readonly DateTime _startDate = new DateTime(2017, 1, 12);

        private readonly char[,] _sheldue = new char[4, 2] { { 'A', 'B' },{ 'C', 'A' },{ 'D', 'C' },{ 'B', 'D' } };

        private readonly TimeInterval[] _timeInterval = { new TimeInterval(8,20), new TimeInterval(20,32) };
        /// <summary>
        /// Определяет смену за дату и время
        /// </summary>
        /// <param name="time">Дата и время для которых нужно определить смену</param>
        /// <returns>Смена которя является текуще по отношению ко времени time</returns>
        public Shift GetShift(DateTime time)
        {
            var difference = (time.AddHours(-8) - _startDate).TotalDays;
            var dayInSheldue = (int)(difference % 4 + 4) % 4;
            int shiftInSheldue = time.AddHours(-8).TimeOfDay<TimeSpan.FromHours(12) ? 0 :  1;
            return new Shift()
            {
                Letter = _sheldue[dayInSheldue, shiftInSheldue],
                BeginTime = time.Date + _timeInterval[shiftInSheldue].StartTime,
                EndTime = time.Date + _timeInterval[shiftInSheldue].EndTime
            };
        }
    }
}
