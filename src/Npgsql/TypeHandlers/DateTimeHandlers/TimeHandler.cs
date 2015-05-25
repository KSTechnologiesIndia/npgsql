﻿using System;
using System.CodeDom;
using Npgsql.BackendMessages;
using NpgsqlTypes;
using System.Data;

namespace Npgsql.TypeHandlers.DateTimeHandlers
{
    /// <remarks>
    /// http://www.postgresql.org/docs/current/static/datatype-datetime.html
    /// </remarks>
    [TypeMapping("time", NpgsqlDbType.Time, DbType.Time, typeof(TimeSpan))]
    internal class TimeHandler : TypeHandler<TimeSpan>, ISimpleTypeReader<TimeSpan>, ISimpleTypeWriter
    {
        /// <summary>
        /// A deprecated compile-time option of PostgreSQL switches to a floating-point representation of some date/time
        /// fields. Npgsql (currently) does not support this mode.
        /// </summary>
        readonly bool _integerFormat;

        public TimeHandler(TypeHandlerRegistry registry)
        {
            _integerFormat = registry.Connector.BackendParams["integer_datetimes"] == "on";
        }

        TimeSpan ISimpleTypeReader<TimeSpan>.Read(NpgsqlBuffer buf, int len, FieldDescription fieldDescription)
        {
            if (!_integerFormat) {
                throw new NotSupportedException("Old floating point representation for timestamps not supported");
            }

            // PostgreSQL time resolution == 1 microsecond == 10 ticks
            return new TimeSpan(buf.ReadInt64() * 10);
        }

        public int ValidateAndGetLength(object value, NpgsqlParameter parameter)
        {
            var asString = value as string;
            if (asString != null)
            {
                var converted = TimeSpan.Parse(asString);
                if (parameter == null)
                {
                    throw CreateConversionButNoParamException(value.GetType());
                }
                parameter.ConvertedValue = converted;
            }
            else if (!(value is TimeSpan))
            {
                throw CreateConversionException(value.GetType());
            }
            return 8;
        }

        public void Write(object value, NpgsqlBuffer buf, NpgsqlParameter parameter)
        {
            if (parameter != null && parameter.ConvertedValue != null) {
                value = parameter.ConvertedValue;
            }

            buf.WriteInt64(((TimeSpan)value).Ticks / 10);
        }
    }
}
