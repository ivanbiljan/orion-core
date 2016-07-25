﻿using System;
using NUnit.Framework;
using Orion.Events.Player;

namespace Orion.Tests.Events.Player
{
	[TestFixture]
	public class PlayedJoinedEventArgsTests
	{
		[Test]
		public void Constructor_Null_ThrowsException()
		{
			Assert.Throws<ArgumentNullException>(() => new PlayerJoinedEventArgs(null));
		}
	}
}
