namespace TDD_WORKSHOP
{
    public class ClosedRangeTest
    {

        [TestFixture]
        public class 閉区間オブジェクトの下端と上端は整数を返す
        {
            [Test]
            public void 下端が3上端が7の閉区間は下端3の整数を返す()
            {
                var range = new ClosedRange(3, 8);
                Assert.That(range.LowerPoint, Is.EqualTo(3));
            }

            [Test]
            public void 下端が3上端が7の閉区間は上端7の整数を返す()
            {
                var range = new ClosedRange(3, 7);
                Assert.That(range.UpperPoint, Is.EqualTo(7));
            }

            [Test]
            public void 下端と上端が5の閉区間は下端5の整数を返す()
            {
                var range = new ClosedRange(5, 5);
                Assert.That(range.UpperPoint, Is.EqualTo(5));
            }
        }

        [TestFixture]
        public class 閉区間オブジェクトは区間を文字列で返す
        {
            [Test]
            public void 下端が3上端が7の閉区間は区間を文字列で返す()
            {
                var range = new ClosedRange(3, 7);
                Assert.That(range.ToString(), Is.EqualTo("[3,7]"));
            }

            [Test]
            public void 下端が1上端が6の閉区間は区間を文字列で返す()
            {
                var range = new ClosedRange(1, 6);
                Assert.That(range.ToString(), Is.EqualTo("[1,6]"));
            }
        }

        [TestFixture]
        public class 整数を受け取り閉区間に含むか判定しbool型を返す
        {
            [Test]
            public void 下端3上端7の閉区間は整数2を受け取りfaleを返す()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsFalse(range.IsInsided(2));
            }

            [Test]
            public void 下端3上端7の閉区間は整数3を受け取りtrueを返す()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsTrue(range.IsInsided(3));
            }

            [Test]
            public void 下端3上端7の閉区間は整数7を受け取りtrueを返す()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsTrue(range.IsInsided(7));
            }

            [Test]
            public void 下端3上端7の閉区間は整数8を受け取りfaleを返す()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsFalse(range.IsInsided(8));
            }
        }

        [TestFixture]
        public class 閉区間の上端と下端の大小比較
        {
            [Test]
            public void 下端6が上端1より大きい場合は例外をスロー()
            {
                try
                {
                    var range = new ClosedRange(6, 1);
                    Assert.Fail();
                }
                catch (ArgumentException) { }
            }

            [Test]
            public void 下端0が上端マイナス1より大きい場合は例外をスロー()
            {
                try
                {
                    var range = new ClosedRange(0, -1);
                    Assert.Fail();
                }
                catch (ArgumentException) { }
            }
        }
    }
}