﻿using System;
using Npgsql.BackendMessages;
using NpgsqlTypes;
using System.Data;

namespace Npgsql.TypeHandlers.DateTimeHandlers
{
    /// <remarks>
    /// http://www.postgresql.org/docs/current/static/datatype-datetime.html
    /// </remarks>
    [TypeMapping("timestamptz", NpgsqlDbType.TimestampTZ, DbType.DateTimeOffset, typeof(DateTimeOffset))]
    internal class TimeStampTzHandler : TimeStampHandler, ISimpleTypeReader<NpgsqlDateTime>, ISimpleTypeReader<DateTimeOffset>
    {
        public TimeStampTzHandler(TypeHandlerRegistry registry) : base(registry) {}

        public override DateTime Read(NpgsqlBuffer buf, int len, FieldDescription fieldDescription)
        {
            // TODO: Convert directly to DateTime without passing through NpgsqlTimeStamp?
            var ts = ((ISimpleTypeReader<NpgsqlDateTime>)this).Read(buf, len, fieldDescription);
            try
            {
                return ts.DateTime;
            } catch (Exception e) {
                throw new SafeReadException(e);
            }
        }

        NpgsqlDateTime ISimpleTypeReader<NpgsqlDateTime>.Read(NpgsqlBuffer buf, int len, FieldDescription fieldDescription)
        {
            var ts = ReadTimeStamp(buf, len, fieldDescription);
            return new NpgsqlDateTime(ts.Date, ts.Time, DateTimeKind.Utc).ToLocalTime();
        }

        DateTimeOffset ISimpleTypeReader<DateTimeOffset>.Read(NpgsqlBuffer buf, int len, FieldDescription fieldDescription)
        {
            return new DateTimeOffset(ReadTimeStamp(buf, len, fieldDescription).DateTime, TimeSpan.Zero);
        }

        public override void Write(object value, NpgsqlBuffer buf, NpgsqlParameter parameter)
        {
            if (parameter != null && parameter.ConvertedValue != null) {
                value = parameter.ConvertedValue;
            }

            if (value is NpgsqlDateTime)
            {
                var ts = (NpgsqlDateTime)value;
                switch (ts.Kind)
                {
                case DateTimeKind.Unspecified:
                    // Treat as Local
                case DateTimeKind.Utc:
                    break;
                case DateTimeKind.Local:
                    ts = ts.ToUniversalTime();
                    break;
                default:
                    throw PGUtil.ThrowIfReached();
                }
                base.Write(ts, buf, parameter);
                return;
            }

            if (value is DateTime)
            {
                var dt = (DateTime)value;
                switch (dt.Kind)
                {
                case DateTimeKind.Unspecified:
                // Treat as Local
                case DateTimeKind.Utc:
                    break;
                case DateTimeKind.Local:
                    dt = dt.ToUniversalTime();
                    break;
                default:
                    throw PGUtil.ThrowIfReached();
                }
                base.Write(dt, buf, parameter);
                return;
            }

            if (value is DateTimeOffset)
            {
                base.Write(((DateTimeOffset)value).ToUniversalTime(), buf, parameter);
                return;
            }

            throw PGUtil.ThrowIfReached();
        }
    }
}
