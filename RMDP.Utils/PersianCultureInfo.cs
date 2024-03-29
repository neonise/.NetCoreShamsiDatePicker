﻿using System;
using System.Globalization;
using RMDP.Utils.Internals;
using DateTimeFormatInfo = System.Globalization.DateTimeFormatInfo;

namespace RMDP.Utils
{
    /// <summary>
    /// CultureInfo for "FA-IR" culture, which has correct calendar information.
    /// </summary>
    public class PersianCultureInfo : CultureInfo
    {
        #region FieldNames

        private struct CultureFieldNames
        {
            public string Calendar
            {
                get { return "calendar"; }
            }

            public string IsReadonly
            {
                get { return "m_isReadOnly"; }
            }
        }

        #endregion

        #region Fields

        private static CultureFieldNames FieldNames;
        private readonly PersianCalendar calendar;
        private readonly System.Globalization.PersianCalendar systemCalendar;
        private DateTimeFormatInfo format;

        #endregion

        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="PersianCultureInfo"/> class.
        /// </summary>
        public PersianCultureInfo()
            : base("fa-IR", false)
        {
            calendar = new PersianCalendar();
            systemCalendar = new System.Globalization.PersianCalendar();
            format = CreateDateTimeFormatInfo();
            SetCalendar();
        }

        #endregion

        #region Private Methods

        protected void SetCalendar()
        {
            ReflectionHelper.SetField(format, FieldNames.Calendar, systemCalendar);
            base.DateTimeFormat = format;
        }

        protected internal DateTimeFormatInfo CreateDateTimeFormatInfo()
        {
            if (format == null)
            {
                format = new DateTimeFormatInfo
                {
                    AbbreviatedDayNames = PersianDateTimeFormatInfo.AbbreviatedDayNames,
                    AbbreviatedMonthGenitiveNames = PersianDateTimeFormatInfo.AbbreviatedMonthGenitiveNames,
                    AbbreviatedMonthNames = PersianDateTimeFormatInfo.AbbreviatedMonthNames,
                    AMDesignator = PersianDateTimeFormatInfo.AMDesignator,
                    DateSeparator = PersianDateTimeFormatInfo.DateSeparator,
                    DayNames = PersianDateTimeFormatInfo.DayNames,
                    FirstDayOfWeek = PersianDateTimeFormatInfo.FirstDayOfWeek,
                    FullDateTimePattern = PersianDateTimeFormatInfo.FullDateTimePattern,
                    LongDatePattern = PersianDateTimeFormatInfo.LongDatePattern,
                    LongTimePattern = PersianDateTimeFormatInfo.LongTimePattern,
                    MonthDayPattern = PersianDateTimeFormatInfo.MonthDayPattern,
                    MonthGenitiveNames = PersianDateTimeFormatInfo.MonthGenitiveNames,
                    MonthNames = PersianDateTimeFormatInfo.MonthNames,
                    PMDesignator = PersianDateTimeFormatInfo.PMDesignator,
                    ShortDatePattern = PersianDateTimeFormatInfo.ShortDatePattern,
                    ShortestDayNames = PersianDateTimeFormatInfo.ShortestDayNames,
                    ShortTimePattern = PersianDateTimeFormatInfo.ShortTimePattern,
                    TimeSeparator = PersianDateTimeFormatInfo.TimeSeparator,
                    YearMonthPattern = PersianDateTimeFormatInfo.YearMonthPattern
                };

                //Make format information readonly to fix
                //cloning problems that might happen with 
                //other controls.
                //ReflectionHelper.SetField(format, FieldNames.IsReadonly, true);
            }

            return format;
        }

        #endregion

        #region Props

        /// <summary>
        /// Gets the default calendar used by the culture.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// A <see cref="T:System.Globalization.Calendar"/> that represents the default calendar used by the culture.
        /// </returns>
        public override Calendar Calendar
        {
            get { return systemCalendar; }
        }

        /// <summary>
        /// Gets the list of calendars that can be used by the culture.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// An array of type <see cref="T:System.Globalization.Calendar"/> that represents the calendars that can be used by the culture represented by the current <see cref="T:System.Globalization.CultureInfo"/>.
        /// </returns>
        public override Calendar[] OptionalCalendars
        {
            get { return new Calendar[] { systemCalendar, calendar }; }
        }

        /// <summary>
        /// Creates a copy of the current <see cref="T:System.Globalization.CultureInfo"/>.
        /// </summary>
        /// <returns>
        /// A copy of the current <see cref="T:System.Globalization.CultureInfo"/>.
        /// </returns>
        public override object Clone()
        {
            return new PersianCultureInfo();
        }

        public new bool IsReadOnly
        {
            get { return true; }
        }

        public override bool IsNeutralCulture
        {
            get { return false; }
        }

        /// <summary>
        /// Gets or sets a <see cref="T:System.Globalization.DateTimeFormatInfo"/> that defines the culturally appropriate format of displaying dates and times.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// A <see cref="T:System.Globalization.DateTimeFormatInfo"/> that defines the culturally appropriate format of displaying dates and times.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// The property is set to null.
        /// </exception>
        public override DateTimeFormatInfo DateTimeFormat
        {
            get { return format; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value", "value can not be null.");

                format = value;
            }
        }

        #endregion
    }
}
