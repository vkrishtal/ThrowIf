using System;
using Xunit;

namespace ThrowIf.Tests
{
    public class ThrowIfNullTests
    {
        [Fact]
        public void NotNull_Class_NoException()
        {
            ThrowIf.Null(new Object());
        }

        [Fact]
        public void NotNull_Struct_NoException()
        {
            Int32? value = 1;
            ThrowIf.Null(value);
        }

        [Fact]
        public void Null_Class_ThrowsArgumentNullException()
        {
            Object obj = null;
            Assert.Throws<ArgumentNullException>(()=> ThrowIf.Null(obj));
        }

        [Fact]
        public void Null_Struct_ThrowsArgumentNullException()
        {
            Int32? value = null;
            Assert.Throws<ArgumentNullException>(() => ThrowIf.Null(value));
        }

        [Fact]
        public void Null_Class_ThrowsArgumentNullExceptionWithMessage()
        {
            Object obj = null;
            Assert.Throws<ArgumentNullException>(() => ThrowIf.Null(obj, "message"));
        }

        [Fact]
        public void Null_Struct_ThrowsArgumentNullExceptionWithMessage()
        {
            Int32? value = null;
            Assert.Throws<ArgumentNullException>(() => ThrowIf.Null(value, "message"));
        }
    }
}
