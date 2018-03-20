using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ThrowIf
{
    public static class ThrowIf
    {
        #region Null

        public static void Null<T>(T obj)
            where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
        }

        public static void Null<T>(T obj, String message)
            where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void Null<T>(T? obj)
            where T : struct
        {
            if (!obj.HasValue)
            {
                throw new ArgumentNullException();
            }
        }

        public static void Null<T>(T? obj, String message)
            where T : struct
        {
            if (!obj.HasValue)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void Null<E>(Object obj)
            where E : Exception, new()
        {
            if (obj == null)
            {
                throw new E();
            }
        }

        public static void Null<E>(Object obj, String message)
            where E : Exception, new()
        {
            if (obj == null)
            {
                var exception = (E)Activator.CreateInstance(typeof(E), new object[] { message });
                throw exception;
            }
        }


        public static void Null<T, E>(T? obj)
            where T : struct
            where E : Exception, new()
        {
            if (!obj.HasValue)
            {
                throw new E();
            }
        }

        public static void Null<T, E>(T? obj, String message)
            where T : struct
            where E : Exception, new()
        {
            if (!obj.HasValue)
            {
                var exception = (E)Activator.CreateInstance(typeof(E), new object[] { message });
                throw exception;
            }
        }

        #endregion Null

        #region NotNull

        public static void NotNull<T>(T obj)
            where T : class
        {
            if (obj != null)
            {
                throw new ArgumentException();
            }
        }

        public static void NotNull<T>(T obj, String message)
            where T : class
        {
            if (obj != null)
            {
                throw new ArgumentException(message);
            }
        }

        public static void NotNull<T>(T? obj)
            where T : struct
        {
            if (obj.HasValue)
            {
                throw new ArgumentException();
            }
        }

        public static void NotNull<T>(T? obj, String message)
            where T : struct
        {
            if (obj.HasValue)
            {
                throw new ArgumentException(message);
            }
        }

        public static void NotNull<T, E>(T obj)
            where T : class
            where E : Exception, new()
        {
            if (obj != null)
            {
                throw new E();
            }
        }

        public static void NotNull<T, E>(T obj, String message)
            where T : class
            where E : Exception, new()
        {
            if (obj != null)
            {
                var exception = (E)Activator.CreateInstance(typeof(E), new object[] { message });
                throw exception;
            }
        }

        public static void NotNull<T, E>(T? obj)
            where T : struct
            where E : Exception, new()
        {
            if (obj.HasValue)
            {
                throw new E();
            }
        }

        public static void NotNull<T, E>(T? obj, String message)
            where T : struct
            where E : Exception, new()
        {
            if (obj.HasValue)
            {
                var exception = (E)Activator.CreateInstance(typeof(E), new object[] { message });
                throw exception;
            }
        }

        #endregion NotNull

        #region Empty

        public static void Empty(IEnumerable enumerable)
        {
            if (enumerable == null)
            {
                throw new Exception("Enumerable is null reference.");
            }

            foreach(var item in enumerable)
            {
                return;
            }

            throw new Exception("Empty enumerable.");
        }

        public static void Empty<T>(IEnumerable<T> enumerable)
        {
            if (enumerable == null || !enumerable.Any())
            {
                throw new Exception("Empty enumerable.");
            }
        }

        public static void Empty<T>(T[] array)
        {
            if (array == null || !array.Any())
            {
                throw new Exception("Empty array.");
            }
        }

        public static void Empty<T>(T[][] matrix)
        {
            if (matrix == null || !matrix.Any())
            {
                throw new Exception("Empty matrix.");
            }
        }

        public static void Empty(String text)
        {
            if (String.IsNullOrEmpty(text))
            {
                throw new Exception("Empty text.");
            }
        }

        public static void Empty<T>(List<T> list)
        {
            if (list == null || !list.Any())
            {
                throw new Exception("Empty list.");
            }
        }

        #endregion Empty

        #region NotEmpty

        public static void NotEmpty(IEnumerable enumerable)
        {
            if (enumerable == null)
            {
                return;
            }

            foreach (var item in enumerable)
            {
                throw new Exception("Enumerable is not empty but must be empty.");
            }
        }

        public static void NotEmpty<T>(IEnumerable<T> enumerable)
        {
            if (enumerable != null && enumerable.Any())
            {
                throw new Exception("Enumerable is not empty but must be empty.");
            }
        }

        public static void NotEmpty<T>(T[] array)
        {
            if (array != null && array.Any())
            {
                throw new Exception("Array is not empty but must be empty.");
            }
        }

        public static void NotEmpty<T>(T[][] matrix)
        {
            if (matrix != null && matrix.Any())
            {
                throw new Exception("Matrix is not empty but must be empty.");
            }
        }

        public static void NotEmpty(String text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                throw new Exception("String is not empty but must be empty.");
            }
        }

        public static void NotEmpty<T>(List<T> list)
        {
            if (list != null && list.Any())
            {
                throw new Exception("List is not empty but must be empty.");
            }
        }

        #endregion NotEmpty

        #region Contains

        public static void Contains(IEnumerable enumerable)
        {
        }

        public static void Contains<T>(IEnumerable<T> enumerable)
        {
        }

        public static void Contains<T>(T[] array)
        {
        }

        public static void Contains<T>(T[][] array)
        {
        }

        public static void Contains<T>(T[,] array)
        {
        }

        public static void Contains(String text)
        {
        }

        public static void Contains<T>(List<T> list)
        {
        }

        #endregion Contains

        #region DoesNotContain

        public static void DoesNotContain(IEnumerable enumerable)
        {
        }

        public static void DoesNotContain<T>(IEnumerable<T> enumerable)
        {
        }

        public static void DoesNotContain<T>(T[] array)
        {
        }

        public static void DoesNotContain<T>(T[][] array)
        {
        }

        public static void DoesNotContain<T>(T[,] array)
        {
        }

        public static void DoesNotContain(String text)
        {
        }

        public static void DoesNotContain<T>(List<T> list)
        {
        }

        #endregion DoesNotContain
    }
}
