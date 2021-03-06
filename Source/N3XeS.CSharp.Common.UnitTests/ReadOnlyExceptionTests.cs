// <copyright file="ReadOnlyExceptionTests.cs" company="John Caruthers">Copyright (c) 2013, John Caruthers</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using N3XeS.CSharp.Common.Exceptions;

namespace N3XeS.CSharp.Common.Exceptions.UnitTests
{
    /// <summary>This class contains parameterized unit tests for ReadOnlyException</summary>
    [TestClass]
    [PexClass(typeof(ReadOnlyException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ReadOnlyExceptionTests
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public ReadOnlyException ConstructorTest()
		{
			ReadOnlyException target = new ReadOnlyException();
			return target;
			// TODO: add assertions to method ReadOnlyExceptionTests.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public ReadOnlyException ConstructorTest01(string message)
		{
			ReadOnlyException target = new ReadOnlyException(message);
			return target;
			// TODO: add assertions to method ReadOnlyExceptionTests.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(String, Exception)</summary>
		[PexMethod]
		public ReadOnlyException ConstructorTest02(string message, Exception exceptionInner)
		{
			ReadOnlyException target = new ReadOnlyException(message, exceptionInner);
			return target;
			// TODO: add assertions to method ReadOnlyExceptionTests.ConstructorTest02(String, Exception)
		}
	}
}
