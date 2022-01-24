using NUnit.Framework;
using Burst.Compiler.IL.Tests;
using Unity.Mathematics.FixedPoint;
using static Unity.Mathematics.FixedPoint.MathFp;

namespace Unity.Mathematics.FixedPoint.Tests
{
    [TestFixture]
    class TestRigidTransform
    {
        [TestCompiler]
        public static void rigid_transform_construct_from_matrix()
        {
            Fp4x4 m4x4 = TestMatrix.test4x4_zyx;

            RigidTransform q4x4 = RigidTransform(m4x4);

            Fp4x4 mq4x4 = Fp4x4(q4x4);

            TestUtils.AreEqual(m4x4, mq4x4, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void rigid_transform_axisAngle()
        {
            RigidTransform q =
                RigidTransform.AxisAngle(normalize(Fp3((Fp)(1.0f), (Fp)(2.0f), (Fp)(3.0f))), (Fp)(10.0f));

            RigidTransform r =
                RigidTransform(QuaternionFp((Fp)(-0.2562833f), (Fp)(-0.5125666f), (Fp)(-0.76885f), (Fp)(0.2836622f)),
                    Fp3.zero);
            TestUtils.AreEqual(r, q, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void rigid_transform_euler()
        {
            Fp3 test_angles = TestMatrix.test_angles;
            RigidTransform q0 = RigidTransform.Euler(test_angles);
            RigidTransform q0_xyz = RigidTransform.Euler(test_angles, RotationOrder.XYZ);
            RigidTransform q0_xzy = RigidTransform.Euler(test_angles, RotationOrder.XZY);
            RigidTransform q0_yxz = RigidTransform.Euler(test_angles, RotationOrder.YXZ);
            RigidTransform q0_yzx = RigidTransform.Euler(test_angles, RotationOrder.YZX);
            RigidTransform q0_zxy = RigidTransform.Euler(test_angles, RotationOrder.ZXY);
            RigidTransform q0_zyx = RigidTransform.Euler(test_angles, RotationOrder.ZYX);

            RigidTransform q1 = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z);
            RigidTransform q1_xyz =
                RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            RigidTransform q1_xzy =
                RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            RigidTransform q1_yxz =
                RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            RigidTransform q1_yzx =
                RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            RigidTransform q1_zxy =
                RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            RigidTransform q1_zyx =
                RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);

            Fp epsilon = (Fp)(0.0001f);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.3435619f), (Fp)(0.3899215f), (Fp)(0.7948176f)),
                    Fp3.zero), q0, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.4597331f), (Fp)(0.06979711f), (Fp)(0.3899215f), (Fp)(0.7948176f)),
                    Fp3.zero), q0_xyz, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.06979711f), (Fp)(0.3899215f), (Fp)(0.8630749f)),
                    Fp3.zero), q0_xzy, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.4597331f), (Fp)(0.06979711f), (Fp)(0.1971690f), (Fp)(0.8630748f)),
                    Fp3.zero), q0_yxz, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.4597331f), (Fp)(0.34356190f), (Fp)(0.1971690f), (Fp)(0.7948176f)),
                    Fp3.zero), q0_yzx, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.34356190f), (Fp)(0.3899215f), (Fp)(0.7948176f)),
                    Fp3.zero), q0_zxy, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.34356190f), (Fp)(0.1971690f), (Fp)(0.8630749f)),
                    Fp3.zero), q0_zyx, epsilon);

            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.3435619f), (Fp)(0.3899215f), (Fp)(0.7948176f)),
                    Fp3.zero), q1, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.4597331f), (Fp)(0.06979711f), (Fp)(0.3899215f), (Fp)(0.7948176f)),
                    Fp3.zero), q1_xyz, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.06979711f), (Fp)(0.3899215f), (Fp)(0.8630749f)),
                    Fp3.zero), q1_xzy, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.4597331f), (Fp)(0.06979711f), (Fp)(0.1971690f), (Fp)(0.8630748f)),
                    Fp3.zero), q1_yxz, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.4597331f), (Fp)(0.34356190f), (Fp)(0.1971690f), (Fp)(0.7948176f)),
                    Fp3.zero), q1_yzx, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.34356190f), (Fp)(0.3899215f), (Fp)(0.7948176f)),
                    Fp3.zero), q1_zxy, epsilon);
            TestUtils.AreEqual(
                RigidTransform(QuaternionFp((Fp)(-0.3133549f), (Fp)(0.34356190f), (Fp)(0.1971690f), (Fp)(0.8630749f)),
                    Fp3.zero), q1_zyx, epsilon);

            Fp3x3 m0 = Fp3x3(q0.rot);
            Fp3x3 m0_xyz = Fp3x3(q0_xyz.rot);
            Fp3x3 m0_xzy = Fp3x3(q0_xzy.rot);
            Fp3x3 m0_yxz = Fp3x3(q0_yxz.rot);
            Fp3x3 m0_yzx = Fp3x3(q0_yzx.rot);
            Fp3x3 m0_zxy = Fp3x3(q0_zxy.rot);
            Fp3x3 m0_zyx = Fp3x3(q0_zyx.rot);

            Fp3x3 m1 = Fp3x3(q1.rot);
            Fp3x3 m1_xyz = Fp3x3(q1_xyz.rot);
            Fp3x3 m1_xzy = Fp3x3(q1_xzy.rot);
            Fp3x3 m1_yxz = Fp3x3(q1_yxz.rot);
            Fp3x3 m1_yzx = Fp3x3(q1_yzx.rot);
            Fp3x3 m1_zxy = Fp3x3(q1_zxy.rot);
            Fp3x3 m1_zyx = Fp3x3(q1_zyx.rot);

            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m0, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xyz, m0_xyz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yzx, m0_yzx, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m0_zxy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xzy, m0_xzy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yxz, m0_yxz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zyx, m0_zyx, (Fp)(0.0001f));

            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m1, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xyz, m1_xyz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yzx, m1_yzx, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m1_zxy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xzy, m1_xzy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yxz, m1_yxz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zyx, m1_zyx, epsilon);
        }

        [TestCompiler]
        public static void rigid_transform_rotateX()
        {
            Fp angle = (Fp)(2.3f);
            RigidTransform q = RigidTransform.RotateX(angle);

            RigidTransform r =
                RigidTransform(QuaternionFp((Fp)(0.91276394f), (Fp)(0.0f), (Fp)(0.0f), (Fp)(0.40848744f)), Fp3.zero);
            TestUtils.AreEqual(r, q, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void rigid_transform_rotateY()
        {
            Fp angle = (Fp)(2.3f);
            RigidTransform q = RigidTransform.RotateY(angle);

            RigidTransform r =
                RigidTransform(QuaternionFp((Fp)(0.0f), (Fp)(0.91276394f), (Fp)(0.0f), (Fp)(0.40848744f)), Fp3.zero);
            TestUtils.AreEqual(r, q, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void rigid_transform_rotateZ()
        {
            Fp angle = (Fp)(2.3f);
            RigidTransform q = RigidTransform.RotateZ(angle);

            RigidTransform r =
                RigidTransform(QuaternionFp((Fp)(0.0f), (Fp)(0.0f), (Fp)(0.91276394f), (Fp)(0.40848744f)), Fp3.zero);
            TestUtils.AreEqual(r, q, (Fp)(0.0001f));
        }

        static internal readonly QuaternionFp test_q0 =
            new QuaternionFp((Fp)(0.3270836f), (Fp)(0.8449658f), (Fp)(-0.1090279f), (Fp)(0.4088545f));

        static internal readonly QuaternionFp test_q1 =
            new QuaternionFp((Fp)(-0.05623216f), (Fp)(0.731018f), (Fp)(-0.6747859f), (Fp)(-0.08434824f));

        static internal readonly QuaternionFp test_q2 =
            new QuaternionFp((Fp)(-0.2316205f), (Fp)(-0.6022133f), (Fp)(-0.7411857f), (Fp)(-0.1852964f));

        static internal readonly QuaternionFp test_q3 =
            new QuaternionFp((Fp)(0.3619499f), (Fp)(0.8352691f), (Fp)(-0.1392115f), (Fp)(0.3897922f));

        [TestCompiler]
        public static void rigid_transform_inverse()
        {
            RigidTransform q = RigidTransform(QuaternionFp((Fp)(1.0f), (Fp)(-2.0f), (Fp)(3.0f), (Fp)(-4.0f)),
                Fp3(1, 2, 3));
            RigidTransform iq = inverse(q);
            RigidTransform qiq = mul(iq, q);

            TestUtils.AreEqual(RigidTransform.identity, qiq, (Fp)(0.00001f));
        }

        [TestCompiler]
        public static void rigid_transform_mul_vector()
        {
            Fp4x4 m = TestMatrix.test4x4_xyz;
            RigidTransform q = RigidTransform(m);

            Fp3 vector = Fp3((Fp)(1.1f), (Fp)(-2.2f), (Fp)(3.5f));

            Fp4 mvector0 = mul(m, Fp4(vector, 0));
            Fp4 qvector0 = mul(q, Fp4(vector, 0));
            TestUtils.AreEqual(mvector0, qvector0, (Fp)(0.0001f));

            Fp4 mvector1 = mul(m, Fp4(vector, 1));
            Fp4 qvector1 = mul(q, Fp4(vector, 1));
            TestUtils.AreEqual(mvector1, qvector1, (Fp)(0.0001f));
        }

        [TestCompiler]
        public static void rigid_transform_mul_limitation()
        {
            RigidTransform rigidTransform =
                new RigidTransform(QuaternionFp(0, 0, 0, 1), Fp3(new Fp(6), new Fp(1), 0));
            Fp3 point = new Fp3(new Fp(21260089188), -new Fp(1), new Fp(31997506363));
            Fp3 result = MathFp.transform(rigidTransform, point);
            TestUtils.IsFalse(any(isinf(result)));
            TestUtils.IsFalse(any(isnan(result)));
        }

        [TestCase]
        public static void rigid_transform_EqualsObjectOverride()
        {
            TestUtils.IsFalse(new RigidTransform().Equals((object)new int()));
            TestUtils.IsTrue(new RigidTransform().Equals((object)new RigidTransform()));
        }
    }
}