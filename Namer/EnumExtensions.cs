namespace Namer
{
    using System;
    using System.ComponentModel;
    using System.Reflection;

    /// <summary>
    /// The enum extensions.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Get enumeration description.
        /// </summary>
        /// <param name="value">Enumeration value.</param>
        /// <returns><see cref="string"/> description.</returns>
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return value.ToString();
        }
    }
}
