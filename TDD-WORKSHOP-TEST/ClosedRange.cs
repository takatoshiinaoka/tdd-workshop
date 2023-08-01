namespace TDD_WORKSHOP
{
    public class ClosedRangeTest
    {

        [TestFixture]
        public class ��ԃI�u�W�F�N�g�̉��[�Ə�[�͐�����Ԃ�
        {
            [Test]
            public void ���[��3��[��7�̕�Ԃ͉��[3�̐�����Ԃ�()
            {
                var range = new ClosedRange(3, 8);
                Assert.That(range.LowerPoint, Is.EqualTo(3));
            }

            [Test]
            public void ���[��3��[��7�̕�Ԃ͏�[7�̐�����Ԃ�()
            {
                var range = new ClosedRange(3, 7);
                Assert.That(range.UpperPoint, Is.EqualTo(7));
            }

            [Test]
            public void ���[�Ə�[��5�̕�Ԃ͉��[5�̐�����Ԃ�()
            {
                var range = new ClosedRange(5, 5);
                Assert.That(range.UpperPoint, Is.EqualTo(5));
            }
        }

        [TestFixture]
        public class ��ԃI�u�W�F�N�g�͋�Ԃ𕶎���ŕԂ�
        {
            [Test]
            public void ���[��3��[��7�̕�Ԃ͋�Ԃ𕶎���ŕԂ�()
            {
                var range = new ClosedRange(3, 7);
                Assert.That(range.ToString(), Is.EqualTo("[3,7]"));
            }

            [Test]
            public void ���[��1��[��6�̕�Ԃ͋�Ԃ𕶎���ŕԂ�()
            {
                var range = new ClosedRange(1, 6);
                Assert.That(range.ToString(), Is.EqualTo("[1,6]"));
            }
        }

        [TestFixture]
        public class �������󂯎���ԂɊ܂ނ����肵bool�^��Ԃ�
        {
            [Test]
            public void ���[3��[7�̕�Ԃ͐���2���󂯎��fale��Ԃ�()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsFalse(range.IsInsided(2));
            }

            [Test]
            public void ���[3��[7�̕�Ԃ͐���3���󂯎��true��Ԃ�()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsTrue(range.IsInsided(3));
            }

            [Test]
            public void ���[3��[7�̕�Ԃ͐���7���󂯎��true��Ԃ�()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsTrue(range.IsInsided(7));
            }

            [Test]
            public void ���[3��[7�̕�Ԃ͐���8���󂯎��fale��Ԃ�()
            {
                var range = new ClosedRange(3, 7);
                Assert.IsFalse(range.IsInsided(8));
            }
        }

        [TestFixture]
        public class ��Ԃ̏�[�Ɖ��[�̑召��r
        {
            [Test]
            public void ���[6����[1���傫���ꍇ�͗�O���X���[()
            {
                try
                {
                    var range = new ClosedRange(6, 1);
                    Assert.Fail();
                }
                catch (ArgumentException) { }
            }

            [Test]
            public void ���[0����[�}�C�i�X1���傫���ꍇ�͗�O���X���[()
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