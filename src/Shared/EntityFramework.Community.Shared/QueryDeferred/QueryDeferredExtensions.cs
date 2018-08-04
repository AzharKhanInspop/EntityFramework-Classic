﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

public static partial class EntityFrameworkClassicExtensions
{
    private static MethodInfo GetMethodInfo<T1, T2>(Func<T1, T2> f, T1 unused1)
    {
        return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3>(Func<T1, T2, T3> f, T1 unused1, T2 unused2)
    {
        return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3, T4>(Func<T1, T2, T3, T4> f, T1 unused1, T2 unused2, T3 unused3)
    {
        return f.Method;
    }

    private static MethodInfo GetMethodInfo<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5> f, T1 unused1, T2 unused2, T3 unused3, T4 unused4)
    {
        return f.Method;
    }

    private static Expression GetSourceExpression<TSource>(IEnumerable<TSource> source)
    {
        var q = source as IQueryable<TSource>;
        if (q != null)
        {
            return q.Expression;
        }

        return Expression.Constant(source, typeof(IEnumerable<TSource>));
    }
}