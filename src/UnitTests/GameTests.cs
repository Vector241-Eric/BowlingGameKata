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

        [TestFixture]
        public class When_a_spare_is_rolled_then_a_3_then_rest_are_zero
        {
            [Test]
            public void Should_score_16()
            {
                var game = new Game();

                game.AddRoll(5);
                game.AddRoll(5);
                game.AddRoll(3);
                for (int roll = 0; roll < 17; roll++)
                    game.AddRoll(0);

                game.GetScore().ShouldEqual(16);
            }
        }
    }
}