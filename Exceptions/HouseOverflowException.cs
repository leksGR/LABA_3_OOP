using System;

namespace WinFormsApp_OOP_Lab3_Singleton
{
    public class HouseOverflowException : OverflowException
    {
        public string AdditionalInfo { get; }

        public HouseOverflowException()
            : base("Переполнение значения.")
        {
            AdditionalInfo = "Не указано";
        }

        public HouseOverflowException(string message, string additionalInfo = "")
            : base(message)
        {
            AdditionalInfo = additionalInfo;
        }
    }
}