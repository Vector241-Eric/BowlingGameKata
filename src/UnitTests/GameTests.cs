using BowlingScorer;
using NUnit.Framework;
using Should;

namespace UnitTests
{
    public class GameTests
    {
        [TestFixture]
        public class When_all_zeros_are_rolled
        {
            [Test]
            public void Should_score_a_zero()
            {
                var game = new Game();
                for (int roll = 0; roll < 20; roll++)
                    game.AddRoll(0);

                game.GetScore().ShouldEqual(0);
            }
        }

        [TestFixture]
        public class When_all_ones_are_rolled
        {
            [Test]
            public void Should_score_a_20()
            {
                var game = new Game();
                for (int roll = 0; roll < 20; roll++)
                    game.AddRoll(1);

                game.GetScore().ShouldEqual(20);
            }
        }
    }
}