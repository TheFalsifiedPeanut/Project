namespace Collect_Dudes.World
{
    using Serialization;

    /// <summary>
    /// Represents a date via a day, month and year components.
    /// </summary>
    internal class Date
    {
        #region Fields

        /// <summary>
        /// The day component.
        /// </summary>
        byte day;
        
        /// <summary>
        /// The month component.
        /// </summary>
        byte month;
        
        /// <summary>
        /// The year component.
        /// </summary>
        ushort year;

        #endregion
        
        #region Getters

        /// <summary>
        /// Get the day component.
        /// </summary>
        /// <returns> Returns the day component. </returns>
        public byte GetDay()
        {
            return day;
        }

        /// <summary>
        /// Get the month component.
        /// </summary>
        /// <returns> Returns the month component. </returns>
        public byte GetMonth()
        {
            return month;
        }

        /// <summary>
        /// Get the year component.
        /// </summary>
        /// <returns> Returns the year component. </returns>
        public ushort GetYear()
        {
            return year;
        }

        #endregion
        
        #region Setters

        /// <summary>
        /// Set the day component.
        /// </summary>
        public void SetDay(byte day)
        {
            this.day = day;
        }

        /// <summary>
        /// Set the month component.
        /// </summary>
        public void SetMonth(byte month)
        {
            this.month = month;
        }

        /// <summary>
        /// Set the year component.
        /// </summary>
        public void SetYear(ushort year)
        {
            this.year = year;
        }

        #endregion

        #region Initialisation

        /// <summary>
        /// A constructor for Date.
        /// </summary>
        /// <param name="day"> The day component. </param>
        /// <param name="month"> The month component. </param>
        /// <param name="year"> The year component. </param>
        public Date(byte day, byte month, ushort year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        #endregion

        #region Behaviours

        /// <summary>
        /// Increments the date by one day.
        /// </summary>
        public void IncrementDay()
        {
            day++;

            if (day > InternalSettings.daysInMonth)
            {
                month++;
            }
            
            day = (byte)(day % InternalSettings.daysInMonth);

            if (month > InternalSettings.monthsInYear)
            {
                year++;
            }
            
            month = (byte)(month % InternalSettings.monthsInYear);
        }

        #endregion
    }
}