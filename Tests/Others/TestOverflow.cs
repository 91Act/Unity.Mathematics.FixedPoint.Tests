using Burst.Compiler.IL.Tests;
using NUnit.Framework;

namespace Unity.Mathematics.FixedPoint.Tests
{
    [TestFixture]
    public class TestOverflow
    {
        [TestCompiler]
        public static void cross_overflow()
        {
            Fp3 kNormal = new Fp3((Fp)20L, (Fp)(-4294967296L), (Fp)1086L);
            Fp3 iNormal = new Fp3((Fp)(-4375L), (Fp)(-4294967297L), (Fp)2615L);
            Fp3 kiCross = MathFp.cross(kNormal, iNormal);
            TestUtils.AreEqual(kiCross, new Fp3((Fp)(-1528L), -Fp.Inf, (Fp)(-4396L)));
        }
        [TestCompiler]
        public static void fp_inverse_overflow()
        {
            Fp m = new Fp(4611685974548328839) - new Fp(4611685974548328837);
            TestUtils.AreEqual(-m, -Fp.Inf, Fp.Epsilon);
        }

    }
}