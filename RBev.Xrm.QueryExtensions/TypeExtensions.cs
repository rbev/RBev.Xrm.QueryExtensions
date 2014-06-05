using System;
using System.Collections.Generic;
using System.Linq;

namespace RBev.Xrm.QueryExtensions
{
    public static class TypeExtensions
    {

        public static bool IsClosedOver(this Type t, Type openGeneric)
        {
            return t.Lineage()
                .Concat(t.GetInterfaces())
                .Any(type => type.IsGenericType && type.GetGenericTypeDefinition() == openGeneric);
        }

        public static IEnumerable<Type> Lineage(this Type t)
        {
            var type = t;

            while (type != null)
            {
                yield return type;
                type = type.BaseType;
            }
        }


        internal static Type GetEnumerableElementType(this Type seqType)
        {
            Type ienum = FindImplementedIEnumerable(seqType);
            if (ienum == null) return seqType;
            return ienum.GetGenericArguments()[0];
        }

        private static Type FindImplementedIEnumerable(this Type seqType)
        {
            if (seqType == null || seqType == typeof(string))
                return null;

            if (seqType.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(seqType.GetElementType());

            if (seqType.IsGenericType)
            {
                foreach (Type arg in seqType.GetGenericArguments())
                {
                    Type ienum = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (ienum.IsAssignableFrom(seqType))
                    {
                        return ienum;
                    }
                }
            }

            Type[] ifaces = seqType.GetInterfaces();
            if (ifaces != null && ifaces.Length > 0)
            {
                foreach (Type iface in ifaces)
                {
                    Type ienum = FindImplementedIEnumerable(iface);
                    if (ienum != null) return ienum;
                }
            }

            if (seqType.BaseType != null && seqType.BaseType != typeof(object))
            {
                return FindImplementedIEnumerable(seqType.BaseType);
            }

            return null;
        }
    }
}