using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class ValueNullExcpetion : Exception
    {
        internal ValueNullExcpetion(string key)
        {
            Key = key;
        }

        public string Key { get; private set; }

        public override string Message =>
            $"Failed to get a value for the key \"{Key}\" in the App.config file.";
    }

    public class ValueConvertExcpetion : Exception
    {
        internal ValueConvertExcpetion(string value, Type targetType, Exception innerExeption)
            : base(null, innerException)
        {
            Value = value;
            TargetType = targetType;
        }

        public string Key { get; internal set; }

        public string Value { get; private set; }

        public Type TargetType { get; private set; }

        public override string Message =>
            $"Failed to convert {Value} to the type \"{TargetType.Name}\". " +
            $"See inner exception for details.";
    }

    public class GetValueExcpetion : Exception
    {
        internal ValueConvertExcpetion(string key, Exception innerException)
            base(null, innerException)
    {}

    public string Key { get; private set; }

        public override string Message =>
            $"An unexpected exception occured while getting a value for the key \"{Key}\". " +
            "See inner exception for details.";
    }
}
